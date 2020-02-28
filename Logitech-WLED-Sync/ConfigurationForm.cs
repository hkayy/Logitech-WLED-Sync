﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logitech_WLED_Sync
{
    public partial class ConfigurationForm : Form
    {
        WledSyncAppSettings settings;
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void ConfigurationForm_Load(object sender, EventArgs e)
        {
            settings = new WledSyncAppSettings();

            this.StartEnabledCheckBox.Checked = settings.StartEnabled;
            this.UDPPortInput.Value = settings.UDPPort;
            this.CrossfadeEnabledCheckBox.Checked = settings.CrossfadeEnabled;
            this.TransitionTimeInput.Value = settings.TransitionTime;

            this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
            this.CancelButton.Click += new System.EventHandler(this.CancelButtonClick);
        }

        private void SaveButtonClick(object sender, EventArgs e)
        {
            settings.StartEnabled = this.StartEnabledCheckBox.Checked;
            settings.UDPPort = (int)this.UDPPortInput.Value;
            settings.CrossfadeEnabled = this.CrossfadeEnabledCheckBox.Checked;
            settings.TransitionTime = (int)this.TransitionTimeInput.Value;

            settings.Save();
            Console.WriteLine("Save");
        }
        private void CancelButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("Cancel");            
        }
    }
}
