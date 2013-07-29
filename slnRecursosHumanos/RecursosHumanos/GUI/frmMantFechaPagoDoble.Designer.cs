namespace RecursosHumanos.GUI
{
    partial class frmMantFechaPagoDoble
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
            this.tollFechasDobles = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnBorrar = new System.Windows.Forms.ToolStripButton();
            this.btnRefrescar = new System.Windows.Forms.ToolStripButton();
            this.grdFechasDobles = new System.Windows.Forms.DataGridView();
            this.Día = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleFechasPagoDoble = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.creadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modificadoPor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaModificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tollFechasDobles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFechasDobles)).BeginInit();
            this.SuspendLayout();
            // 
            // tollFechasDobles
            // 
            this.tollFechasDobles.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tollFechasDobles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnEditar,
            this.btnBorrar,
            this.btnRefrescar});
            this.tollFechasDobles.Location = new System.Drawing.Point(0, 0);
            this.tollFechasDobles.Name = "tollFechasDobles";
            this.tollFechasDobles.Size = new System.Drawing.Size(846, 52);
            this.tollFechasDobles.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = global::RecursosHumanos.Properties.Resources.nuevo;
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 49);
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNuevo.ToolTipText = "Permite crear un nuevo empleado";
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::RecursosHumanos.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 49);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.ToolTipText = "Permite editar un empleado seleccionado";
            // 
            // btnBorrar
            // 
            this.btnBorrar.Image = global::RecursosHumanos.Properties.Resources.borrar;
            this.btnBorrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(43, 49);
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBorrar.ToolTipText = "Permite borrar un empleado";
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = global::RecursosHumanos.Properties.Resources.actualizar;
            this.btnRefrescar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(59, 49);
            this.btnRefrescar.Text = "Refrescar";
            this.btnRefrescar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefrescar.ToolTipText = "Actualiza los cambios en los empleados realizados";
            // 
            // grdFechasDobles
            // 
            this.grdFechasDobles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFechasDobles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Día,
            this.Mes,
            this.DetalleFechasPagoDoble,
            this.creadoPor,
            this.fechaCreacion,
            this.modificadoPor,
            this.fechaModificacion});
            this.grdFechasDobles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdFechasDobles.Location = new System.Drawing.Point(0, 52);
            this.grdFechasDobles.Name = "grdFechasDobles";
            this.grdFechasDobles.Size = new System.Drawing.Size(846, 210);
            this.grdFechasDobles.TabIndex = 4;
            // 
            // Día
            // 
            this.Día.DataPropertyName = "dia";
            this.Día.HeaderText = "Día";
            this.Día.Name = "Día";
            this.Día.Width = 50;
            // 
            // Mes
            // 
            this.Mes.DataPropertyName = "mes";
            this.Mes.HeaderText = "Mes";
            this.Mes.Name = "Mes";
            this.Mes.Width = 90;
            // 
            // DetalleFechasPagoDoble
            // 
            this.DetalleFechasPagoDoble.DataPropertyName = "descripcionFechaDoble";
            this.DetalleFechasPagoDoble.HeaderText = "Detalle Fechas de Pago Doble";
            this.DetalleFechasPagoDoble.Name = "DetalleFechasPagoDoble";
            this.DetalleFechasPagoDoble.Width = 200;
            // 
            // creadoPor
            // 
            this.creadoPor.DataPropertyName = "creadoPor";
            this.creadoPor.HeaderText = "Creado Por";
            this.creadoPor.Name = "creadoPor";
            // 
            // fechaCreacion
            // 
            this.fechaCreacion.DataPropertyName = "fechaCreacion";
            this.fechaCreacion.HeaderText = "Fecha Creación";
            this.fechaCreacion.Name = "fechaCreacion";
            this.fechaCreacion.Width = 125;
            // 
            // modificadoPor
            // 
            this.modificadoPor.DataPropertyName = "modificadoPor";
            this.modificadoPor.HeaderText = "Modificado Por";
            this.modificadoPor.Name = "modificadoPor";
            // 
            // fechaModificacion
            // 
            this.fechaModificacion.DataPropertyName = "fechaModificacion";
            this.fechaModificacion.HeaderText = "Fecha Modificación";
            this.fechaModificacion.Name = "fechaModificacion";
            this.fechaModificacion.Width = 125;
            // 
            // frmMantFechaPagoDoble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 262);
            this.Controls.Add(this.grdFechasDobles);
            this.Controls.Add(this.tollFechasDobles);
            this.Name = "frmMantFechaPagoDoble";
            this.Text = "Mantenimiento Fechas de Pago Doble";
            this.tollFechasDobles.ResumeLayout(false);
            this.tollFechasDobles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFechasDobles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tollFechasDobles;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnBorrar;
        private System.Windows.Forms.ToolStripButton btnRefrescar;
        private System.Windows.Forms.DataGridView grdFechasDobles;
        private System.Windows.Forms.DataGridViewTextBoxColumn Día;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn DetalleFechasPagoDoble;
        private System.Windows.Forms.DataGridViewTextBoxColumn creadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn modificadoPor;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaModificacion;
    }
}