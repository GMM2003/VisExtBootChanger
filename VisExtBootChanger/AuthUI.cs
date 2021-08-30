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
    public partial class AuthUI : Form
    {
        public AuthUI()
        {
            InitializeComponent();
        }

        private void AuthUI_Load(object sender, EventArgs e)
        {
            string message = "This feature is only used for preview purposes. The ability to change authui.dll's five images aren't implemented yet, so expect to come in a future beta. UI is under construction.";
            string title = "PREVIEW";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
            string extractBootImage;
            extractBootImage = "-open bin/authui.dll -save bin/images/part1.png -action extract -res bin/image1.png -mask IMAGE,17000,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage);

            string extractBootImage2;
            extractBootImage2 = "-open bin/authui.dll -save bin/images/part2.png -action extract -res bin/image2.png -mask IMAGE,17001,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage2);

            string extractBootImage3;
            extractBootImage3 = "-open bin/authui.dll -save bin/images/part3.png -action extract -res bin/image3.png -mask IMAGE,17002,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage3);

            string extractBootImage4;
            extractBootImage4 = "-open bin/authui.dll -save bin/images/part4.png -action extract -res bin/image4.png -mask IMAGE,17003,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage4);

            string extractBootImage5;
            extractBootImage5 = "-open bin/authui.dll -save bin/images/part5.png -action extract -res bin/image5.png -mask IMAGE,17004,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage5);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"bin\images\part1.png";
            pictureBox2.ImageLocation = @"bin\images\part2.png";
            pictureBox3.ImageLocation = @"bin\images\part3.png";
            pictureBox4.ImageLocation = @"bin\images\part4.png";
            pictureBox5.ImageLocation = @"bin\images\part5.png";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string extractBootImage;
            extractBootImage = "-open bin/authui.dll -save bin/images/part1.png -action extract -res bin/image1.png -mask IMAGE,17000,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage);

            string extractBootImage2;
            extractBootImage2 = "-open bin/authui.dll -save bin/images/part2.png -action extract -res bin/image2.png -mask IMAGE,17001,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage2);

            string extractBootImage3;
            extractBootImage3 = "-open bin/authui.dll -save bin/images/part3.png -action extract -res bin/image3.png -mask IMAGE,17002,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage3);

            string extractBootImage4;
            extractBootImage4 = "-open bin/authui.dll -save bin/images/part4.png -action extract -res bin/image4.png -mask IMAGE,17003,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage4);

            string extractBootImage5;
            extractBootImage5 = "-open bin/authui.dll -save bin/images/part5.png -action extract -res bin/image5.png -mask IMAGE,17004,1033";
            System.Diagnostics.Process.Start("ResourceHacker.exe", extractBootImage5);

            pictureBox1.ImageLocation = @"bin\images\part1.png";
            pictureBox2.ImageLocation = @"bin\images\part2.png";
            pictureBox3.ImageLocation = @"bin\images\part3.png";
            pictureBox4.ImageLocation = @"bin\images\part4.png";
            pictureBox5.ImageLocation = @"bin\images\part5.png";
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
