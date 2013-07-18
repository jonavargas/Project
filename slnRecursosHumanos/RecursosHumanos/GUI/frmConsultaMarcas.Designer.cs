namespace GUI
{
    partial class frmConsultaMarcas
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
            this.grpConsultaMarcas = new System.Windows.Forms.GroupBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.dteFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dteFecha1 = new System.Windows.Forms.DateTimePicker();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblDepartamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.grpConsultaMarcas.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpConsultaMarcas
            // 
            this.grpConsultaMarcas.Controls.Add(this.txtCodigo);
            this.grpConsultaMarcas.Controls.Add(this.lblCodigo);
            this.grpConsultaMarcas.Controls.Add(this.txtEstado);
            this.grpConsultaMarcas.Controls.Add(this.txtDepartamento);
            this.grpConsultaMarcas.Controls.Add(this.label2);
            this.grpConsultaMarcas.Controls.Add(this.lblDepartamento);
            this.grpConsultaMarcas.Controls.Add(this.btnFiltrar);
            this.grpConsultaMarcas.Controls.Add(this.dteFecha2);
            this.grpConsultaMarcas.Controls.Add(this.dteFecha1);
            this.grpConsultaMarcas.Controls.Add(this.lblFecha);
            this.grpConsultaMarcas.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpConsultaMarcas.Location = new System.Drawing.Point(0, 0);
            this.grpConsultaMarcas.Name = "grpConsultaMarcas";
            this.grpConsultaMarcas.Size = new System.Drawing.Size(632, 176);
            this.grpConsultaMarcas.TabIndex = 0;
            this.grpConsultaMarcas.TabStop = false;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(365, 22);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 24);
            this.btnFiltrar.TabIndex = 12;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // dteFecha2
            // 
            this.dteFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFecha2.Location = new System.Drawing.Point(234, 24);
            this.dteFecha2.Name = "dteFecha2";
            this.dteFecha2.Size = new System.Drawing.Size(125, 20);
            this.dteFecha2.TabIndex = 11;
            // 
            // dteFecha1
            // 
            this.dteFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dteFecha1.Location = new System.Drawing.Point(103, 24);
            this.dteFecha1.Name = "dteFecha1";
            this.dteFecha1.Size = new System.Drawing.Size(125, 20);
            this.dteFecha1.TabIndex = 10;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(23, 31);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(40, 13);
            this.lblFecha.TabIndex = 9;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblDepartamento
            // 
            this.lblDepartamento.AutoSize = true;
            this.lblDepartamento.Location = new System.Drawing.Point(23, 61);
            this.lblDepartamento.Name = "lblDepartamento";
            this.lblDepartamento.Size = new System.Drawing.Size(77, 13);
            this.lblDepartamento.TabIndex = 13;
            this.lblDepartamento.Text = "Departamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Estado:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(103, 54);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(125, 20);
            this.txtDepartamento.TabIndex = 15;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(103, 79);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(125, 20);
            this.txtEstado.TabIndex = 16;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(26, 112);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 17;
            this.lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(103, 104);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(125, 20);
            this.txtCodigo.TabIndex = 18;
            // 
            // frmConsultaMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 400);
            this.Controls.Add(this.grpConsultaMarcas);
            this.Name = "frmConsultaMarcas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Marcas";
            this.grpConsultaMarcas.ResumeLayout(false);
            this.grpConsultaMarcas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConsultaMarcas;
        private System.Windows.Forms.DateTimePicker dteFecha2;
        private System.Windows.Forms.DateTimePicker dteFecha1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDepartamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}