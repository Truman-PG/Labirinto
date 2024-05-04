using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Labirinto
{
    public partial class frmSalaUm : Form
    {
        public frmSalaUm()
        {
            InitializeComponent();
        }

        private void btnSetaCima_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetaDireita_Click(object sender, EventArgs e)
        {
            frmDesafio frmDesafio = new frmDesafio();

            this.Hide();

            frmDesafio.Closed += (object s, EventArgs ev) => this.Show();

            frmDesafio.Show();
        }

        private void btnLimbo_Click(object sender, EventArgs e)
        {
            frmLimbo frmLimbo = new frmLimbo();

            this.Hide();

            frmLimbo.Closed += (object s, EventArgs ev) => this.Show();

            frmLimbo.Show();

        }

        private void btnSetaBaixo_Click(object sender, EventArgs e)
        {
            frmSalaDois frmSalaDois = new frmSalaDois();

            this.Hide();

            frmSalaDois.Closed += (object s, EventArgs ev) => this.Show();

            frmSalaDois.Show();
        }
    }
}
