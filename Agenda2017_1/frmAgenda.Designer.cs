namespace Agenda2017_1
{
    partial class frmAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboCriterio = new System.Windows.Forms.ComboBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSplitButton1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolModificar = new System.Windows.Forms.ToolStripButton();
            this.toolEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolVerTelefonos = new System.Windows.Forms.ToolStripButton();
            this.toolDetalleContacto = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolbtnAgregar = new System.Windows.Forms.ToolStripButton();
            this.toolbtnModificar = new System.Windows.Forms.ToolStripButton();
            this.toolbtnEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolbtnVerTelefonos = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvContactos
            // 
            this.dgvContactos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContactos.Location = new System.Drawing.Point(12, 54);
            this.dgvContactos.MultiSelect = false;
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(603, 222);
            this.dgvContactos.TabIndex = 0;
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(14, 289);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 7;
            this.cboCampo.SelectedIndexChanged += new System.EventHandler(this.cboCampo_SelectedIndexChanged);
            // 
            // cboCriterio
            // 
            this.cboCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCriterio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCriterio.FormattingEnabled = true;
            this.cboCriterio.Location = new System.Drawing.Point(141, 289);
            this.cboCriterio.Name = "cboCriterio";
            this.cboCriterio.Size = new System.Drawing.Size(144, 21);
            this.cboCriterio.TabIndex = 8;
            // 
            // txtClave
            // 
            this.txtClave.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClave.Location = new System.Drawing.Point(291, 289);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(243, 20);
            this.txtClave.TabIndex = 9;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(540, 282);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 35);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(44, 44);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolAgregar,
            this.toolModificar,
            this.toolEliminar,
            this.toolStripSeparator2,
            this.toolVerTelefonos,
            this.toolDetalleContacto});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(627, 51);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 51);
            // 
            // toolStripSplitButton1
            // 
            this.toolStripSplitButton1.Name = "toolStripSplitButton1";
            this.toolStripSplitButton1.Size = new System.Drawing.Size(6, 51);
            // 
            // toolAgregar
            // 
            this.toolAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolAgregar.Image = global::Agenda2017_1.Properties.Resources.add;
            this.toolAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolAgregar.Name = "toolAgregar";
            this.toolAgregar.Size = new System.Drawing.Size(48, 48);
            this.toolAgregar.Text = "toolStripButton6";
            this.toolAgregar.ToolTipText = "Agregar contacto";
            this.toolAgregar.Click += new System.EventHandler(this.toolAgregar_Click);
            // 
            // toolModificar
            // 
            this.toolModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolModificar.Image = global::Agenda2017_1.Properties.Resources.edit;
            this.toolModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolModificar.Name = "toolModificar";
            this.toolModificar.Size = new System.Drawing.Size(48, 48);
            this.toolModificar.Text = "toolStripButton5";
            this.toolModificar.ToolTipText = "Modificar contacto";
            this.toolModificar.Click += new System.EventHandler(this.toolModificar_Click);
            // 
            // toolEliminar
            // 
            this.toolEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolEliminar.Image = global::Agenda2017_1.Properties.Resources.delete_2;
            this.toolEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolEliminar.Name = "toolEliminar";
            this.toolEliminar.Size = new System.Drawing.Size(48, 48);
            this.toolEliminar.Text = "toolStripButton5";
            this.toolEliminar.ToolTipText = "Eliminar contacto";
            this.toolEliminar.Click += new System.EventHandler(this.toolEliminar_Click);
            // 
            // toolVerTelefonos
            // 
            this.toolVerTelefonos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolVerTelefonos.Image = global::Agenda2017_1.Properties.Resources.phone;
            this.toolVerTelefonos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolVerTelefonos.Name = "toolVerTelefonos";
            this.toolVerTelefonos.Size = new System.Drawing.Size(48, 48);
            this.toolVerTelefonos.Text = "toolStripButton5";
            this.toolVerTelefonos.ToolTipText = "Ver teléfonos contacto";
            this.toolVerTelefonos.Click += new System.EventHandler(this.toolVerTelefonos_Click);
            // 
            // toolDetalleContacto
            // 
            this.toolDetalleContacto.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolDetalleContacto.Image = global::Agenda2017_1.Properties.Resources.user;
            this.toolDetalleContacto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolDetalleContacto.Name = "toolDetalleContacto";
            this.toolDetalleContacto.Size = new System.Drawing.Size(48, 48);
            this.toolDetalleContacto.Text = "toolStripButton5";
            this.toolDetalleContacto.ToolTipText = "Ver detalle contacto";
            this.toolDetalleContacto.Click += new System.EventHandler(this.toolDetalleContacto_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(48, 48);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(48, 48);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(48, 48);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(48, 48);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // toolbtnAgregar
            // 
            this.toolbtnAgregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnAgregar.Image = global::Agenda2017_1.Properties.Resources.add;
            this.toolbtnAgregar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnAgregar.Name = "toolbtnAgregar";
            this.toolbtnAgregar.Size = new System.Drawing.Size(48, 48);
            this.toolbtnAgregar.Text = "toolStripButton5";
            this.toolbtnAgregar.ToolTipText = "Agregar contacto";
            // 
            // toolbtnModificar
            // 
            this.toolbtnModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnModificar.Image = global::Agenda2017_1.Properties.Resources.edit;
            this.toolbtnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnModificar.Name = "toolbtnModificar";
            this.toolbtnModificar.Size = new System.Drawing.Size(48, 48);
            this.toolbtnModificar.Text = "toolStripButton6";
            this.toolbtnModificar.ToolTipText = "Modificar contacto";
            // 
            // toolbtnEliminar
            // 
            this.toolbtnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnEliminar.Image = global::Agenda2017_1.Properties.Resources.delete_2;
            this.toolbtnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnEliminar.Name = "toolbtnEliminar";
            this.toolbtnEliminar.Size = new System.Drawing.Size(48, 48);
            this.toolbtnEliminar.Text = "toolStripButton7";
            this.toolbtnEliminar.ToolTipText = "Eliminar contacto";
            // 
            // toolbtnVerTelefonos
            // 
            this.toolbtnVerTelefonos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolbtnVerTelefonos.Image = global::Agenda2017_1.Properties.Resources.phone;
            this.toolbtnVerTelefonos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolbtnVerTelefonos.Name = "toolbtnVerTelefonos";
            this.toolbtnVerTelefonos.Size = new System.Drawing.Size(48, 48);
            this.toolbtnVerTelefonos.Text = "toolStripButton8";
            this.toolbtnVerTelefonos.ToolTipText = "Ver teléfonos contacto";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 329);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.cboCriterio);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.dgvContactos);
            this.Name = "frmAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.ComboBox cboCriterio;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolbtnAgregar;
        private System.Windows.Forms.ToolStripButton toolbtnModificar;
        private System.Windows.Forms.ToolStripButton toolbtnEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSplitButton1;
        private System.Windows.Forms.ToolStripButton toolbtnVerTelefonos;
        private System.Windows.Forms.ToolStripButton toolAgregar;
        private System.Windows.Forms.ToolStripButton toolModificar;
        private System.Windows.Forms.ToolStripButton toolEliminar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolVerTelefonos;
        private System.Windows.Forms.ToolStripButton toolDetalleContacto;
    }
}

