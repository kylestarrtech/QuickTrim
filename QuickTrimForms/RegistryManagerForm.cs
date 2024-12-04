using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuickTrimForms {
    public partial class RegistryManagerForm : Form {
        public RegistryManagerForm() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            RefreshRegistryEntries();
        }

        private void RefreshRegistryEntries() {
            registryList.Items.Clear();

            RegistryKey mainKey = Registry.ClassesRoot.OpenSubKey("*\\shell") ?? throw new Exception("Subkey does not exist!");

            if (mainKey == null) {
                throw new NullReferenceException("Shell Subkey does not exist!");
            }

            string[] subKeys = mainKey.GetSubKeyNames();
            foreach (string key in subKeys) {
                if (key.Contains("QuickTrim")) {
                    registryList.Items.Add(key);
                }
            }
        }

        private void RemoveSelectedMenusButton_Click(object sender, EventArgs e) {
            foreach (string item in registryList.SelectedItems) {
                RegistryKey baseKey = Registry.ClassesRoot.OpenSubKey("*\\shell", true) ?? throw new Exception("Subkey does not exist!");

                baseKey.DeleteSubKeyTree(item);

                baseKey.Close();
            }

            RefreshRegistryEntries();
        }

        private void AddToMenuButton_Click(object sender, EventArgs e) {
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

            RefreshRegistryEntries();
        }

        private void RemoveAllMenusButton_Click(object sender, EventArgs e) {
            string[] subKeys = Registry.ClassesRoot.GetSubKeyNames();
            foreach (string key in subKeys) {
                if (key.Contains("QuickTrim")) {
                    Registry.ClassesRoot.DeleteSubKeyTree(key);
                }
            }

            RefreshRegistryEntries();
        }
    }
}
