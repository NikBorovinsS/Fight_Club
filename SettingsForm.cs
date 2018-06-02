using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fight_Club
{
    public partial class SettingsForm : Form
    {
        public FightClubMainForm ParentMainForm;

        public bool ChangeAccepted = false;

        private int FightDuration;

        public const int StandartDuration = 100;

        public SettingsForm()
        {
            InitializeComponent();

            ReadAllSettings();
        }

        private void DurationRadioShort_CheckedChanged(object sender, EventArgs e)
        {
            FightDuration = 50;
        }

        private void DurationRadioNormal_CheckedChanged(object sender, EventArgs e)
        {
            FightDuration = 100;
        }

        private void DurationRadioLong_CheckedChanged(object sender, EventArgs e)
        {
            FightDuration = 200;
        }

        private void ReadAllSettings()
        {
            try
            {
                var appSettings = ConfigurationSettings.AppSettings;

                if (appSettings.Count == 0)
                {
                    return;
                }
                else
                {
                    foreach (var key in appSettings.AllKeys)
                    {
                        switch (key)
                        {
                            case "FirstName": SetFirstPlayerName.Text = appSettings[key];
                                break;
                            case "SecondName": SetSecondPlayerName.Text = appSettings[key];
                                break;
                            case "Duration": FightDuration = Int32.Parse(appSettings[key]);
                                break;
                        }
                    }
                }
            }
            catch (ConfigurationException)
            {
                FightDuration = StandartDuration;
            }
        }

        private void AddUpdateAppSettings(string key, string value)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configFile.AppSettings.Settings;
                if (settings[key] == null)
                {
                    settings.Add(key, value);
                }
                else
                {
                    settings[key].Value = value;
                }
                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
            catch (ConfigurationErrorsException)
            {
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            AddUpdateAppSettings("FirstName", SetFirstPlayerName.Text);
            AddUpdateAppSettings("SecondName", SetSecondPlayerName.Text);
            AddUpdateAppSettings("Duration", FightDuration.ToString());

            ChangeAccepted = true;

            ParentMainForm.Enabled = true;
            this.Hide();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ParentMainForm.Enabled = true;
            this.Hide();
        }
    }
}
