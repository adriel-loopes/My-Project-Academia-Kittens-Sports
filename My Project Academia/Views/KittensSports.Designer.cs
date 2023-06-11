namespace My_Project_Academia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            mENUToolStripMenuItem = new ToolStripMenuItem();
            cADASTRODEUSUARIOToolStripMenuItem = new ToolStripMenuItem();
            lOGINToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.MenuHighlight;
            menuStrip1.GripStyle = ToolStripGripStyle.Visible;
            menuStrip1.Items.AddRange(new ToolStripItem[] { mENUToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(662, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            mENUToolStripMenuItem.BackColor = Color.White;
            mENUToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cADASTRODEUSUARIOToolStripMenuItem, lOGINToolStripMenuItem });
            mENUToolStripMenuItem.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            mENUToolStripMenuItem.ForeColor = Color.Blue;
            mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            mENUToolStripMenuItem.Size = new Size(53, 20);
            mENUToolStripMenuItem.Text = "MENU";
            // 
            // cADASTRODEUSUARIOToolStripMenuItem
            // 
            cADASTRODEUSUARIOToolStripMenuItem.ForeColor = Color.Green;
            cADASTRODEUSUARIOToolStripMenuItem.Image = (Image)resources.GetObject("cADASTRODEUSUARIOToolStripMenuItem.Image");
            cADASTRODEUSUARIOToolStripMenuItem.ImageTransparentColor = Color.Red;
            cADASTRODEUSUARIOToolStripMenuItem.Name = "cADASTRODEUSUARIOToolStripMenuItem";
            cADASTRODEUSUARIOToolStripMenuItem.Size = new Size(196, 22);
            cADASTRODEUSUARIOToolStripMenuItem.Text = "CADASTRAR USUARIO";
            cADASTRODEUSUARIOToolStripMenuItem.Click += cADASTRODEUSUARIOToolStripMenuItem_Click;
            // 
            // lOGINToolStripMenuItem
            // 
            lOGINToolStripMenuItem.ForeColor = Color.Green;
            lOGINToolStripMenuItem.Image = (Image)resources.GetObject("lOGINToolStripMenuItem.Image");
            lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            lOGINToolStripMenuItem.Size = new Size(196, 22);
            lOGINToolStripMenuItem.Text = "LOGIN";
            lOGINToolStripMenuItem.Click += lOGINToolStripMenuItem_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 406);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleDescription = "";
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(239, 49);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(2, 2);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(222, 128);
            label3.Name = "label3";
            label3.Size = new Size(207, 32);
            label3.TabIndex = 11;
            label3.Text = "KITTENS SPORTS";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(239, 57);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(175, 68);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 430);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaMenu - Kittens Sports";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mENUToolStripMenuItem;
        private ToolStripMenuItem cADASTRODEUSUARIOToolStripMenuItem;
        private ToolStripMenuItem lOGINToolStripMenuItem;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label3;
        private PictureBox pictureBox3;
    }
}