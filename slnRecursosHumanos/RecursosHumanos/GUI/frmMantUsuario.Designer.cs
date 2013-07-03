namespace GUI
{
    partial class frmMantUsuario
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
            this.tollUsuario = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdUsuario = new System.Windows.Forms.DataGridView();
            this.colidUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coltipo_Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuarioPass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcreadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfechadeCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmodificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colfechadeModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colActivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // tollUsuario
            // 
            this.tollUsuario.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tollUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBorrar,
            this.btnRefrescar});
            this.tollUsuario.Location = new System.Drawing.Point(0, 0);
            this.tollUsuario.Name = "tollUsuario";
            this.tollUsuario.Size = new System.Drawing.Size(918, 52);
            this.tollUsuario.TabIndex = 0;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::RecursosHumanos.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 49);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.ToolTipText = "Genera un nuevo Usuario que administre el sistema";
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
            this.btnEditar.ToolTipText = "Modifica un usuario ya existente";
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
            this.btnBorrar.ToolTipText = "Elimina un usuario del sistema";
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
            this.btnRefrescar.ToolTipText = "Actualiza la información de los usuarios";
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // grdUsuario
            // 
            this.grdUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidUsuario,
            this.coltipo_Usuario,
            this.colUsuarioPass,
            this.colcreadoPor,
            this.colfechadeCreacion,
            this.colmodificadoPor,
            this.colfechadeModificacion,
            this.colActivo});
            this.grdUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdUsuario.Location = new System.Drawing.Point(0, 52);
            this.grdUsuario.Name = "grdUsuario";
            this.grdUsuario.Size = new System.Drawing.Size(918, 210);
            this.grdUsuario.TabIndex = 1;
            // 
            // colidUsuario
            // 
            this.colidUsuario.DataPropertyName = "IdUsuario";
            this.colidUsuario.HeaderText = "ID Usuario";
            this.colidUsuario.Name = "colidUsuario";
            this.colidUsuario.Width = 125;
            // 
            // coltipo_Usuario
            // 
            this.coltipo_Usuario.DataPropertyName = "tipoUsuario";
            this.coltipo_Usuario.HeaderText = "Tipo Usuario";
            this.coltipo_Usuario.Name = "coltipo_Usuario";
            // 
            // colUsuarioPass
            // 
            this.colUsuarioPass.DataPropertyName = "password";
            this.colUsuarioPass.HeaderText = "Password";
            this.colUsuarioPass.Name = "colUsuarioPass";
            this.colUsuarioPass.Width = 75;
            // 
            // colcreadoPor
            // 
            this.colcreadoPor.DataPropertyName = "creadoPor";
            this.colcreadoPor.HeaderText = "Creado Por";
            this.colcreadoPor.Name = "colcreadoPor";
            this.colcreadoPor.Width = 125;
            // 
            // colfechadeCreacion
            // 
            this.colfechadeCreacion.DataPropertyName = "fechaCreacion";
            this.colfechadeCreacion.HeaderText = "Fecha de Creación";
            this.colfechadeCreacion.Name = "colfechadeCreacion";
            this.colfechadeCreacion.Width = 125;
            // 
            // colmodificadoPor
            // 
            this.colmodificadoPor.DataPropertyName = "modificadoPor";
            this.colmodificadoPor.HeaderText = "Modificado Por";
            this.colmodificadoPor.Name = "colmodificadoPor";
            this.colmodificadoPor.Width = 125;
            // 
            // colfechadeModificacion
            // 
            this.colfechadeModificacion.DataPropertyName = "fechaModificacion";
            this.colfechadeModificacion.HeaderText = "Fecha de Modificación";
            this.colfechadeModificacion.Name = "colfechadeModificacion";
            this.colfechadeModificacion.Width = 125;
            // 
            // colActivo
            // 
            this.colActivo.DataPropertyName = "activo";
            this.colActivo.HeaderText = "Activo";
            this.colActivo.Name = "colActivo";
            this.colActivo.Width = 50;
            // 
            // frmMantUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 262);
            this.Controls.Add(this.grdUsuario);
            this.Controls.Add(this.tollUsuario);
            this.Name = "frmMantUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Usuario";
            this.tollUsuario.ResumeLayout(false);
            this.tollUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollUsuario;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn coltipo_Usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarioPass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcreadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfechadeCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmodificadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colfechadeModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colActivo;
    }
}