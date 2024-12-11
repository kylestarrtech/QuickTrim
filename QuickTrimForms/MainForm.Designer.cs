namespace QuickTrimForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            VideoFile = new OpenFileDialog();
            VideoPath = new Label();
            SelectVideo = new Button();
            TrimStart = new TextBox();
            label2 = new Label();
            TrimEnd = new TextBox();
            SaveButton = new Button();
            SaveLastSecondsButton = new Button();
            LastSecondsText = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            OpenRightClickMenu = new Button();
            CRFBar = new TrackBar();
            CRFLabel = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CRFBar).BeginInit();
            SuspendLayout();
            // 
            // VideoFile
            // 
            VideoFile.FileName = "VideoFile";
            // 
            // VideoPath
            // 
            VideoPath.BackColor = SystemColors.ControlDark;
            VideoPath.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            VideoPath.Location = new Point(12, 9);
            VideoPath.Name = "VideoPath";
            VideoPath.Size = new Size(586, 19);
            VideoPath.TabIndex = 0;
            VideoPath.Text = "[No video selected]";
            VideoPath.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // SelectVideo
            // 
            SelectVideo.Location = new Point(12, 31);
            SelectVideo.Name = "SelectVideo";
            SelectVideo.Size = new Size(130, 23);
            SelectVideo.TabIndex = 1;
            SelectVideo.Text = "Choose Video...";
            SelectVideo.UseVisualStyleBackColor = true;
            SelectVideo.Click += SelectVideo_Click;
            // 
            // TrimStart
            // 
            TrimStart.Location = new Point(72, 19);
            TrimStart.Name = "TrimStart";
            TrimStart.Size = new Size(101, 23);
            TrimStart.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(179, 19);
            label2.Name = "label2";
            label2.Size = new Size(27, 19);
            label2.TabIndex = 3;
            label2.Text = "-";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TrimEnd
            // 
            TrimEnd.Location = new Point(212, 19);
            TrimEnd.Name = "TrimEnd";
            TrimEnd.Size = new Size(101, 23);
            TrimEnd.TabIndex = 4;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(507, 21);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(73, 21);
            SaveButton.TabIndex = 5;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // SaveLastSecondsButton
            // 
            SaveLastSecondsButton.Location = new Point(507, 19);
            SaveLastSecondsButton.Name = "SaveLastSecondsButton";
            SaveLastSecondsButton.Size = new Size(73, 23);
            SaveLastSecondsButton.TabIndex = 6;
            SaveLastSecondsButton.Text = "Save";
            SaveLastSecondsButton.UseVisualStyleBackColor = true;
            SaveLastSecondsButton.Click += SaveLastSecondsButton_Click;
            // 
            // LastSecondsText
            // 
            LastSecondsText.Location = new Point(72, 19);
            LastSecondsText.Name = "LastSecondsText";
            LastSecondsText.Size = new Size(101, 23);
            LastSecondsText.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 19);
            label1.TabIndex = 11;
            label1.Text = "Trim from";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Control;
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TrimStart);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TrimEnd);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Location = new Point(12, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(586, 54);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Trim Between";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Control;
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(LastSecondsText);
            groupBox2.Controls.Add(SaveLastSecondsButton);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(586, 54);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Save Last";
            // 
            // label4
            // 
            label4.Location = new Point(179, 20);
            label4.Name = "label4";
            label4.Size = new Size(105, 19);
            label4.TabIndex = 13;
            label4.Text = "seconds of video";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(60, 19);
            label3.TabIndex = 12;
            label3.Text = "Save last";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OpenRightClickMenu
            // 
            OpenRightClickMenu.Location = new Point(374, 31);
            OpenRightClickMenu.Name = "OpenRightClickMenu";
            OpenRightClickMenu.Size = new Size(224, 23);
            OpenRightClickMenu.TabIndex = 14;
            OpenRightClickMenu.Text = "Manage Right-Click Menu";
            OpenRightClickMenu.UseVisualStyleBackColor = true;
            OpenRightClickMenu.Click += OpenRightClickMenu_Click;
            // 
            // CRFBar
            // 
            CRFBar.AutoSize = false;
            CRFBar.Location = new Point(92, 209);
            CRFBar.Maximum = 48;
            CRFBar.Minimum = 4;
            CRFBar.Name = "CRFBar";
            CRFBar.Size = new Size(426, 26);
            CRFBar.TabIndex = 15;
            CRFBar.Value = 4;
            CRFBar.Scroll += CRFBar_Scroll;
            CRFBar.MouseUp += CRFBar_MouseUp;
            // 
            // CRFLabel
            // 
            CRFLabel.Location = new Point(92, 182);
            CRFLabel.Name = "CRFLabel";
            CRFLabel.Size = new Size(426, 19);
            CRFLabel.TabIndex = 16;
            CRFLabel.Text = "Constant Rate Factor (CRF): 0";
            CRFLabel.TextAlign = ContentAlignment.MiddleCenter;
            CRFLabel.Click += CRFLabel_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label6.Location = new Point(12, 209);
            label6.Name = "label6";
            label6.Size = new Size(74, 29);
            label6.TabIndex = 17;
            label6.Text = "Lossless (Not Recommended)";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label7.Location = new Point(524, 209);
            label7.Name = "label7";
            label7.Size = new Size(74, 29);
            label7.TabIndex = 18;
            label7.Text = "High Compression";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 247);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(CRFLabel);
            Controls.Add(CRFBar);
            Controls.Add(OpenRightClickMenu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(SelectVideo);
            Controls.Add(VideoPath);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainForm";
            Text = "QuickTrim";
            Load += Form1_Load;
            DragDrop += Form1_DragDrop;
            DragEnter += Form1_DragEnter;
            DragLeave += Form1_DragLeave;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)CRFBar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog VideoFile;
        private Label VideoPath;
        private Button SelectVideo;
        private TextBox TrimStart;
        private Label label2;
        private TextBox TrimEnd;
        private Button SaveButton;
        private Button SaveLastSecondsButton;
        private TextBox LastSecondsText;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private Button OpenRightClickMenu;
        private TrackBar CRFBar;
        private Label CRFLabel;
        private Label label6;
        private Label label7;
    }
}
