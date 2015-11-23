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
            SresgaminG.Arma3.Mute.State muteState = SresgaminG.Arma3.Mute.MuteUnmute(MuteAppName.Text);

            buttonMute.Text = (muteState ==  SresgaminG.Arma3.Mute.State.Muted ? "Unmute" : "Mute");
        }

        private void OnClickIsMuted(object sender, EventArgs e)
        {
            MessageBox.Show(this, string.Format("{0} is {1}", MuteAppName.Text, (SresgaminG.Arma3.Mute.IsMuted(MuteAppName.Text)) ? "muted" : "not muted"), "How Interesting", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnShown(object sender, EventArgs e)
        {
            bool state = SresgaminG.Arma3.Mute.IsMuted(MuteAppName.Text);

            buttonMute.Text = (state ? "Unmute" : "Mute");
        }
    }
}
