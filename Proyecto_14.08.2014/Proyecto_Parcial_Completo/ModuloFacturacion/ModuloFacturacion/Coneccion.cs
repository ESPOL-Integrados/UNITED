using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace ModuloFacturacion
{
    class Coneccion
    {
        public String coneccion = "Data Source=.;Initial Catalog=SAV;Integrated Security=True";

        public Boolean Conectando()
        {
            try
            {
                SqlConnection cnn = new SqlConnection(this.coneccion);
                cnn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Boolean IngresaUsuario(int cod,int ruc,int id,String razon,String nombre,String apellido,
            String direccion,int telefono,char x,char y)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("SV_FC_INGRESO_CLIENTE", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@cod", cod);
                    coneccion.Parameters.AddWithValue("@ruc", ruc);
                    coneccion.Parameters.AddWithValue("@id", id);
                    coneccion.Parameters.AddWithValue("@razon", razon);
                    coneccion.Parameters.AddWithValue("@nomb", nombre);
                    coneccion.Parameters.AddWithValue("@ape", apellido);
                    coneccion.Parameters.AddWithValue("@dir", direccion);
                    coneccion.Parameters.AddWithValue("@tel", telefono);
                    coneccion.Parameters.AddWithValue("@gen", x);
                    coneccion.Parameters.AddWithValue("@est", y);
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Boolean ModificaUsuario(int cod, int ruc, int id, String razon, String nombre, String apellido,
            String direccion, int telefono)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("SV_FC_MODIFICAR_CLIENTE", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    
                    coneccion.Parameters.AddWithValue("@ruc", ruc);
                    coneccion.Parameters.AddWithValue("@id", id);
                    coneccion.Parameters.AddWithValue("@razon", razon);
                    coneccion.Parameters.AddWithValue("@nomb", nombre);
                    coneccion.Parameters.AddWithValue("@ape", apellido);
                    coneccion.Parameters.AddWithValue("@dir", direccion);
                    coneccion.Parameters.AddWithValue("@tel", telefono);
                    coneccion.Parameters.AddWithValue("@gen", 'M');
                    coneccion.Parameters.AddWithValue("@est", 'A');
                    coneccion.Parameters.AddWithValue("@cod", cod);
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Boolean EliminarUsuario(int cod)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("SV_FC_ELIMINAR_CLIENTE", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;

                    coneccion.Parameters.AddWithValue("@cod", cod);
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        public Boolean ConsultarUsuario(int cod)
        {
            if (this.Conectando())
            {
                try
                {
                    SqlConnection conectado = new SqlConnection(this.coneccion);
                    conectado.Open();
                    SqlCommand coneccion = new SqlCommand("SV_FC_CONSULTAR_CLIENTE", conectado);
                    coneccion.CommandType = System.Data.CommandType.StoredProcedure;
                    coneccion.Parameters.AddWithValue("@cod", cod);
                    coneccion.ExecuteNonQuery();
                    conectado.Close();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
