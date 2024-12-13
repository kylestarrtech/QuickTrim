using FFMpegCore.Enums;
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
    public partial class PreferencesForm : Form {
        public PreferencesForm() {
            InitializeComponent();
        }

        private void cpuUsageType_SelectedIndexChanged(object sender, EventArgs e) {
            QuickTrimSettings settings;
            try {
                settings = SettingsUtility.GetSettings() ?? throw new NullReferenceException("Settings cannot be loaded!");
            }
            catch (NullReferenceException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            settings.CPUUsage = (QuickTrimCPUUsage)cpuUsageType.SelectedValue;
            try {
                SettingsUtility.SaveSettings(settings);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PreferencesForm_Load(object sender, EventArgs e) {
            QuickTrimSettings settings;

            try {
                settings = SettingsUtility.GetSettings() ?? throw new NullReferenceException("Settings cannot be loaded!");
            }
            catch (NullReferenceException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Create elements in the combobox CPUUsageType to match the enum
            cpuUsageType.DataSource = Enum.GetValues(typeof(QuickTrimCPUUsage));

            // Set the selected value to the current value in the settings
            foreach (QuickTrimCPUUsage item in cpuUsageType.Items) {
                if (item == settings.CPUUsage) {
                    cpuUsageType.SelectedItem = item;
                    break;
                }
            }

            // Create elements in the combobox EncoderPresetBox to match the enum
            EncoderPresetBox.DataSource = Enum.GetValues(typeof(Speed));

            // Set the selected value to the current value in the settings
            foreach (Speed item in EncoderPresetBox.Items) {
                if (item == settings.EncoderPreset) {
                    EncoderPresetBox.SelectedItem = item;
                    break;
                }
            }

            SetSpecificFramerateBox.Checked = settings.EncodeSpecificFramerate;

            SetFramerateNum.Enabled = settings.EncodeSpecificFramerate;
            placeboSetButton.Enabled = settings.EncodeSpecificFramerate;
            setFramerateInfoBox.Enabled = settings.EncodeSpecificFramerate;
            setFramerateLabel.Enabled = settings.EncodeSpecificFramerate;

            SetFramerateNum.Value = Math.Clamp(settings.SetFrameRate, SetFramerateNum.Minimum, SetFramerateNum.Maximum);
        }

        private void UnfocusControl(object sender, EventArgs e) {
            this.ActiveControl = null;
        }

        private void EncoderPresetBox_SelectedIndexChanged(object sender, EventArgs e) {
            QuickTrimSettings settings;
            try {
                settings = SettingsUtility.GetSettings() ?? throw new NullReferenceException("Settings cannot be loaded!");
            }
            catch (NullReferenceException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            settings.EncoderPreset = (Speed)EncoderPresetBox.SelectedValue;

            try {
                SettingsUtility.SaveSettings(settings);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetSpecificFramerateBox_CheckedChanged(object sender, EventArgs e) {
            QuickTrimSettings settings;
            try {
                settings = SettingsUtility.GetSettings() ?? throw new NullReferenceException("Settings cannot be loaded!");
            }
            catch (NullReferenceException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            settings.EncodeSpecificFramerate = SetSpecificFramerateBox.Checked;

            SetFramerateNum.Enabled = settings.EncodeSpecificFramerate;
            placeboSetButton.Enabled = settings.EncodeSpecificFramerate;
            setFramerateInfoBox.Enabled = settings.EncodeSpecificFramerate;
            setFramerateLabel.Enabled = settings.EncodeSpecificFramerate;


            try {
                SettingsUtility.SaveSettings(settings);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetFramerateNum_ValueChanged(object sender, EventArgs e) {
            QuickTrimSettings settings;
            try {
                settings = SettingsUtility.GetSettings() ?? throw new NullReferenceException("Settings cannot be loaded!");
            }
            catch (NullReferenceException ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            settings.SetFrameRate = (int)SetFramerateNum.Value;

            try {
                SettingsUtility.SaveSettings(settings);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
