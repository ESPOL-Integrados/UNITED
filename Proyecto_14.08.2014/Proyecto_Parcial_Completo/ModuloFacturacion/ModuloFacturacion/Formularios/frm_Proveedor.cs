using ModuloFacturacion.Datos;
using ModuloFacturacion.Formularios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using ModuloFacturacion.Reglas_del_negocio;
namespace Sistema_compras.Formularios
{
    public partial class frm_Proveedor : Form
    {
        
        public frm_Proveedor()
        {
            InitializeComponent();
        }

        private void frm_Proveedor_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'sAV_INVENTARIO_DataSet.IN_R_TIPO_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.iN_R_TIPO_PRODUCTOTableAdapter.Fill(this.sAV_INVENTARIO_DataSet.IN_R_TIPO_PRODUCTO);
            
            // TODO: esta línea de código carga datos en la tabla 'sAV_INVENTARIO_DataSet.IN_R_TIPO_PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.iN_R_TIPO_PRODUCTOTableAdapter.Fill(this.sAV_INVENTARIO_DataSet.IN_R_TIPO_PRODUCTO);
            tss_lbl_fecha.Text = DateTime.Now.ToString();
            txt_fecha_ingreso.Text = DateTime.Now.ToString("yyyy-MM-dd");


            






        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btn_consultar_Proveedor_Click(object sender, EventArgs e)
        {
            frm_Consulta_Proveedor x1 = new frm_Consulta_Proveedor();
            x1.ShowDialog();

        }

        private void btn_consultar_Click(object sender, EventArgs e)
        {
            @new obj1 = new @new();

            int codigo = Convert.ToInt32(txt_codigo.Text);
            var x=obj1.consulta(codigo);



            foreach (var item in x )
            {
                if (item._codigo >= 1)
                {
                    //Asignacion de Datos de la base
                    txt_codigo.Text = Convert.ToString(item._codigo);
                    txt_nombre.Text = item._nombre;
                    txt_razon_social.Text = Convert.ToString(item._razonsocial);
                    txt_telefono.Text = item._telefono;
                    txt_direccion.Text = item._direccion;
                    txt_fecha_ingreso.Text = Convert.ToString(item._fecha_ingreso);
                    txt_responsable.Text = item._responsable;
                    if (item._contabilidad == true)
                    {

                        rdb_Contabilidad_YES.Checked = true;
                    }
                    else {

                        rdb_Contabilidad_NO.Checked = true;
                    }
                    txt_ruc.Text = item._ruc;
                    txt_cedula.Text = item._cedula_pass;
                    cbx_tipo_producto.SelectedIndex = Convert.ToInt32(item._id_tipo_producto)-1;
                    

                    break;
                }
            }

            
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {


            txt_codigo.Text = "";
            txt_nombre.Text = "";
            txt_razon_social.Text = "";
            txt_telefono.Text = "";
            txt_fecha_ingreso.Text = DateTime.Now.ToString("yyyy-MM-dd");
            txt_responsable.Text = "";
            txt_direccion.Text = "";
            txt_ruc.Text = "";
            txt_cedula.Text = "";



            
            

            
            
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {

            if ((this.txt_nombre.Text == String.Empty) || (this.txt_razon_social.Text == String.Empty) || (this.txt_telefono.Text == String.Empty) || (this.txt_direccion.Text == String.Empty) ||
                (this.txt_fecha_ingreso.Text == String.Empty) || (this.txt_responsable.Text == String.Empty))
            {
                MessageBox.Show("No puede dejar espacios vacios al realizar una operacion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else {
                Proveedor x = new Proveedor();
                @new clas = new @new();
                x._nombre = txt_nombre.Text;
                x._razonsocial = txt_razon_social.Text;
                x._telefono = txt_telefono.Text;
                x._direccion = txt_direccion.Text;
                x._fecha_ingreso = Convert.ToDateTime(txt_fecha_ingreso.Text);
                x._responsable = txt_responsable.Text;

                //SELECCION DE RADIO BUTTONS
                if (rdb_Contabilidad_YES.Checked)
                {
                    x._contabilidad = true;
                }
                else
                {
                    x._contabilidad = false;
                }
                x._ruc = txt_ruc.Text;
                x._cedula_pass = txt_cedula.Text;

                if (cbx_tipo_producto.SelectedIndex == -1)
                {
                    MessageBox.Show("No a seleccionado tipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    x._id_tipo_producto = cbx_tipo_producto.SelectedIndex + 1;
                }

                clas.insertar(x);
                MessageBox.Show("El ingeso se realizo satisfactoriamente!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btn_Nuevo.PerformClick();
            
            
            }//END IF




           
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea modificar el usuario seleccionado?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            { 
                
                //CAPTURA DE DATOS

                Proveedor x = new Proveedor();

                @new clas = new @new();
                x._codigo = Convert.ToInt32(txt_codigo.Text);
                x._nombre = txt_nombre.Text;
                x._razonsocial = txt_razon_social.Text;
                x._telefono = txt_telefono.Text;
                x._direccion = txt_direccion.Text;
                x._fecha_ingreso = Convert.ToDateTime(txt_fecha_ingreso.Text);
                x._responsable = txt_responsable.Text;

                //SELECCION DE RADIO BUTTONS
                if (rdb_Contabilidad_YES.Checked)
                {
                    x._contabilidad = true;
                }
                else
                {
                    x._contabilidad = false;
                }
                x._ruc = txt_ruc.Text;
                x._cedula_pass = txt_cedula.Text;

                if (cbx_tipo_producto.SelectedIndex == -1)
                {
                    MessageBox.Show("No a seleccionado tipo", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    x._id_tipo_producto = cbx_tipo_producto.SelectedIndex + 1;
                }

                clas.Modificar(x);
                MessageBox.Show("La modificacion se realizo satisfactoriamente!", "Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            
            }
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            DialogResult x = MessageBox.Show("¿Esta seguro que desea eliminar ese registro?", "System", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (x == DialogResult.Yes)
            {

                @new obj1 = new @new();

                int codigo = Convert.ToInt32(txt_codigo.Text);
                obj1.Eliminar(codigo);
                MessageBox.Show("Registro eliminado con exito", "System", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //Validaciones de cajas de texto
        private void txt_ruc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_cedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_responsable_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        

     

      


        
        
        
     

       
    }
}
