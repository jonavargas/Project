namespace GUI
{
    partial class frmMantDepartamento
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
            System.Windows.Forms.ToolStripButton btnBorrar;
            this.grdDepartamento = new System.Windows.Forms.DataGridView();
            this.toolDepartamento = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.IdDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDepartamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificadopor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            btnBorrar = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamento)).BeginInit();
            this.toolDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBorrar
            // 
            btnBorrar.Image = global::RecursosHumanos.Properties.Resources.borrar;
            btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new System.Drawing.Size(43, 49);
            btnBorrar.Text = "Borrar";
            btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // grdDepartamento
            // 
            this.grdDepartamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDepartamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdDepartamento,
            this.nombreDepartamento,
            this.fechaModificacion,
            this.fechaCreacion,
            this.Creado,
            this.Modificadopor,
            this.Activo});
            this.grdDepartamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdDepartamento.Location = new System.Drawing.Point(0, 52);
            this.grdDepartamento.Name = "grdDepartamento";
            this.grdDepartamento.Size = new System.Drawing.Size(742, 209);
            this.grdDepartamento.TabIndex = 3;
            // 
            // toolDepartamento
            // 
            this.toolDepartamento.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolDepartamento.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            btnBorrar,
            this.btnRefrescar});
            this.toolDepartamento.Location = new System.Drawing.Point(0, 0);
            this.toolDepartamento.Name = "toolDepartamento";
            this.toolDepartamento.Size = new System.Drawing.Size(742, 52);
            this.toolDepartamento.TabIndex = 2;
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
            // IdDepartamento
            // 
            this.IdDepartamento.DataPropertyName = "idDepartamento";
            this.IdDepartamento.HeaderText = "Id Departamento";
            this.IdDepartamento.Name = "IdDepartamento";
            this.IdDepartamento.ReadOnly = true;
            // 
            // nombreDepartamento
            // 
            this.nombreDepartamento.DataPropertyName = "nombreDepartamento";
            this.nombreDepartamento.HeaderText = "Nombre Departamento";
            this.nombreDepartamento.Name = "nombreDepartamento";
            this.nombreDepartamento.ReadOnly = true;
            this.nombreDepartamento.Width = 150;
            // 
            // fechaModificacion
            // 
            this.fechaModificacion.DataPropertyName = "fechaModificacion";
            this.fechaModificacion.HeaderText = "Fecha de modificación";
            this.fechaModificacion.Name = "fechaModificacion";
            this.fechaModificacion.ReadOnly = true;
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.DataPropertyName = "fechaCreacion";
            this.fechaCreacion.HeaderText = "Fecha de creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.ReadOnly = true;
            // 
            // Creado
            // 
            this.Creado.DataPropertyName = "creadoPor";
            this.Creado.HeaderText = "Creado por";
            this.Creado.Name = "Creado";
            this.Creado.ReadOnly = true;
            // 
            // Modificadopor
            // 
            this.Modificadopor.DataPropertyName = "modificadoPor";
            this.Modificadopor.HeaderText = "Modificado por";
            this.Modificadopor.Name = "Modificadopor";
            this.Modificadopor.ReadOnly = true;
            // 
            // Activo
            // 
            this.Activo.DataPropertyName = "activo";
            this.Activo.HeaderText = "Activo";
            this.Activo.Name = "Activo";
            this.Activo.ReadOnly = true;
            this.Activo.Width = 50;
            // 
            // frmMantDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 261);
            this.Controls.Add(this.grdDepartamento);
            this.Controls.Add(this.toolDepartamento);
            this.Name = "frmMantDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Departamento";
            ((System.ComponentModel.ISupportInitialize)(this.grdDepartamento)).EndInit();
            this.toolDepartamento.ResumeLayout(false);
            this.toolDepartamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdDepartamento;
        private System.Windows.Forms.ToolStrip toolDepartamento;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDepartamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modificadopor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Activo;
    }
}