using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BLL;


namespace Agenda2017_1
{
    public class LocalidadService
    {

        public IList<Localidad> traerLocalidades() {

            DataAccessLayer accesoDatos = new DataAccessLayer();
            IList<Localidad> lista = new List<Localidad>();

            try
            {
                accesoDatos.setearComandoText("Select ID, CP, Localidad From LOCALIDADES");
                accesoDatos.abrirConexion();
                accesoDatos.ejecutarQuery();
                while (accesoDatos.Lector.Read())
                {
                    Localidad loc = new Localidad();
                    loc.Id = accesoDatos.Lector.GetInt32(0);
                    loc.CP = accesoDatos.Lector.GetInt32(1);
                    loc.Localid = accesoDatos.Lector.GetString(2);
                    lista.Add(loc);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally {
                accesoDatos.cerrarConexion();
            }

        }

    }
}
