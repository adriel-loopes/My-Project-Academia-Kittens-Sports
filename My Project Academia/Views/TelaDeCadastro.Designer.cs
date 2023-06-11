namespace My_Project_Academia.Views
{
    partial class TelaDeCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaDeCadastro));
            pictureBox1 = new PictureBox();
            label3 = new Label();
            btnCadastrar = new Button();
            btnLimpar = new Button();
            btnSair = new Button();
            lbNomeCompleto = new Label();
            lbEmail = new Label();
            lbUsuario = new Label();
            lbSenha = new Label();
            ttbSenha = new TextBox();
            ttbNomeCompleto = new TextBox();
            ttbEmail = new TextBox();
            ttbUsuario = new TextBox();
            btnVer = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(243, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 67);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(228, 143);
            label3.Name = "label3";
            label3.Size = new Size(207, 32);
            label3.TabIndex = 9;
            label3.Text = "KITTENS SPORTS";
            // 
            // btnCadastrar
            // 
            btnCadastrar.ForeColor = Color.Blue;
            btnCadastrar.Location = new Point(192, 349);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(75, 23);
            btnCadastrar.TabIndex = 11;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.ForeColor = Color.Green;
            btnLimpar.Location = new Point(273, 349);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 12;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnSair
            // 
            btnSair.ForeColor = Color.Red;
            btnSair.Location = new Point(354, 349);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 13;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // lbNomeCompleto
            // 
            lbNomeCompleto.AutoSize = true;
            lbNomeCompleto.BackColor = Color.Transparent;
            lbNomeCompleto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbNomeCompleto.Location = new Point(91, 211);
            lbNomeCompleto.Name = "lbNomeCompleto";
            lbNomeCompleto.Size = new Size(132, 21);
            lbNomeCompleto.TabIndex = 14;
            lbNomeCompleto.Text = "Nome Completo";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.Transparent;
            lbEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbEmail.Location = new Point(169, 238);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(54, 21);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "E-mail";
            // 
            // lbUsuario
            // 
            lbUsuario.AutoSize = true;
            lbUsuario.BackColor = Color.Transparent;
            lbUsuario.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsuario.Location = new Point(158, 267);
            lbUsuario.Name = "lbUsuario";
            lbUsuario.Size = new Size(65, 21);
            lbUsuario.TabIndex = 16;
            lbUsuario.Text = "Usuário";
            // 
            // lbSenha
            // 
            lbSenha.AutoSize = true;
            lbSenha.BackColor = Color.Transparent;
            lbSenha.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSenha.Location = new Point(169, 296);
            lbSenha.Name = "lbSenha";
            lbSenha.Size = new Size(54, 21);
            lbSenha.TabIndex = 17;
            lbSenha.Text = "Senha";
            // 
            // ttbSenha
            // 
            ttbSenha.Location = new Point(229, 298);
            ttbSenha.Name = "ttbSenha";
            ttbSenha.Size = new Size(127, 23);
            ttbSenha.TabIndex = 18;
            ttbSenha.UseSystemPasswordChar = true;
            // 
            // ttbNomeCompleto
            // 
            ttbNomeCompleto.Location = new Point(229, 211);
            ttbNomeCompleto.Name = "ttbNomeCompleto";
            ttbNomeCompleto.Size = new Size(200, 23);
            ttbNomeCompleto.TabIndex = 19;
            // 
            // ttbEmail
            // 
            ttbEmail.Location = new Point(229, 240);
            ttbEmail.Name = "ttbEmail";
            ttbEmail.Size = new Size(200, 23);
            ttbEmail.TabIndex = 20;
            // 
            // ttbUsuario
            // 
            ttbUsuario.Location = new Point(229, 269);
            ttbUsuario.Name = "ttbUsuario";
            ttbUsuario.Size = new Size(200, 23);
            ttbUsuario.TabIndex = 21;
            // 
            // btnVer
            // 
            btnVer.Location = new Point(372, 298);
            btnVer.Name = "btnVer";
            btnVer.Size = new Size(57, 23);
            btnVer.TabIndex = 22;
            btnVer.Text = "Ver";
            btnVer.UseVisualStyleBackColor = true;
            btnVer.Click += btnVer_Click;
            // 
            // TelaDeCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Looes;
            ClientSize = new Size(662, 430);
            Controls.Add(btnVer);
            Controls.Add(ttbUsuario);
            Controls.Add(ttbEmail);
            Controls.Add(ttbNomeCompleto);
            Controls.Add(ttbSenha);
            Controls.Add(lbSenha);
            Controls.Add(lbUsuario);
            Controls.Add(lbEmail);
            Controls.Add(lbNomeCompleto);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(btnCadastrar);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Name = "TelaDeCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TelaDeCadastro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label3;
        private Button btnCadastrar;
        private Button btnLimpar;
        private Button btnSair;
        private Label lbNomeCompleto;
        private Label lbEmail;
        private Label lbUsuario;
        private Label lbSenha;
        private TextBox ttbSenha;
        private TextBox ttbNomeCompleto;
        private TextBox ttbEmail;
        private TextBox ttbUsuario;
        private Button btnVer;
    }
}