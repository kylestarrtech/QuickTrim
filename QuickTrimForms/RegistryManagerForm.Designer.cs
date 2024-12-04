namespace QuickTrimForms {
    partial class RegistryManagerForm {
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
            label1 = new Label();
            registryList = new ListBox();
            RemoveSelectedMenusButton = new Button();
            RemoveAllMenusButton = new Button();
            groupBox1 = new GroupBox();
            label3 = new Label();
            LastSecondsText = new TextBox();
            label2 = new Label();
            AddToMenuButton = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(12, 71);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 0;
            label1.Text = "Right Click Entries:";
            // 
            // registryList
            // 
            registryList.FormattingEnabled = true;
            registryList.ItemHeight = 15;
            registryList.Location = new Point(12, 89);
            registryList.Name = "registryList";
            registryList.Size = new Size(345, 289);
            registryList.TabIndex = 1;
            // 
            // RemoveSelectedMenusButton
            // 
            RemoveSelectedMenusButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RemoveSelectedMenusButton.Location = new Point(12, 384);
            RemoveSelectedMenusButton.Name = "RemoveSelectedMenusButton";
            RemoveSelectedMenusButton.Size = new Size(83, 33);
            RemoveSelectedMenusButton.TabIndex = 3;
            RemoveSelectedMenusButton.Text = "Remove";
            RemoveSelectedMenusButton.UseVisualStyleBackColor = true;
            RemoveSelectedMenusButton.Click += RemoveSelectedMenusButton_Click;
            // 
            // RemoveAllMenusButton
            // 
            RemoveAllMenusButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            RemoveAllMenusButton.Location = new Point(101, 384);
            RemoveAllMenusButton.Name = "RemoveAllMenusButton";
            RemoveAllMenusButton.Size = new Size(125, 33);
            RemoveAllMenusButton.TabIndex = 4;
            RemoveAllMenusButton.Text = "Remove ALL";
            RemoveAllMenusButton.UseVisualStyleBackColor = true;
            RemoveAllMenusButton.Click += RemoveAllMenusButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(LastSecondsText);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 56);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add new Right-Click menu";
            // 
            // label3
            // 
            label3.Location = new Point(182, 27);
            label3.Name = "label3";
            label3.Size = new Size(66, 19);
            label3.TabIndex = 2;
            label3.Text = "seconds...";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LastSecondsText
            // 
            LastSecondsText.Location = new Point(76, 23);
            LastSecondsText.Name = "LastSecondsText";
            LastSecondsText.Size = new Size(100, 23);
            LastSecondsText.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(17, 24);
            label2.Name = "label2";
            label2.Size = new Size(53, 19);
            label2.TabIndex = 0;
            label2.Text = "Save last";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // AddToMenuButton
            // 
            AddToMenuButton.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            AddToMenuButton.Location = new Point(284, 39);
            AddToMenuButton.Name = "AddToMenuButton";
            AddToMenuButton.Size = new Size(73, 29);
            AddToMenuButton.TabIndex = 6;
            AddToMenuButton.Text = "Add";
            AddToMenuButton.UseVisualStyleBackColor = true;
            AddToMenuButton.Click += AddToMenuButton_Click;
            // 
            // RegistryManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 429);
            Controls.Add(AddToMenuButton);
            Controls.Add(groupBox1);
            Controls.Add(RemoveAllMenusButton);
            Controls.Add(RemoveSelectedMenusButton);
            Controls.Add(registryList);
            Controls.Add(label1);
            Name = "RegistryManagerForm";
            Text = "Registry Management";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox registryList;
        private Button RemoveSelectedMenusButton;
        private Button RemoveAllMenusButton;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox LastSecondsText;
        private Label label3;
        private Button AddToMenuButton;
    }
}