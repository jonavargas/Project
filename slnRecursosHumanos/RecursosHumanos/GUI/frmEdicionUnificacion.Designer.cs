namespace RecursosHumanos.GUI
{
    partial class frmEdicionUnificacion
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
            this.toolBotones = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.tcUnificacion = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.grdUniDatos = new System.Windows.Forms.DataGridView();
            this.numeroMarca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnCargarMarca = new System.Windows.Forms.ToolStripButton();
            this.btnEditarMarca = new System.Windows.Forms.ToolStripButton();
            this.btnBorrarMarca = new System.Windows.Forms.ToolStripButton();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.grpDatos1 = new System.Windows.Forms.GroupBox();
            this.txtUnifi = new System.Windows.Forms.TextBox();
            this.lblNumUnificacion = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.txtEstMarcas = new System.Windows.Forms.TextBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblEstadoMarcas = new System.Windows.Forms.Label();
            this.lblAl = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblFechas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dateFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dateFecha2 = new System.Windows.Forms.DateTimePicker();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.grpTotPag = new System.Windows.Forms.GroupBox();
            this.txtMonHorExt = new System.Windows.Forms.TextBox();
            this.lblMonHorExt = new System.Windows.Forms.Label();
            this.txtMonHorReg = new System.Windows.Forms.TextBox();
            this.lblTotHorDobles = new System.Windows.Forms.Label();
            this.txtMontHorReg = new System.Windows.Forms.TextBox();
            this.lblMontoHorReg = new System.Windows.Forms.Label();
            this.grpTotHor = new System.Windows.Forms.GroupBox();
            this.txtTotHorasExtr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotHorDob = new System.Windows.Forms.TextBox();
            this.lblTotHorDob = new System.Windows.Forms.Label();
            this.txtTotHorReg = new System.Windows.Forms.TextBox();
            this.lblTotHorReg = new System.Windows.Forms.Label();
            this.toolBotones.SuspendLayout();
            this.tcUnificacion.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUniDatos)).BeginInit();
            this.grpBotones.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.grpDatos1.SuspendLayout();
            this.tp2.SuspendLayout();
            this.grpTotPag.SuspendLayout();
            this.grpTotHor.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBotones
            // 
            this.toolBotones.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar});
            this.toolBotones.Location = new System.Drawing.Point(0, 0);
            this.toolBotones.Name = "toolBotones";
            this.toolBotones.Size = new System.Drawing.Size(768, 58);
            this.toolBotones.TabIndex = 0;
            this.toolBotones.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Image = global::RecursosHumanos.Properties.Resources.salvar;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(57, 55);
            this.btnSalvar.Tag = "";
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tcUnificacion
            // 
            this.tcUnificacion.Controls.Add(this.tp1);
            this.tcUnificacion.Controls.Add(this.tp2);
            this.tcUnificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUnificacion.Location = new System.Drawing.Point(0, 55);
            this.tcUnificacion.Name = "tcUnificacion";
            this.tcUnificacion.SelectedIndex = 0;
            this.tcUnificacion.Size = new System.Drawing.Size(762, 454);
            this.tcUnificacion.TabIndex = 2;
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.grdUniDatos);
            this.tp1.Controls.Add(this.grpBotones);
            this.tp1.Controls.Add(this.grpDatos1);
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(754, 425);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Datos";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // grdUniDatos
            // 
            this.grdUniDatos.AllowUserToDeleteRows = false;
            this.grdUniDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUniDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numeroMarca,
            this.fecha,
            this.tipo});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUniDatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdUniDatos.Location = new System.Drawing.Point(8, 270);
            this.grdUniDatos.Name = "grdUniDatos";
            this.grdUniDatos.ReadOnly = true;
            this.grdUniDatos.Size = new System.Drawing.Size(734, 149);
            this.grdUniDatos.TabIndex = 51;
            // 
            // numeroMarca
            // 
            this.numeroMarca.HeaderText = "Número marca";
            this.numeroMarca.Name = "numeroMarca";
            this.numeroMarca.ReadOnly = true;
            this.numeroMarca.Width = 150;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 150;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "Tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            this.tipo.Width = 150;
            // 
            // grpBotones
            // 
            this.grpBotones.Controls.Add(this.toolStrip1);
            this.grpBotones.Location = new System.Drawing.Point(9, 187);
            this.grpBotones.Name = "grpBotones";
            this.grpBotones.Size = new System.Drawing.Size(733, 77);
            this.grpBotones.TabIndex = 50;
            this.grpBotones.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnCargarMarca,
            this.btnEditarMarca,
            this.btnBorrarMarca,
            this.btnNuevo});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(386, 58);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnCargarMarca
            // 
            this.btnCargarMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarMarca.Image = global::RecursosHumanos.Properties.Resources.cargar;
            this.btnCargarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCargarMarca.Name = "btnCargarMarca";
            this.btnCargarMarca.Size = new System.Drawing.Size(108, 55);
            this.btnCargarMarca.Tag = "9";
            this.btnCargarMarca.Text = "Cargar Marca";
            this.btnCargarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnEditarMarca
            // 
            this.btnEditarMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarMarca.Image = global::RecursosHumanos.Properties.Resources.editar;
            this.btnEditarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditarMarca.Name = "btnEditarMarca";
            this.btnEditarMarca.Size = new System.Drawing.Size(101, 55);
            this.btnEditarMarca.Tag = "10";
            this.btnEditarMarca.Text = "Editar Marca";
            this.btnEditarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnBorrarMarca
            // 
            this.btnBorrarMarca.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarMarca.Image = global::RecursosHumanos.Properties.Resources.borrar;
            this.btnBorrarMarca.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrarMarca.Name = "btnBorrarMarca";
            this.btnBorrarMarca.Size = new System.Drawing.Size(105, 55);
            this.btnBorrarMarca.Tag = "11";
            this.btnBorrarMarca.Text = "Borrar Marca";
            this.btnBorrarMarca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::RecursosHumanos.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 55);
            this.btnNuevo.Tag = "12";
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // grpDatos1
            // 
            this.grpDatos1.Controls.Add(this.txtUnifi);
            this.grpDatos1.Controls.Add(this.lblNumUnificacion);
            this.grpDatos1.Controls.Add(this.cmbEmpleado);
            this.grpDatos1.Controls.Add(this.txtEstMarcas);
            this.grpDatos1.Controls.Add(this.lblEmpleado);
            this.grpDatos1.Controls.Add(this.lblEstadoMarcas);
            this.grpDatos1.Controls.Add(this.lblAl);
            this.grpDatos1.Controls.Add(this.cmbEstado);
            this.grpDatos1.Controls.Add(this.lblFechas);
            this.grpDatos1.Controls.Add(this.lblEstado);
            this.grpDatos1.Controls.Add(this.dateFecha1);
            this.grpDatos1.Controls.Add(this.dateFecha2);
            this.grpDatos1.Location = new System.Drawing.Point(8, 6);
            this.grpDatos1.Name = "grpDatos1";
            this.grpDatos1.Size = new System.Drawing.Size(734, 175);
            this.grpDatos1.TabIndex = 48;
            this.grpDatos1.TabStop = false;
            // 
            // txtUnifi
            // 
            this.txtUnifi.Location = new System.Drawing.Point(137, 145);
            this.txtUnifi.Name = "txtUnifi";
            this.txtUnifi.Size = new System.Drawing.Size(122, 22);
            this.txtUnifi.TabIndex = 6;
            this.txtUnifi.Tag = "8";
            // 
            // lblNumUnificacion
            // 
            this.lblNumUnificacion.AutoSize = true;
            this.lblNumUnificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumUnificacion.Location = new System.Drawing.Point(10, 148);
            this.lblNumUnificacion.Name = "lblNumUnificacion";
            this.lblNumUnificacion.Size = new System.Drawing.Size(125, 16);
            this.lblNumUnificacion.TabIndex = 48;
            this.lblNumUnificacion.Text = "Número unificación:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.ItemHeight = 16;
            this.cmbEmpleado.Location = new System.Drawing.Point(137, 9);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(312, 24);
            this.cmbEmpleado.TabIndex = 1;
            this.cmbEmpleado.Tag = "";
            // 
            // txtEstMarcas
            // 
            this.txtEstMarcas.Location = new System.Drawing.Point(137, 107);
            this.txtEstMarcas.Name = "txtEstMarcas";
            this.txtEstMarcas.Size = new System.Drawing.Size(122, 22);
            this.txtEstMarcas.TabIndex = 5;
            this.txtEstMarcas.Tag = "7";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(10, 17);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(77, 16);
            this.lblEmpleado.TabIndex = 37;
            this.lblEmpleado.Text = "Empleado: ";
            // 
            // lblEstadoMarcas
            // 
            this.lblEstadoMarcas.AutoSize = true;
            this.lblEstadoMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMarcas.Location = new System.Drawing.Point(10, 112);
            this.lblEstadoMarcas.Name = "lblEstadoMarcas";
            this.lblEstadoMarcas.Size = new System.Drawing.Size(102, 16);
            this.lblEstadoMarcas.TabIndex = 46;
            this.lblEstadoMarcas.Text = "Estado marcas:";
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAl.Location = new System.Drawing.Point(280, 44);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(19, 16);
            this.lblAl.TabIndex = 43;
            this.lblAl.Text = "al";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(137, 72);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(122, 24);
            this.cmbEstado.TabIndex = 4;
            this.cmbEstado.Tag = "6";
            // 
            // lblFechas
            // 
            this.lblFechas.AutoSize = true;
            this.lblFechas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechas.Location = new System.Drawing.Point(10, 45);
            this.lblFechas.Name = "lblFechas";
            this.lblFechas.Size = new System.Drawing.Size(78, 16);
            this.lblFechas.TabIndex = 40;
            this.lblFechas.Text = "Fechas del:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(10, 75);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 16);
            this.lblEstado.TabIndex = 45;
            this.lblEstado.Text = "Estado:";
            // 
            // dateFecha1
            // 
            this.dateFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha1.Location = new System.Drawing.Point(137, 39);
            this.dateFecha1.Name = "dateFecha1";
            this.dateFecha1.Size = new System.Drawing.Size(122, 22);
            this.dateFecha1.TabIndex = 2;
            this.dateFecha1.Tag = "4";
            // 
            // dateFecha2
            // 
            this.dateFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFecha2.Location = new System.Drawing.Point(325, 38);
            this.dateFecha2.Name = "dateFecha2";
            this.dateFecha2.Size = new System.Drawing.Size(124, 22);
            this.dateFecha2.TabIndex = 3;
            this.dateFecha2.Tag = "5";
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.grpTotPag);
            this.tp2.Controls.Add(this.grpTotHor);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(754, 425);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Totales";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // grpTotPag
            // 
            this.grpTotPag.Controls.Add(this.txtMonHorExt);
            this.grpTotPag.Controls.Add(this.lblMonHorExt);
            this.grpTotPag.Controls.Add(this.txtMonHorReg);
            this.grpTotPag.Controls.Add(this.lblTotHorDobles);
            this.grpTotPag.Controls.Add(this.txtMontHorReg);
            this.grpTotPag.Controls.Add(this.lblMontoHorReg);
            this.grpTotPag.Location = new System.Drawing.Point(390, 6);
            this.grpTotPag.Name = "grpTotPag";
            this.grpTotPag.Size = new System.Drawing.Size(356, 143);
            this.grpTotPag.TabIndex = 2;
            this.grpTotPag.TabStop = false;
            this.grpTotPag.Text = "Total a pagar";
            // 
            // txtMonHorExt
            // 
            this.txtMonHorExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonHorExt.Location = new System.Drawing.Point(179, 100);
            this.txtMonHorExt.Name = "txtMonHorExt";
            this.txtMonHorExt.ReadOnly = true;
            this.txtMonHorExt.Size = new System.Drawing.Size(159, 26);
            this.txtMonHorExt.TabIndex = 6;
            // 
            // lblMonHorExt
            // 
            this.lblMonHorExt.AutoSize = true;
            this.lblMonHorExt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonHorExt.Location = new System.Drawing.Point(16, 106);
            this.lblMonHorExt.Name = "lblMonHorExt";
            this.lblMonHorExt.Size = new System.Drawing.Size(128, 16);
            this.lblMonHorExt.TabIndex = 5;
            this.lblMonHorExt.Text = "Monto horas Extras :";
            // 
            // txtMonHorReg
            // 
            this.txtMonHorReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMonHorReg.Location = new System.Drawing.Point(179, 62);
            this.txtMonHorReg.Name = "txtMonHorReg";
            this.txtMonHorReg.ReadOnly = true;
            this.txtMonHorReg.Size = new System.Drawing.Size(159, 26);
            this.txtMonHorReg.TabIndex = 4;
            // 
            // lblTotHorDobles
            // 
            this.lblTotHorDobles.AutoSize = true;
            this.lblTotHorDobles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotHorDobles.Location = new System.Drawing.Point(16, 68);
            this.lblTotHorDobles.Name = "lblTotHorDobles";
            this.lblTotHorDobles.Size = new System.Drawing.Size(133, 16);
            this.lblTotHorDobles.TabIndex = 3;
            this.lblTotHorDobles.Text = "Monto horas dobles :";
            // 
            // txtMontHorReg
            // 
            this.txtMontHorReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMontHorReg.Location = new System.Drawing.Point(179, 27);
            this.txtMontHorReg.Name = "txtMontHorReg";
            this.txtMontHorReg.ReadOnly = true;
            this.txtMontHorReg.Size = new System.Drawing.Size(159, 26);
            this.txtMontHorReg.TabIndex = 2;
            // 
            // lblMontoHorReg
            // 
            this.lblMontoHorReg.AutoSize = true;
            this.lblMontoHorReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoHorReg.Location = new System.Drawing.Point(16, 33);
            this.lblMontoHorReg.Name = "lblMontoHorReg";
            this.lblMontoHorReg.Size = new System.Drawing.Size(148, 16);
            this.lblMontoHorReg.TabIndex = 1;
            this.lblMontoHorReg.Text = "Monto horas regulares :";
            // 
            // grpTotHor
            // 
            this.grpTotHor.Controls.Add(this.txtTotHorasExtr);
            this.grpTotHor.Controls.Add(this.label1);
            this.grpTotHor.Controls.Add(this.txtTotHorDob);
            this.grpTotHor.Controls.Add(this.lblTotHorDob);
            this.grpTotHor.Controls.Add(this.txtTotHorReg);
            this.grpTotHor.Controls.Add(this.lblTotHorReg);
            this.grpTotHor.Location = new System.Drawing.Point(3, 6);
            this.grpTotHor.Name = "grpTotHor";
            this.grpTotHor.Size = new System.Drawing.Size(368, 143);
            this.grpTotHor.TabIndex = 1;
            this.grpTotHor.TabStop = false;
            this.grpTotHor.Text = "Total horas";
            // 
            // txtTotHorasExtr
            // 
            this.txtTotHorasExtr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotHorasExtr.Location = new System.Drawing.Point(166, 96);
            this.txtTotHorasExtr.Name = "txtTotHorasExtr";
            this.txtTotHorasExtr.ReadOnly = true;
            this.txtTotHorasExtr.Size = new System.Drawing.Size(159, 26);
            this.txtTotHorasExtr.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total horas extras :";
            // 
            // txtTotHorDob
            // 
            this.txtTotHorDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotHorDob.Location = new System.Drawing.Point(166, 58);
            this.txtTotHorDob.Name = "txtTotHorDob";
            this.txtTotHorDob.ReadOnly = true;
            this.txtTotHorDob.Size = new System.Drawing.Size(159, 26);
            this.txtTotHorDob.TabIndex = 3;
            // 
            // lblTotHorDob
            // 
            this.lblTotHorDob.AutoSize = true;
            this.lblTotHorDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotHorDob.Location = new System.Drawing.Point(6, 68);
            this.lblTotHorDob.Name = "lblTotHorDob";
            this.lblTotHorDob.Size = new System.Drawing.Size(127, 16);
            this.lblTotHorDob.TabIndex = 2;
            this.lblTotHorDob.Text = "Total horas dobles :";
            // 
            // txtTotHorReg
            // 
            this.txtTotHorReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotHorReg.Location = new System.Drawing.Point(166, 23);
            this.txtTotHorReg.Name = "txtTotHorReg";
            this.txtTotHorReg.ReadOnly = true;
            this.txtTotHorReg.Size = new System.Drawing.Size(159, 26);
            this.txtTotHorReg.TabIndex = 1;
            // 
            // lblTotHorReg
            // 
            this.lblTotHorReg.AutoSize = true;
            this.lblTotHorReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotHorReg.Location = new System.Drawing.Point(6, 33);
            this.lblTotHorReg.Name = "lblTotHorReg";
            this.lblTotHorReg.Size = new System.Drawing.Size(142, 16);
            this.lblTotHorReg.TabIndex = 0;
            this.lblTotHorReg.Text = "Total horas regulares :";
            // 
            // frmEdicionUnificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 516);
            this.Controls.Add(this.tcUnificacion);
            this.Controls.Add(this.toolBotones);
            this.Name = "frmEdicionUnificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición de Unificación";
            this.toolBotones.ResumeLayout(false);
            this.toolBotones.PerformLayout();
            this.tcUnificacion.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUniDatos)).EndInit();
            this.grpBotones.ResumeLayout(false);
            this.grpBotones.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpDatos1.ResumeLayout(false);
            this.grpDatos1.PerformLayout();
            this.tp2.ResumeLayout(false);
            this.grpTotPag.ResumeLayout(false);
            this.grpTotPag.PerformLayout();
            this.grpTotHor.ResumeLayout(false);
            this.grpTotHor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBotones;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.TabControl tcUnificacion;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.DateTimePicker dateFecha2;
        private System.Windows.Forms.DateTimePicker dateFecha1;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblEstadoMarcas;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grpDatos1;
        private System.Windows.Forms.TextBox txtEstMarcas;
        private System.Windows.Forms.TextBox txtUnifi;
        private System.Windows.Forms.Label lblNumUnificacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCargarMarca;
        private System.Windows.Forms.ToolStripButton btnEditarMarca;
        private System.Windows.Forms.ToolStripButton btnBorrarMarca;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.DataGridView grdUniDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroMarca;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.GroupBox grpTotPag;
        private System.Windows.Forms.GroupBox grpTotHor;
        private System.Windows.Forms.TextBox txtTotHorDob;
        private System.Windows.Forms.Label lblTotHorDob;
        private System.Windows.Forms.TextBox txtTotHorReg;
        private System.Windows.Forms.Label lblTotHorReg;
        private System.Windows.Forms.TextBox txtTotHorasExtr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonHorExt;
        private System.Windows.Forms.Label lblMonHorExt;
        private System.Windows.Forms.TextBox txtMonHorReg;
        private System.Windows.Forms.Label lblTotHorDobles;
        private System.Windows.Forms.TextBox txtMontHorReg;
        private System.Windows.Forms.Label lblMontoHorReg;
    }
}