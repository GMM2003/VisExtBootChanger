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
    public partial class StartCheck : Form
    {
        public StartCheck()
        {
            InitializeComponent();
        }

        private void StartCheck_Load(object sender, EventArgs e)
        {
            if (File.Exists("bin/fr.fr"))
            {
                FirstRun fr = new FirstRun();
                fr.Show();
                this.Hide();
            }
            else
            {
                this.Hide();
                SplashScreen ss = new SplashScreen();
                ss.Show();
                this.Hide();
            }
        }
    }
}
