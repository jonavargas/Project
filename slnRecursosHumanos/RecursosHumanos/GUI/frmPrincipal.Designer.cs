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
            this.mnuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Font = new System.Drawing.Font("Centaur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Mantenimientos});
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.Size = new System.Drawing.Size(574, 26);
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
            this.empleadoToolStripMenuItem});
            this.Mantenimientos.Name = "Mantenimientos";
            this.Mantenimientos.Size = new System.Drawing.Size(128, 22);
            this.Mantenimientos.Text = "Mantenimientos";
            // 
            // catalogoFechasToolStripMenuItem
            // 
            this.catalogoFechasToolStripMenuItem.Name = "catalogoFechasToolStripMenuItem";
            this.catalogoFechasToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.catalogoFechasToolStripMenuItem.Text = "Catalogo Fechas";
            this.catalogoFechasToolStripMenuItem.Click += new System.EventHandler(this.catalogoFechasToolStripMenuItem_Click);
            // 
            // deduccionesToolStripMenuItem
            // 
            this.deduccionesToolStripMenuItem.Name = "deduccionesToolStripMenuItem";
            this.deduccionesToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.deduccionesToolStripMenuItem.Text = "Deducciones";
            this.deduccionesToolStripMenuItem.Click += new System.EventHandler(this.deduccionesToolStripMenuItem_Click);
            // 
            // departamentoToolStripMenuItem
            // 
            this.departamentoToolStripMenuItem.Name = "departamentoToolStripMenuItem";
            this.departamentoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.departamentoToolStripMenuItem.Text = "Departamento";
            this.departamentoToolStripMenuItem.Click += new System.EventHandler(this.departamentoToolStripMenuItem_Click);
            // 
            // parametroToolStripMenuItem
            // 
            this.parametroToolStripMenuItem.Name = "parametroToolStripMenuItem";
            this.parametroToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.parametroToolStripMenuItem.Text = "Parametro";
            this.parametroToolStripMenuItem.Click += new System.EventHandler(this.parametroToolStripMenuItem_Click);
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            this.usuarioToolStripMenuItem.Click += new System.EventHandler(this.usuarioToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 271);
            this.Controls.Add(this.mnuPrincipal);
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
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
    }
}

