namespace Arma3.Mute.Test
{
    partial class MuteTesterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMute = new System.Windows.Forms.Button();
            this.MuteAppName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listAudioApplications = new System.Windows.Forms.ListBox();
            this.LabelListOfAudioApplications = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonMute
            // 
            this.buttonMute.Location = new System.Drawing.Point(255, 12);
            this.buttonMute.Name = "buttonMute";
            this.buttonMute.Size = new System.Drawing.Size(75, 23);
            this.buttonMute.TabIndex = 1;
            this.buttonMute.Text = "Mute";
            this.buttonMute.UseVisualStyleBackColor = true;
            this.buttonMute.Click += new System.EventHandler(this.OnClickMute);
            // 
            // MuteAppName
            // 
            this.MuteAppName.Location = new System.Drawing.Point(12, 14);
            this.MuteAppName.Name = "MuteAppName";
            this.MuteAppName.Size = new System.Drawing.Size(156, 20);
            this.MuteAppName.TabIndex = 2;
            this.MuteAppName.Text = "Chrome";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Is Muted?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnClickIsMuted);
            // 
            // listAudioApplications
            // 
            this.listAudioApplications.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listAudioApplications.FormattingEnabled = true;
            this.listAudioApplications.Location = new System.Drawing.Point(12, 63);
            this.listAudioApplications.Name = "listAudioApplications";
            this.listAudioApplications.Size = new System.Drawing.Size(452, 199);
            this.listAudioApplications.TabIndex = 3;
            // 
            // LabelListOfAudioApplications
            // 
            this.LabelListOfAudioApplications.AutoSize = true;
            this.LabelListOfAudioApplications.Location = new System.Drawing.Point(12, 47);
            this.LabelListOfAudioApplications.Name = "LabelListOfAudioApplications";
            this.LabelListOfAudioApplications.Size = new System.Drawing.Size(94, 13);
            this.LabelListOfAudioApplications.TabIndex = 4;
            this.LabelListOfAudioApplications.Text = "Audio Applications";
            // 
            // MuteTesterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 277);
            this.Controls.Add(this.LabelListOfAudioApplications);
            this.Controls.Add(this.listAudioApplications);
            this.Controls.Add(this.MuteAppName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonMute);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MuteTesterForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mute Tester";
            this.Shown += new System.EventHandler(this.OnShown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMute;
        private System.Windows.Forms.TextBox MuteAppName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listAudioApplications;
        private System.Windows.Forms.Label LabelListOfAudioApplications;
    }
}

