using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            areas formareas = new areas();
            formareas.Show();
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            financeiro formfinanceiro = new financeiro();
            formfinanceiro.Show();
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            usarios formusario = new usarios();
            formusario.Show();
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
           saude formsaude = new saude();
            formsaude.Show();
        }

        private void btncavalo_Click(object sender, EventArgs e)
        {
         
        {
            formsCavalo formCavalos = new formsCavalo();
            formCavalos.Show();
            
            }
            
        }

        private void btnrelatorios_Click(object sender, EventArgs e)
        {
            relatorio formrelatorios = new relatorio();
            formrelatorios.Show();
        }
    }
}
