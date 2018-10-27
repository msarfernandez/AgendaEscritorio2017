using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Agenda2017_1
{
    public class Contacto
    {
        public Int32 ContactoId { set; get; }
        private String nombre;
        private String apellido;
        private String direccion;
        
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Direccion {
            get { return direccion; }
            set { direccion = value; }
        }

        public IList<Telefono> Telefonos { set; get; }
        public Localidad Localidad { set; get; }
        public Boolean Estado { get; set; }
        public Decimal Altura { get; set; }
        public Int16 Edad { set; get; }
        public DateTime FechaNacimiento { set; get; }
        public String Foto { set; get; }
        
    }
}
