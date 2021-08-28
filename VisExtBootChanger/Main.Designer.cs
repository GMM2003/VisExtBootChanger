
namespace VisExtBootChanger
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ntoskrnlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extractImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requirementsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToMakeBootImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToRevertBackToDefaultBootScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.presetsToolStripMenuItem,
            this.extractImageToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ntoskrnlToolStripMenuItem,
            this.imageFileToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // ntoskrnlToolStripMenuItem
            // 
            this.ntoskrnlToolStripMenuItem.Name = "ntoskrnlToolStripMenuItem";
            this.ntoskrnlToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.ntoskrnlToolStripMenuItem.Text = "ntoskrnl.exe";
            this.ntoskrnlToolStripMenuItem.Click += new System.EventHandler(this.ntoskrnlToolStripMenuItem_Click);
            // 
            // imageFileToolStripMenuItem
            // 
            this.imageFileToolStripMenuItem.Name = "imageFileToolStripMenuItem";
            this.imageFileToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.imageFileToolStripMenuItem.Text = "Image file";
            this.imageFileToolStripMenuItem.Click += new System.EventHandler(this.imageFileToolStripMenuItem_Click);
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.presetsToolStripMenuItem.Text = "Presets";
            this.presetsToolStripMenuItem.Click += new System.EventHandler(this.presetsToolStripMenuItem_Click);
            // 
            // extractImageToolStripMenuItem
            // 
            this.extractImageToolStripMenuItem.Name = "extractImageToolStripMenuItem";
            this.extractImageToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.extractImageToolStripMenuItem.Text = "Extract image";
            this.extractImageToolStripMenuItem.Click += new System.EventHandler(this.extractImageToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requirementsToolStripMenuItem,
            this.howToMakeBootImageToolStripMenuItem,
            this.howToRevertBackToDefaultBootScreenToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // requirementsToolStripMenuItem
            // 
            this.requirementsToolStripMenuItem.Name = "requirementsToolStripMenuItem";
            this.requirementsToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.requirementsToolStripMenuItem.Text = "Requirements";
            this.requirementsToolStripMenuItem.Click += new System.EventHandler(this.requirementsToolStripMenuItem_Click);
            // 
            // howToMakeBootImageToolStripMenuItem
            // 
            this.howToMakeBootImageToolStripMenuItem.Name = "howToMakeBootImageToolStripMenuItem";
            this.howToMakeBootImageToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.howToMakeBootImageToolStripMenuItem.Text = "How to make boot image correctly";
            this.howToMakeBootImageToolStripMenuItem.Click += new System.EventHandler(this.howToMakeBootImageToolStripMenuItem_Click);
            // 
            // howToRevertBackToDefaultBootScreenToolStripMenuItem
            // 
            this.howToRevertBackToDefaultBootScreenToolStripMenuItem.Name = "howToRevertBackToDefaultBootScreenToolStripMenuItem";
            this.howToRevertBackToDefaultBootScreenToolStripMenuItem.Size = new System.Drawing.Size(293, 22);
            this.howToRevertBackToDefaultBootScreenToolStripMenuItem.Text = "How to revert back to default boot screen";
            this.howToRevertBackToDefaultBootScreenToolStripMenuItem.Click += new System.EventHandler(this.howToRevertBackToDefaultBootScreenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(624, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisExtBootChanger";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ntoskrnlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem extractImageToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requirementsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToMakeBootImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToRevertBackToDefaultBootScreenToolStripMenuItem;
    }
}

