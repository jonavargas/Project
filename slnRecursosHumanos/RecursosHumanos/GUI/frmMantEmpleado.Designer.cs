namespace GUI
{
    partial class frmMantEmpleado
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
            this.grdEmpleado = new System.Windows.Forms.DataGridView();
            this.tollEmpleado = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salarioPorHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).BeginInit();
            this.tollEmpleado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdEmpleado
            // 
            this.grdEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmpleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmpleado,
            this.idDepartamento,
            this.nombreEmpleado,
            this.apellido1,
            this.apellido2,
            this.numCedula,
            this.telefono,
            this.fechaNacimiento,
            this.salarioPorHora,
            this.creadoPor,
            this.fechaCreacion,
            this.modificadoPor,
            this.fechaModificacion,
            this.activo});
            this.grdEmpleado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdEmpleado.Location = new System.Drawing.Point(0, 52);
            this.grdEmpleado.Name = "grdEmpleado";
            this.grdEmpleado.Size = new System.Drawing.Size(841, 213);
            this.grdEmpleado.TabIndex = 3;
            // 
            // tollEmpleado
            // 
            this.tollEmpleado.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tollEmpleado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBorrar,
            this.btnRefrescar});
            this.tollEmpleado.Location = new System.Drawing.Point(0, 0);
            this.tollEmpleado.Name = "tollEmpleado";
            this.tollEmpleado.Size = new System.Drawing.Size(841, 52);
            this.tollEmpleado.TabIndex = 2;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::RecursosHumanos.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 49);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.ToolTipText = "Permite crear un nuevo empleado";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click_1);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::RecursosHumanos.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 49);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.ToolTipText = "Permite editar un empleado seleccionado";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::RecursosHumanos.Properties.Resources.borrar;
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(43, 49);
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.ToolTipText = "Permite borrar un empleado";
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::RecursosHumanos.Properties.Resources.actualizar;
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(59, 49);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefrescar.ToolTipText = "Actualiza los cambios en los empleados realizados";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idEmpleado";
            this.idEmpleado.HeaderText = "Id Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            // 
            // idDepartamento
            // 
            this.idDepartamento.DataPropertyName = "idDepartamento";
            this.idDepartamento.HeaderText = "Id Departamento";
            this.idDepartamento.Name = "idDepartamento";
            this.idDepartamento.ReadOnly = true;
            this.idDepartamento.Width = 115;
            // 
            // nombreEmpleado
            // 
            this.nombreEmpleado.DataPropertyName = "nombreEmpleado";
            this.nombreEmpleado.HeaderText = "Nombre Empleado";
            this.nombreEmpleado.Name = "nombreEmpleado";
            this.nombreEmpleado.ReadOnly = true;
            // 
            // apellido1
            // 
            this.apellido1.DataPropertyName = "apellido1";
            this.apellido1.HeaderText = "Apellido1";
            this.apellido1.Name = "apellido1";
            this.apellido1.ReadOnly = true;
            // 
            // apellido2
            // 
            this.apellido2.DataPropertyName = "apellido2";
            this.apellido2.HeaderText = "Apellido2";
            this.apellido2.Name = "apellido2";
            this.apellido2.ReadOnly = true;
            // 
            // numCedula
            // 
            this.numCedula.DataPropertyName = "numCedula";
            this.numCedula.HeaderText = "Número de Cedula";
            this.numCedula.Name = "numCedula";
            this.numCedula.ReadOnly = true;
            // 
            // telefono
            // 
            this.telefono.DataPropertyName = "telefono";
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.DataPropertyName = "fechaNacimiento";
            this.fechaNacimiento.HeaderText = "Fecha de Nacimiento";
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.ReadOnly = true;
            this.fechaNacimiento.Width = 150;
            // 
            // salarioPorHora
            // 
            this.salarioPorHora.DataPropertyName = "salarioPorHora";
            this.salarioPorHora.HeaderText = "Salario Por Hora";
            this.salarioPorHora.Name = "salarioPorHora";
            this.salarioPorHora.ReadOnly = true;
            // 
            // creadoPor
            // 
            this.creadoPor.DataPropertyName = "creadoPor";
            this.creadoPor.HeaderText = "Creado Por";
            this.creadoPor.Name = "creadoPor";
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.DataPropertyName = "fechaCreacion";
            this.fechaCreacion.HeaderText = "Fecha Creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.Width = 125;
            // 
            // modificadoPor
            // 
            this.modificadoPor.DataPropertyName = "modificadoPor";
            this.modificadoPor.HeaderText = "Modificado Por";
            this.modificadoPor.Name = "modificadoPor";
            // 
            // fechaModificacion
            // 
            this.fechaModificacion.DataPropertyName = "fechaModificacion";
            this.fechaModificacion.HeaderText = "Fecha Modificación";
            this.fechaModificacion.Name = "fechaModificacion";
            this.fechaModificacion.Width = 125;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.Width = 50;
            // 
            // frmMantEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 265);
            this.Controls.Add(this.grdEmpleado);
            this.Controls.Add(this.tollEmpleado);
            this.Name = "frmMantEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Empleado";
            ((System.ComponentModel.ISupportInitialize)(this.grdEmpleado)).EndInit();
            this.tollEmpleado.ResumeLayout(false);
            this.tollEmpleado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdEmpleado;
        private System.Windows.Forms.ToolStrip tollEmpleado;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn salarioPorHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
    }
}