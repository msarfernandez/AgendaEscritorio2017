using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Agenda2017_1
{
    public partial class frmDetalleContacto : Form
    {
        //atributo para guardar el contacto que recibamos por constructor
        private Contacto con;

        public frmDetalleContacto()
        {
            InitializeComponent();
        }
        public frmDetalleContacto(Contacto con)
        {
            //recibo el contacto por constructor
            InitializeComponent();
            this.con = con;
        }

        private void frmDetalleContacto_Load(object sender, EventArgs e)
        {
            try
            {
                //pre cargo todos los datos del contacto
                txtNombre.Text = con.Nombre;
                txtApellido.Text = con.Apellido;
                txtDireccion.Text = con.Direccion;
                txtEdad.Text = con.Edad.ToString();
                mtxtAltura.Text = con.Altura.ToString();
                txtLocalidad.Text = con.Localidad.ToString();
                txtFecha.Text = con.FechaNacimiento.ToShortDateString();

                //si el contacto no tiene foto le mando el iconito celeste
                if (con.Foto == "")
                {
                    imageFoto.Image = Agenda2017_1.Properties.Resources.user;
                }
                else {
                    imageFoto.ImageLocation = con.Foto;
                }

                
            }
            catch (Exception)
            {
                
                throw;
            }


        }
    }
}
