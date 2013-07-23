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
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdoSalida = new System.Windows.Forms.RadioButton();
            this.rdoEntrada = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpInfoEmpleado = new System.Windows.Forms.GroupBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdUnificacion = new System.Windows.Forms.TextBox();
            this.txtIdMarca = new System.Windows.Forms.TextBox();
            this.lblUnificacion = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.grpNumeros = new System.Windows.Forms.GroupBox();
            this.cmbCodigo = new System.Windows.Forms.ComboBox();
            this.grpTipo.SuspendLayout();
            this.grpInfoEmpleado.SuspendLayout();
            this.grpNumeros.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(12, 151);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(128, 16);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado de la Marca:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(12, 114);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 16);
            this.lblDepartamento.TabIndex = 24;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(12, 79);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(151, 16);
            this.lblEmpleado.TabIndex = 27;
            this.lblEmpleado.Text = "Nombre del Empleado: ";
            // 
            // grpTipo
            // 
            this.grpTipo.BackColor = System.Drawing.Color.Transparent;
            this.grpTipo.Controls.Add(this.rdoSalida);
            this.grpTipo.Controls.Add(this.rdoEntrada);
            this.grpTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipo.ForeColor = System.Drawing.Color.Black;
            this.grpTipo.Location = new System.Drawing.Point(23, 379);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(472, 68);
            this.grpTipo.TabIndex = 15;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo de la marca";
            // 
            // rdoSalida
            // 
            this.rdoSalida.AutoSize = true;
            this.rdoSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSalida.ForeColor = System.Drawing.Color.Black;
            this.rdoSalida.Location = new System.Drawing.Point(240, 31);
            this.rdoSalida.Name = "rdoSalida";
            this.rdoSalida.Size = new System.Drawing.Size(65, 20);
            this.rdoSalida.TabIndex = 9;
            this.rdoSalida.TabStop = true;
            this.rdoSalida.Text = "Salida";
            this.rdoSalida.UseVisualStyleBackColor = true;
            // 
            // rdoEntrada
            // 
            this.rdoEntrada.AutoSize = true;
            this.rdoEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoEntrada.ForeColor = System.Drawing.Color.Black;
            this.rdoEntrada.Location = new System.Drawing.Point(123, 31);
            this.rdoEntrada.Name = "rdoEntrada";
            this.rdoEntrada.Size = new System.Drawing.Size(73, 20);
            this.rdoEntrada.TabIndex = 8;
            this.rdoEntrada.TabStop = true;
            this.rdoEntrada.Text = "Entrada";
            this.rdoEntrada.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(228, 469);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 34);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(128, 469);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 34);
            this.btnAceptar.TabIndex = 10;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grpInfoEmpleado
            // 
            this.grpInfoEmpleado.Controls.Add(this.cmbCodigo);
            this.grpInfoEmpleado.Controls.Add(this.cmbEmpleado);
            this.grpInfoEmpleado.Controls.Add(this.cmbEstado);
            this.grpInfoEmpleado.Controls.Add(this.cmbDepartamento);
            this.grpInfoEmpleado.Controls.Add(this.dtpFecha);
            this.grpInfoEmpleado.Controls.Add(this.label5);
            this.grpInfoEmpleado.Controls.Add(this.label3);
            this.grpInfoEmpleado.Controls.Add(this.lblDepartamento);
            this.grpInfoEmpleado.Controls.Add(this.lblEstado);
            this.grpInfoEmpleado.Controls.Add(this.lblEmpleado);
            this.grpInfoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInfoEmpleado.Location = new System.Drawing.Point(8, 128);
            this.grpInfoEmpleado.Name = "grpInfoEmpleado";
            this.grpInfoEmpleado.Size = new System.Drawing.Size(472, 227);
            this.grpInfoEmpleado.TabIndex = 18;
            this.grpInfoEmpleado.TabStop = false;
            this.grpInfoEmpleado.Text = "Información empleado";
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(168, 72);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(275, 24);
            this.cmbEmpleado.TabIndex = 34;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(168, 144);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(277, 24);
            this.cmbEstado.TabIndex = 6;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(169, 107);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(275, 24);
            this.cmbDepartamento.TabIndex = 5;
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy   hh:mm:ss  tt";
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(170, 184);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(276, 22);
            this.dtpFecha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 189);
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
            // txtIdUnificacion
            // 
            this.txtIdUnificacion.Enabled = false;
            this.txtIdUnificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdUnificacion.Location = new System.Drawing.Point(119, 61);
            this.txtIdUnificacion.Name = "txtIdUnificacion";
            this.txtIdUnificacion.Size = new System.Drawing.Size(84, 21);
            this.txtIdUnificacion.TabIndex = 2;
            // 
            // txtIdMarca
            // 
            this.txtIdMarca.Enabled = false;
            this.txtIdMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdMarca.Location = new System.Drawing.Point(119, 29);
            this.txtIdMarca.Name = "txtIdMarca";
            this.txtIdMarca.Size = new System.Drawing.Size(84, 21);
            this.txtIdMarca.TabIndex = 1;
            // 
            // lblUnificacion
            // 
            this.lblUnificacion.AutoSize = true;
            this.lblUnificacion.BackColor = System.Drawing.Color.Transparent;
            this.lblUnificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnificacion.Location = new System.Drawing.Point(8, 64);
            this.lblUnificacion.Name = "lblUnificacion";
            this.lblUnificacion.Size = new System.Drawing.Size(107, 15);
            this.lblUnificacion.TabIndex = 12;
            this.lblUnificacion.Text = "No. unificación:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.BackColor = System.Drawing.Color.Transparent;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.Location = new System.Drawing.Point(8, 32);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(77, 15);
            this.lblMarca.TabIndex = 11;
            this.lblMarca.Text = "No. marca:";
            // 
            // grpNumeros
            // 
            this.grpNumeros.Controls.Add(this.txtIdMarca);
            this.grpNumeros.Controls.Add(this.txtIdUnificacion);
            this.grpNumeros.Controls.Add(this.lblMarca);
            this.grpNumeros.Controls.Add(this.lblUnificacion);
            this.grpNumeros.Location = new System.Drawing.Point(12, 12);
            this.grpNumeros.Name = "grpNumeros";
            this.grpNumeros.Size = new System.Drawing.Size(468, 100);
            this.grpNumeros.TabIndex = 19;
            this.grpNumeros.TabStop = false;
            // 
            // cmbCodigo
            // 
            this.cmbCodigo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodigo.FormattingEnabled = true;
            this.cmbCodigo.Location = new System.Drawing.Point(168, 37);
            this.cmbCodigo.Name = "cmbCodigo";
            this.cmbCodigo.Size = new System.Drawing.Size(275, 24);
            this.cmbCodigo.TabIndex = 35;
            // 
            // frmEdicionMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 515);
            this.Controls.Add(this.grpNumeros);
            this.Controls.Add(this.grpInfoEmpleado);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpTipo);
            this.Name = "frmEdicionMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Marcas";
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.grpInfoEmpleado.ResumeLayout(false);
            this.grpInfoEmpleado.PerformLayout();
            this.grpNumeros.ResumeLayout(false);
            this.grpNumeros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdoSalida;
        private System.Windows.Forms.RadioButton rdoEntrada;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpInfoEmpleado;
        private System.Windows.Forms.TextBox txtIdUnificacion;
        private System.Windows.Forms.TextBox txtIdMarca;
        private System.Windows.Forms.Label lblUnificacion;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.GroupBox grpNumeros;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbCodigo;
    }
}