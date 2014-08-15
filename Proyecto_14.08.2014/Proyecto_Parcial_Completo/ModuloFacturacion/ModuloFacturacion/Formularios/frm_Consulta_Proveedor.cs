using Sistema_compras.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ModuloFacturacion.Formularios
{
    public partial class frm_Consulta_Proveedor : Form
    {
        

        public frm_Consulta_Proveedor()
        {
            InitializeComponent();
        }

        private void frm_Consulta_Proveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sAV_COMPRAS_DataSet.CP_M_PROVEEDOR' Puede moverla o quitarla según sea necesario.
            this.cP_M_PROVEEDORTableAdapter.Fill(this.sAV_COMPRAS_DataSet.CP_M_PROVEEDOR);

        }

        private void dgv_ConsultaProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            frm_Proveedor f = new frm_Proveedor();
            f.txt_nombre.Text = dgv_ConsultaProveedor.CurrentRow.Cells[1].Value.ToString();

        }


    }
}
