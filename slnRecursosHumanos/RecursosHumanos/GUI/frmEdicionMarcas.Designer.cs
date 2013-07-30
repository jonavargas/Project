namespace GUI
{
    partial class frmEdicionMarcas
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
            this.grpInfoEmpleado = new System.Windows.Forms.GroupBox();
            this.txtEstadoMarca = new System.Windows.Forms.TextBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdoSalida = new System.Windows.Forms.RadioButton();
            this.rdoEntrada = new System.Windows.Forms.RadioButton();
            this.txtNumUnificacion = new System.Windows.Forms.TextBox();
            this.txtNumMarca = new System.Windows.Forms.TextBox();
            this.lblNumUnificacion = new System.Windows.Forms.Label();
            this.lblNumMarca = new System.Windows.Forms.Label();
            this.grpInfoEmpleado.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpInfoEmpleado
            // 
            this.grpInfoEmpleado.Controls.Add(this.txtEstadoMarca);
            this.grpInfoEmpleado.Controls.Add(this.cmbCodigo);
            this.grpInfoEmpleado.Controls.Add(this.dtpFecha);
            this.grpInfoEmpleado.Controls.Add(this.label5);
            this.grpInfoEmpleado.Controls.Add(this.label3);
            this.grpInfoEmpleado.Controls.Add(this.lblEstado);
            this.grpInfoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoEmpleado.Location = new System.Drawing.Point(9, 28);
            this.grpInfoEmpleado.Name = "grpInfoEmpleado";
            this.grpInfoEmpleado.Size = new System.Drawing.Size(472, 168);
            this.grpInfoEmpleado.TabIndex = 22;
            this.grpInfoEmpleado.TabStop = false;
            this.grpInfoEmpleado.Text = "Información empleado";
            // 
            // txtEstadoMarca
            // 
            this.txtEstadoMarca.Location = new System.Drawing.Point(168, 80);
            this.txtEstadoMarca.Name = "txtEstadoMarca";
            this.txtEstadoMarca.Size = new System.Drawing.Size(275, 22);
            this.txtEstadoMarca.TabIndex = 2;
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(168, 37);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(275, 24);
            this.cmbCodigo.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy   hh:mm:ss  tt";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(169, 127);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(276, 22);
            this.dtpFecha.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 16);
            this.label5.TabIndex = 33;
            this.label5.Text = "Fecha de la Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 16);
            this.label3.TabIndex = 31;
            this.label3.Text = "Código Empleado:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(12, 85);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(128, 16);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado de la Marca:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(248, 300);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 34);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(120, 300);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 34);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grpTipo
            // 
            this.grpTipo.BackColor = System.Drawing.Color.Transparent;
            this.grpTipo.Controls.Add(this.rdoSalida);
            this.grpTipo.Controls.Add(this.rdoEntrada);
            this.grpTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipo.ForeColor = System.Drawing.Color.Black;
            this.grpTipo.Location = new System.Drawing.Point(9, 213);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(472, 68);
            this.grpTipo.TabIndex = 21;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo de la marca";
            // 
            // rdoSalida
            // 
            this.rdoSalida.AutoSize = true;
            this.rdoSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSalida.ForeColor = System.Drawing.Color.Black;
            this.rdoSalida.Location = new System.Drawing.Point(267, 31);
            this.rdoSalida.Name = "rdoSalida";
            this.rdoSalida.Size = new System.Drawing.Size(65, 20);
            this.rdoSalida.TabIndex = 5;
            this.rdoSalida.TabStop = true;
            this.rdoSalida.Text = "Salida";
            this.rdoSalida.UseVisualStyleBackColor = true;
            // 
            // rdoEntrada
            // 
            this.rdoEntrada.AutoSize = true;
            this.rdoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEntrada.ForeColor = System.Drawing.Color.Black;
            this.rdoEntrada.Location = new System.Drawing.Point(113, 31);
            this.rdoEntrada.Name = "rdoEntrada";
            this.rdoEntrada.Size = new System.Drawing.Size(73, 20);
            this.rdoEntrada.TabIndex = 4;
            this.rdoEntrada.TabStop = true;
            this.rdoEntrada.Text = "Entrada";
            this.rdoEntrada.UseVisualStyleBackColor = true;
            // 
            // txtNumUnificacion
            // 
            this.txtNumUnificacion.Location = new System.Drawing.Point(501, 155);
            this.txtNumUnificacion.Name = "txtNumUnificacion";
            this.txtNumUnificacion.Size = new System.Drawing.Size(82, 20);
            this.txtNumUnificacion.TabIndex = 30;
            // 
            // txtNumMarca
            // 
            this.txtNumMarca.Location = new System.Drawing.Point(501, 91);
            this.txtNumMarca.Name = "txtNumMarca";
            this.txtNumMarca.Size = new System.Drawing.Size(82, 20);
            this.txtNumMarca.TabIndex = 29;
            // 
            // lblNumUnificacion
            // 
            this.lblNumUnificacion.AutoSize = true;
            this.lblNumUnificacion.Location = new System.Drawing.Point(498, 126);
            this.lblNumUnificacion.Name = "lblNumUnificacion";
            this.lblNumUnificacion.Size = new System.Drawing.Size(88, 13);
            this.lblNumUnificacion.TabIndex = 28;
            this.lblNumUnificacion.Text = "Num Unificación:";
            // 
            // lblNumMarca
            // 
            this.lblNumMarca.AutoSize = true;
            this.lblNumMarca.Location = new System.Drawing.Point(498, 65);
            this.lblNumMarca.Name = "lblNumMarca";
            this.lblNumMarca.Size = new System.Drawing.Size(65, 13);
            this.lblNumMarca.TabIndex = 27;
            this.lblNumMarca.Text = "Num Marca:";
            // 
            // frmEdicionMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 355);
            this.Controls.Add(this.txtNumUnificacion);
            this.Controls.Add(this.txtNumMarca);
            this.Controls.Add(this.lblNumUnificacion);
            this.Controls.Add(this.lblNumMarca);
            this.Controls.Add(this.grpInfoEmpleado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpTipo);
            this.Name = "frmEdicionMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Marcas";
            this.grpInfoEmpleado.ResumeLayout(false);
            this.grpInfoEmpleado.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpInfoEmpleado;
        private System.Windows.Forms.ComboBox cmbCodigo;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdoSalida;
        private System.Windows.Forms.RadioButton rdoEntrada;
        private System.Windows.Forms.TextBox txtNumUnificacion;
        private System.Windows.Forms.TextBox txtNumMarca;
        private System.Windows.Forms.Label lblNumUnificacion;
        private System.Windows.Forms.Label lblNumMarca;
        private System.Windows.Forms.TextBox txtEstadoMarca;

    }
}