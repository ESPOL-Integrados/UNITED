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
    public partial class FrmFacturacion : Form
    {
        public DataTable Dt = new DataTable();
        public DataRow Dr;

        

        public DataColumn Codigo = new DataColumn("Codigo");//
        public DataColumn Descripcion = new DataColumn("Descripcion");
        public DataColumn Cant = new DataColumn("Cantidad");
        public DataColumn Pre = new DataColumn("Precio");
        public DataColumn Tot = new DataColumn("Total");

       

        public FrmFacturacion()
        {
            InitializeComponent();
        }

       
        //private void  USUARIODataGridView_CellClick(object sender,DataGridViewCellEventArgs e As System.Windows.Forms.DataGridViewCellEventArgs) Handles USUARIODataGridView.CellClick
        int x;
        decimal to = 0, subt = 0;
        private void dataGridView1_CellContentDobleClick(object sender, DataGridViewCellEventArgs e) 
        {

            FrmFacturacionProducto a = new FrmFacturacionProducto();
            a.ShowDialog();
            Dr = Dt.NewRow();
            Dr[Codigo] = a.co;
            Dr[Descripcion] = a.de;
            Dr[Cant] = a.ca;
            Dr[Pre] = a.pr;
            Dr[Tot] = a.to;
            Dt.Rows.Add(Dr);
            subt = 0;
            for (x = 0; x < Dt.Rows.Count; x++)
            {
                subt = subt + Convert.ToDecimal(Dt.Rows[x][4]);
            }
            txtSub.Text = Convert.ToString(subt);
            subt=subt*12/100;
            txtDes.Text = Convert.ToString(subt);
            to = Convert.ToDecimal(txtSub.Text) + Convert.ToDecimal(txtDes.Text);
            txtTot.Text = Convert.ToString(to);
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            Dt.Columns.Add(this.Codigo);
            Dt.Columns.Add(this.Descripcion);
            Dt.Columns.Add(this.Cant);
            Dt.Columns.Add(this.Pre);
            Dt.Columns.Add(this.Tot);
            dataGridView1.DataSource = this.Dt;  
        }
    }
}
