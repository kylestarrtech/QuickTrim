using System.Reflection.Metadata;
using System.Security.Principal;
using System.Text.Json;
using FFMpegCore;
using FFMpegCore.Arguments;
using FFMpegCore.Enums;
using Microsoft.Win32;

namespace QuickTrimForms
{
    public partial class MainForm : Form {

        public string SelectedVideoPath = string.Empty;
        bool SeenCRFWarning = false;

        QuickTrimSettings settings;

        public bool IsAdmin {
            get {
                return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
            }
        }

        public MainForm() {
            InitializeComponent();
        }

        private void SelectVideo_Click(object sender, EventArgs e) {
            SelectedVideoPath = string.Empty;

            using (VideoFile) {
                VideoFile.InitialDirectory = "C:\\";
                VideoFile.Filter = "MP4 files (*.mp4)|*.mp4";
                VideoFile.RestoreDirectory = true;

                if (VideoFile.ShowDialog() == DialogResult.OK) {
                    SelectedVideoPath = VideoFile.FileName;
                }
                else {
                    Console.WriteLine("Did not pass dialog result");
                }
            }

            UpdateVideoPathDetails();
        }

        private void UpdateVideoPathDetails() {
            if (SelectedVideoPath == string.Empty) {
                VideoPath.Text = "[No video selected]";
                return;
            }

            VideoPath.Text = SelectedVideoPath;

            var videoInfo = FFProbe.Analyse(SelectedVideoPath);

            TrimStart.Text = "0";
            TrimEnd.Text = ((int)videoInfo.Duration.TotalSeconds).ToString();
        }

        private void SaveButton_Click(object sender, EventArgs e) {
            TrimVideo(SelectedVideoPath, TrimStart.Text, TrimEnd.Text);
        }

        public void SaveLastSeconds(string videoPath, string seconds) {
            double start, end;

            if (videoPath == string.Empty) {
                return;
            }

            // Check video extension
            if (Path.GetExtension(videoPath) != ".mp4") {
                throw new FileExtensionInvalidException("File extension is not .mp4");
            }

            // Check if the input is a number
            if (!Utility.IsNumber(seconds)) {
                throw new TimeInputInvalidException("Input is not a number.");
            }

            var videoInfo = FFProbe.Analyse(videoPath);

            start = (int)videoInfo.Duration.TotalSeconds - int.Parse(seconds);
            end = videoInfo.Duration.TotalSeconds;

            TrimVideo(videoPath, start.ToString(), end.ToString());
        }

        public void TrimVideo(string videoPath, string start, string end) {

            double startTime, endTime;

            startTime = Utility.GetNumber(start);
            endTime = Utility.GetNumber(end);

            if (startTime >= endTime) {
                throw new TimeInvalidException("Start time is larger than or equal to the end time!");
            }

            if (startTime == -int.MaxValue || endTime == -int.MaxValue) {
                throw new TimeInputInvalidException("Input values are not able to be converted to numbers.");
            }

            string filePath = Path.GetDirectoryName(videoPath) ?? throw new Exception("Directory does not exist!");
            string fileName = Path.GetFileNameWithoutExtension(videoPath);
            string extension = Path.GetExtension(videoPath);

            string currentEpoch = Utility.GetCurrentEpoch().ToString();
            string fileNameSuffix = $"-TRIM-{currentEpoch}";

            string outputPath = filePath + Path.DirectorySeparatorChar + fileName + fileNameSuffix + extension;

            double duration = endTime - startTime;

            double framerate = FFProbe.Analyse(videoPath).VideoStreams.First().FrameRate;
            int closestFramerate = AvailableFramerates.FindClosestFPS(framerate);

            var options = new Action<FFMpegArgumentOptions>(opts => {
                opts.WithVideoCodec(VideoCodec.LibX264)                             // Sets the video codec
                    .WithCustomArgument("-vsync cfr")                               // Ensures the framerate is constant, not variable.
                    .WithConstantRateFactor(settings.ConstantRateFactor)            // Sets quality, assists in reducing file size
                    .WithCustomArgument("-ss " + startTime)                         // Sets the start time
                    .WithCustomArgument("-t " + duration)                           // Sets the duration
                    .WithCustomArgument($"-threads {(int)settings.CPUUsage}")       // Sets the number of threads to 1
                    .WithSpeedPreset(settings.EncoderPreset)                        // Sets the encoding speed
                    .WithFastStart();                                               // Optimizes the video for Internet streaming by putting the headers at the beginning of the file.
                
                if (settings.EncodeSpecificFramerate) {
                    opts.WithFramerate(settings.SetFrameRate);
                } else {
                    opts.WithFramerate(closestFramerate);
                }
            });

            

            FFMpegArguments
                .FromFileInput(videoPath)
                .OutputToFile(outputPath, true, options)
                .ProcessSynchronously();
        }

        public void InitializeSettings() {
            QuickTrimSettings curSettings = SettingsUtility.GetSettings() ?? throw new NullReferenceException("Settings cannot be loaded!");

            if (curSettings == null) {
                throw new NullReferenceException("Settings don't exist upon initialization! This should be impossible unless the settings file was deleted during program launch!");
            }

            settings = curSettings;

            LoadSettingsUI();
        }

        public void LoadSettingsUI() {
            CRFLabel.Text = $"Constant Rate Factor: {settings.ConstantRateFactor}";

            CRFBar.Value = settings.ConstantRateFactor;
        }

        private void Form1_Load(object sender, EventArgs e) {
            InitializeSettings();

            string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\QuickTrim";
            string fileName = "StartupLog.txt";

            string fullPath = $"{startupPath}\\{fileName}";


            if (!Directory.Exists(startupPath)) {
                Directory.CreateDirectory(startupPath);
            }

            if (!File.Exists(fullPath)) {
                File.Create(fullPath);
            }

            StreamWriter sw = new StreamWriter(fullPath);

            List<string> log = new List<string>();

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length < 3) {
                return;
            }

            //MessageBox.Show(args.Length.ToString());
            //log.Add($"Number of arguments: {args.Length}. Arguments listed below:");

            //foreach (string arg in args) {
            //    log.Add($"\t{arg}");
            //    MessageBox.Show(arg);
            //}

            log.Add("Checking validity...");

            try {
                if (args.Length > 3) {
                    log.Add($"Invalid number of arguments: {args.Length}");
                    throw new Exception($"Invalid number of arguments: {args.Length}");
                }

                log.Add($"Argument length valid...");


                if (!Utility.IsNumber(args[2])) {
                    log.Add($"Seconds input argument \"{args[2]}\" is not a number.");
                    throw new TimeInputInvalidException($"Seconds input argument \"{args[2]}\" is not a number.");
                }

                log.Add($"Seconds input is a number. Argument valid.");

                if (!File.Exists(args[1])) {
                    log.Add($"File \"{args[1]}\" does not exist.");
                    throw new FileNotFoundException($"File \"{args[1]}\" does not exist.");
                }

                log.Add("File input exists. Argument valid.");

                string filePath = args[1];
                string seconds = args[2];

                log.Add($"Attempting Save: SaveLastSeconds({filePath}, {seconds}");
                SaveLastSeconds(filePath, seconds);
                log.Add($"Save successful!");

                Application.Exit();
            }
            catch (Exception ex) {
                log.Add($"Exception caught: {ex.Message}");
                MessageBox.Show(ex.Message);
            }
            finally {
                foreach (string line in log) {
                    sw.WriteLine(line);
                }
                sw.Close();
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) {
            e.Effect = DragDropEffects.Copy;
            this.BackColor = Color.FromArgb(191, 255, 191);
        }

        private void Form1_DragLeave(object sender, EventArgs e) {
            this.BackColor = Color.White;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e) {
            this.BackColor = Color.White;

            object data = e.Data.GetData(DataFormats.FileDrop) ?? throw new DragDropException("No file data found!");
            string[] files = (string[])data;

            if (files == null || files.Length != 1) {
                throw new DragDropException("Only one file can be imported at a time and the file must have content!");
            }

            SelectedVideoPath = files[0];

            UpdateVideoPathDetails();
        }

        private void SaveLastSecondsButton_Click(object sender, EventArgs e) {
            SaveLastSeconds(SelectedVideoPath, LastSecondsText.Text);
        }

        private void RegisterToRightClick_Click(object sender, EventArgs e) {
            if (!Utility.IsNumber(LastSecondsText.Text)) {
                MessageBox.Show("Input is not a number.");
                return;
            }

            string exePath = Application.ExecutablePath;

            RegistryKey actKey = Registry.ClassesRoot.CreateSubKey(
                @$"*\shell\QuickTrim{LastSecondsText.Text}s"
            );
            actKey.SetValue("", $"QT: Save last {LastSecondsText.Text} seconds");

            RegistryKey cmdKey = Registry.ClassesRoot.CreateSubKey(
                @$"*\shell\QuickTrim{LastSecondsText.Text}s\command"
            );
            cmdKey.SetValue("", $"\"{exePath}\" \"%1\" {LastSecondsText.Text}");
        }

        private void UnregisterToRightClick_Click(object sender, EventArgs e) {
            if (!Utility.IsNumber(LastSecondsText.Text)) {
                MessageBox.Show("Input is not a number.");
                return;
            }

            Registry.ClassesRoot.DeleteSubKeyTree(
                @$"*\shell\QuickTrim{LastSecondsText.Text}s"
            );
        }

        private void UnregisterAllFromRightClick_Click(object sender, EventArgs e) {
            string[] subKeys = Registry.ClassesRoot.GetSubKeyNames();
            foreach (string key in subKeys) {
                if (key.Contains("QuickTrim")) {
                    Registry.ClassesRoot.DeleteSubKeyTree(key);
                }
            }
        }

        private void OpenRightClickMenu_Click(object sender, EventArgs e) {
            if (!IsAdmin) {
                MessageBox.Show("Administrator Privileges are required to access this menu. Please run QuickTrim as Administrator.");
                return;
            }

            RegistryManagerForm registryManagerForm = new RegistryManagerForm();
            
            registryManagerForm.Show();
            registryManagerForm.Location = this.Location;
            this.Hide();


            registryManagerForm.FormClosed += (s, args) => {
                this.Location = registryManagerForm.Location;
                this.Show();
            };
        }
        private void preferencesButton_Click(object sender, EventArgs e) {
            PreferencesForm prefForm = new PreferencesForm();
            
            prefForm.Show();
            prefForm.Location = this.Location;
            this.Hide();


            prefForm.FormClosed += (s, args) => {
                settings = SettingsUtility.GetSettings() ?? throw new NullReferenceException("Settings cannot be loaded!");
                
                this.Location = prefForm.Location;
                this.Show();

            };
        }

        private void CRFLabel_Click(object sender, EventArgs e) {

        }

        private void CRFBar_Scroll(object sender, EventArgs e) {

            if (CRFBar.Value < 17 && !SeenCRFWarning) {
                DialogResult result = MessageBox.Show(
                    "Setting the Constant Rate Factor below this threshold may result in an increase in file size, most notably for videos that have already underwent compression (most videos).\n\nYou will not see this message again while QuickTrim is running.",
                    "Warning: CRF Safe Zone",
                    MessageBoxButtons.OK);

                SeenCRFWarning = true;
            }

            CRFLabel.Text = $"Constant Rate Factor: {CRFBar.Value}*";
        }

        private void CRFBar_MouseUp(object sender, MouseEventArgs e) {
            QuickTrimSettings settings = SettingsUtility.GetSettings() ?? throw new NullReferenceException("Settings cannot be loaded!");

            settings.ConstantRateFactor = CRFBar.Value;
            CRFLabel.Text = $"Constant Rate Factor: {CRFBar.Value}";


            SettingsUtility.SaveSettings(settings);
        }
    }
}
