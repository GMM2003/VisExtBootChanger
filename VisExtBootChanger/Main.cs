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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void imageFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
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

                if (fi.Exists)
                {
                    if (File.Exists("bin/preview.png"))
                    {
                        File.Delete("bin/preview.png");
                    }
                }

                string imageReplace;
                imageReplace = "-open bin/ntoskrnl.exe -save bin/ntoskrnl-modify.exe -action modify -res bin/image.bmp -mask BITMAP,1,1033";
                System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace);

                string previewImage;
                previewImage = "-i bin/image.bmp -i bin/mask.png -filter_complex 'overlay' -codec:a copy bin/preview.png";
                var process = System.Diagnostics.Process.Start("ffmpeg.exe", previewImage);

                process.WaitForExit();
                Preview p = new Preview();
                p.Show();
            }
        }

        private void ntoskrnlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse NTOSKRNL.EXE file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "EXE",
                Filter = "EXE files (*.exe)|*.exe",
                FilterIndex = 2,

                ReadOnlyChecked = false,
                ShowReadOnly = false,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string destFile = Path.Combine("bin/", Path.GetFileName(openFileDialog1.FileName));
                File.Copy(openFileDialog1.FileName, destFile, true);
                System.IO.FileInfo fi = new System.IO.FileInfo(destFile);
                if (fi.Exists)
                {
                    if (File.Exists("bin/ntoskrnl-replace.exe"))
                    {
                        File.Delete("bin/ntoskrnl-replace.exe");
                    }
                    fi.MoveTo(@"bin/ntoskrnl-replace.exe");
                }

                var process = System.Diagnostics.Process.Start("installnt.bat");

                process.WaitForExit();
                File.Delete(@"bin/ntoskrnl-replace.exe");
                Restart r = new Restart();
                r.Show();
                this.Hide();
            }
        }

        private void extractImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Title = "Browse EXE file",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "EXE",
                Filter = "EXE files (*.exe)|*.exe",
                FilterIndex = 2,

                ReadOnlyChecked = false,
                ShowReadOnly = false,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string destFile = Path.Combine("extracted/", Path.GetFileName(openFileDialog1.FileName));
                System.IO.FileInfo fi = new System.IO.FileInfo(destFile);
                if (fi.Exists)
                {
                    if (File.Exists("bin/bootimage.bmp"))
                    {
                        File.Delete("bin/bootimage.bmp");
                    }
                }

                string extractBootImage;
                extractBootImage = "-open " + openFileDialog1.FileName + " -save extracted/bootimage.bmp -action extract -res bin/image.bmp -mask BITMAP,1,1033";
                System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage);
                string message = "Boot image extracted. Check 'extracted' folder.";
                string title = "Extract image";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            Thread.Sleep(1000);
            Application.Exit();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.HOVER;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void presetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            Presets p = new Presets();
            p.Show();
        }

        private void requirementsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            System.Diagnostics.Process.Start(@"help\Requirements.txt");
        }

        private void howToMakeBootImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            System.Diagnostics.Process.Start(@"help\How to make boot image correctly.html");
        }

        private void Main_Load(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void howToRevertBackToDefaultBootScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.IO.Stream str = Properties.Resources.SELECT;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
            System.Diagnostics.Process.Start(@"help\How to revert back to default boot screen.txt");
        }
    }
}
