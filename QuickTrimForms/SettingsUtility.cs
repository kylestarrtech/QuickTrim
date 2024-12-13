using FFMpegCore.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace QuickTrimForms {
    public static class SettingsUtility {
        public static string startupPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\QuickTrim";
        public static string settingsPath = $"{startupPath}\\settings.json";

        public static QuickTrimSettings? GetSettings() {

            if (!File.Exists(settingsPath)) {
                SettingsDontExistFailsafe();
                return null;
            }

            string settingsJson = File.ReadAllText(settingsPath);
            QuickTrimSettings settingsObject = JsonSerializer.Deserialize<QuickTrimSettings>(settingsJson) ?? throw new NullReferenceException("Settings cannot be deserialized properly!");

            return settingsObject;
        }

        public static void SaveSettings(QuickTrimSettings settings) {
            if (settings == null) {
                throw new NullReferenceException("Settings cannot be null!");
            }

            if (!File.Exists(settingsPath)) {
                throw new FileNotFoundException("Settings file does not exist!");
            }

            string json = JsonSerializer.Serialize(settings);

            File.WriteAllText(settingsPath, json);
        }

        public static void SettingsDontExistFailsafe() {
            if (File.Exists(settingsPath)) {
                return;
            }

            QuickTrimSettings settings = new QuickTrimSettings();

            settings.ConstantRateFactor = 30;
            settings.CPUUsage = QuickTrimCPUUsage.Default;
            settings.EncoderPreset = Speed.Medium;
            settings.EncodeSpecificFramerate = false;
            settings.SetFrameRate = 60;

            string json = JsonSerializer.Serialize(settings);

            File.WriteAllText(settingsPath, json);

            MessageBox.Show("Settings file was not found, a new one has been created with default values. QuickTrim will now restart.", "Settings File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Application.Restart();
        }
    }
}
