using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms
{
    public partial class frmInv_MenuPrincipal : Form
    {
        public frmInv_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantProducto frm = new frmMantProducto();
            frm.ShowDialog();
        }

        private void bodegaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantBodega frm = new frmMantBodega();
            frm.ShowDialog();
        }

        private void perchaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantPercha frm = new frmMantPercha();
            frm.ShowDialog();
        }

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKardex frm = new frmKardex();
            frm.ShowDialog();
        }

        private void movimientosDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimientoInventario frm = new frmMovimientoInventario();
            frm.ShowDialog();
        }

        private void conceptosDeMovimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConceptoMovimientoInventario frm = new frmConceptoMovimientoInventario();
            frm.ShowDialog();
        }

        private void productoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteGeneralProducto rep = new ReporteGeneralProducto();
            rep.ShowDialog();
        }

        private void tipoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteGeneralTipoProducto rep = new ReporteGeneralTipoProducto();
            rep.ShowDialog();
        }

        private void perchaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteGeneralPercha rep = new ReporteGeneralPercha();
            rep.ShowDialog();
        }

        private void movimientoDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteMovimientoInventario rep = new ReporteMovimientoInventario();
            rep.ShowDialog();
        }

        private void bodegaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteGeneralBodega rep = new ReporteGeneralBodega();
            rep.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tipoProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTipoProducto frm = new frmTipoProducto();
            frm.ShowDialog();
        }

        private void medidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantMedida frm = new frmMantMedida();
            frm.ShowDialog();
        }
    }
}
