namespace GUI
{
    partial class frmMantDeducciones
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
            this.tollDeducciones = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdDeducciones = new System.Windows.Forms.DataGridView();
            this.idDeducciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollDeducciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeducciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tollDeducciones
            // 
            this.tollDeducciones.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tollDeducciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBorrar,
            this.btnRefrescar});
            this.tollDeducciones.Location = new System.Drawing.Point(0, 0);
            this.tollDeducciones.Name = "tollDeducciones";
            this.tollDeducciones.Size = new System.Drawing.Size(844, 52);
            this.tollDeducciones.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::RecursosHumanos.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 49);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::RecursosHumanos.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 49);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
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
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // grdDeducciones
            // 
            this.grdDeducciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDeducciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDeducciones,
            this.descripcion,
            this.porcentaje,
            this.creadoPor,
            this.fechaCreacion,
            this.modificadoPor,
            this.fechaModificacion,
            this.activo});
            this.grdDeducciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDeducciones.Location = new System.Drawing.Point(0, 52);
            this.grdDeducciones.Name = "grdDeducciones";
            this.grdDeducciones.Size = new System.Drawing.Size(844, 178);
            this.grdDeducciones.TabIndex = 1;
            // 
            // idDeducciones
            // 
            this.idDeducciones.DataPropertyName = "idDeducciones";
            this.idDeducciones.HeaderText = "Id Deducciones";
            this.idDeducciones.Name = "idDeducciones";
            this.idDeducciones.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // porcentaje
            // 
            this.porcentaje.DataPropertyName = "porcentaje";
            this.porcentaje.HeaderText = "Porcentaje";
            this.porcentaje.Name = "porcentaje";
            this.porcentaje.ReadOnly = true;
            // 
            // creadoPor
            // 
            this.creadoPor.DataPropertyName = "creadoPor";
            this.creadoPor.HeaderText = "Creado Por";
            this.creadoPor.Name = "creadoPor";
            this.creadoPor.ReadOnly = true;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.DataPropertyName = "fechaCreacion";
            this.fechaCreacion.HeaderText = "Fecha Creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            this.fechaCreacion.Width = 125;
            // 
            // modificadoPor
            // 
            this.modificadoPor.DataPropertyName = "modificadoPor";
            this.modificadoPor.HeaderText = "Modificado Por";
            this.modificadoPor.Name = "modificadoPor";
            this.modificadoPor.ReadOnly = true;
            // 
            // fechaModificacion
            // 
            this.fechaModificacion.DataPropertyName = "fechaModificacion";
            this.fechaModificacion.HeaderText = "Fecha Modificación";
            this.fechaModificacion.Name = "fechaModificacion";
            this.fechaModificacion.ReadOnly = true;
            this.fechaModificacion.Width = 125;
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            this.activo.ReadOnly = true;
            this.activo.Width = 50;
            // 
            // frmMantDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 230);
            this.Controls.Add(this.grdDeducciones);
            this.Controls.Add(this.tollDeducciones);
            this.Name = "frmMantDeducciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Deducciones";
            this.tollDeducciones.ResumeLayout(false);
            this.tollDeducciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDeducciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollDeducciones;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdDeducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDeducciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
    }
}