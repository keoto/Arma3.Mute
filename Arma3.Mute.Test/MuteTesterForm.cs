using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Gma.System.MouseKeyHook;

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
            SetupGlobalKeys();
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

        #region Global Key

        private IKeyboardMouseEvents m_GlobalHook;


        private void SetupGlobalKeys()
        {
            Unsubscribe();



            Subscribe();
        }

        public void Subscribe()
        {
            // Note: for the application hook, use the Hook.AppEvents() instead
            m_GlobalHook = Hook.GlobalEvents();
            m_GlobalHook.KeyUp += GlobalHookKeyUp;
        }

        public void Unsubscribe()
        {
            if (m_GlobalHook == null) return;

            m_GlobalHook.KeyUp -= GlobalHookKeyUp;

            //It is recommened to dispose it
            m_GlobalHook.Dispose();
        }

        private void GlobalHookKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1 && ModifierKeys == Keys.None)
                SresgaminG.Arma3.Mute.MuteUnmute(MuteAppName.Text);
        }

        #endregion
    }
}
