using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace VisExtBootChanger
{
    public partial class FirstRun : Form
    {
        public FirstRun()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"help\Requirements.txt");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = false;
            string message = "Program will now exit because you didn't have enough requirements to change the boot screen. If you want to use this program at a later time, please make sure you have everything installed before running.";
            string title = "Welcome";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Stream str2 = Properties.Resources.INTROMUSIC;
            System.Media.SoundPlayer snd2 = new System.Media.SoundPlayer(str2);
            snd2.Stop();

            File.Delete("bin/fr.fr");
            FirstRunStart frs = new FirstRunStart();
            frs.Show();
            this.Hide();
        }

        private void FirstRun_Load(object sender, EventArgs e)
        {
            System.IO.Stream str2 = Properties.Resources.INTROMUSIC;
            System.Media.SoundPlayer snd2 = new System.Media.SoundPlayer(str2);
            snd2.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            axWindowsMediaPlayer1.Visible = false;
        }

        private void axWindowsMediaPlayer1_ClickEvent(object sender, AxWMPLib._WMPOCXEvents_ClickEvent e)
        {
            System.IO.Stream str2 = Properties.Resources.INTROMUSIC;
            System.Media.SoundPlayer snd2 = new System.Media.SoundPlayer(str2);
            snd2.PlayLooping();

            timer1.Stop();
            axWindowsMediaPlayer1.Visible = false;
        }
    }
}
