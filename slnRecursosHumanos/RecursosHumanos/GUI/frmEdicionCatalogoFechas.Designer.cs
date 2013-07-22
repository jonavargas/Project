namespace GUI
{
    partial class frmEdicionCatalogoFechas
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
            this.lblid_CatalogoFechas = new System.Windows.Forms.Label();
            this.lbldia = new System.Windows.Forms.Label();
            this.lblmes = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblfecha_de_Modificacion = new System.Windows.Forms.Label();
            this.lblfecha_de_Creacion = new System.Windows.Forms.Label();
            this.lblcreado_Por = new System.Windows.Forms.Label();
            this.lblmodificado_Por = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtCatalogoFechas = new System.Windows.Forms.TextBox();
            this.txtFechaModificacion = new System.Windows.Forms.TextBox();
            this.txtCreadopor = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtModificadopor = new System.Windows.Forms.TextBox();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbDia = new System.Windows.Forms.ComboBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.chkActivo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblid_CatalogoFechas
            // 
            this.lblid_CatalogoFechas.AutoSize = true;
            this.lblid_CatalogoFechas.Location = new System.Drawing.Point(23, 21);
            this.lblid_CatalogoFechas.Name = "lblid_CatalogoFechas";
            this.lblid_CatalogoFechas.Size = new System.Drawing.Size(105, 13);
            this.lblid_CatalogoFechas.TabIndex = 0;
            this.lblid_CatalogoFechas.Text = "Id Catalogo Fechas :";
            // 
            // lbldia
            // 
            this.lbldia.AutoSize = true;
            this.lbldia.Location = new System.Drawing.Point(23, 74);
            this.lbldia.Name = "lbldia";
            this.lbldia.Size = new System.Drawing.Size(31, 13);
            this.lbldia.TabIndex = 1;
            this.lbldia.Text = "Día :";
            // 
            // lblmes
            // 
            this.lblmes.AutoSize = true;
            this.lblmes.Location = new System.Drawing.Point(23, 47);
            this.lblmes.Name = "lblmes";
            this.lblmes.Size = new System.Drawing.Size(33, 13);
            this.lblmes.TabIndex = 2;
            this.lblmes.Text = "Mes :";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(23, 105);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(69, 13);
            this.lblDescripcion.TabIndex = 3;
            this.lblDescripcion.Text = "Descripción :";
            // 
            // lblfecha_de_Modificacion
            // 
            this.lblfecha_de_Modificacion.AutoSize = true;
            this.lblfecha_de_Modificacion.Location = new System.Drawing.Point(50, 308);
            this.lblfecha_de_Modificacion.Name = "lblfecha_de_Modificacion";
            this.lblfecha_de_Modificacion.Size = new System.Drawing.Size(115, 13);
            this.lblfecha_de_Modificacion.TabIndex = 4;
            this.lblfecha_de_Modificacion.Text = "Fecha de Modificación";
            this.lblfecha_de_Modificacion.Visible = false;
            // 
            // lblfecha_de_Creacion
            // 
            this.lblfecha_de_Creacion.AutoSize = true;
            this.lblfecha_de_Creacion.Location = new System.Drawing.Point(50, 335);
            this.lblfecha_de_Creacion.Name = "lblfecha_de_Creacion";
            this.lblfecha_de_Creacion.Size = new System.Drawing.Size(97, 13);
            this.lblfecha_de_Creacion.TabIndex = 5;
            this.lblfecha_de_Creacion.Text = "Fecha de Creación";
            this.lblfecha_de_Creacion.Visible = false;
            // 
            // lblcreado_Por
            // 
            this.lblcreado_Por.AutoSize = true;
            this.lblcreado_Por.Location = new System.Drawing.Point(50, 364);
            this.lblcreado_Por.Name = "lblcreado_Por";
            this.lblcreado_Por.Size = new System.Drawing.Size(60, 13);
            this.lblcreado_Por.TabIndex = 6;
            this.lblcreado_Por.Text = "Creado Por";
            this.lblcreado_Por.Visible = false;
            // 
            // lblmodificado_Por
            // 
            this.lblmodificado_Por.AutoSize = true;
            this.lblmodificado_Por.Location = new System.Drawing.Point(50, 391);
            this.lblmodificado_Por.Name = "lblmodificado_Por";
            this.lblmodificado_Por.Size = new System.Drawing.Size(78, 13);
            this.lblmodificado_Por.TabIndex = 7;
            this.lblmodificado_Por.Text = "Modificado Por";
            this.lblmodificado_Por.Visible = false;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(23, 133);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(97, 13);
            this.lblEstado.TabIndex = 8;
            this.lblEstado.Text = "Estado del usuario:";
            // 
            // txtCatalogoFechas
            // 
            this.txtCatalogoFechas.Location = new System.Drawing.Point(139, 18);
            this.txtCatalogoFechas.Name = "txtCatalogoFechas";
            this.txtCatalogoFechas.Size = new System.Drawing.Size(218, 20);
            this.txtCatalogoFechas.TabIndex = 1;
            // 
            // txtFechaModificacion
            // 
            this.txtFechaModificacion.Location = new System.Drawing.Point(166, 303);
            this.txtFechaModificacion.Name = "txtFechaModificacion";
            this.txtFechaModificacion.Size = new System.Drawing.Size(218, 20);
            this.txtFechaModificacion.TabIndex = 10;
            this.txtFechaModificacion.Visible = false;
            // 
            // txtCreadopor
            // 
            this.txtCreadopor.Location = new System.Drawing.Point(166, 358);
            this.txtCreadopor.Name = "txtCreadopor";
            this.txtCreadopor.Size = new System.Drawing.Size(218, 20);
            this.txtCreadopor.TabIndex = 12;
            this.txtCreadopor.Visible = false;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(139, 98);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(218, 20);
            this.txtDescripcion.TabIndex = 4;
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(166, 332);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(218, 20);
            this.txtFechaCreacion.TabIndex = 15;
            this.txtFechaCreacion.Visible = false;
            // 
            // txtModificadopor
            // 
            this.txtModificadopor.Location = new System.Drawing.Point(166, 384);
            this.txtModificadopor.Name = "txtModificadopor";
            this.txtModificadopor.Size = new System.Drawing.Size(218, 20);
            this.txtModificadopor.TabIndex = 16;
            this.txtModificadopor.Visible = false;
            // 
            // txtActivo
            // 
            this.txtActivo.Location = new System.Drawing.Point(166, 427);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(218, 20);
            this.txtActivo.TabIndex = 17;
            this.txtActivo.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(111, 169);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(82, 23);
            this.btnAceptar.TabIndex = 6;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(208, 169);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // cmbDia
            // 
            this.cmbDia.FormattingEnabled = true;
            this.cmbDia.Location = new System.Drawing.Point(139, 71);
            this.cmbDia.Name = "cmbDia";
            this.cmbDia.Size = new System.Drawing.Size(218, 21);
            this.cmbDia.TabIndex = 3;
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmbMes.Location = new System.Drawing.Point(139, 44);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(218, 21);
            this.cmbMes.TabIndex = 2;
            this.cmbMes.SelectedIndexChanged += new System.EventHandler(this.cmbMes_SelectedIndexChanged);
            // 
            // chkActivo
            // 
            this.chkActivo.AutoSize = true;
            this.chkActivo.Checked = true;
            this.chkActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActivo.Location = new System.Drawing.Point(160, 133);
            this.chkActivo.Name = "chkActivo";
            this.chkActivo.Size = new System.Drawing.Size(56, 17);
            this.chkActivo.TabIndex = 5;
            this.chkActivo.Text = "Activo";
            this.chkActivo.UseVisualStyleBackColor = true;
            // 
            // frmEdicionCatalogoFechas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 215);
            this.Controls.Add(this.chkActivo);
            this.Controls.Add(this.cmbMes);
            this.Controls.Add(this.cmbDia);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtActivo);
            this.Controls.Add(this.txtModificadopor);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtCreadopor);
            this.Controls.Add(this.txtFechaModificacion);
            this.Controls.Add(this.txtCatalogoFechas);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblmodificado_Por);
            this.Controls.Add(this.lblcreado_Por);
            this.Controls.Add(this.lblfecha_de_Creacion);
            this.Controls.Add(this.lblfecha_de_Modificacion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblmes);
            this.Controls.Add(this.lbldia);
            this.Controls.Add(this.lblid_CatalogoFechas);
            this.Name = "frmEdicionCatalogoFechas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Catalogo Fechas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid_CatalogoFechas;
        private System.Windows.Forms.Label lbldia;
        private System.Windows.Forms.Label lblmes;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblfecha_de_Modificacion;
        private System.Windows.Forms.Label lblfecha_de_Creacion;
        private System.Windows.Forms.Label lblcreado_Por;
        private System.Windows.Forms.Label lblmodificado_Por;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtCatalogoFechas;
        private System.Windows.Forms.TextBox txtFechaModificacion;
        private System.Windows.Forms.TextBox txtCreadopor;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtModificadopor;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ComboBox cmbDia;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.CheckBox chkActivo;
    }
}