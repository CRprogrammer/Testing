using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logic_Magic_Software
{
    public partial class InicioForm : Form
    {
        public InicioForm()
        {
            InitializeComponent();
            
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {

            MenuPrincipal menuPrincipal = new MenuPrincipal();
            menuPrincipal.MdiParent = this;
            menuPrincipal.WindowState = FormWindowState.Maximized;
            menuPrincipal.Show();
            btnContinuar.Visible = false;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void acercaDeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AyudaForm ayudaForm = new AyudaForm();
            ayudaForm.Show();
            ayudaForm.TopMost = true;
            
        }
    }
}
