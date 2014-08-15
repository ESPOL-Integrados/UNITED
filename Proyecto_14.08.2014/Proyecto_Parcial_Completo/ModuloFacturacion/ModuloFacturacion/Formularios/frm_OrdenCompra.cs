using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_compras
{
    public partial class frm_OrdenCompra : Form
    {
        public frm_OrdenCompra()
        {
            InitializeComponent();
        }

        private void frm_OrdenCompra_Load(object sender, EventArgs e)
        {
            tss_lbl_fecha.Text = DateTime.Now.ToString();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
    }
}
