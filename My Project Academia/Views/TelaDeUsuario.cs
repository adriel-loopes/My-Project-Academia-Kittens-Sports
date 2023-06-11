

namespace My_Project_Academia.Views
{
    public partial class TelaDeUsuario : Form
    {
        public TelaDeUsuario()
        {
            InitializeComponent();
        }

        private void btnCadNovoTreino_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Deseja cadastrar novo treino?", "SIM", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new Loading();
                    this.Hide();
                    new TelaCadTreino().ShowDialog();
                }

            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
