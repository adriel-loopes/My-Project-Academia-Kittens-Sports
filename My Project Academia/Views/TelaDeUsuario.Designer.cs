namespace My_Project_Academia.Views
{
    partial class TelaDeUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeUsuario));
            dateTimePicker1 = new DateTimePicker();
            btnCadNovoTreino = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(63, 48);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(251, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // btnCadNovoTreino
            // 
            btnCadNovoTreino.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnCadNovoTreino.BackColor = SystemColors.ControlLightLight;
            btnCadNovoTreino.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadNovoTreino.ForeColor = Color.Red;
            btnCadNovoTreino.Location = new Point(518, 124);
            btnCadNovoTreino.Name = "btnCadNovoTreino";
            btnCadNovoTreino.Size = new Size(108, 29);
            btnCadNovoTreino.TabIndex = 3;
            btnCadNovoTreino.Text = "Cadastrar Treino";
            btnCadNovoTreino.UseVisualStyleBackColor = false;
            btnCadNovoTreino.Click += btnCadNovoTreino_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(22, 123);
            label1.Name = "label1";
            label1.Size = new Size(45, 25);
            label1.TabIndex = 5;
            label1.Text = "SEG";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(82, 123);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 6;
            label2.Text = "TER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(148, 123);
            label3.Name = "label3";
            label3.Size = new Size(52, 25);
            label3.TabIndex = 7;
            label3.Text = "QUA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(217, 123);
            label4.Name = "label4";
            label4.Size = new Size(45, 25);
            label4.TabIndex = 8;
            label4.Text = "QUI";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Blue;
            label5.Location = new Point(279, 123);
            label5.Name = "label5";
            label5.Size = new Size(44, 25);
            label5.TabIndex = 9;
            label5.Text = "SEX";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(22, 159);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(360, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Blue;
            label6.Location = new Point(338, 123);
            label6.Name = "label6";
            label6.Size = new Size(46, 25);
            label6.TabIndex = 11;
            label6.Text = "SAB";
            // 
            // TelaDeUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Looes;
            ClientSize = new Size(662, 430);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCadNovoTreino);
            Controls.Add(dateTimePicker1);
            Name = "TelaDeUsuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDeUsuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dateTimePicker1;
        private Button btnCadNovoTreino;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
    }
}