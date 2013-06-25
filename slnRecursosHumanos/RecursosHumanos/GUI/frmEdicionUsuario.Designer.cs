namespace GUI
{
    partial class frmEdicionUsuario
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
            this.lblidUsuario = new System.Windows.Forms.Label();
            this.lbltipoUsuario = new System.Windows.Forms.Label();
            this.lblpassword = new System.Windows.Forms.Label();
            this.lblfecha_de_Modificacion = new System.Windows.Forms.Label();
            this.lblfecha_de_Creacion = new System.Windows.Forms.Label();
            this.lblcreado_Por = new System.Windows.Forms.Label();
            this.lblmodificado_Por = new System.Windows.Forms.Label();
            this.txtidUsuario = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtfecha_de_Modificacion = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtcreadoPor = new System.Windows.Forms.TextBox();
            this.txtModificadoPor = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblidUsuario
            // 
            this.lblidUsuario.AutoSize = true;
            this.lblidUsuario.Location = new System.Drawing.Point(24, 25);
            this.lblidUsuario.Name = "lblidUsuario";
            this.lblidUsuario.Size = new System.Drawing.Size(61, 13);
            this.lblidUsuario.TabIndex = 0;
            this.lblidUsuario.Text = "Id Usuario :";
            // 
            // lbltipoUsuario
            // 
            this.lbltipoUsuario.AutoSize = true;
            this.lbltipoUsuario.Location = new System.Drawing.Point(24, 60);
            this.lbltipoUsuario.Name = "lbltipoUsuario";
            this.lbltipoUsuario.Size = new System.Drawing.Size(88, 13);
            this.lbltipoUsuario.TabIndex = 1;
            this.lbltipoUsuario.Text = "Tipo de Usuario :";
            // 
            // lblpassword
            // 
            this.lblpassword.AutoSize = true;
            this.lblpassword.Location = new System.Drawing.Point(24, 93);
            this.lblpassword.Name = "lblpassword";
            this.lblpassword.Size = new System.Drawing.Size(59, 13);
            this.lblpassword.TabIndex = 2;
            this.lblpassword.Text = "Password :";
            // 
            // lblfecha_de_Modificacion
            // 
            this.lblfecha_de_Modificacion.AutoSize = true;
            this.lblfecha_de_Modificacion.Location = new System.Drawing.Point(24, 270);
            this.lblfecha_de_Modificacion.Name = "lblfecha_de_Modificacion";
            this.lblfecha_de_Modificacion.Size = new System.Drawing.Size(115, 13);
            this.lblfecha_de_Modificacion.TabIndex = 3;
            this.lblfecha_de_Modificacion.Text = "Fecha de Modificación";
            this.lblfecha_de_Modificacion.Visible = false;
            // 
            // lblfecha_de_Creacion
            // 
            this.lblfecha_de_Creacion.AutoSize = true;
            this.lblfecha_de_Creacion.Location = new System.Drawing.Point(24, 292);
            this.lblfecha_de_Creacion.Name = "lblfecha_de_Creacion";
            this.lblfecha_de_Creacion.Size = new System.Drawing.Size(97, 13);
            this.lblfecha_de_Creacion.TabIndex = 4;
            this.lblfecha_de_Creacion.Text = "Fecha de Creación";
            this.lblfecha_de_Creacion.Visible = false;
            // 
            // lblcreado_Por
            // 
            this.lblcreado_Por.AutoSize = true;
            this.lblcreado_Por.Location = new System.Drawing.Point(24, 314);
            this.lblcreado_Por.Name = "lblcreado_Por";
            this.lblcreado_Por.Size = new System.Drawing.Size(60, 13);
            this.lblcreado_Por.TabIndex = 5;
            this.lblcreado_Por.Text = "Creado Por";
            this.lblcreado_Por.Visible = false;
            // 
            // lblmodificado_Por
            // 
            this.lblmodificado_Por.AutoSize = true;
            this.lblmodificado_Por.Location = new System.Drawing.Point(24, 347);
            this.lblmodificado_Por.Name = "lblmodificado_Por";
            this.lblmodificado_Por.Size = new System.Drawing.Size(78, 13);
            this.lblmodificado_Por.TabIndex = 6;
            this.lblmodificado_Por.Text = "Modificado Por";
            this.lblmodificado_Por.Visible = false;
            // 
            // txtidUsuario
            // 
            this.txtidUsuario.Location = new System.Drawing.Point(114, 18);
            this.txtidUsuario.Name = "txtidUsuario";
            this.txtidUsuario.Size = new System.Drawing.Size(211, 20);
            this.txtidUsuario.TabIndex = 1;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(114, 90);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(211, 20);
            this.txtpassword.TabIndex = 3;
            // 
            // txtfecha_de_Modificacion
            // 
            this.txtfecha_de_Modificacion.Location = new System.Drawing.Point(145, 267);
            this.txtfecha_de_Modificacion.Name = "txtfecha_de_Modificacion";
            this.txtfecha_de_Modificacion.Size = new System.Drawing.Size(211, 20);
            this.txtfecha_de_Modificacion.TabIndex = 10;
            this.txtfecha_de_Modificacion.Visible = false;
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(145, 286);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(211, 20);
            this.txtFechaCreacion.TabIndex = 11;
            this.txtFechaCreacion.Visible = false;
            // 
            // txtcreadoPor
            // 
            this.txtcreadoPor.Location = new System.Drawing.Point(145, 314);
            this.txtcreadoPor.Name = "txtcreadoPor";
            this.txtcreadoPor.Size = new System.Drawing.Size(211, 20);
            this.txtcreadoPor.TabIndex = 13;
            this.txtcreadoPor.Visible = false;
            // 
            // txtModificadoPor
            // 
            this.txtModificadoPor.Location = new System.Drawing.Point(145, 340);
            this.txtModificadoPor.Name = "txtModificadoPor";
            this.txtModificadoPor.Size = new System.Drawing.Size(211, 20);
            this.txtModificadoPor.TabIndex = 15;
            this.txtModificadoPor.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(24, 128);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(97, 13);
            this.lblEstado.TabIndex = 16;
            this.lblEstado.Text = "Estado del usuario:";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(132, 159);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(228, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.AutoCompleteCustomSource.AddRange(new string[] {
            "Supervisor",
            "Regular"});
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Supervisor",
            "Regular"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(114, 51);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(211, 21);
            this.cmbTipoUsuario.TabIndex = 2;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Location = new System.Drawing.Point(151, 127);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 4;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // frmEdicionUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 194);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtModificadoPor);
            this.Controls.Add(this.txtcreadoPor);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtfecha_de_Modificacion);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtidUsuario);
            this.Controls.Add(this.lblmodificado_Por);
            this.Controls.Add(this.lblcreado_Por);
            this.Controls.Add(this.lblfecha_de_Creacion);
            this.Controls.Add(this.lblfecha_de_Modificacion);
            this.Controls.Add(this.lblpassword);
            this.Controls.Add(this.lbltipoUsuario);
            this.Controls.Add(this.lblidUsuario);
            this.Name = "frmEdicionUsuario";
            this.Text = "Edición Usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblidUsuario;
        private System.Windows.Forms.Label lbltipoUsuario;
        private System.Windows.Forms.Label lblpassword;
        private System.Windows.Forms.Label lblfecha_de_Modificacion;
        private System.Windows.Forms.Label lblfecha_de_Creacion;
        private System.Windows.Forms.Label lblcreado_Por;
        private System.Windows.Forms.Label lblmodificado_Por;
        private System.Windows.Forms.TextBox txtidUsuario;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtfecha_de_Modificacion;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtcreadoPor;
        private System.Windows.Forms.TextBox txtModificadoPor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}