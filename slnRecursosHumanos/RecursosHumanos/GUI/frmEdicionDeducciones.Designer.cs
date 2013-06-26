namespace GUI
{
    partial class frmEdicionDeducciones
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
            this.lblIDDeducciones = new System.Windows.Forms.Label();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblFechaCreacion = new System.Windows.Forms.Label();
            this.lblFechaModificacion = new System.Windows.Forms.Label();
            this.lblCreadorModificacion = new System.Windows.Forms.Label();
            this.lblCreador = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtIdDeducciones = new System.Windows.Forms.TextBox();
            this.txtPorcentaje = new System.Windows.Forms.TextBox();
            this.txtFecha_Creacion = new System.Windows.Forms.TextBox();
            this.txtFecha_Modificacion = new System.Windows.Forms.TextBox();
            this.txtModificado_por = new System.Windows.Forms.TextBox();
            this.txtCreado_por = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblIDDeducciones
            // 
            this.lblIDDeducciones.AutoSize = true;
            this.lblIDDeducciones.Location = new System.Drawing.Point(28, 21);
            this.lblIDDeducciones.Name = "lblIDDeducciones";
            this.lblIDDeducciones.Size = new System.Drawing.Size(88, 13);
            this.lblIDDeducciones.TabIndex = 0;
            this.lblIDDeducciones.Text = "Id Deducciones :";
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(28, 47);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(64, 13);
            this.lblPorcentaje.TabIndex = 1;
            this.lblPorcentaje.Text = "Porcentaje :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(28, 75);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 2;
            this.lblDescripcion.Text = "Descripción :";
            // 
            // lblFechaCreacion
            // 
            this.lblFechaCreacion.AutoSize = true;
            this.lblFechaCreacion.Location = new System.Drawing.Point(28, 354);
            this.lblFechaCreacion.Name = "lblFechaCreacion";
            this.lblFechaCreacion.Size = new System.Drawing.Size(82, 13);
            this.lblFechaCreacion.TabIndex = 3;
            this.lblFechaCreacion.Text = "Fecha Creacion";
            // 
            // lblFechaModificacion
            // 
            this.lblFechaModificacion.AutoSize = true;
            this.lblFechaModificacion.Location = new System.Drawing.Point(28, 384);
            this.lblFechaModificacion.Name = "lblFechaModificacion";
            this.lblFechaModificacion.Size = new System.Drawing.Size(100, 13);
            this.lblFechaModificacion.TabIndex = 4;
            this.lblFechaModificacion.Text = "Fecha Modificacion";
            // 
            // lblCreadorModificacion
            // 
            this.lblCreadorModificacion.AutoSize = true;
            this.lblCreadorModificacion.Location = new System.Drawing.Point(28, 412);
            this.lblCreadorModificacion.Name = "lblCreadorModificacion";
            this.lblCreadorModificacion.Size = new System.Drawing.Size(77, 13);
            this.lblCreadorModificacion.TabIndex = 5;
            this.lblCreadorModificacion.Text = "Modificado por";
            // 
            // lblCreador
            // 
            this.lblCreador.AutoSize = true;
            this.lblCreador.Location = new System.Drawing.Point(28, 441);
            this.lblCreador.Name = "lblCreador";
            this.lblCreador.Size = new System.Drawing.Size(59, 13);
            this.lblCreador.TabIndex = 6;
            this.lblCreador.Text = "Creado por";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(28, 111);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(97, 13);
            this.lblEstado.TabIndex = 7;
            this.lblEstado.Text = "Estado del usuario:";
            // 
            // txtIdDeducciones
            // 
            this.txtIdDeducciones.Location = new System.Drawing.Point(143, 21);
            this.txtIdDeducciones.Name = "txtIdDeducciones";
            this.txtIdDeducciones.Size = new System.Drawing.Size(239, 20);
            this.txtIdDeducciones.TabIndex = 1;
            // 
            // txtPorcentaje
            // 
            this.txtPorcentaje.Location = new System.Drawing.Point(143, 47);
            this.txtPorcentaje.Name = "txtPorcentaje";
            this.txtPorcentaje.Size = new System.Drawing.Size(239, 20);
            this.txtPorcentaje.TabIndex = 2;
            this.txtPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPorcentaje_KeyPress);
            // 
            // txtFecha_Creacion
            // 
            this.txtFecha_Creacion.Location = new System.Drawing.Point(143, 354);
            this.txtFecha_Creacion.Name = "txtFecha_Creacion";
            this.txtFecha_Creacion.Size = new System.Drawing.Size(239, 20);
            this.txtFecha_Creacion.TabIndex = 10;
            // 
            // txtFecha_Modificacion
            // 
            this.txtFecha_Modificacion.Location = new System.Drawing.Point(143, 384);
            this.txtFecha_Modificacion.Name = "txtFecha_Modificacion";
            this.txtFecha_Modificacion.Size = new System.Drawing.Size(239, 20);
            this.txtFecha_Modificacion.TabIndex = 11;
            // 
            // txtModificado_por
            // 
            this.txtModificado_por.Location = new System.Drawing.Point(143, 412);
            this.txtModificado_por.Name = "txtModificado_por";
            this.txtModificado_por.Size = new System.Drawing.Size(239, 20);
            this.txtModificado_por.TabIndex = 12;
            // 
            // txtCreado_por
            // 
            this.txtCreado_por.Location = new System.Drawing.Point(143, 441);
            this.txtCreado_por.Name = "txtCreado_por";
            this.txtCreado_por.Size = new System.Drawing.Size(239, 20);
            this.txtCreado_por.TabIndex = 13;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(143, 74);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(239, 20);
            this.txtDescripcion.TabIndex = 3;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(169, 145);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(260, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(178, 111);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // frmEdicionDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 178);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCreado_por);
            this.Controls.Add(this.txtModificado_por);
            this.Controls.Add(this.txtFecha_Modificacion);
            this.Controls.Add(this.txtFecha_Creacion);
            this.Controls.Add(this.txtPorcentaje);
            this.Controls.Add(this.txtIdDeducciones);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCreador);
            this.Controls.Add(this.lblCreadorModificacion);
            this.Controls.Add(this.lblFechaModificacion);
            this.Controls.Add(this.lblFechaCreacion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.lblIDDeducciones);
            this.Name = "frmEdicionDeducciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Deducciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIDDeducciones;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblFechaCreacion;
        private System.Windows.Forms.Label lblFechaModificacion;
        private System.Windows.Forms.Label lblCreadorModificacion;
        private System.Windows.Forms.Label lblCreador;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtIdDeducciones;
        private System.Windows.Forms.TextBox txtPorcentaje;
        private System.Windows.Forms.TextBox txtFecha_Creacion;
        private System.Windows.Forms.TextBox txtFecha_Modificacion;
        private System.Windows.Forms.TextBox txtModificado_por;
        private System.Windows.Forms.TextBox txtCreado_por;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}