namespace GUI
{
    partial class frmEdicionDepartamento
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
            this.grpDepartamento = new System.Windows.Forms.GroupBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNombreDepa = new System.Windows.Forms.TextBox();
            this.txtIdDepartamento = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNombreDepa = new System.Windows.Forms.Label();
            this.grpDepartamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(198, 159);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(86, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(108, 159);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(84, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // grpDepartamento
            // 
            this.grpDepartamento.Controls.Add(this.chkActivo);
            this.grpDepartamento.Controls.Add(this.lblEstado);
            this.grpDepartamento.Controls.Add(this.txtNombreDepa);
            this.grpDepartamento.Controls.Add(this.txtIdDepartamento);
            this.grpDepartamento.Controls.Add(this.lblNombre);
            this.grpDepartamento.Controls.Add(this.lblNombreDepa);
            this.grpDepartamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDepartamento.Location = new System.Drawing.Point(0, 0);
            this.grpDepartamento.Name = "grpDepartamento";
            this.grpDepartamento.Size = new System.Drawing.Size(402, 131);
            this.grpDepartamento.TabIndex = 3;
            this.grpDepartamento.TabStop = false;
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(198, 100);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 3;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(40, 100);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(97, 13);
            this.lblEstado.TabIndex = 3;
            this.lblEstado.Text = "Estado del usuario:";
            // 
            // txtNombreDepa
            // 
            this.txtNombreDepa.Location = new System.Drawing.Point(165, 66);
            this.txtNombreDepa.Name = "txtNombreDepa";
            this.txtNombreDepa.Size = new System.Drawing.Size(185, 20);
            this.txtNombreDepa.TabIndex = 2;
            // 
            // txtIdDepartamento
            // 
            this.txtIdDepartamento.Location = new System.Drawing.Point(165, 28);
            this.txtIdDepartamento.Name = "txtIdDepartamento";
            this.txtIdDepartamento.Size = new System.Drawing.Size(185, 20);
            this.txtIdDepartamento.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 69);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(117, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Departamento:";
            // 
            // lblNombreDepa
            // 
            this.lblNombreDepa.AutoSize = true;
            this.lblNombreDepa.Location = new System.Drawing.Point(37, 31);
            this.lblNombreDepa.Name = "lblNombreDepa";
            this.lblNombreDepa.Size = new System.Drawing.Size(89, 13);
            this.lblNombreDepa.TabIndex = 0;
            this.lblNombreDepa.Text = "Id Departamento:";
            // 
            // frmEdicionDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 194);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grpDepartamento);
            this.Name = "frmEdicionDepartamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Departamento";
            this.grpDepartamento.ResumeLayout(false);
            this.grpDepartamento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox grpDepartamento;
        private System.Windows.Forms.TextBox txtNombreDepa;
        private System.Windows.Forms.TextBox txtIdDepartamento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNombreDepa;
        private System.Windows.Forms.CheckBox chkActivo;
        private System.Windows.Forms.Label lblEstado;
    }
}