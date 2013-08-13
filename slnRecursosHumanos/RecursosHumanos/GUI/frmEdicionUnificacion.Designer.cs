namespace GUI
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
            this.grdMarcas = new System.Windows.Forms.DataGridView();
            this.grpBotones = new System.Windows.Forms.GroupBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditarMarca = new System.Windows.Forms.ToolStripButton();
            this.btnBorrarMarca = new System.Windows.Forms.ToolStripButton();
            this.btnCargarMarca = new System.Windows.Forms.ToolStripButton();
            this.grpDatos1 = new System.Windows.Forms.GroupBox();
            this.lblEstadoUnificacion = new System.Windows.Forms.Label();
            this.txtNumUni = new System.Windows.Forms.TextBox();
            this.lblNumUnificacion = new System.Windows.Forms.Label();
            this.cmbIDEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.lblEstadoMarcas = new System.Windows.Forms.Label();
            this.lblAl = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblFechas = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.grpTotPag = new System.Windows.Forms.GroupBox();
            this.txtmontoExtra = new System.Windows.Forms.TextBox();
            this.lblMonHorExt = new System.Windows.Forms.Label();
            this.txtmontoDobles = new System.Windows.Forms.TextBox();
            this.lblTotHorDobles = new System.Windows.Forms.Label();
            this.txtmontoRegular = new System.Windows.Forms.TextBox();
            this.lblMontoHorReg = new System.Windows.Forms.Label();
            this.grpTotHor = new System.Windows.Forms.GroupBox();
            this.txthoraExtra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthoraDoble = new System.Windows.Forms.TextBox();
            this.lblTotHorDob = new System.Windows.Forms.Label();
            this.txthoraRegular = new System.Windows.Forms.TextBox();
            this.lblTotHorReg = new System.Windows.Forms.Label();
            this.toolBotones.SuspendLayout();
            this.tcUnificacion.SuspendLayout();
            this.tp1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).BeginInit();
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
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
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
            this.tp1.Controls.Add(this.grdMarcas);
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
            // grdMarcas
            // 
            this.grdMarcas.AllowUserToDeleteRows = false;
            this.grdMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMarcas.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdMarcas.Location = new System.Drawing.Point(8, 270);
            this.grdMarcas.Name = "grdMarcas";
            this.grdMarcas.ReadOnly = true;
            this.grdMarcas.Size = new System.Drawing.Size(734, 149);
            this.grdMarcas.TabIndex = 51;
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
            this.btnNuevo,
            this.btnEditarMarca,
            this.btnBorrarMarca,
            this.btnCargarMarca});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(386, 58);
            this.toolStrip1.TabIndex = 49;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
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
            this.btnEditarMarca.Click += new System.EventHandler(this.btnEditarMarca_Click);
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
            this.btnBorrarMarca.Click += new System.EventHandler(this.btnBorrarMarca_Click);
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
            this.btnCargarMarca.Click += new System.EventHandler(this.btnCargarMarca_Click);
            // 
            // grpDatos1
            // 
            this.grpDatos1.Controls.Add(this.lblEstadoUnificacion);
            this.grpDatos1.Controls.Add(this.txtNumUni);
            this.grpDatos1.Controls.Add(this.lblNumUnificacion);
            this.grpDatos1.Controls.Add(this.cmbIDEmpleado);
            this.grpDatos1.Controls.Add(this.lblEmpleado);
            this.grpDatos1.Controls.Add(this.lblEstadoMarcas);
            this.grpDatos1.Controls.Add(this.lblAl);
            this.grpDatos1.Controls.Add(this.cmbEstado);
            this.grpDatos1.Controls.Add(this.lblFechas);
            this.grpDatos1.Controls.Add(this.lblEstado);
            this.grpDatos1.Controls.Add(this.dtpFecha1);
            this.grpDatos1.Controls.Add(this.dtpFecha2);
            this.grpDatos1.Location = new System.Drawing.Point(8, 6);
            this.grpDatos1.Name = "grpDatos1";
            this.grpDatos1.Size = new System.Drawing.Size(734, 175);
            this.grpDatos1.TabIndex = 48;
            this.grpDatos1.TabStop = false;
            // 
            // lblEstadoUnificacion
            // 
            this.lblEstadoUnificacion.AutoSize = true;
            this.lblEstadoUnificacion.Location = new System.Drawing.Point(154, 142);
            this.lblEstadoUnificacion.Name = "lblEstadoUnificacion";
            this.lblEstadoUnificacion.Size = new System.Drawing.Size(0, 16);
            this.lblEstadoUnificacion.TabIndex = 49;
            // 
            // txtNumUni
            // 
            this.txtNumUni.Location = new System.Drawing.Point(157, 107);
            this.txtNumUni.Name = "txtNumUni";
            this.txtNumUni.Size = new System.Drawing.Size(122, 22);
            this.txtNumUni.TabIndex = 6;
            this.txtNumUni.Tag = "8";
            // 
            // lblNumUnificacion
            // 
            this.lblNumUnificacion.AutoSize = true;
            this.lblNumUnificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumUnificacion.Location = new System.Drawing.Point(10, 110);
            this.lblNumUnificacion.Name = "lblNumUnificacion";
            this.lblNumUnificacion.Size = new System.Drawing.Size(128, 16);
            this.lblNumUnificacion.TabIndex = 48;
            this.lblNumUnificacion.Text = "Número Unificación:";
            // 
            // cmbIDEmpleado
            // 
            this.cmbIDEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIDEmpleado.FormattingEnabled = true;
            this.cmbIDEmpleado.ItemHeight = 16;
            this.cmbIDEmpleado.Location = new System.Drawing.Point(157, 9);
            this.cmbIDEmpleado.Name = "cmbIDEmpleado";
            this.cmbIDEmpleado.Size = new System.Drawing.Size(312, 24);
            this.cmbIDEmpleado.TabIndex = 1;
            this.cmbIDEmpleado.Tag = "";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(10, 17);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(124, 16);
            this.lblEmpleado.TabIndex = 37;
            this.lblEmpleado.Text = "Código Empleado: ";
            // 
            // lblEstadoMarcas
            // 
            this.lblEstadoMarcas.AutoSize = true;
            this.lblEstadoMarcas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoMarcas.Location = new System.Drawing.Point(10, 142);
            this.lblEstadoMarcas.Name = "lblEstadoMarcas";
            this.lblEstadoMarcas.Size = new System.Drawing.Size(102, 16);
            this.lblEstadoMarcas.TabIndex = 46;
            this.lblEstadoMarcas.Text = "Estado Marcas:";
            // 
            // lblAl
            // 
            this.lblAl.AutoSize = true;
            this.lblAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAl.Location = new System.Drawing.Point(300, 44);
            this.lblAl.Name = "lblAl";
            this.lblAl.Size = new System.Drawing.Size(19, 16);
            this.lblAl.TabIndex = 43;
            this.lblAl.Text = "al";
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "Generada"});
            this.cmbEstado.Location = new System.Drawing.Point(157, 72);
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
            // dtpFecha1
            // 
            this.dtpFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(157, 39);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(122, 22);
            this.dtpFecha1.TabIndex = 2;
            this.dtpFecha1.Tag = "4";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(345, 38);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(124, 22);
            this.dtpFecha2.TabIndex = 3;
            this.dtpFecha2.Tag = "5";
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
            this.grpTotPag.Controls.Add(this.txtmontoExtra);
            this.grpTotPag.Controls.Add(this.lblMonHorExt);
            this.grpTotPag.Controls.Add(this.txtmontoDobles);
            this.grpTotPag.Controls.Add(this.lblTotHorDobles);
            this.grpTotPag.Controls.Add(this.txtmontoRegular);
            this.grpTotPag.Controls.Add(this.lblMontoHorReg);
            this.grpTotPag.Location = new System.Drawing.Point(390, 6);
            this.grpTotPag.Name = "grpTotPag";
            this.grpTotPag.Size = new System.Drawing.Size(356, 143);
            this.grpTotPag.TabIndex = 2;
            this.grpTotPag.TabStop = false;
            this.grpTotPag.Text = "Total a pagar";
            // 
            // txtmontoExtra
            // 
            this.txtmontoExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontoExtra.Location = new System.Drawing.Point(179, 100);
            this.txtmontoExtra.Name = "txtmontoExtra";
            this.txtmontoExtra.ReadOnly = true;
            this.txtmontoExtra.Size = new System.Drawing.Size(159, 26);
            this.txtmontoExtra.TabIndex = 6;
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
            // txtmontoDobles
            // 
            this.txtmontoDobles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontoDobles.Location = new System.Drawing.Point(179, 62);
            this.txtmontoDobles.Name = "txtmontoDobles";
            this.txtmontoDobles.ReadOnly = true;
            this.txtmontoDobles.Size = new System.Drawing.Size(159, 26);
            this.txtmontoDobles.TabIndex = 4;
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
            // txtmontoRegular
            // 
            this.txtmontoRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmontoRegular.Location = new System.Drawing.Point(179, 27);
            this.txtmontoRegular.Name = "txtmontoRegular";
            this.txtmontoRegular.ReadOnly = true;
            this.txtmontoRegular.Size = new System.Drawing.Size(159, 26);
            this.txtmontoRegular.TabIndex = 2;
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
            this.grpTotHor.Controls.Add(this.txthoraExtra);
            this.grpTotHor.Controls.Add(this.label1);
            this.grpTotHor.Controls.Add(this.txthoraDoble);
            this.grpTotHor.Controls.Add(this.lblTotHorDob);
            this.grpTotHor.Controls.Add(this.txthoraRegular);
            this.grpTotHor.Controls.Add(this.lblTotHorReg);
            this.grpTotHor.Location = new System.Drawing.Point(3, 6);
            this.grpTotHor.Name = "grpTotHor";
            this.grpTotHor.Size = new System.Drawing.Size(368, 143);
            this.grpTotHor.TabIndex = 1;
            this.grpTotHor.TabStop = false;
            this.grpTotHor.Text = "Total horas";
            // 
            // txthoraExtra
            // 
            this.txthoraExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoraExtra.Location = new System.Drawing.Point(166, 96);
            this.txthoraExtra.Name = "txthoraExtra";
            this.txthoraExtra.ReadOnly = true;
            this.txthoraExtra.Size = new System.Drawing.Size(159, 26);
            this.txthoraExtra.TabIndex = 5;
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
            // txthoraDoble
            // 
            this.txthoraDoble.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoraDoble.Location = new System.Drawing.Point(166, 58);
            this.txthoraDoble.Name = "txthoraDoble";
            this.txthoraDoble.ReadOnly = true;
            this.txthoraDoble.Size = new System.Drawing.Size(159, 26);
            this.txthoraDoble.TabIndex = 3;
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
            // txthoraRegular
            // 
            this.txthoraRegular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthoraRegular.Location = new System.Drawing.Point(166, 23);
            this.txthoraRegular.Name = "txthoraRegular";
            this.txthoraRegular.ReadOnly = true;
            this.txthoraRegular.Size = new System.Drawing.Size(159, 26);
            this.txthoraRegular.TabIndex = 1;
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
            this.Text = "Edición Unificación";
            this.toolBotones.ResumeLayout(false);
            this.toolBotones.PerformLayout();
            this.tcUnificacion.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMarcas)).EndInit();
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
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label lblFechas;
        private System.Windows.Forms.Label lblAl;
        private System.Windows.Forms.ComboBox cmbIDEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.Label lblEstadoMarcas;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox grpDatos1;
        private System.Windows.Forms.TextBox txtNumUni;
        private System.Windows.Forms.Label lblNumUnificacion;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnCargarMarca;
        private System.Windows.Forms.ToolStripButton btnEditarMarca;
        private System.Windows.Forms.ToolStripButton btnBorrarMarca;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.GroupBox grpBotones;
        private System.Windows.Forms.DataGridView grdMarcas;
        private System.Windows.Forms.GroupBox grpTotPag;
        private System.Windows.Forms.GroupBox grpTotHor;
        private System.Windows.Forms.TextBox txthoraDoble;
        private System.Windows.Forms.Label lblTotHorDob;
        private System.Windows.Forms.TextBox txthoraRegular;
        private System.Windows.Forms.Label lblTotHorReg;
        private System.Windows.Forms.TextBox txthoraExtra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmontoExtra;
        private System.Windows.Forms.Label lblMonHorExt;
        private System.Windows.Forms.TextBox txtmontoDobles;
        private System.Windows.Forms.Label lblTotHorDobles;
        private System.Windows.Forms.TextBox txtmontoRegular;
        private System.Windows.Forms.Label lblMontoHorReg;
        private System.Windows.Forms.Label lblEstadoUnificacion;
    }
}