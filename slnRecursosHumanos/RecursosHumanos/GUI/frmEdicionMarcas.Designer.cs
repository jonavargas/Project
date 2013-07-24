namespace RecursosHumanos.GUI
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
            this.grpEdicionMarcas = new System.Windows.Forms.GroupBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.cmbEmpleado = new System.Windows.Forms.ComboBox();
            this.cmbDepartamento = new System.Windows.Forms.ComboBox();
            this.lblEmpleado = new System.Windows.Forms.Label();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdoSalida = new System.Windows.Forms.RadioButton();
            this.rdoEntrada = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpEdicionMarcas.SuspendLayout();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpEdicionMarcas
            // 
            this.grpEdicionMarcas.BackColor = System.Drawing.Color.Transparent;
            this.grpEdicionMarcas.Controls.Add(this.lblEstado);
            this.grpEdicionMarcas.Controls.Add(this.lblDepartamento);
            this.grpEdicionMarcas.Controls.Add(this.cmbEstado);
            this.grpEdicionMarcas.Controls.Add(this.cmbEmpleado);
            this.grpEdicionMarcas.Controls.Add(this.cmbDepartamento);
            this.grpEdicionMarcas.Controls.Add(this.lblEmpleado);
            this.grpEdicionMarcas.Location = new System.Drawing.Point(2, 2);
            this.grpEdicionMarcas.Name = "grpEdicionMarcas";
            this.grpEdicionMarcas.Size = new System.Drawing.Size(432, 142);
            this.grpEdicionMarcas.TabIndex = 14;
            this.grpEdicionMarcas.TabStop = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(21, 107);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 16);
            this.lblEstado.TabIndex = 25;
            this.lblEstado.Text = "Estado:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartamento.Location = new System.Drawing.Point(20, 29);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(97, 16);
            this.lblDepartamento.TabIndex = 24;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(123, 102);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(277, 21);
            this.cmbEstado.TabIndex = 29;
            // 
            // cmbEmpleado
            // 
            this.cmbEmpleado.FormattingEnabled = true;
            this.cmbEmpleado.Location = new System.Drawing.Point(123, 66);
            this.cmbEmpleado.Name = "cmbEmpleado";
            this.cmbEmpleado.Size = new System.Drawing.Size(277, 21);
            this.cmbEmpleado.TabIndex = 28;
            // 
            // cmbDepartamento
            // 
            this.cmbDepartamento.FormattingEnabled = true;
            this.cmbDepartamento.Location = new System.Drawing.Point(123, 32);
            this.cmbDepartamento.Name = "cmbDepartamento";
            this.cmbDepartamento.Size = new System.Drawing.Size(277, 21);
            this.cmbDepartamento.TabIndex = 26;
            // 
            // lblEmpleado
            // 
            this.lblEmpleado.AutoSize = true;
            this.lblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpleado.Location = new System.Drawing.Point(21, 66);
            this.lblEmpleado.Name = "lblEmpleado";
            this.lblEmpleado.Size = new System.Drawing.Size(77, 16);
            this.lblEmpleado.TabIndex = 27;
            this.lblEmpleado.Text = "Empleado: ";
            // 
            // grpTipo
            // 
            this.grpTipo.BackColor = System.Drawing.Color.Transparent;
            this.grpTipo.Controls.Add(this.rdoSalida);
            this.grpTipo.Controls.Add(this.rdoEntrada);
            this.grpTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTipo.ForeColor = System.Drawing.Color.Black;
            this.grpTipo.Location = new System.Drawing.Point(2, 163);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(432, 68);
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
            this.rdoSalida.TabIndex = 1;
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
            this.rdoEntrada.TabIndex = 0;
            this.rdoEntrada.TabStop = true;
            this.rdoEntrada.Text = "Entrada";
            this.rdoEntrada.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(225, 255);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 34);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(125, 255);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(87, 34);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmEdicionMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 321);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpEdicionMarcas);
            this.Name = "frmEdicionMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Marcas";
            this.grpEdicionMarcas.ResumeLayout(false);
            this.grpEdicionMarcas.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpEdicionMarcas;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.ComboBox cmbEmpleado;
        private System.Windows.Forms.ComboBox cmbDepartamento;
        private System.Windows.Forms.Label lblEmpleado;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdoSalida;
        private System.Windows.Forms.RadioButton rdoEntrada;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}