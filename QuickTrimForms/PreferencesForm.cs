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

        private void textBox1_TextChanged(object sender, EventArgs e) {

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
        }

        private void CPUUsageInfoBox_Enter(object sender, EventArgs e) {
            this.ActiveControl = null;
        }
    }
}
