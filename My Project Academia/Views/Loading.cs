using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace My_Project_Academia.Views
{
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbProcessando.Top -= 3;
            if (lbProcessando.Top <= 10)
            {
                Timer1.Stop();
                Timer3.Start();
            }

        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            lbProcessando.Top += 3;
            if (lbProcessando.Top >= 50)
            {
                Timer1.Start();
                Timer3.Stop();
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {
            Panel1.Width += 5;
            if (Panel1.Width >= 300)
            {
                Timer4.Stop();

                this.Hide();
                new TelaDeUsuario().ShowDialog();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {

        }
    }
}
