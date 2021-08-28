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
    public partial class Presets : Form
    {
        public Presets()
        {
            InitializeComponent();
        }

        private void Presets_Load(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            this.Close();
        }

        private void rTMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/xp/xp-rtm.bmp";
            System.Diagnostics.Process.Start("xp-rtm.bat");

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/xp/xp-whistlerb1.bmp";
            System.Diagnostics.Process.Start("xp-whistlerb1.bat");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/xp/xp-whistlerb2-2419.bmp";
            System.Diagnostics.Process.Start("xp-whistlerb2-2419.bat");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/xp/xp-whistlerb2-2428.bmp";
            System.Diagnostics.Process.Start("xp-whistlerb2-2428.bat");
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/xp/xp-whistlerrc1-2474.bmp";
            System.Diagnostics.Process.Start("xp-whistlerrc1-2474.bat");
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/xp/xp-whistlerrc1-2481.bmp";
            System.Diagnostics.Process.Start("xp-whistlerrc1-2481.bat");
        }

        private void m4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/vista/vista-lhm4m5.bmp";
            System.Diagnostics.Process.Start("vista-lhm4m5.bat");
        }

        private void m7ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/vista/vista-lhm7.bmp";
            System.Diagnostics.Process.Start("vista-lhm7.bat");
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/vista/vista-lhb1.bmp";
            System.Diagnostics.Process.Start("vista-lhb1.bat");
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/vista/vista-lhb2.bmp";
            System.Diagnostics.Process.Start("vista-lhb2.bat");
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/vista/vista-lhb2alt.bmp";
            System.Diagnostics.Process.Start("vista-lhb2alt.bat");
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/20002006/vista/vista-lhrc1.bmp";
            System.Diagnostics.Process.Start("vista-lhrc1.bat");
        }

        private void toolStripMenuItem11_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/2008present/7/seven-sevenm3.bmp";
            System.Diagnostics.Process.Start("seven-sevenm3.bat");
        }

        private void rTMToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/2008present/7/seven-rtm.bmp";
            System.Diagnostics.Process.Start("seven-rtm.bat");
        }

        private void rTMToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/2008present/8/8-rtm.bmp";
            System.Diagnostics.Process.Start("8-rtm.bat");
        }

        private void m3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/2008present/8/8-m3.bmp";
            System.Diagnostics.Process.Start("8-m3.bat");
        }

        private void m3altToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/2008present/8/8-m3alt.bmp";
            System.Diagnostics.Process.Start("8-m3alt.bat");
        }

        private void consumerPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/2008present/8/8-cp.bmp";
            System.Diagnostics.Process.Start("8-cp.bat");
        }

        private void releasePreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/versions/2008present/8/8-rp.bmp";
            System.Diagnostics.Process.Start("8-rp.bat");
        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/vista-styled/win1.bmp";
            System.Diagnostics.Process.Start("vs1.bat");
        }

        private void toolStripMenuItem16_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/vista-styled/win3.bmp";
            System.Diagnostics.Process.Start("vs3.bat");
        }

        private void toolStripMenuItem15_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/vista-styled/win31.bmp";
            System.Diagnostics.Process.Start("vs31.bat");
        }

        private void toolStripMenuItem14_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/vista-styled/win95.bmp";
            System.Diagnostics.Process.Start("vs95.bat");
        }

        private void toolStripMenuItem13_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/vista-styled/win98.bmp";
            System.Diagnostics.Process.Start("vs98.bat");
        }

        private void toolStripMenuItem12_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/vista-styled/win2k.bmp";
            System.Diagnostics.Process.Start("vs2k.bat");
        }

        private void xPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            pictureBox1.ImageLocation = @"presets/vista-styled/winxp.bmp";
            System.Diagnostics.Process.Start("vsxp.bat");
        }

        private void restartifAppliedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            string message = "If you already applied a preset, it is recommended to restart your computer. Do you want to restart now?";
            string title = "Restart";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                System.IO.Stream str2 = Properties.Resources.SELECT;
                System.Media.SoundPlayer snd2 = new System.Media.SoundPlayer(str2);
                snd2.Play();
                string RestartAction;
                RestartAction = "/r /t 00";
                var process2 = System.Diagnostics.Process.Start("shutdown.exe", RestartAction);
            }
            else
            {

            }
        }

        private void vistastyledToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rTMToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            System.Diagnostics.Process.Start("vista-rtm.bat");
        }
    }
}
