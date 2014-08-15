using System;
using ModuloFacturacion.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_compras.Formularios
{
    public partial class frm_ConsultarGenerales : Form
    {
        public frm_ConsultarGenerales()
        {
            InitializeComponent();
        }

        private void frm_ConsultarGenerales_Load(object sender, EventArgs e)
        {
            tss_lbl_Fecha.Text = DateTime.Now.ToString();
        }
    }
}
