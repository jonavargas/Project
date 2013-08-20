namespace GUI
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.Mantenimientos = new System.Windows.Forms.ToolStripMenuItem();
            this.catalogoFechasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parametroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegistroMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.IngresoMarcas = new System.Windows.Forms.ToolStripMenuItem();
            this.Procesos = new System.Windows.Forms.ToolStripMenuItem();
            this.CrearUnificacion = new System.Windows.Forms.ToolStripMenuItem();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.lblSesion = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNombreUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuPrincipal.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Font = new System.Drawing.Font("Centaur", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mantenimientos,
            this.RegistroMarcas,
            this.Procesos});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(747, 29);
            this.mnuPrincipal.TabIndex = 0;
            // 
            // Mantenimientos
            // 
            this.Mantenimientos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogoFechasToolStripMenuItem,
            this.deduccionesToolStripMenuItem,
            this.departamentoToolStripMenuItem,
            this.parametroToolStripMenuItem,
            this.usuarioToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.maToolStripMenuItem});
            this.Mantenimientos.Name = "Mantenimientos";
            this.Mantenimientos.Size = new System.Drawing.Size(151, 25);
            this.Mantenimientos.Text = "Mantenimientos";
            // 
            // catalogoFechasToolStripMenuItem
            // 
            this.catalogoFechasToolStripMenuItem.Name = "catalogoFechasToolStripMenuItem";
            this.catalogoFechasToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.catalogoFechasToolStripMenuItem.Text = "Catalogo Fechas";
            this.catalogoFechasToolStripMenuItem.Click += new System.EventHandler(this.catalogoFechasToolStripMenuItem_Click);
            // 
            // deduccionesToolStripMenuItem
            // 
            this.deduccionesToolStripMenuItem.Name = "deduccionesToolStripMenuItem";
            this.deduccionesToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.deduccionesToolStripMenuItem.Text = "Deducciones";
            this.deduccionesToolStripMenuItem.Click += new System.EventHandler(this.deduccionesToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // parametroToolStripMenuItem
            // 
            this.parametroToolStripMenuItem.Name = "parametroToolStripMenuItem";
            this.parametroToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.parametroToolStripMenuItem.Text = "Parámetro";
            this.parametroToolStripMenuItem.Click += new System.EventHandler(this.parametroToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // maToolStripMenuItem
            // 
            this.maToolStripMenuItem.Name = "maToolStripMenuItem";
            this.maToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.maToolStripMenuItem.Text = "Consultar Marcas";
            this.maToolStripMenuItem.Click += new System.EventHandler(this.maToolStripMenuItem_Click);
            // 
            // RegistroMarcas
            // 
            this.RegistroMarcas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.IngresoMarcas});
            this.RegistroMarcas.Name = "RegistroMarcas";
            this.RegistroMarcas.Size = new System.Drawing.Size(78, 25);
            this.RegistroMarcas.Text = "Marcas";
            // 
            // IngresoMarcas
            // 
            this.IngresoMarcas.Name = "IngresoMarcas";
            this.IngresoMarcas.Size = new System.Drawing.Size(224, 26);
            this.IngresoMarcas.Text = "Ingreso de Marcas";
            this.IngresoMarcas.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // Procesos
            // 
            this.Procesos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CrearUnificacion,
            this.pagosToolStripMenuItem});
            this.Procesos.Name = "Procesos";
            this.Procesos.Size = new System.Drawing.Size(90, 25);
            this.Procesos.Text = "Procesos";
            // 
            // CrearUnificacion
            // 
            this.CrearUnificacion.Name = "CrearUnificacion";
            this.CrearUnificacion.Size = new System.Drawing.Size(174, 26);
            this.CrearUnificacion.Text = "Unificación";
            this.CrearUnificacion.Click += new System.EventHandler(this.CrearUnificacion_Click);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.pagosToolStripMenuItem.Text = "Pagos";
            this.pagosToolStripMenuItem.Click += new System.EventHandler(this.pagosToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSesion,
            this.lblNombreUsuario});
            this.statusBar.Location = new System.Drawing.Point(0, 367);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(747, 22);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // lblSesion
            // 
            this.lblSesion.Name = "lblSesion";
            this.lblSesion.Size = new System.Drawing.Size(85, 17);
            this.lblSesion.Text = "Usuario actual:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 389);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem Mantenimientos;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deduccionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catalogoFechasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parametroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel lblSesion;
        private System.Windows.Forms.ToolStripStatusLabel lblNombreUsuario;
        private System.Windows.Forms.ToolStripMenuItem RegistroMarcas;
        private System.Windows.Forms.ToolStripMenuItem IngresoMarcas;
        private System.Windows.Forms.ToolStripMenuItem maToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Procesos;
        private System.Windows.Forms.ToolStripMenuItem CrearUnificacion;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
    }
}

