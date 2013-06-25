namespace  GUI
{
    partial class frmMantParametro
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
            this.tollParametro = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdParametro = new System.Windows.Forms.DataGridView();
            this.idParametro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEntrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lunes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.martes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miercoles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jueves = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viernes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sabado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domingo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollParametro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParametro)).BeginInit();
            this.SuspendLayout();
            // 
            // tollParametro
            // 
            this.tollParametro.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tollParametro.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBorrar,
            this.btnRefrescar});
            this.tollParametro.Location = new System.Drawing.Point(0, 0);
            this.tollParametro.Name = "tollParametro";
            this.tollParametro.Size = new System.Drawing.Size(978, 52);
            this.tollParametro.TabIndex = 0;
            this.tollParametro.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::RecursosHumanos.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 49);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.ToolTipText = "Genera un nuevo Parametro";
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
            this.btnEditar.ToolTipText = "Edita un parametro ya existente";
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
            this.btnBorrar.ToolTipText = "Borrar un parametro Existente";
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
            // grdParametro
            // 
            this.grdParametro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdParametro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idParametro,
            this.horaEntrada,
            this.horaSalida,
            this.lunes,
            this.martes,
            this.miercoles,
            this.Jueves,
            this.viernes,
            this.sabado,
            this.domingo,
            this.fechaModificacion,
            this.fechaCreacion,
            this.creadoPor,
            this.modificadoPor,
            this.activo});
            this.grdParametro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdParametro.Location = new System.Drawing.Point(0, 52);
            this.grdParametro.Name = "grdParametro";
            this.grdParametro.Size = new System.Drawing.Size(978, 210);
            this.grdParametro.TabIndex = 1;
            // 
            // idParametro
            // 
            this.idParametro.DataPropertyName = "idParametro";
            this.idParametro.HeaderText = "Id Parametro";
            this.idParametro.Name = "idParametro";
            // 
            // horaEntrada
            // 
            this.horaEntrada.DataPropertyName = "horaEntrada";
            this.horaEntrada.HeaderText = "Hora Entrada";
            this.horaEntrada.Name = "horaEntrada";
            // 
            // horaSalida
            // 
            this.horaSalida.DataPropertyName = "horaSalida";
            this.horaSalida.HeaderText = "Hora Salida";
            this.horaSalida.Name = "horaSalida";
            // 
            // lunes
            // 
            this.lunes.DataPropertyName = "lunes";
            this.lunes.HeaderText = "Lunes";
            this.lunes.Name = "lunes";
            this.lunes.Width = 70;
            // 
            // martes
            // 
            this.martes.DataPropertyName = "martes";
            this.martes.HeaderText = "Martes";
            this.martes.Name = "martes";
            this.martes.Width = 70;
            // 
            // miercoles
            // 
            this.miercoles.DataPropertyName = "miercoles";
            this.miercoles.HeaderText = "Miércoles";
            this.miercoles.Name = "miercoles";
            this.miercoles.Width = 70;
            // 
            // Jueves
            // 
            this.Jueves.DataPropertyName = "jueves";
            this.Jueves.HeaderText = "Jueves";
            this.Jueves.Name = "Jueves";
            this.Jueves.Width = 70;
            // 
            // viernes
            // 
            this.viernes.DataPropertyName = "viernes";
            this.viernes.HeaderText = "Viernes";
            this.viernes.Name = "viernes";
            this.viernes.Width = 70;
            // 
            // sabado
            // 
            this.sabado.DataPropertyName = "sabado";
            this.sabado.HeaderText = "Sábado";
            this.sabado.Name = "sabado";
            this.sabado.Width = 70;
            // 
            // domingo
            // 
            this.domingo.DataPropertyName = "domingo";
            this.domingo.HeaderText = "Domingo";
            this.domingo.Name = "domingo";
            this.domingo.Width = 70;
            // 
            // fechaModificacion
            // 
            this.fechaModificacion.DataPropertyName = "fechaModificacion";
            this.fechaModificacion.HeaderText = "Fecha Modificación";
            this.fechaModificacion.Name = "fechaModificacion";
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.DataPropertyName = "fechaCreacion";
            this.fechaCreacion.HeaderText = "Fecha Creación";
            this.fechaCreacion.Name = "fechaCreacion";
            // 
            // creadoPor
            // 
            this.creadoPor.DataPropertyName = "creadoPor";
            this.creadoPor.HeaderText = "Creado Por";
            this.creadoPor.Name = "creadoPor";
            // 
            // modificadoPor
            // 
            this.modificadoPor.DataPropertyName = "modificadoPor";
            this.modificadoPor.HeaderText = "Modificado Por";
            this.modificadoPor.Name = "modificadoPor";
            // 
            // activo
            // 
            this.activo.DataPropertyName = "activo";
            this.activo.HeaderText = "Activo";
            this.activo.Name = "activo";
            // 
            // frmMantParametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 262);
            this.Controls.Add(this.grdParametro);
            this.Controls.Add(this.tollParametro);
            this.Name = "frmMantParametro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Parámetro";
            this.tollParametro.ResumeLayout(false);
            this.tollParametro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdParametro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollParametro;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdParametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn idParametro;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEntrada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSalida;
        private System.Windows.Forms.DataGridViewTextBoxColumn lunes;
        private System.Windows.Forms.DataGridViewTextBoxColumn martes;
        private System.Windows.Forms.DataGridViewTextBoxColumn miercoles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jueves;
        private System.Windows.Forms.DataGridViewTextBoxColumn viernes;
        private System.Windows.Forms.DataGridViewTextBoxColumn sabado;
        private System.Windows.Forms.DataGridViewTextBoxColumn domingo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn activo;
    }
}