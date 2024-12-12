﻿namespace QuickTrimForms {
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
            CPUUsageInfoBox.BorderStyle = BorderStyle.None;
            CPUUsageInfoBox.Location = new Point(12, 56);
            CPUUsageInfoBox.Multiline = true;
            CPUUsageInfoBox.Name = "CPUUsageInfoBox";
            CPUUsageInfoBox.ReadOnly = true;
            CPUUsageInfoBox.Size = new Size(273, 129);
            CPUUsageInfoBox.TabIndex = 2;
            CPUUsageInfoBox.Text = "Controls how many threads FFmpeg will have access to during encoding. This can greatly affect how quickly a video is processed.\r\n\r\nDefault = Automatic\r\nSlower = 1 thread.\r\nSlow = 4 threads.";
            CPUUsageInfoBox.TextChanged += textBox1_TextChanged;
            CPUUsageInfoBox.Enter += CPUUsageInfoBox_Enter;
            // 
            // PreferencesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 197);
            Controls.Add(CPUUsageInfoBox);
            Controls.Add(label1);
            Controls.Add(cpuUsageType);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "PreferencesForm";
            Text = "Preferences";
            Load += PreferencesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cpuUsageType;
        private Label label1;
        private TextBox CPUUsageInfoBox;
    }
}