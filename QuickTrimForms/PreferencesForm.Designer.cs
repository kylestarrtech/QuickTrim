namespace QuickTrimForms {
    partial class PreferencesForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            cpuUsageType = new ComboBox();
            label1 = new Label();
            CPUUsageInfoBox = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            EncoderPresetBox = new ComboBox();
            setFramerateInfoBox = new TextBox();
            setFramerateLabel = new Label();
            SetSpecificFramerateBox = new CheckBox();
            SetFramerateNum = new NumericUpDown();
            placeboSetButton = new Button();
            ((System.ComponentModel.ISupportInitialize)SetFramerateNum).BeginInit();
            SuspendLayout();
            // 
            // cpuUsageType
            // 
            cpuUsageType.FormattingEnabled = true;
            cpuUsageType.Location = new Point(12, 27);
            cpuUsageType.Name = "cpuUsageType";
            cpuUsageType.Size = new Size(273, 23);
            cpuUsageType.TabIndex = 0;
            cpuUsageType.SelectedIndexChanged += cpuUsageType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 15);
            label1.TabIndex = 1;
            label1.Text = "CPU Usage Type:";
            // 
            // CPUUsageInfoBox
            // 
            CPUUsageInfoBox.BorderStyle = BorderStyle.FixedSingle;
            CPUUsageInfoBox.Font = new Font("Segoe UI", 7F);
            CPUUsageInfoBox.Location = new Point(12, 56);
            CPUUsageInfoBox.Multiline = true;
            CPUUsageInfoBox.Name = "CPUUsageInfoBox";
            CPUUsageInfoBox.ReadOnly = true;
            CPUUsageInfoBox.Size = new Size(273, 80);
            CPUUsageInfoBox.TabIndex = 2;
            CPUUsageInfoBox.Text = "Controls how many threads FFmpeg will have access to during encoding. This can greatly affect how quickly a video is processed.\r\n\r\nDefault = Automatic\r\nSlower = 1 thread.\r\nSlow = 4 threads.";
            CPUUsageInfoBox.Enter += UnfocusControl;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 7F);
            textBox2.Location = new Point(12, 189);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(273, 31);
            textBox2.TabIndex = 7;
            textBox2.Text = "A set of options that will compromise between encoding speed and compression ratio.";
            textBox2.Enter += UnfocusControl;
            // 
            // label2
            // 
            label2.Location = new Point(12, 142);
            label2.Name = "label2";
            label2.Size = new Size(273, 15);
            label2.TabIndex = 6;
            label2.Text = "Encoder Preset:";
            // 
            // EncoderPresetBox
            // 
            EncoderPresetBox.FormattingEnabled = true;
            EncoderPresetBox.Location = new Point(12, 160);
            EncoderPresetBox.Name = "EncoderPresetBox";
            EncoderPresetBox.Size = new Size(273, 23);
            EncoderPresetBox.TabIndex = 5;
            EncoderPresetBox.SelectedIndexChanged += EncoderPresetBox_SelectedIndexChanged;
            // 
            // setFramerateInfoBox
            // 
            setFramerateInfoBox.BorderStyle = BorderStyle.FixedSingle;
            setFramerateInfoBox.Font = new Font("Segoe UI", 7F);
            setFramerateInfoBox.Location = new Point(12, 298);
            setFramerateInfoBox.Multiline = true;
            setFramerateInfoBox.Name = "setFramerateInfoBox";
            setFramerateInfoBox.ReadOnly = true;
            setFramerateInfoBox.Size = new Size(273, 43);
            setFramerateInfoBox.TabIndex = 10;
            setFramerateInfoBox.Text = "If the \"Encode at set framerate?\" setting is ticked, videos will ALWAYS render at the specified framerate. Otherwise it's automatically rounded to the nearest available.";
            // 
            // setFramerateLabel
            // 
            setFramerateLabel.Location = new Point(12, 251);
            setFramerateLabel.Name = "setFramerateLabel";
            setFramerateLabel.Size = new Size(273, 15);
            setFramerateLabel.TabIndex = 9;
            setFramerateLabel.Text = "Set Framerate:";
            // 
            // SetSpecificFramerateBox
            // 
            SetSpecificFramerateBox.AutoSize = true;
            SetSpecificFramerateBox.Location = new Point(12, 229);
            SetSpecificFramerateBox.Name = "SetSpecificFramerateBox";
            SetSpecificFramerateBox.Size = new Size(155, 19);
            SetSpecificFramerateBox.TabIndex = 11;
            SetSpecificFramerateBox.Text = "Encode at set framerate?";
            SetSpecificFramerateBox.UseVisualStyleBackColor = true;
            SetSpecificFramerateBox.CheckedChanged += SetSpecificFramerateBox_CheckedChanged;
            // 
            // SetFramerateNum
            // 
            SetFramerateNum.Increment = new decimal(new int[] { 15, 0, 0, 0 });
            SetFramerateNum.Location = new Point(12, 269);
            SetFramerateNum.Maximum = new decimal(new int[] { 480, 0, 0, 0 });
            SetFramerateNum.Minimum = new decimal(new int[] { 24, 0, 0, 0 });
            SetFramerateNum.Name = "SetFramerateNum";
            SetFramerateNum.Size = new Size(192, 23);
            SetFramerateNum.TabIndex = 12;
            SetFramerateNum.Value = new decimal(new int[] { 24, 0, 0, 0 });
            SetFramerateNum.ValueChanged += SetFramerateNum_ValueChanged;
            // 
            // placeboSetButton
            // 
            placeboSetButton.Location = new Point(210, 269);
            placeboSetButton.Name = "placeboSetButton";
            placeboSetButton.Size = new Size(75, 23);
            placeboSetButton.TabIndex = 13;
            placeboSetButton.Text = "Set";
            placeboSetButton.UseVisualStyleBackColor = true;
            // 
            // PreferencesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 350);
            Controls.Add(placeboSetButton);
            Controls.Add(SetFramerateNum);
            Controls.Add(SetSpecificFramerateBox);
            Controls.Add(setFramerateInfoBox);
            Controls.Add(setFramerateLabel);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(EncoderPresetBox);
            Controls.Add(CPUUsageInfoBox);
            Controls.Add(label1);
            Controls.Add(cpuUsageType);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PreferencesForm";
            Text = "Preferences";
            Load += PreferencesForm_Load;
            ((System.ComponentModel.ISupportInitialize)SetFramerateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cpuUsageType;
        private Label label1;
        private TextBox CPUUsageInfoBox;
        private TextBox textBox2;
        private Label label2;
        private ComboBox EncoderPresetBox;
        private TextBox setFramerateInfoBox;
        private Label setFramerateLabel;
        private CheckBox SetSpecificFramerateBox;
        private NumericUpDown SetFramerateNum;
        private Button placeboSetButton;
    }
}