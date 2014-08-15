using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_compras.Formularios
{
    public partial class frm_Solicitud_Pedido : Form
    {
        public frm_Solicitud_Pedido()
        {
            InitializeComponent();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Solicitud_Pedido_Load(object sender, EventArgs e)
        {
            tss_lbl_fecha.Text = DateTime.Now.ToString();
        }

       

   
    }
}
