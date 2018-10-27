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
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            cargarGrillaContactos();
            cboCampo.Items.Add("Nombre");
            cboCampo.Items.Add("Apellido");
            cboCampo.Items.Add("Edad");
            cboCampo.SelectedIndex = 0;
        }

        private void cargarGrillaContactos()
        {
            try
            {
                ContactoNegocio contactoService = new ContactoNegocio();
                dgvContactos.DataSource = contactoService.traerContactos();

                //para ordenar las columnas de la grilla
                //dgvContactos.Columns[4].DisplayIndex = 0;
                dgvContactos.Columns[0].Visible = false;
                dgvContactos.Columns[5].Visible = false;
                dgvContactos.Columns[6].Visible = false;
                dgvContactos.Columns[7].Visible = false;
                dgvContactos.Columns[8].Visible = false;
                dgvContactos.Columns[9].Visible = false;
                //para ocultar

            }
            catch (Exception ex)
            {
                MessageBox.Show("Que lastima, faló... " + ex.ToString());
            }

        }

        private void cboCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboCriterio.Items.Clear();
            if (cboCampo.SelectedItem.ToString() == "Edad")
            {
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Igual a");
            }
            else {

                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Contiene");
                cboCriterio.Items.Add("Termina con");
            }
            cboCriterio.SelectedIndex = 0;
        
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ContactoNegocio neg = new ContactoNegocio();

            try{

                if (cboCampo.SelectedIndex == -1) {
                    MessageBox.Show("Debe seleccionar un campo para poder buscar");
                    return;
                }

               dgvContactos.DataSource = neg.Buscar(cboCampo.SelectedItem.ToString(), cboCriterio.SelectedItem.ToString(), txtClave.Text.Trim());


            }catch(Exception ex){
                MessageBox.Show("No buscó nada, rompe como loco!");
            }
        }

        private void toolAgregar_Click(object sender, EventArgs e)
        {
            frmAgregarContacto agregar = new frmAgregarContacto();
            try
            {
                //cuando se ejecuta esto, el form "agregar" toma el control
                agregar.ShowDialog();
                //cuando termina, devuelve el control al form AGENDA y se ejecuta el siguiente evento
                frmAgenda_Load(sender, e);
                //si falla el AGREGAR, devolverá una excepción, y saltará directamente al catch.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Contacto con = (Contacto)dgvContactos.CurrentRow.DataBoundItem;
                frmAgregarContacto modificar = new frmAgregarContacto(con);
                modificar.Text = "Modificando";
                modificar.ShowDialog();
                cargarGrillaContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolEliminar_Click(object sender, EventArgs e)
        {
            ContactoNegocio serv = new ContactoNegocio();
            try
            {
                if (MessageBox.Show("Está seguro de elimnar lógicamente al contaco?", "Eliminar", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.No)
                {
                    return;
                }
                Contacto con = (Contacto)dgvContactos.CurrentRow.DataBoundItem;
                serv.eliminarLogico(con);
                cargarGrillaContactos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void toolVerTelefonos_Click(object sender, EventArgs e)
        {
            Contacto con;
            //guardo el item seleccionado, lo casteo a Contacto, porque sé que es uno...
            con = (Contacto)dgvContactos.CurrentRow.DataBoundItem;
            //creo una instancia de la ventana de telefonos y le paso los telefonos del contacto seleccionado
            //por el constructor nuevo que agregamos.
            frmTelefonosContacto ventanaTelefonos = new frmTelefonosContacto(con.Telefonos);
            ventanaTelefonos.Show();
        }

        private void toolDetalleContacto_Click(object sender, EventArgs e)
        {
            Contacto con = (Contacto)dgvContactos.CurrentRow.DataBoundItem;
            frmDetalleContacto detalle = new frmDetalleContacto(con);
            detalle.ShowDialog();
        }


    }
}
