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
    public partial class Restart : Form
    {
        public Restart()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            string RestartAction;
            RestartAction = "/r /t 00";
            var process2 = System.Diagnostics.Process.Start("shutdown.exe", RestartAction);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            {
                progressBar1.Increment(5);
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label2.Enabled = true;
            System.IO.Stream str = Properties.Resources.Windows_Ding;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            label3.Enabled = true;
            System.IO.Stream str2 = Properties.Resources.Windows_Ding;
            System.Media.SoundPlayer snd2 = new System.Media.SoundPlayer(str2);
            snd2.Play();
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            label4.Enabled = true;
            System.IO.Stream str3 = Properties.Resources.Windows_Shutdown;
            System.Media.SoundPlayer snd3 = new System.Media.SoundPlayer(str3);
            snd3.Play();
        }

        private void Restart_Load(object sender, EventArgs e)
        {

        }
    }
}
