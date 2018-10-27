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
    public partial class frmTelefonosContacto : Form
    {
        public frmTelefonosContacto()
        {
            InitializeComponent();
        }

        //agregamos este constructor que recibe una lista te telefonos por parámetro
        public frmTelefonosContacto(IList<Telefono> telefonos) {
            InitializeComponent();
            //se la damos como origen de datos a la grilla y nada mas. Cuando este form nace, 
            //carga automaticamente los telefonos que le manden del otro form.
            dgvTelefonos.DataSource = telefonos;
            dgvTelefonos.Columns[0].Visible = false;
        }

        private void frmTelefonosContacto_Load(object sender, EventArgs e)
        {

        }



    }
}
