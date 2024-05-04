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
    public partial class frmDesafio : Form
    {
        public frmDesafio()
        {
            InitializeComponent();
        }

        private void btnResposta_Click(object sender, EventArgs e)
        {
            if(numResultadoDesafio.Value == 290)
            {
                frmSalaDois frmSalaDois = new frmSalaDois();
                this.Hide();
                frmSalaDois.Closed += (object s, EventArgs ev) => this.Show();
                frmSalaDois.Show();
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
