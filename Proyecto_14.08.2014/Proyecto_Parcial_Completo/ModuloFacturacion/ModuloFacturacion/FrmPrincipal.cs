
using Sistema_compras.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModuloFacturacion 
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfact_Click(object sender, EventArgs e)
        {
            
            FrmFacturacionPrincipal a= new FrmFacturacionPrincipal();
            a.ShowDialog();
        }

        private void btninv_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btncom_Click(object sender, EventArgs e)
        {
            frmMDI_Principal x = new frmMDI_Principal();
            x.ShowDialog();
        }
    }
}
