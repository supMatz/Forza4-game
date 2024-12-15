using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forza4_Mk2_Cerioni
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnAvviaPartita_Click(object sender, EventArgs e)
        {
            string nomeRosso = tbRosso.Text;
            string nomeGiallo = tbGiallo.Text;
            int r = (int)nudRighe.Value;
            int c = (int)nudColonne.Value;

            if (Program.AreValidGenericStrings(nomeGiallo, nomeRosso))
            {
                Hide();
                FrmGioco frmGioco = new FrmGioco(nomeGiallo, nomeRosso, r, c);
                frmGioco.ShowDialog(this);
            }
            else
                MessageBox.Show("Inserire i nomi dei giocatori prima di inziare!", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
