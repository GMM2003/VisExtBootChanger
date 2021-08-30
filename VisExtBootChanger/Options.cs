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
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void Options_FormClosed(object sender, FormClosedEventArgs e)
        {
            Main m = new Main();
            m.Show();
            this.Hide();
        }

        private void Options_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button2, "Changelog is not added yet. Will added in future betas.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FirstRunStart frs = new FirstRunStart();
            frs.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/GMM2003/VisExtBootChanger");
        }
    }
}
