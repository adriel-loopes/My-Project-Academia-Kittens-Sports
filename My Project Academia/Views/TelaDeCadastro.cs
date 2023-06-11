namespace My_Project_Academia.Views
{
    public partial class TelaDeCadastro : Form
    {
        public TelaDeCadastro()
        {
            InitializeComponent();
        }

        //Aplicação para sair da pagina ou totalmente
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }
            //Application.ExitThread();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }
        private void LimpaTela()
        {
            ttbNomeCompleto.Clear();
            ttbEmail.Clear();
            ttbUsuario.Clear();
            ttbSenha.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if ((ttbUsuario.Text != "") & MessageBox.Show("Deseja cadastrar usuário?", "SALVAR", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                MessageBox.Show("Usuário cadastrado com sucesso!");
                new Loading().ShowDialog();
                new TelaDeLogin();
                this.Hide();
            }
            else
                MessageBox.Show("Os campos estão vazios. Por favor preencha-os!");

            //this.Hide();

            //if(ttbUsuario.Text == "")
            {
                //MessageBox.Show("Os campos estão vazios.Por favor preencha-os!");
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (ttbSenha.UseSystemPasswordChar == true)
            {
                ttbSenha.UseSystemPasswordChar = false;
                btnVer.Text = "Ocultar";
            }
            else
            {
                ttbSenha.UseSystemPasswordChar = true;
                btnVer.Text = "Ver";
            }
        }
    }
}
