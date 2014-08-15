using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModuloFacturacion.Reglas_del_negocio;
using System.Data.Entity.Infrastructure;

namespace ModuloFacturacion.Datos
{
    public class @new
    {
        
        public decimal getSiguiente()
        {
            try
            {
                
                SAVEntities1 ent = new SAVEntities1();
                //Console.WriteLine("Error: " + ((from a in ent.CP_M_PROVEEDOR select Convert.ToInt32(a.Codigo_Proveedor)).Max()));
                decimal x = ((from a in ent.CP_M_PROVEEDOR select a.Codigo_Proveedor).Max()) + 1;
                return x;
                
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                return 1;
            }
        }

     
        public List<Proveedor> consulta(int codigo)
        {

            try
            {
                List<Proveedor> lista = new List<Proveedor>();
                SAVEntities1 ent = new SAVEntities1();

                var con = from p in ent.CP_M_PROVEEDOR where p.Codigo_Proveedor == codigo select p ;

                foreach (var item in con)
                {
                    Proveedor prov = new Proveedor();
                    prov._codigo = Convert.ToInt32(item.Codigo_Proveedor);
                    prov._nombre = item.nombre;
                    prov._razonsocial = item.razonSocial;
                    prov._telefono = item.telefono;
                    prov._direccion = item.direccion;
                    prov._fecha_ingreso = Convert.ToDateTime(item.fecha_ingreso);
                    prov._responsable = item.responsable_legal;
                    prov._contabilidad = Convert.ToBoolean(item.contabilidad);
                    prov._ruc = item.ruc;
                    prov._cedula_pass = item.cedula_pass;
                    prov._id_tipo_producto = Convert.ToInt32(item.id_tipo_producto);
                    lista.Add(prov);
                }
                return lista;


            }
            catch (Exception)
            {

                return null;
            }
        }

        public void Eliminar(int codigo) {


            try
            {
                // Instanciamos el DbContext
                var dbContext = new SAVEntities1();

                // Extraemos el ObjectContext del DbContext (a partir de Entity Framework 4.1)
                var objectContext = ((IObjectContextAdapter)dbContext).ObjectContext;

                // Realizamos la consulta
                var clienteEliminar = dbContext.CP_M_PROVEEDOR.Where(id => id.Codigo_Proveedor == codigo).First();

                // Eliminamos el cliente
                objectContext.DeleteObject(clienteEliminar);    // Para el Framework 4.0 o inferior
                dbContext.CP_M_PROVEEDOR.Remove(clienteEliminar);     // Para el Framework 4.1 o superior

                // Guardamos los cambios
                dbContext.SaveChanges();
            }
            catch (Exception)
            {
                
                throw;
            }


            
            
        
        
        }

        public void insertar(Proveedor obj)
        {
            int id = Convert.ToInt32( getSiguiente());
            obj._codigo = id;
            try
            {              
                using (SAVEntities1 intes = new SAVEntities1())
                {
                    CP_M_PROVEEDOR prove = new CP_M_PROVEEDOR()
                    {
                        Codigo_Proveedor=obj._codigo,
                        nombre = obj._nombre,
                        //EDITACION
                        razonSocial = obj._razonsocial ,
                        telefono = obj._telefono,
                        direccion = obj._direccion,
                        fecha_ingreso = Convert.ToDateTime(obj._fecha_ingreso),
                        responsable_legal = obj._responsable, 
                        contabilidad= obj._contabilidad,
                        ruc = obj._ruc,
                        cedula_pass = obj._cedula_pass, 
                        id_tipo_producto= obj._id_tipo_producto,
                       

                    };
                   
                    intes.CP_M_PROVEEDOR.Add(prove);
                    intes.SaveChanges();
                }
                
            }
            catch (Exception)
            {
                
                throw;
            }

        }

        public void Modificar(Proveedor DatosAModificar) {


            try
            {
                SAVEntities1 ent = new SAVEntities1();
                var DatosOld = ent.CP_M_PROVEEDOR.First(u => u.Codigo_Proveedor == DatosAModificar._codigo);
               // var x = (from a in ent.CP_M_PROVEEDOR where a.Codigo_Proveedor == DatosAModificar._codigo).first();

                DatosOld.nombre = DatosAModificar._nombre;
                DatosOld.razonSocial = DatosAModificar._razonsocial;
                DatosOld.telefono = DatosAModificar._telefono;

                DatosOld.direccion = DatosAModificar._direccion;
                DatosOld.fecha_ingreso = Convert.ToDateTime(DatosAModificar._fecha_ingreso);
                DatosOld.contabilidad = Convert.ToBoolean(DatosAModificar._contabilidad);

                DatosOld.ruc = DatosAModificar._ruc;
                DatosOld.cedula_pass = DatosAModificar._cedula_pass;
                DatosOld.id_tipo_producto = Convert.ToInt32(DatosAModificar._id_tipo_producto);
                
                
               
                
                ent.SaveChanges();


            }
            catch (Exception)
            {
                
                throw;
            }
            

            
        
        
        }

        /* public Boolean guardar(clsRevalorizacion reval)
         {
             try
             {
                 int id = getSiguiente();
                 reval.Codigo = id;
                 using (ActivoFijoEntities ent = new ActivoFijoEntities())
                 {
                     revalorizacion revalor = new revalorizacion()
                     {
                        
                         razonSocial= obj._razonsocial,
                         telefono= obj._telefono, 
                         direccion= obj._direccion,
                         fecha_ingreso= obj._fecha_ingreso, 
                         responsable_legal=obj._responsable, 
                         contabilidad= obj._contabilidad,
                         ruc=obj._ruc,
                         cedula_pass=obj._cedula_pass, 
                         id_tipo_producto=obj._id_tipo_producto,
                     };

                     ent.AddTorevalorizacion(revalor);
                     ent.SaveChanges();
                 }
                 return true;
             }
             catch (Exception)
             {

                 return false;
             }

         }
         */

        /*
     public List<Proveedor> consulta()
    {

        try
        {
            List<Proveedor> lista = new List<Proveedor>();
            SAVEntities1 ent = new SAVEntities1();

            var con = from p in ent.CP_M_PROVEEDOR select p;

            foreach (var item in con)
            {
                Proveedor prov = new Proveedor();
                prov._codigo = Convert.ToInt32(item.Codigo_Proveedor);
                prov._nombre = item.nombre;
                   
                lista.Add(prov);
            }
            return lista;


        }
        catch (Exception)
        {

            return null;
        }
    }
     * */

        /* 
       public Boolean eliminar(clsTesisSubdirector TesisSubDirec)
       {
           try
           {
               using (MetodologiaEntities ent = new MetodologiaEntities())
               {
                   //Hago un wehere por el primaryKey codigo y con esto elimini de las tablas Persona,Tesis y PersonasTesis
                   var x = (from q in ent.Persona where q.IdPersona == TesisSubDirec.IdPersona select q).First();
                   var p = (from r in ent.Tesis where r.IdTesis == TesisSubDirec.idTesis select r).First();
                   var y = (from z in ent.TesisSubDirector where z.IdTesis == TesisSubDirec.idTesis select z).First();
                   //Eliminar es muy parecido
                   //Eliminar el registro que me trajo los selects realizados
                   ent.DeleteObject(x);
                   ent.DeleteObject(p);
                   ent.DeleteObject(y);
                   ent.SaveChanges();
               }
               return true;
           }
           catch (Exception)
           {

               return false;
           }

       }
      * */





    }
}
