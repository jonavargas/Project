namespace GUI
{
    partial class frmRegistroMarcas
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
            this.btnMarcar = new System.Windows.Forms.Button();
            this.lblCodigoEmpleado = new System.Windows.Forms.Label();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMarcar
            // 
            this.btnMarcar.Location = new System.Drawing.Point(181, 93);
            this.btnMarcar.Name = "btnMarcar";
            this.btnMarcar.Size = new System.Drawing.Size(75, 23);
            this.btnMarcar.TabIndex = 5;
            this.btnMarcar.Text = "Marcar";
            this.btnMarcar.UseVisualStyleBackColor = true;
            this.btnMarcar.Click += new System.EventHandler(this.btnMarcar_Click);
            // 
            // lblCodigoEmpleado
            // 
            this.lblCodigoEmpleado.AutoSize = true;
            this.lblCodigoEmpleado.Location = new System.Drawing.Point(22, 42);
            this.lblCodigoEmpleado.Name = "lblCodigoEmpleado";
            this.lblCodigoEmpleado.Size = new System.Drawing.Size(93, 13);
            this.lblCodigoEmpleado.TabIndex = 4;
            this.lblCodigoEmpleado.Text = "Código Empleado:";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(123, 39);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(208, 20);
            this.txtCodigoEmpleado.TabIndex = 3;
            // 
            // frmRegistroMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 137);
            this.Controls.Add(this.btnMarcar);
            this.Controls.Add(this.lblCodigoEmpleado);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Name = "frmRegistroMarcas";
            this.Text = "Registro de Ingreso ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMarcar;
        private System.Windows.Forms.Label lblCodigoEmpleado;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
    }
}