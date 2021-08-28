using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VisExtBootChanger
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.START;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Main m = new Main();
            m.Show();
            this.Hide();
        }
    }
}
