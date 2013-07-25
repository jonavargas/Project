namespace GUI
{
    partial class frmConsultaMarcas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.dteFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dteFecha1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.tollConsulta = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdConsultas = new System.Windows.Forms.DataGridView();
            this.idMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpFiltro = new System.Windows.Forms.GroupBox();
            this.lblRango = new System.Windows.Forms.Label();
            this.grpConsulta = new System.Windows.Forms.GroupBox();
            this.rbtInactivo = new System.Windows.Forms.RadioButton();
            this.rbtActivo = new System.Windows.Forms.RadioButton();
            this.estadoEmpleado = new System.Windows.Forms.Label();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.tollConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultas)).BeginInit();
            this.grpFiltro.SuspendLayout();
            this.grpConsulta.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(244, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "al";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(61, 433);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(0, 13);
            this.lblCodigo.TabIndex = 17;
            // 
            // dteFecha2
            // 
            this.dteFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFecha2.Location = new System.Drawing.Point(275, 44);
            this.dteFecha2.Name = "dteFecha2";
            this.dteFecha2.Size = new System.Drawing.Size(125, 22);
            this.dteFecha2.TabIndex = 11;
            // 
            // dteFecha1
            // 
            this.dteFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFecha1.Location = new System.Drawing.Point(113, 45);
            this.dteFecha1.Name = "dteFecha1";
            this.dteFecha1.Size = new System.Drawing.Size(125, 22);
            this.dteFecha1.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(20, 51);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 16);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fechas del:";
            // 
            // tollConsulta
            // 
            this.tollConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tollConsulta.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tollConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnAnular,
            this.btnRefrescar});
            this.tollConsulta.Location = new System.Drawing.Point(0, 0);
            this.tollConsulta.Name = "tollConsulta";
            this.tollConsulta.Size = new System.Drawing.Size(986, 58);
            this.tollConsulta.TabIndex = 26;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::RecursosHumanos.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 55);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::RecursosHumanos.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 55);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::RecursosHumanos.Properties.Resources.borrar;
            this.btnAnular.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(60, 55);
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::RecursosHumanos.Properties.Resources.actualizar;
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(79, 55);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // grdConsultas
            // 
            this.grdConsultas.AllowUserToDeleteRows = false;
            this.grdConsultas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.grdConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMarca,
            this.idUnificacion,
            this.idEmpleado,
            this.NombreEmpleado,
            this.fecha,
            this.tipo,
            this.estado,
            this.creadoPor,
            this.fechaCreacion,
            this.modificadoPor,
            this.fechaModificacion});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdConsultas.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdConsultas.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.grdConsultas.Location = new System.Drawing.Point(0, 294);
            this.grdConsultas.Name = "grdConsultas";
            this.grdConsultas.ReadOnly = true;
            this.grdConsultas.Size = new System.Drawing.Size(977, 185);
            this.grdConsultas.TabIndex = 27;
            // 
            // idMarca
            // 
            this.idMarca.DataPropertyName = "idmarca";
            this.idMarca.HeaderText = "Cod. Marca";
            this.idMarca.Name = "idMarca";
            this.idMarca.ReadOnly = true;
            this.idMarca.Width = 50;
            // 
            // idUnificacion
            // 
            this.idUnificacion.DataPropertyName = "idunificacion";
            this.idUnificacion.HeaderText = "Cod. Unificación";
            this.idUnificacion.Name = "idUnificacion";
            this.idUnificacion.ReadOnly = true;
            this.idUnificacion.Width = 70;
            // 
            // idEmpleado
            // 
            this.idEmpleado.DataPropertyName = "idempleado";
            this.idEmpleado.HeaderText = "Cod. Empleado";
            this.idEmpleado.Name = "idEmpleado";
            this.idEmpleado.ReadOnly = true;
            // 
            // NombreEmpleado
            // 
            this.NombreEmpleado.DataPropertyName = "nombreEmpleado";
            this.NombreEmpleado.HeaderText = "Nombre";
            this.NombreEmpleado.Name = "NombreEmpleado";
            this.NombreEmpleado.ReadOnly = true;
            this.NombreEmpleado.Width = 120;
            // 
            // fecha
            // 
            this.fecha.DataPropertyName = "fecha";
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 130;
            // 
            // tipo
            // 
            this.tipo.DataPropertyName = "tipo";
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 40;
            // 
            // estado
            // 
            this.estado.DataPropertyName = "estado";
            this.estado.HeaderText = "Estado";
            this.estado.Name = "estado";
            this.estado.ReadOnly = true;
            this.estado.Width = 80;
            // 
            // creadoPor
            // 
            this.creadoPor.DataPropertyName = "creadoPor";
            this.creadoPor.HeaderText = "Creado por:";
            this.creadoPor.Name = "creadoPor";
            this.creadoPor.ReadOnly = true;
            this.creadoPor.Width = 85;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.DataPropertyName = "fechaCreacion";
            this.fechaCreacion.HeaderText = "Fecha creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            // 
            // modificadoPor
            // 
            this.modificadoPor.DataPropertyName = "modificadoPor";
            this.modificadoPor.HeaderText = "Modificado por:";
            this.modificadoPor.Name = "modificadoPor";
            this.modificadoPor.ReadOnly = true;
            this.modificadoPor.Width = 85;
            // 
            // fechaModificacion
            // 
            this.fechaModificacion.DataPropertyName = "fechaModificacion";
            this.fechaModificacion.HeaderText = "Fecha modificación";
            this.fechaModificacion.Name = "fechaModificacion";
            this.fechaModificacion.ReadOnly = true;
            this.fechaModificacion.Width = 105;
            // 
            // grpFiltro
            // 
            this.grpFiltro.Controls.Add(this.lblRango);
            this.grpFiltro.Controls.Add(this.dteFecha2);
            this.grpFiltro.Controls.Add(this.dteFecha1);
            this.grpFiltro.Controls.Add(this.lblFecha);
            this.grpFiltro.Controls.Add(this.label1);
            this.grpFiltro.Location = new System.Drawing.Point(0, 55);
            this.grpFiltro.Name = "grpFiltro";
            this.grpFiltro.Size = new System.Drawing.Size(977, 88);
            this.grpFiltro.TabIndex = 28;
            this.grpFiltro.TabStop = false;
            // 
            // lblRango
            // 
            this.lblRango.AutoSize = true;
            this.lblRango.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRango.Location = new System.Drawing.Point(19, 15);
            this.lblRango.Name = "lblRango";
            this.lblRango.Size = new System.Drawing.Size(143, 16);
            this.lblRango.TabIndex = 20;
            this.lblRango.Text = "Fechas a consultar:";
            // 
            // grpConsulta
            // 
            this.grpConsulta.Controls.Add(this.rbtInactivo);
            this.grpConsulta.Controls.Add(this.rbtActivo);
            this.grpConsulta.Controls.Add(this.estadoEmpleado);
            this.grpConsulta.Controls.Add(this.cmbCodigo);
            this.grpConsulta.Controls.Add(this.cmbEmpleado);
            this.grpConsulta.Controls.Add(this.label3);
            this.grpConsulta.Controls.Add(this.cmbEstado);
            this.grpConsulta.Controls.Add(this.cmbDepartamento);
            this.grpConsulta.Controls.Add(this.lblEstado);
            this.grpConsulta.Controls.Add(this.btnLimpiar);
            this.grpConsulta.Controls.Add(this.lblDepartamento);
            this.grpConsulta.Controls.Add(this.btnFiltrar);
            this.grpConsulta.Controls.Add(this.lblEmpleado);
            this.grpConsulta.Location = new System.Drawing.Point(6, 149);
            this.grpConsulta.Name = "grpConsulta";
            this.grpConsulta.Size = new System.Drawing.Size(968, 139);
            this.grpConsulta.TabIndex = 29;
            this.grpConsulta.TabStop = false;
            // 
            // rbtInactivo
            // 
            this.rbtInactivo.AutoSize = true;
            this.rbtInactivo.Location = new System.Drawing.Point(368, 100);
            this.rbtInactivo.Name = "rbtInactivo";
            this.rbtInactivo.Size = new System.Drawing.Size(63, 17);
            this.rbtInactivo.TabIndex = 33;
            this.rbtInactivo.TabStop = true;
            this.rbtInactivo.Text = "Inactivo";
            this.rbtInactivo.UseVisualStyleBackColor = true;
            // 
            // rbtActivo
            // 
            this.rbtActivo.AutoSize = true;
            this.rbtActivo.Location = new System.Drawing.Point(260, 99);
            this.rbtActivo.Name = "rbtActivo";
            this.rbtActivo.Size = new System.Drawing.Size(55, 17);
            this.rbtActivo.TabIndex = 32;
            this.rbtActivo.TabStop = true;
            this.rbtActivo.Text = "Activo";
            this.rbtActivo.UseVisualStyleBackColor = true;
            // 
            // estadoEmpleado
            // 
            this.estadoEmpleado.AutoSize = true;
            this.estadoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoEmpleado.Location = new System.Drawing.Point(32, 99);
            this.estadoEmpleado.Name = "estadoEmpleado";
            this.estadoEmpleado.Size = new System.Drawing.Size(142, 16);
            this.estadoEmpleado.TabIndex = 31;
            this.estadoEmpleado.Text = "Estado del Empleado:";
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(191, 16);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(278, 21);
            this.cmbCodigo.TabIndex = 3;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.ItemHeight = 13;
            this.cmbEmpleado.Location = new System.Drawing.Point(191, 55);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(278, 21);
            this.cmbEmpleado.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Código Empleado:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(654, 55);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(278, 21);
            this.cmbEstado.TabIndex = 6;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(654, 16);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(278, 21);
            this.cmbDepartamento.TabIndex = 5;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(519, 55);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(128, 16);
            this.lblEstado.TabIndex = 14;
            this.lblEstado.Text = "Estado de la Marca:";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpiar.Location = new System.Drawing.Point(654, 99);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(80, 29);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click_1);
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(519, 16);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 16);
            this.lblDepartamento.TabIndex = 13;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(852, 99);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(80, 29);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(32, 55);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(151, 16);
            this.lblEmpleado.TabIndex = 21;
            this.lblEmpleado.Text = "Nombre del Empleado: ";
            // 
            // frmConsultaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 475);
            this.Controls.Add(this.grpConsulta);
            this.Controls.Add(this.grpFiltro);
            this.Controls.Add(this.grdConsultas);
            this.Controls.Add(this.tollConsulta);
            this.Controls.Add(this.lblCodigo);
            this.Name = "frmConsultaMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Marcas";
            this.tollConsulta.ResumeLayout(false);
            this.tollConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdConsultas)).EndInit();
            this.grpFiltro.ResumeLayout(false);
            this.grpFiltro.PerformLayout();
            this.grpConsulta.ResumeLayout(false);
            this.grpConsulta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dteFecha2;
        private System.Windows.Forms.DateTimePicker dteFecha1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip tollConsulta;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdConsultas;
        private System.Windows.Forms.GroupBox grpFiltro;
        private System.Windows.Forms.Label lblRango;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUnificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacion;
        private System.Windows.Forms.GroupBox grpConsulta;
        private System.Windows.Forms.RadioButton rbtInactivo;
        private System.Windows.Forms.RadioButton rbtActivo;
        private System.Windows.Forms.Label estadoEmpleado;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblEmpleado;
    }
}