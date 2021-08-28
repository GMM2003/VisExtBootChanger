using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace VisExtBootChanger
{
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Preview_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"bin/preview.png";
            ToolTip toolTip1 = new ToolTip();
            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(button1, "This option will use the changed NTOSKRNL to replace the existing file (on System32) with that one. WARNING: MAKE SURE YOU HAVE EXTENDED KERNEL INSTALLED WITH VERSION 6.0.6003.20555.");
            System.IO.Stream str = Properties.Resources.HOVER;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

            ToolTip toolTip2 = new ToolTip();
            toolTip2.ShowAlways = true;
            toolTip2.SetToolTip(button2, "This option will not make changes to the NTOSKRNL. It will replace the old image (shown in the preview) with a new one.");
            System.IO.Stream str2 = Properties.Resources.HOVER;
            System.Media.SoundPlayer snd2 = new System.Media.SoundPlayer(str2);
            snd2.Play();

            ToolTip toolTip3 = new ToolTip();
            toolTip3.ShowAlways = true;
            toolTip3.SetToolTip(button3, "This option will save the modified NTOSKRNL to a specified directory with the new image (shown in preview).");
            System.IO.Stream str3 = Properties.Resources.HOVER;
            System.Media.SoundPlayer snd3 = new System.Media.SoundPlayer(str3);
            snd3.Play();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            File.Delete(@"bin/preview.png");
            string destPath = "modified/ntoskrnl-modified.exe";
            string destBackupPath = "modified/ntoskrnl-modified-original.exe";
            string existoriginalPath = "modified/ntoskrnl-modified-original.exe";
            if (File.Exists(destPath))
            {
                string message2 = "The file you're saving already exists. Your file will be saved, but the existing file will be renamed as ntoskrnl-modified-original.exe.";
                string title2 = "File exists";
                MessageBoxButtons buttons2 = MessageBoxButtons.OK;
                DialogResult result2 = MessageBox.Show(message2, title2, buttons2);
                if (result2 == DialogResult.OK)
                {
                    if (File.Exists(existoriginalPath))
                    {
                        File.Delete("modified/ntoskrnl-modified-original.exe");
                        File.Move("modified/ntoskrnl-modified.exe", "modified/ntoskrnl-modified-original.exe");
                    }
                    else
                    {
                        File.Move("modified/ntoskrnl-modified.exe", "modified/ntoskrnl-modified-original.exe");
                    }
                }
            }
            System.IO.FileInfo fi = new System.IO.FileInfo(destPath);
            File.Move("bin/ntoskrnl-modify.exe", destPath);
            string message = "Modified NTOSKRNL file saved to 'modified' folder.";
            string title = "Saved";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            File.Delete(@"bin/preview.png");
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse BMP file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "BMP",
                Filter = "BMP files (*.bmp)|*.bmp",
                FilterIndex = 2,

                ReadOnlyChecked = false,
                ShowReadOnly = false,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label2.Visible = true;
                string destFile = Path.Combine("bin/", Path.GetFileName(openFileDialog1.FileName));
                File.Copy(openFileDialog1.FileName, destFile, true);
                System.IO.FileInfo fi = new System.IO.FileInfo(destFile);
                if (fi.Exists)
                {
                    if (File.Exists("bin/image.bmp"))
                    {
                        File.Delete("bin/image.bmp");
                    }
                    fi.MoveTo(@"bin/image.bmp");
                }

                string imageReplace;
                imageReplace = "-open bin/ntoskrnl.exe -save bin/ntoskrnl-modify.exe -action modify -res bin/image.bmp -mask BITMAP,1,1033";
                var process2 = System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace);

                string previewImage;
                previewImage = "-i bin/image.bmp -i bin/mask.png -filter_complex 'overlay' -codec:a copy bin/preview.png";
                var process = System.Diagnostics.Process.Start("ffmpeg.exe", previewImage);

                process2.WaitForExit();

                process.WaitForExit();
                label2.Visible = false;
                Refresh r = new Refresh();
                r.Show();
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.HOVER;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            File.Delete(@"bin/preview.png");
            var process = System.Diagnostics.Process.Start("installm.bat");

            process.WaitForExit();
            Restart r = new Restart();
            r.Show();
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
