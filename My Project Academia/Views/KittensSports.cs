using My_Project_Academia.Views;

namespace My_Project_Academia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lOGINToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            new TelaDeLogin().ShowDialog();
        }

        private void cADASTRODEUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaDeCadastro().ShowDialog();
        }
    }
}