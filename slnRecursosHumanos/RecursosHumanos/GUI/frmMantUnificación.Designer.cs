namespace GUI
{
    partial class frmMantUnificación
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
            this.grpUnificacion = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.dteFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dteFecha1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tollConsulta = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnBloque = new System.Windows.Forms.ToolStripButton();
            this.btnAprobar = new System.Windows.Forms.ToolStripButton();
            this.btnReversar = new System.Windows.Forms.ToolStripButton();
            this.btnAnular = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.grdUnificacion = new System.Windows.Forms.DataGridView();
            this.grpUnificacion.SuspendLayout();
            this.tollConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnificacion)).BeginInit();
            this.SuspendLayout();
            // 
            // grpUnificacion
            // 
            this.grpUnificacion.Controls.Add(this.btnFiltrar);
            this.grpUnificacion.Controls.Add(this.cmbEstado);
            this.grpUnificacion.Controls.Add(this.lblEstado);
            this.grpUnificacion.Controls.Add(this.cmbEmpleado);
            this.grpUnificacion.Controls.Add(this.lblEmpleado);
            this.grpUnificacion.Controls.Add(this.cmbDepartamento);
            this.grpUnificacion.Controls.Add(this.lblDepartamento);
            this.grpUnificacion.Controls.Add(this.dteFecha2);
            this.grpUnificacion.Controls.Add(this.dteFecha1);
            this.grpUnificacion.Controls.Add(this.lblFecha);
            this.grpUnificacion.Controls.Add(this.label1);
            this.grpUnificacion.Location = new System.Drawing.Point(2, 1);
            this.grpUnificacion.Name = "grpUnificacion";
            this.grpUnificacion.Size = new System.Drawing.Size(700, 166);
            this.grpUnificacion.TabIndex = 0;
            this.grpUnificacion.TabStop = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.Black;
            this.btnFiltrar.Location = new System.Drawing.Point(484, 88);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(80, 29);
            this.btnFiltrar.TabIndex = 30;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(152, 133);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(259, 21);
            this.cmbEstado.TabIndex = 28;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(21, 133);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 16);
            this.lblEstado.TabIndex = 29;
            this.lblEstado.Text = "Estado:";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.ItemHeight = 13;
            this.cmbEmpleado.Location = new System.Drawing.Point(152, 96);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(259, 21);
            this.cmbEmpleado.TabIndex = 26;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(21, 96);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(77, 16);
            this.lblEmpleado.TabIndex = 27;
            this.lblEmpleado.Text = "Empleado: ";
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(152, 55);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(259, 21);
            this.cmbDepartamento.TabIndex = 24;
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(21, 60);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 16);
            this.lblDepartamento.TabIndex = 25;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // dteFecha2
            // 
            this.dteFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFecha2.Location = new System.Drawing.Point(298, 20);
            this.dteFecha2.Name = "dteFecha2";
            this.dteFecha2.Size = new System.Drawing.Size(113, 22);
            this.dteFecha2.TabIndex = 22;
            // 
            // dteFecha1
            // 
            this.dteFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dteFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFecha1.Location = new System.Drawing.Point(155, 20);
            this.dteFecha1.Name = "dteFecha1";
            this.dteFecha1.Size = new System.Drawing.Size(112, 22);
            this.dteFecha1.TabIndex = 21;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(21, 26);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(78, 16);
            this.lblFecha.TabIndex = 20;
            this.lblFecha.Text = "Fechas del:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(273, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "al";
            // 
            // tollConsulta
            // 
            this.tollConsulta.Dock = System.Windows.Forms.DockStyle.None;
            this.tollConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tollConsulta.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tollConsulta.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnBloque,
            this.btnAprobar,
            this.btnReversar,
            this.btnAnular,
            this.btnEditar});
            this.tollConsulta.Location = new System.Drawing.Point(2, 170);
            this.tollConsulta.Name = "tollConsulta";
            this.tollConsulta.Size = new System.Drawing.Size(394, 58);
            this.tollConsulta.TabIndex = 27;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::RecursosHumanos.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(60, 55);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnBloque
            // 
            this.btnBloque.Image = global::RecursosHumanos.Properties.Resources.lego;
            this.btnBloque.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBloque.Name = "btnBloque";
            this.btnBloque.Size = new System.Drawing.Size(62, 55);
            this.btnBloque.Text = "Bloque";
            this.btnBloque.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Image = global::RecursosHumanos.Properties.Resources.Check;
            this.btnAprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(71, 55);
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnReversar
            // 
            this.btnReversar.Image = global::RecursosHumanos.Properties.Resources._31;
            this.btnReversar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReversar.Name = "btnReversar";
            this.btnReversar.Size = new System.Drawing.Size(75, 55);
            this.btnReversar.Text = "Reversar";
            this.btnReversar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            // btnEditar
            // 
            this.btnEditar.Image = global::RecursosHumanos.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Black;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(54, 55);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // grdUnificacion
            // 
            this.grdUnificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUnificacion.Location = new System.Drawing.Point(2, 231);
            this.grdUnificacion.Name = "grdUnificacion";
            this.grdUnificacion.Size = new System.Drawing.Size(700, 250);
            this.grdUnificacion.TabIndex = 28;
            // 
            // frmMantUnificación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 512);
            this.Controls.Add(this.grdUnificacion);
            this.Controls.Add(this.tollConsulta);
            this.Controls.Add(this.grpUnificacion);
            this.Name = "frmMantUnificación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Unificación";
            this.grpUnificacion.ResumeLayout(false);
            this.grpUnificacion.PerformLayout();
            this.tollConsulta.ResumeLayout(false);
            this.tollConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnificacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUnificacion;
        private System.Windows.Forms.DateTimePicker dteFecha2;
        private System.Windows.Forms.DateTimePicker dteFecha1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ToolStrip tollConsulta;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnAnular;
        private System.Windows.Forms.ToolStripButton btnBloque;
        private System.Windows.Forms.ToolStripButton btnAprobar;
        private System.Windows.Forms.ToolStripButton btnReversar;
        private System.Windows.Forms.DataGridView grdUnificacion;
    }
}