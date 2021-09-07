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
    public partial class AuthUI : Form
    {
        public AuthUI()
        {
            InitializeComponent();
        }

        private void AuthUI_Load(object sender, EventArgs e)
        {
            string message = "This feature isn't complete yet, but due to this, you can only change the first image in this beta. While the rest of the features are coming soon, UI is almost complete. Stay tuned for more.";
            string title = "PREVIEW";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            string extractBootImage;
            extractBootImage = "-open bin/authui.dll -save bin/images/default/part1.png -action extract -res bin/image1.png -mask IMAGE,17000,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage);

            string extractBootImage2;
            extractBootImage2 = "-open bin/authui.dll -save bin/images/default/part2.png -action extract -res bin/image2.png -mask IMAGE,17001,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage2);

            string extractBootImage3;
            extractBootImage3 = "-open bin/authui.dll -save bin/images/default/part3.png -action extract -res bin/image3.png -mask IMAGE,17002,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage3);

            string extractBootImage4;
            extractBootImage4 = "-open bin/authui.dll -save bin/images/default/part4.png -action extract -res bin/image4.png -mask IMAGE,17003,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage4);

            string extractBootImage5;
            extractBootImage5 = "-open bin/authui.dll -save bin/images/default/part5.png -action extract -res bin/image5.png -mask IMAGE,17004,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage5);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string extractBootImage;
            extractBootImage = "-open bin/authui.dll -save bin/images/default/part1.png -action extract -res bin/image1.png -mask IMAGE,17000,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage);

            string extractBootImage2;
            extractBootImage2 = "-open bin/authui.dll -save bin/images/default/part2.png -action extract -res bin/image2.png -mask IMAGE,17001,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage2);

            string extractBootImage3;
            extractBootImage3 = "-open bin/authui.dll -save bin/images/default/part3.png -action extract -res bin/image3.png -mask IMAGE,17002,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage3);

            string extractBootImage4;
            extractBootImage4 = "-open bin/authui.dll -save bin/images/default/part4.png -action extract -res bin/image4.png -mask IMAGE,17003,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage4);

            string extractBootImage5;
            extractBootImage5 = "-open bin/authui.dll -save bin/images/default/part5.png -action extract -res bin/image5.png -mask IMAGE,17004,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage5);

            pictureBox1.ImageLocation = @"bin\images\default\part1.png";
            pictureBox2.ImageLocation = @"bin\images\default\part2.png";
            pictureBox3.ImageLocation = @"bin\images\default\part3.png";
            pictureBox4.ImageLocation = @"bin\images\default\part4.png";
            pictureBox5.ImageLocation = @"bin\images\default\part5.png";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.ImageLocation = @"bin\images\default\part1.png";
            pictureBox2.ImageLocation = @"bin\images\default\part2.png";
            pictureBox3.ImageLocation = @"bin\images\default\part3.png";
            pictureBox4.ImageLocation = @"bin\images\default\part4.png";
            pictureBox5.ImageLocation = @"bin\images\default\part5.png";
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"bin\images\default\part1.png";
            pictureBox2.ImageLocation = @"bin\images\default\part2.png";
            pictureBox3.ImageLocation = @"bin\images\default\part3.png";
            pictureBox4.ImageLocation = @"bin\images\default\part4.png";
            pictureBox5.ImageLocation = @"bin\images\default\part5.png";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
               Title = "Browse PNG file",

               CheckFileExists = true,
               CheckPathExists = true,

               DefaultExt = "PNG",
               Filter = "PNG files (*.png)|*.png",
               FilterIndex = 2,

               ReadOnlyChecked = false,
               ShowReadOnly = false,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                label8.Visible = true;

                if (radioButton1.Checked)
                {
                    label8.Text = "Copying image";
                    string destFile = Path.Combine("bin/images/custom", Path.GetFileName(openFileDialog1.FileName));
                    File.Copy(openFileDialog1.FileName, destFile, true);
                    System.IO.FileInfo fi = new System.IO.FileInfo(destFile);
                    if (fi.Exists)
                    {
                        if (File.Exists("bin/images/custom/temp-cusp1.png"))
                        {
                            File.Delete("bin/images/custom/temp-cusp1.png");
                        }
                        fi.MoveTo(@"bin/images/custom/temp-cusp1.png");
                    }

                    label8.Text = "Sizing image to 300x300 resolution";
                    string resizeImage;
                    resizeImage = "bin/images/custom/temp-cusp1.png -resize 300x300! bin/images/custom/cusp1.png";
                    var process = System.Diagnostics.Process.Start("convert.exe", resizeImage);

                    process.WaitForExit();

                    File.Delete("bin/images/custom/temp-cusp1.png");

                    if (checkBox1.Checked)
                    {
                        label8.Text = "Applying vignette effect to image";
                        string vignetteImage;
                        vignetteImage = "bin/images/custom/cusp1.png -background black -vignette 0x13 bin/images/custom/cusp1.png";
                        var process2 = System.Diagnostics.Process.Start("convert.exe", vignetteImage);

                        process2.WaitForExit();
                    }

                    if (checkBox2.Checked)
                    {
                        label8.Text = "Applying black and white color effect to image";
                        string grayscaleImage;
                        grayscaleImage = "bin/images/custom/cusp1.png -type Grayscale bin/images/custom/cusp1.png";
                        var process3 = System.Diagnostics.Process.Start("convert.exe", grayscaleImage);

                        process3.WaitForExit();
                    }

                    if (checkBox3.Checked)
                    {
                        label8.Text = "Resizing watermark to match the size of the image";
                        string resizewatermarkImage;
                        resizewatermarkImage = "bin/images/watermark/logo.png -resize 300x300 bin/images/watermark/logo-300x300.png";
                        var process4 = System.Diagnostics.Process.Start("convert.exe", resizewatermarkImage);

                        process4.WaitForExit();

                        label8.Text = "Adding watermark to image";
                        string previewImage;
                        previewImage = "-i bin/images/custom/cusp1.png -i bin/images/watermark/logo-300x300.png -filter_complex 'overlay' -codec:a copy bin/images/custom/watermark-cusp1.png";
                        var process5 = System.Diagnostics.Process.Start("ffmpeg.exe", previewImage);

                        process5.WaitForExit();

                        File.Delete("bin/images/custom/cusp1.png");

                        string originalPath = "bin/images/custom/watermark-cusp1.png";
                        string duplicatePath = "bin/images/custom/cusp1.png";
                        File.Move(originalPath, duplicatePath);
                    }
                }

                if (radioButton2.Checked)
                {
                    label8.Text = "Copying image";
                    string destFile = Path.Combine("bin/images/custom", Path.GetFileName(openFileDialog1.FileName));
                    File.Copy(openFileDialog1.FileName, destFile, true);
                    System.IO.FileInfo fi = new System.IO.FileInfo(destFile);
                    if (fi.Exists)
                    {
                        if (File.Exists("bin/images/custom/temp-cusp1.png"))
                        {
                            File.Delete("bin/images/custom/temp-cusp1.png");
                        }
                        fi.MoveTo(@"bin/images/custom/temp-cusp1.png");
                    }

                    label8.Text = "Sizing image to 400x400 resolution";
                    string resizeImage;
                    resizeImage = "bin/images/custom/temp-cusp1.png -resize 400x400! bin/images/custom/cusp1.png";
                    var process = System.Diagnostics.Process.Start("convert.exe", resizeImage);

                    process.WaitForExit();

                    File.Delete("bin/images/custom/temp-cusp1.png");

                    if (checkBox1.Checked)
                    {
                        label8.Text = "Applying vignette effect to image";
                        string vignetteImage;
                        vignetteImage = "bin/images/custom/cusp1.png -background black -vignette 0x13 bin/images/custom/cusp1.png";
                        var process2 = System.Diagnostics.Process.Start("convert.exe", vignetteImage);

                        process2.WaitForExit();
                    }

                    if (checkBox2.Checked)
                    {
                        label8.Text = "Applying black and white color effect to image";
                        string grayscaleImage;
                        grayscaleImage = "bin/images/custom/cusp1.png -type Grayscale bin/images/custom/cusp1.png";
                        var process3 = System.Diagnostics.Process.Start("convert.exe", grayscaleImage);

                        process3.WaitForExit();
                    }

                    if (checkBox3.Checked)
                    {
                        label8.Text = "Resizing watermark to match the size of the image";
                        string resizewatermarkImage;
                        resizewatermarkImage = "bin/images/watermark/logo.png -resize 400x400 bin/images/watermark/logo-400x400.png";
                        var process4 = System.Diagnostics.Process.Start("convert.exe", resizewatermarkImage);

                        process4.WaitForExit();

                        label8.Text = "Adding watermark to image";
                        string previewImage;
                        previewImage = "-i bin/images/custom/cusp1.png -i bin/images/watermark/logo-400x400.png -filter_complex 'overlay' -codec:a copy bin/images/custom/watermark-cusp1.png";
                        var process5 = System.Diagnostics.Process.Start("ffmpeg.exe", previewImage);

                        process5.WaitForExit();

                        File.Delete("bin/images/custom/cusp1.png");

                        string originalPath = "bin/images/custom/watermark-cusp1.png";
                        string duplicatePath = "bin/images/custom/cusp1.png";
                        File.Move(originalPath, duplicatePath);
                    }
                }

                if (radioButton3.Checked)
                {
                    label8.Text = "Copying image";
                    string destFile = Path.Combine("bin/images/custom", Path.GetFileName(openFileDialog1.FileName));
                    File.Copy(openFileDialog1.FileName, destFile, true);
                    System.IO.FileInfo fi = new System.IO.FileInfo(destFile);
                    if (fi.Exists)
                    {
                        if (File.Exists("bin/images/custom/temp-cusp1.png"))
                        {
                            File.Delete("bin/images/custom/temp-cusp1.png");
                        }
                        fi.MoveTo(@"bin/images/custom/temp-cusp1.png");
                    }

                    label8.Text = "Sizing image to 500x500 resolution";
                    string resizeImage;
                    resizeImage = "bin/images/custom/temp-cusp1.png -resize 500x500! bin/images/custom/cusp1.png";
                    var process = System.Diagnostics.Process.Start("convert.exe", resizeImage);

                    process.WaitForExit();

                    File.Delete("bin/images/custom/temp-cusp1.png");

                    if (checkBox1.Checked)
                    {
                        label8.Text = "Applying vignette effect to image";
                        string vignetteImage;
                        vignetteImage = "bin/images/custom/cusp1.png -background black -vignette 0x13 bin/images/custom/cusp1.png";
                        var process2 = System.Diagnostics.Process.Start("convert.exe", vignetteImage);

                        process2.WaitForExit();
                    }

                    if (checkBox2.Checked)
                    {
                        label8.Text = "Applying black and white color effect to image";
                        string grayscaleImage;
                        grayscaleImage = "bin/images/custom/cusp1.png -type Grayscale bin/images/custom/cusp1.png";
                        var process3 = System.Diagnostics.Process.Start("convert.exe", grayscaleImage);

                        process3.WaitForExit();
                    }

                    if (checkBox3.Checked)
                    {
                        label8.Text = "Resizing watermark to match the size of the image";
                        string resizewatermarkImage;
                        resizewatermarkImage = "bin/images/watermark/logo.png -resize 500x500 bin/images/watermark/logo-500x500.png";
                        var process4 = System.Diagnostics.Process.Start("convert.exe", resizewatermarkImage);

                        process4.WaitForExit();

                        label8.Text = "Adding watermark to image";
                        string previewImage;
                        previewImage = "-i bin/images/custom/cusp1.png -i bin/images/watermark/logo-500x500.png -filter_complex 'overlay' -codec:a copy bin/images/custom/watermark-cusp1.png";
                        var process5 = System.Diagnostics.Process.Start("ffmpeg.exe", previewImage);

                        process5.WaitForExit();

                        File.Delete("bin/images/custom/cusp1.png");

                        string originalPath = "bin/images/custom/watermark-cusp1.png";
                        string duplicatePath = "bin/images/custom/cusp1.png";
                        File.Move(originalPath, duplicatePath);
                    }
                }

                timer2.Start();
                label8.Text = "Done!";
                pictureBox1.ImageLocation = @"bin\images\custom\cusp1.png";
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = "This is a preview. Will work when done.";
            string title = "Restart";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            button4.Enabled = true;
            // button5.Enabled = true;
            // button6.Enabled = true;
            // button7.Enabled = true;
            // button8.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            // button5.Enabled = true;
            // button6.Enabled = true;
            // button7.Enabled = true;
            // button8.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button4.Enabled = true;
            // button5.Enabled = true;
            // button6.Enabled = true;
            // button7.Enabled = true;
            // button8.Enabled = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            label8.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                string imageReplace;
                imageReplace = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/default/part1.png -mask IMAGE,17000,1033";
                System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace);

                string imageReplace2;
                imageReplace2 = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/default/part2.png -mask IMAGE,17001,1033";
                System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace2);

                string imageReplace3;
                imageReplace3 = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/default/part3.png -mask IMAGE,17002,1033";
                System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace3);

                string imageReplace4;
                imageReplace4 = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/default/part4.png -mask IMAGE,17003,1033";
                System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace4);

                string imageReplace5;
                imageReplace5 = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/default/part5.png -mask IMAGE,17004,1033";
                System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace5);

                string filePath = "bin/authui-modify.dll";
                string moveAuthUI = Environment.ExpandEnvironmentVariables("%USERPROFILE%" + @"\Desktop\authui-modified.dll");
                if (File.Exists(moveAuthUI))
                {
                    File.Delete(moveAuthUI);
                    File.Copy(filePath, moveAuthUI);
                }
                else
                {
                    File.Copy(filePath, moveAuthUI);
                }

                string message = "Your authui.dll is saved to your desktop. To replace it, it is recommended to boot to another operating system from CD or USB (like a Windows PE or a Live Linux distribution), and replace it from there. Forcing to rename or moving authui.dll from System32 will cause the User Account Control to stop working (and show a black screen for less than a second), which will not make changes to your system.";
                string title = "IMPORTANT";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
            else if (radioButton5.Checked)
            {
                if (File.Exists("bin/images/custom/cusp1.png"))
                {
                    string imageReplace;
                    imageReplace = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/custom/cusp1.png -mask IMAGE,17000,1033";
                    System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace);
                }
                else if (File.Exists("bin/images/custom/cusp2.png"))
                {
                    string imageReplace2;
                    imageReplace2 = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/custom/cusp2.png -mask IMAGE,17001,1033";
                    System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace2);
                }
                else if (File.Exists("bin/images/custom/cusp3.png"))
                {
                    string imageReplace3;
                    imageReplace3 = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/custom/cusp3.png -mask IMAGE,17002,1033";
                    System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace3);
                }
                else if (File.Exists("bin/images/custom/cusp4.png"))
                {
                    string imageReplace4;
                    imageReplace4 = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/custom/cusp4.png -mask IMAGE,17003,1033";
                    System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace4);
                }
                else if (File.Exists("bin/images/custom/cusp5.png"))
                {
                    string imageReplace5;
                    imageReplace5 = "-open bin/authui.dll -save bin/authui-modify.dll -action modify -res bin/images/custom/cusp5.png -mask IMAGE,17004,1033";
                    System.Diagnostics.Process.Start("ResourceHacker.exe", imageReplace5);
                }

                string filePath = "bin/authui-modify.dll";
                string moveAuthUI = Environment.ExpandEnvironmentVariables("%USERPROFILE%" + @"\Desktop\authui-modified.dll");
                if (File.Exists(moveAuthUI))
                {
                    File.Delete(moveAuthUI);
                    File.Copy(filePath, moveAuthUI);
                }
                else
                {
                    File.Copy(filePath, moveAuthUI);
                }

            string message = "Your authui.dll is saved to your desktop. To replace it, it is recommended to boot to another operating system from CD or USB (like a Windows PE or a Live Linux distribution), and replace it from there. Forcing to rename or moving authui.dll from System32 will cause the User Account Control to stop working (and show a black screen for less than a second), which will not make changes to your system.";
            string title = "IMPORTANT";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);

            }
            else
            {
                string message = "No custom images are found. Please specify any image you want to use and try again. File not changed.";
                string title = "Restart";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result = MessageBox.Show(message, title, buttons);
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            button2.Enabled = true;

        }
    }
}
