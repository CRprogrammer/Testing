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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;


            
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            InicioForm inicioForm = new InicioForm();
            inicioForm = (InicioForm)Application.OpenForms["InicioForm"];
            inicioForm.Close();
        }
    }
}
