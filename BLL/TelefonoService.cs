using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Agenda2017_1;
using BLL;

namespace Agenda2017_1
{
    public class TelefonoService
    {

        public IList<Telefono> traerTelefonosPorContacto(Int32 idContacto) {

            SqlConnection conexion = new SqlConnection("data source=.; initial catalog=AGENDA_DB; integrated security=sspi");
            SqlCommand comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select ContactoId, Telefono, Tipo from TELEFONOS Te inner join TIPOS Ti on Te.IdTipo = Ti.ID Where ContactoId = " + idContacto.ToString();
            comando.Connection = conexion;
            SqlDataReader lector;
            IList<Telefono> lista = new List<Telefono>();

            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
                while (lector.Read()) {
                    Telefono tel = new Telefono();
                    tel.ContactoId = lector.GetInt32(0);
                    tel.Telephone = lector.GetString(1);
                    tel.Tipo = lector.GetString(2);
                    lista.Add(tel);
                }
                return lista;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally {
                conexion.Close();
                conexion.Dispose();
                comando.Dispose();
            }


        }


        //método que agrega una lista de telefonos de un contacto
        public void agregarListaTelefonos(int p, IList<Telefono> iList)
        {
            //recorre la lista con el foreach
            foreach (var telNuevo in iList)
            {
                //llama al metodo agregar en cada vuelta
                agregar(telNuevo, p);
            }
        }

        //el metodo agregar lo llamo desde el que agrega una lista de telefonos o bien lo podría usar para agregar un telefono solo.
        public void agregar(Telefono telNuevo, Int32 IdContacto)
        {
            DataAccessLayer conexion = new DataAccessLayer();
            string consulta = "Insert into TELEFONOS Values (" + IdContacto.ToString() + ", '" + telNuevo.Telephone + "', ";
            try
            {
                //seteo insert y ejecuto
                if(telNuevo.Tipo == "Casa")
                    consulta = consulta + "2, 0)";
                else
                    consulta = consulta + "1, 0)";
                
                conexion.setearComandoText(consulta);
                conexion.abrirConexion();
                conexion.ejecutarNonQuery();
            }
            catch (Exception )
            {
           
                throw;
            }
            
        }


    }
}
