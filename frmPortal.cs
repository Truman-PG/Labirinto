using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirinto
{
    public partial class frmPortal : Form
    {
        public frmPortal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            // Cria uma instância para um novo formulário
            frmSalaUm frmSalaUm = new frmSalaUm();

            this.Hide();

            frmSalaUm.Closed += (object s, EventArgs ev) => this.Show(); 

            frmSalaUm.Show();
        }
    }
}
