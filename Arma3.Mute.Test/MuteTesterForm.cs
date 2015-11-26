using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Arma3.Mute.Test
{
    public partial class MuteTesterForm : Form
    {
        public MuteTesterForm()
        {
            InitializeComponent();
        }

        private void OnClickMute(object sender, EventArgs e)
        {
            SresgaminG.Arma3.Mute.MuteUnmute(MuteAppName.Text);
        }

        private void OnShown(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void OnClickRefresh(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            List<string> audioApps = SresgaminG.Arma3.Mute.GetListOfApplicationsWithAudio();

            listAudioApplications.Items.Clear();
            foreach (string audioApp in audioApps)
                listAudioApplications.Items.Add(audioApp);
        }

        private void OnClickVolumeUp(object sender, EventArgs e)
        {
            SresgaminG.Arma3.Mute.VolumeUp(MuteAppName.Text);
        }

        private void OnVolumeDown(object sender, EventArgs e)
        {
            SresgaminG.Arma3.Mute.VolumeDown(MuteAppName.Text);
        }
    }
}
