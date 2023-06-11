namespace My_Project_Academia.Views
{
    partial class TelaDeLogin
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeLogin));
            label1 = new Label();
            label2 = new Label();
            btnValidar = new Button();
            ttbUsuario = new TextBox();
            ttbSenha = new TextBox();
            label3 = new Label();
            btnLimpar = new Button();
            btnSair = new Button();
            pictureBox1 = new PictureBox();
            Timer1 = new System.Windows.Forms.Timer(components);
            btnVer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(164, 219);
            label1.Name = "label1";
            label1.Size = new Size(53, 17);
            label1.TabIndex = 0;
            label1.Text = "Usuário";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(174, 255);
            label2.Name = "label2";
            label2.Size = new Size(43, 17);
            label2.TabIndex = 1;
            label2.Text = "Senha";
            // 
            // btnValidar
            // 
            btnValidar.ForeColor = Color.Blue;
            btnValidar.Location = new Point(220, 305);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(73, 23);
            btnValidar.TabIndex = 2;
            btnValidar.Text = "VALIDAR";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // ttbUsuario
            // 
            ttbUsuario.Location = new Point(223, 219);
            ttbUsuario.Name = "ttbUsuario";
            ttbUsuario.Size = new Size(228, 23);
            ttbUsuario.TabIndex = 3;
            // 
            // ttbSenha
            // 
            ttbSenha.Location = new Point(223, 255);
            ttbSenha.Name = "ttbSenha";
            ttbSenha.Size = new Size(149, 23);
            ttbSenha.TabIndex = 4;
            ttbSenha.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(227, 142);
            label3.Name = "label3";
            label3.Size = new Size(207, 32);
            label3.TabIndex = 5;
            label3.Text = "KITTENS SPORTS";
            // 
            // btnLimpar
            // 
            btnLimpar.ForeColor = Color.FromArgb(0, 64, 0);
            btnLimpar.Location = new Point(299, 305);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(73, 23);
            btnLimpar.TabIndex = 6;
            btnLimpar.Text = "LIMPAR";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.ForeColor = Color.Red;
            btnSair.Location = new Point(378, 305);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(73, 23);
            btnSair.TabIndex = 7;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(242, 72);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(399, 255);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(52, 23);
            btnVer.TabIndex = 9;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // TelaDeLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Looes;
            ClientSize = new Size(662, 430);
            Controls.Add(btnVer);
            Controls.Add(pictureBox1);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(label3);
            Controls.Add(ttbSenha);
            Controls.Add(ttbUsuario);
            Controls.Add(btnValidar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TelaDeLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDeLogin";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnValidar;
        private TextBox ttbUsuario;
        private TextBox ttbSenha;
        private Label label3;
        private Button btnLimpar;
        private Button btnSair;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer Timer1;
        private Button btnVer;
    }
}