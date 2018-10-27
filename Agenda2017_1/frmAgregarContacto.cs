using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Agenda2017_1;
using System.IO;

namespace Agenda2017_1
{
    public partial class frmAgregarContacto : Form
    {
        private Contacto contacto;
        private IList<Telefono> listaTelefonosNuevos;

        public frmAgregarContacto()
        {
            InitializeComponent();
            contacto = new Contacto();
        }

        public frmAgregarContacto(Contacto con) {
            InitializeComponent();
            contacto = con;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            //agregar el contacto....
            ContactoNegocio serviceContacto = new ContactoNegocio();

            try {
                contacto.Nombre = txtNombre.Text.Trim();
                contacto.Apellido = txtApellido.Text.Trim();
                contacto.Direccion = txtDireccion.Text.Trim();
                contacto.Localidad = (Localidad)cboLocalidad.SelectedItem;

                if (this.Text != "Modificando")
                {
                    serviceContacto.agregarContacto(contacto);
                    MessageBox.Show("Agregado correctamente!");
                }
                else {
                    serviceContacto.modificar(contacto);
                    MessageBox.Show("Modificado correctamente!");
                }

                this.Dispose();

            
            }catch(Exception ex){
                MessageBox.Show("Error FATAL. " + ex.ToString(), "", MessageBoxButtons.OK);
            }

        }

        private void frmAgregarContacto_Load(object sender, EventArgs e)
        {
            //acá deberíamos pre cargar el combo de selección. Cómo¡?
            //Necesitamos la clase LOCALIDAD, la clase LocalidadService con un método
            //treaerLocalidades que obviamente devuelve una lista de localidades. Y luego....

            LocalidadService serv = new LocalidadService();
            //la lista locs la tengo que cargar con el método traerLocalidades... no?
            //y se la doy al combo de selección como origen de datos (igual que las grillas)
            cboLocalidad.DataSource = serv.traerLocalidades();
            //esto es para decirle al combo de selección qué atributo de la clase localidad quiero que muestre.
            cboLocalidad.DisplayMember = "Localid";

            //le agrego un ValueMember para usar el Id para asignar la Localidad del contacto seleccionado al combo
            cboLocalidad.ValueMember = "Id";



            if (Text == "Modificando")
            {
                txtApellido.Text = contacto.Apellido;
                txtNombre.Text = contacto.Nombre;
                txtDireccion.Text = contacto.Direccion;

                //acá uso selected value, teniendo en cuenta que toma el ID de la Localidad, 
                //y le asigno el ID de la localidad del contacto
                cboLocalidad.SelectedValue = contacto.Localidad.Id;
            }
            else {
                listaTelefonosNuevos = new List<Telefono>();
                dgvTelefonos.DataSource = listaTelefonosNuevos;
                dgvTelefonos.Columns[0].Visible = false;
            }

            //combo de tipo de telefono, le agrego las opciones a mano. Estas deberían ser de la base de datos en realidad.
            //pero nuestro teléfono debería a su vez tener un atributo clase TIPO para poder asignarlo.
            cboTipo.Items.Add("Trabajo");
            cboTipo.Items.Add("Casa");
            //seteo el primero por default
            cboTipo.SelectedIndex = 0;

            //pre default para el campo estatura (porque me pone nervioso que falle...)
            mtxtAltura.Text = "0.00";


        }

        private void btnAceptarSP_Click(object sender, EventArgs e)
        {
            ContactoNegocio neg = new ContactoNegocio();
            try {
                contacto.Nombre = txtNombre.Text.Trim();
                contacto.Apellido = txtApellido.Text.Trim();
                contacto.Direccion = txtDireccion.Text.Trim();
                contacto.Localidad = (Localidad)cboLocalidad.SelectedItem;
                contacto.Foto = txtFoto.Text;

                
                contacto.Altura = Convert.ToDecimal(mtxtAltura.Text.Trim());

                contacto.Edad = Convert.ToInt16(txtEdad.Text.Trim());
                contacto.FechaNacimiento = dtpFechaNacimiento.Value;

                contacto.Telefonos = listaTelefonosNuevos;
                neg.agregarContactoSP(contacto);

                MessageBox.Show("Gracias por usar Stored Procedure para agregar su contacto.");
                this.Dispose();
            }catch(Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }


        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            //agregar el telefono a la lista y la lista a la grilla
            //creo un objeto telefono
            Telefono telNuevo = new Telefono();
            //lo cargo con los datos
            telNuevo.Telephone = txtTelefono.Text.Trim();
            telNuevo.Tipo = cboTipo.SelectedItem.ToString();
            //lo agrego a la lista
            listaTelefonosNuevos.Add(telNuevo);
            //limpio la grilla y le doy la lista de nuevo
            dgvTelefonos.DataSource = null;
            dgvTelefonos.DataSource = listaTelefonosNuevos;
            dgvTelefonos.Columns[0].Visible = false;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            //OpenFileDialog para que abra la ventanita que te deja buscar
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            //Path.GetFullPath es para saber la dirección completa y poder guardarla.
            //para usarla tuve que incluir System.IO
            txtFoto.Text = Path.GetFullPath(file.FileName);
            
        }

    }
}
