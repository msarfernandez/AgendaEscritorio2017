using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using BLL;

namespace Agenda2017_1
{
    public class ContactoNegocio
    {
       
        //Metodo que se conecta y trae los registros de la DB
        public IList<Contacto> traerContactos() {

            TelefonoService serviceTel = new TelefonoService();
            IList<Contacto> lista = new List<Contacto>();
            //conection string >> es donde esta la DB
            SqlConnection conexion = new SqlConnection();
            conexion.ConnectionString = "data source=(local); initial catalog=AGENDA_DB; integrated security=sspi";
            //comando >> es la consulta que voy a enviar
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select Nombre, Apellido, Direccion, C.ID, Localidad, L.CP, L.ID, C.Altura, C.Edad, C.FechaNacimiento, C.Foto From CONTACTOS C inner join LOCALIDADES L On C.CP = L.CP Where C.Estado = 1";
            comando.Connection = conexion;
            //contenedor del resultado la consulta
            SqlDataReader lector;

            try
            {

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Contacto con = new Contacto();
                    con.Nombre = lector.GetString(0);
                    con.Apellido = lector.GetString(1);
                    con.Direccion = lector.GetString(2);
                    con.ContactoId = lector.GetInt32(3);
                    con.Localidad = new Localidad() { Localid = lector.GetString(4), CP = lector.GetInt32(5), Id = lector.GetInt32(6) };
                    con.Telefonos = serviceTel.traerTelefonosPorContacto(con.ContactoId);
                    con.Altura = lector.GetDecimal(7);
                    con.Edad = lector.GetInt16(8);
                    
                    //esto para validar si viene nulo de la base de datos...
                    if(!(lector.IsDBNull(lector.GetOrdinal("fechaNacimiento")))){
                        con.FechaNacimiento = lector.GetDateTime(9);
                    }
                    if (!(lector.IsDBNull(lector.GetOrdinal("Foto"))))
                    {
                        con.Foto = lector.GetString(10);
                    }
                    


                    lista.Add(con);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }

        }

        public void agregarContacto(Contacto nuevo)
        {
            SqlConnection conexion = new SqlConnection("initial catalog=AGENDA_DB; data source=.; integrated security=sspi");
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;
            comando.CommandText = "Insert into CONTACTOS Values ('" + nuevo.Nombre + "', '" + nuevo.Apellido + "', '" + nuevo.Direccion + "'," + nuevo.Localidad.CP.ToString() + ")";

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }

        }

        public void agregarContactoSP(Contacto nuevo) {

            DataAccessLayer acceso = new DataAccessLayer();
            TelefonoService tels = new TelefonoService();

            try
            {
                acceso.setearComandoSP("altaContacto");
                acceso.Comando.Parameters.Clear();
                acceso.Comando.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                acceso.Comando.Parameters.AddWithValue("@apellido", nuevo.Apellido);
                acceso.Comando.Parameters.AddWithValue("@direc", nuevo.Direccion);
                acceso.Comando.Parameters.AddWithValue("@cp", nuevo.Localidad.CP);
                acceso.Comando.Parameters.AddWithValue("@altura",nuevo.Altura );
                acceso.Comando.Parameters.AddWithValue("@edad", nuevo.Edad);
                acceso.Comando.Parameters.AddWithValue("@fechaNacimiento", nuevo.FechaNacimiento);
                acceso.Comando.Parameters.AddWithValue("@foto", nuevo.Foto);
                acceso.abrirConexion();
                
                nuevo.ContactoId = Convert.ToInt32(acceso.ejecutarScalar());

                tels.agregarListaTelefonos(nuevo.ContactoId, nuevo.Telefonos);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                acceso.cerrarConexion();
            }

        }

        public void eliminaFisico(Contacto con) {

            DataAccessLayer datos = new DataAccessLayer();

            try
            {
                datos.setearComandoText("Delete From CONTACTOS Where ID = " + con.ContactoId.ToString());
                datos.abrirConexion();
                datos.ejecutarNonQuery();
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }

            

        }

        public void eliminarLogico(Contacto con) {

            DataAccessLayer acceso = new DataAccessLayer();
            try
            {

                acceso.setearComandoText("Update CONTACTOS Set Estado = 0 Where ID = " + con.ContactoId.ToString());
                acceso.abrirConexion();
                acceso.ejecutarNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                acceso.cerrarConexion();
            }
        }

        public void modificar(Contacto contacto)
        {
            DataAccessLayer dato = new DataAccessLayer();
            try {
                dato.setearComandoText("Update CONTACTOS Set Nombre = '" + contacto.Nombre + "', Apellido = '" + contacto.Apellido + "', Direccion = '" + contacto.Direccion + "', CP = " + contacto.Localidad.CP.ToString() + " Where ID = " + contacto.ContactoId.ToString());
                dato.abrirConexion();
                dato.ejecutarNonQuery();
                dato.cerrarConexion();
            }catch(Exception ex){
                throw ex;
            }
        }

        public IList<Contacto> Buscar(string campo, string criterio, string clave)
        {

            IList<Contacto> lista = new List<Contacto>();
            TelefonoService serviceTel = new TelefonoService();
            String consulta = "Select Nombre, Apellido, Direccion, C.ID, Localidad, L.CP, L.ID, C.Altura, C.Edad, C.FechaNacimiento From CONTACTOS C inner join LOCALIDADES L On C.CP = L.CP Where C.Estado = 1 and ";
            DataAccessLayer conexion = new DataAccessLayer();

            try
            {
                switch (criterio)
                {
                    case "Comienza con":
                        consulta = consulta + campo + " Like '" + clave + "%'";
                        break;
                    case "Termina con":
                        consulta = consulta + campo + " Like '%" + clave + "'";
                        break;
                    case "Contiene":
                        consulta = consulta + campo + " Like '%" + clave + "%'";
                        break;
                    case "Mayor a":
                        consulta = consulta + campo + " > " + clave;
                        break;
                    case "Igual a":
                        consulta = consulta + campo + " = " + clave;
                        break;
                    case "Menor a":
                        consulta = consulta + campo + " < " + clave;
                        break;
                }

                conexion.setearComandoText(consulta);
                conexion.abrirConexion();
                conexion.ejecutarQuery();

                while (conexion.Lector.Read())
                {
                    Contacto con = new Contacto();
                    con.Nombre = conexion.Lector.GetString(0);
                    con.Apellido = conexion.Lector.GetString(1);
                    con.Direccion = conexion.Lector.GetString(2);
                    con.ContactoId = conexion.Lector.GetInt32(3);
                    con.Localidad = new Localidad() { Localid = conexion.Lector.GetString(4), CP = conexion.Lector.GetInt32(5), Id = conexion.Lector.GetInt32(6) };
                    con.Telefonos = serviceTel.traerTelefonosPorContacto(con.ContactoId);
                    con.Altura = conexion.Lector.GetDecimal(7);
                    con.Edad = conexion.Lector.GetInt16(8);

                    //esto para validar si viene nulo de la base de datos...
                    if (!(conexion.Lector.IsDBNull(conexion.Lector.GetOrdinal("fechaNacimiento"))))
                    {
                        con.FechaNacimiento = conexion.Lector.GetDateTime(9);
                    }


                    lista.Add(con);
                }
                return lista;

            }
            catch (Exception ex)
            {
                
                throw ex;
            }

        }
    }
}
