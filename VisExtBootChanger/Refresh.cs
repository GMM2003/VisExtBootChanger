using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace VisExtBootChanger
{
    public partial class Refresh : Form
    {
        public Refresh()
        {
            InitializeComponent();
        }

        private void Refresh_Load(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            Preview p = new Preview();
            p.Show();
            this.Close();
        }
    }
}
