using System;
using ModuloFacturacion.Formularios;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Sistema_compras.Formularios;

namespace ModuloFacturacion
{
    
    public partial class FrmFacturacionProducto : Form
    {
        
        public String co="11";
        public String de = "11";
        public String ca = "11";
        public String pr = "11";
        public String to = "11";
        //public IProducto Caller { private get; set; }

        enum e_FILTER_OPTION { SIN_FILTRO, CADENA_QUE_COMIENCE_CON, CADENA_QUE_NO_COMIENCE_CON, CADENA_QUE_CONTENGA, CADENA_QUE_NO_CONTENGA, CADENA_IGUAL };
        enum e_FILTER_OPTION1 { SIN_FILTRO1, NUMERICO_MENOR, NUMERICO_MAYOR, NUMERICO_MENOR_IGUAL, NUMERICO_MAYOR_IGUAL, NUMERICO_IGUAL, NUMERICO_DISTINTO };
        public FrmFacturacionProducto()
        {
            InitializeComponent();
        }
        
        public BindingSource BindingSource1 = new BindingSource();

        int Filtrar_DataGridView(String Columna,String texto, BindingSource  BindingSource1, DataGridView  DataGridView,
             e_FILTER_OPTION bus)
  
        {

            if (BindingSource1.DataSource == null)
            
                return 0 ; 
            
  
            try  
            {
                String filtro = null;
                switch (bus)
                {
                    case e_FILTER_OPTION.CADENA_QUE_COMIENCE_CON:
                        filtro = "like '"+texto+"%'";
                    break;
                    case e_FILTER_OPTION.CADENA_QUE_NO_COMIENCE_CON:
                        filtro = "Not like '" + texto +"%'";  
                        break;
                    case e_FILTER_OPTION.CADENA_QUE_CONTENGA:  
                        filtro = "Not like '%" + texto + "%'";  
                        break;
                    case e_FILTER_OPTION.CADENA_QUE_NO_CONTENGA:  
                        filtro = "like '%" + texto+ "%'";  
                        break;
                    case e_FILTER_OPTION.CADENA_IGUAL:  
                        filtro = "='" + texto +"'";  
                        break;
                    default:
                        MessageBox.Show("Nooooooooooo");
                        break;
                }
                if (bus == e_FILTER_OPTION.SIN_FILTRO)
                    filtro ="";
  
            
                if (filtro != null) 
                    filtro = "[" + Columna + "]" + filtro;
             
  
            
                BindingSource1.Filter = filtro;
                DataGridView.DataSource = BindingSource1.DataSource;
  
                return (BindingSource1.Count);
  
            }
            catch 
                {
                MessageBox.Show("error");
                return 0;
                //MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)  
                }  
        }
        public static Boolean IsNumeric(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }
        int Filtrar_DataGridView1(String Columna, String texto, BindingSource BindingSource1, DataGridView DataGridView,
             e_FILTER_OPTION1 bus)
        {

            if (BindingSource1.DataSource == null)

                return 0;


            try
            {
                String filtro = null;
                switch (bus)
                {
                    case e_FILTER_OPTION1.NUMERICO_MENOR:
                        filtro = "< " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_MAYOR:
                        filtro = "> " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_MENOR_IGUAL:
                        filtro = "<= " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_MAYOR_IGUAL:
                        filtro = ">= " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_IGUAL:
                        filtro = "= " + texto + "";
                        break;
                    case e_FILTER_OPTION1.NUMERICO_DISTINTO:
                        filtro = "!= " + texto + "";
                        break;
                    default:
                        MessageBox.Show("Nooooooooooo");
                        break;
                }
                
                if (bus == e_FILTER_OPTION1.SIN_FILTRO1 | !IsNumeric(texto))
                    filtro = "";


                if (filtro != null)
                    filtro = "[" + Columna + "]" + filtro;



                BindingSource1.Filter = filtro;
                DataGridView.DataSource = BindingSource1.DataSource;

                return (BindingSource1.Count);
                
            }
            catch
            {
                MessageBox.Show("error");
                
                //MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)  
            }
            return 0;
        }

        public void filnum()
        {
            int ret = Filtrar_DataGridView("Descripcion_Producto", Convert.ToString(txtNombre.Text), BindingSource1, dgPro,
                                        (e_FILTER_OPTION)cmbFiltro.SelectedIndex);
            if (ret == 0) 
            
                txtNombre.BackColor = Color.Red;
            else  
                txtNombre.BackColor = Color.White;
        }
        public void filnum1()
        {
            if (txtNombre.Text == "")
                txtNombre.Text = "0";
            int ret = Filtrar_DataGridView1("Codigo_Producto", txtNombre.Text, BindingSource1, dgPro,
                                        (e_FILTER_OPTION1)cmbFiltro.SelectedIndex);
            if (ret == 0)

                txtNombre.BackColor = Color.Red;
            else
                txtNombre.BackColor = Color.White;
        }
        public void ini()
        {

            String a = "Data Source=.;Initial Catalog=SAV;Integrated Security=True";
            String b= "IN_M_BUS_PRODUCTO";

            
            SqlDataAdapter da = new SqlDataAdapter(b, a);
            DataTable ta = new DataTable();
            da.Fill(ta);
            dgPro.DataSource = ta;
            BindingSource1.DataSource = ta;
        }

        private void frmFacturacionProducto_Closing(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtCant.Text = "";
            
        }
        private void FrmFacturacionProducto_Load(object sender, EventArgs e)
        {
            
            Capa2 con = new Capa2();
            try 
            {
                if (con.conectar())
                {
                    ini();
                    
                }
            }
            catch
            {
                MessageBox.Show("Coneccion error", "Coneccion");
            }
        }

        private void rdbNombre_CheckedChanged(object sender, EventArgs e)
        {
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("No filtrar");  
            cmbFiltro.Items.Add("Que comience con");  
            cmbFiltro.Items.Add("Que No comience con");  
            cmbFiltro.Items.Add("Que contenga");  
            cmbFiltro.Items.Add("Que No contenga");  
            cmbFiltro.Items.Add("Que sea igual");
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.SelectedIndex = 1;
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            cmbFiltro.Items.Clear();
            cmbFiltro.Items.Add("No filtrar");  
            cmbFiltro.Items.Add("Menor");  
            cmbFiltro.Items.Add("Mayor");  
            cmbFiltro.Items.Add("Menor o igual");
            cmbFiltro.Items.Add("Mayor o igual");  
            cmbFiltro.Items.Add("Igual");
            cmbFiltro.Items.Add("Distinto");
            cmbFiltro.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFiltro.SelectedIndex = 1;
            //filnum1();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_EditValueChanged(object sender, EventArgs e)
        {
            dgPro.AllowUserToAddRows = false;
            dgPro.ReadOnly = true;
            if (rdbNombre.Checked==(true))
                filnum();
            else
                filnum1();
        }

        

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow f = this.dgPro.CurrentRow;
            
            
            MessageBox.Show("Codigo: " + dgPro[0, dgPro.CurrentRow.Index].Value);
            this.co = Convert.ToString(dgPro[0, dgPro.CurrentRow.Index].Value);
            //this.co=Convert.ToString(f.Cells["Codigo_Producto"].Value);
            this.de = Convert.ToString(f.Cells["Descripcion_Producto"].Value);
            this.ca  =txtCant.Text;
            this.pr = Convert.ToString(f.Cells["Precio"].Value);
            this.to = Convert.ToString(Convert.ToInt32(this.txtCant.Text) * Convert.ToDecimal(f.Cells[4].Value));
            
            
            
            //co = dgPro[0, dgPro.CurrentRow.Index].Value;
            //a.Dr = a.Dt.NewRow();
            /*
            a.Dr = a.Dt.NewRow();
            a.Dr[a.Codigo.ColumnName] = dgPro[0, dgPro.CurrentRow.Index].Value;
            a.Dr[a.Descripcion] = Convert.ToString(f.Cells[1].Value);
            a.Dr[a.Cant] = Convert.ToInt32(txtCant.Text);
            a.Dr[a.Pre] = Convert.ToDecimal(f.Cells[4].Value);
            a.Dr[a.Tot] = Convert.ToDecimal(Convert.ToInt32(this.txtCant.Text) * Convert.ToDecimal(f.Cells[4].Value));
            a.Dt.Rows.Add(a.Dr);
            DataTable DtBus = new DataTable();
            int x;
            decimal to=0,subt=0;
            for (x = 0; x < a.Dt.Rows.Count - 1; x++)
            {
                subt = subt+ Convert.ToDecimal(a.Dt.Rows[x][4]);

            }*/
            
            
            this.Close();
        }

    }
}
