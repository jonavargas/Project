namespace GUI
{
    partial class frmLogin
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.pctPassword = new System.Windows.Forms.PictureBox();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(161, 114);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(55, 114);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(83, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Iniciar Sesión";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.pctPassword);
            this.grpLogin.Controls.Add(this.pctUsuario);
            this.grpLogin.Controls.Add(this.txtClave);
            this.grpLogin.Controls.Add(this.txtLogin);
            this.grpLogin.Controls.Add(this.lblClave);
            this.grpLogin.Controls.Add(this.lblLogin);
            this.grpLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpLogin.Location = new System.Drawing.Point(0, 0);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(299, 108);
            this.grpLogin.TabIndex = 3;
            this.grpLogin.TabStop = false;
            // 
            // pctPassword
            // 
            this.pctPassword.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pctPassword.Image = global::RecursosHumanos.Properties.Resources.password;
            this.pctPassword.Location = new System.Drawing.Point(24, 61);
            this.pctPassword.Name = "pctPassword";
            this.pctPassword.Size = new System.Drawing.Size(30, 30);
            this.pctPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPassword.TabIndex = 5;
            this.pctPassword.TabStop = false;
            // 
            // pctUsuario
            // 
            this.pctUsuario.Image = global::RecursosHumanos.Properties.Resources.usuario;
            this.pctUsuario.Location = new System.Drawing.Point(24, 25);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(30, 30);
            this.pctUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctUsuario.TabIndex = 4;
            this.pctUsuario.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(131, 69);
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(142, 20);
            this.txtClave.TabIndex = 3;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(131, 29);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(142, 20);
            this.txtLogin.TabIndex = 2;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(61, 72);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(64, 13);
            this.lblClave.TabIndex = 1;
            this.lblClave.Text = "Contraseña:";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(61, 32);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(46, 13);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Usuario:";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 149);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpLogin);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.PictureBox pctPassword;
        private System.Windows.Forms.PictureBox pctUsuario;
    }
}