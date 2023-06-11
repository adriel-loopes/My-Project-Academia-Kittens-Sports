
namespace My_Project_Academia.Views
{
    public partial class TelaDeLogin : Form
    {
        public TelaDeLogin()
        {
            InitializeComponent();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimpaTela();
        }

        //Método para limpar os campos preenchidos
        private void LimpaTela()
        {
            ttbUsuario.Clear();
            ttbSenha.Clear();
        }

        //Aplicação para Sair da tela
        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
            }

        }

        //Validação de acesso permitido ou erro no login
        private void btnValidar_Click(object sender, EventArgs e)
        {
            if (ttbUsuario.Text == "admin" & ttbSenha.Text == "1234" || ttbUsuario.Text == "ADMIN" & ttbSenha.Text == "1234")
            {
                new Loading().ShowDialog();
                this.Close();
                //MessageBox.Show("Acesso Liberado!");
                //new Loading().ShowDialog();
                //this.Close();
            }

            if (ttbUsuario.Text == "" & ttbSenha.Text == "")
            {

                MessageBox.Show("Por favor, preencha os campos acima!", "ATENÇÃO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            else
            {
                MessageBox.Show("Usuário ou senha inválido!\n Tente novamente!", "ERRO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

        }
        private void Sair()
        {
            if (MessageBox.Show("Deseja realmente sair?", "SAIR", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
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
