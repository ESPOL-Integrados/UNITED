using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace ModuloFacturacion
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char x,y;
            Object selectedItemg = cmbgen.SelectedItem;
            Object selectedIteme = cmbestado.SelectedItem;
            if ((selectedItemg.ToString()=="Masculino"))
                x = 'M';
            else
                x = 'F';
            if ((selectedIteme.ToString() == "Activo"))
                y = 'A';
            else
                y = 'I';
            try
            {
                if (!string.IsNullOrEmpty(selectedItemg.ToString()) || !string.IsNullOrEmpty(selectedIteme.ToString()))
                {
                    Capa2 con = new Capa2();
                    if (con.conectar())
                    {
                        if (con.RegistraClienteNuevo(Convert.ToInt32(txtcod.Text.ToString()), Convert.ToInt32(txtruc.Text.ToString()),
                            Convert.ToInt32(txtced.Text.ToString()), txtrazon.Text.ToString(), txtnom.Text.ToString(),
                            txtape.Text.ToString(), txtdire.Text.ToString(), Convert.ToInt32(txttel.Text.ToString()),x,y))

                            MessageBox.Show("Usuario Registrado con Exito.");
                        else
                            MessageBox.Show("Problema al ingresar usuario");
                    }
                    else
                    {
                        MessageBox.Show("Coneccion rechazada");
                    }
                }
                else
                    MessageBox.Show("Campos Vacios");
            }
            catch
            {
                MessageBox.Show("Instancia de Clase Rechazada", "Coneccion");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                Capa2 con = new Capa2();
                if (con.conectar())
                {
                    if (con.ModificarClienteNuevo(Convert.ToInt32(txtcod.Text.ToString()), Convert.ToInt32(txtruc.Text.ToString()),
                        Convert.ToInt32(txtced.Text.ToString()), txtrazon.Text.ToString(), txtnom.Text.ToString(),
                        txtape.Text.ToString(), txtdire.Text.ToString(), Convert.ToInt32(txttel.Text.ToString())))

                        MessageBox.Show("Usuario Modificado con Exito.");
                    else
                        MessageBox.Show("Problema al Modificar usuario");
                }
                else
                {
                    MessageBox.Show("Coneccion rechazada");
                }
            }
            catch
            {
                MessageBox.Show("Instancia de Clase Rechazada", "Coneccion");
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            try
            {
                Capa2 con = new Capa2();
                if (con.conectar())
                {
                    if (con.EliminarClienteNuevo(Convert.ToInt32(txtcod.Text.ToString())))

                        MessageBox.Show("Usuario Eliminado con Exito.");
                    else
                        MessageBox.Show("Problema al eliminar usuario");
                }
                else
                {
                    MessageBox.Show("Coneccion rechazada");
                }
            }
            catch
            {
                MessageBox.Show("Instancia de Clase Rechazada", "Coneccion");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndexg = cmbgen.SelectedIndex;
            Object selectedItemg = cmbgen.SelectedItem;
            Object selectedIteme = cmbestado.SelectedItem;

            try
            {
                if (!string.IsNullOrEmpty(selectedItemg.ToString()) || !string.IsNullOrEmpty(selectedIteme.ToString()))
                {
                    Capa2 con = new Capa2();
                    if (con.conectar())
                    {
                        String coneccion = "Data Source=.;Initial Catalog=SAV;Integrated Security=True";
                        SqlConnection cnn = new SqlConnection(coneccion);
                        cnn.Open();
                        String cons = "select * from RH_M_CLIENTE where Codigo_Cliente=" + txtcod.Text;
                        SqlCommand cmd = new SqlCommand(cons, cnn);
                        try
                        {
                            SqlDataReader r = cmd.ExecuteReader();
                            r.Read();
                            txtruc.Text = Convert.ToString(r.GetValue(1));
                            txtced.Text = Convert.ToString(r.GetValue(2));
                            txtnom.Text = Convert.ToString(r.GetValue(4));
                            txtape.Text = Convert.ToString(r.GetValue(5));
                            txtrazon.Text = Convert.ToString(r.GetValue(3));
                            txtdire.Text = Convert.ToString(r.GetValue(6));
                            txttel.Text = Convert.ToString(r.GetValue(7));
                        }

                        catch
                        {

                        }

                    }
                    else
                    {
                        MessageBox.Show("Coneccion rechazada");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Instancia de Clase Rechazada", "Coneccion");
            }
        }
      
     }
}
