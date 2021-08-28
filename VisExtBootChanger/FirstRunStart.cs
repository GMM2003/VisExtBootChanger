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
    public partial class FirstRunStart : Form
    {
        public FirstRunStart()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            SplashScreen ss = new SplashScreen();
            ss.Show();
            this.Hide();
        }
    }
}
