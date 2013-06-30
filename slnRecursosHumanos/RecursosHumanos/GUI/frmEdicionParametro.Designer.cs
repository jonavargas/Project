namespace GUI
{
    partial class frmEdicionParametro
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
            this.lblIdParametro = new System.Windows.Forms.Label();
            this.lblhora_Entrada = new System.Windows.Forms.Label();
            this.lblhora_Salida = new System.Windows.Forms.Label();
            this.lblfecha_de_Modificacion = new System.Windows.Forms.Label();
            this.lblfecha_de_Creacion = new System.Windows.Forms.Label();
            this.lblmodificado_Por = new System.Windows.Forms.Label();
            this.lblcreado_Por = new System.Windows.Forms.Label();
            this.lblActivo = new System.Windows.Forms.Label();
            this.txtIdParametro = new System.Windows.Forms.TextBox();
            this.txtFechaModificacion = new System.Windows.Forms.TextBox();
            this.txtModificadopor = new System.Windows.Forms.TextBox();
            this.txtFechaCreacion = new System.Windows.Forms.TextBox();
            this.txtActivo = new System.Windows.Forms.TextBox();
            this.txtCreadopor = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.ckdLunes = new System.Windows.Forms.CheckBox();
            this.ckdMartes = new System.Windows.Forms.CheckBox();
            this.ckdMiercoles = new System.Windows.Forms.CheckBox();
            this.ckdJueves = new System.Windows.Forms.CheckBox();
            this.ckdViernes = new System.Windows.Forms.CheckBox();
            this.ckdSabado = new System.Windows.Forms.CheckBox();
            this.ckdDomingo = new System.Windows.Forms.CheckBox();
            this.lblDiasLaborales = new System.Windows.Forms.Label();
            this.ckdActivo = new System.Windows.Forms.CheckBox();
            this.txtHoraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.txtHoraSalida = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblIdParametro
            // 
            this.lblIdParametro.AutoSize = true;
            this.lblIdParametro.Location = new System.Drawing.Point(20, 12);
            this.lblIdParametro.Name = "lblIdParametro";
            this.lblIdParametro.Size = new System.Drawing.Size(73, 13);
            this.lblIdParametro.TabIndex = 0;
            this.lblIdParametro.Text = "Id Parametro :";
            // 
            // lblhora_Entrada
            // 
            this.lblhora_Entrada.AutoSize = true;
            this.lblhora_Entrada.Location = new System.Drawing.Point(20, 38);
            this.lblhora_Entrada.Name = "lblhora_Entrada";
            this.lblhora_Entrada.Size = new System.Drawing.Size(75, 13);
            this.lblhora_Entrada.TabIndex = 1;
            this.lblhora_Entrada.Text = "Hora entrada :";
            // 
            // lblhora_Salida
            // 
            this.lblhora_Salida.AutoSize = true;
            this.lblhora_Salida.Location = new System.Drawing.Point(20, 64);
            this.lblhora_Salida.Name = "lblhora_Salida";
            this.lblhora_Salida.Size = new System.Drawing.Size(83, 13);
            this.lblhora_Salida.TabIndex = 2;
            this.lblhora_Salida.Text = "Hora de Salida :";
            // 
            // lblfecha_de_Modificacion
            // 
            this.lblfecha_de_Modificacion.AutoSize = true;
            this.lblfecha_de_Modificacion.Location = new System.Drawing.Point(23, 359);
            this.lblfecha_de_Modificacion.Name = "lblfecha_de_Modificacion";
            this.lblfecha_de_Modificacion.Size = new System.Drawing.Size(115, 13);
            this.lblfecha_de_Modificacion.TabIndex = 10;
            this.lblfecha_de_Modificacion.Text = "Fecha de Modificación";
            this.lblfecha_de_Modificacion.Visible = false;
            // 
            // lblfecha_de_Creacion
            // 
            this.lblfecha_de_Creacion.AutoSize = true;
            this.lblfecha_de_Creacion.Location = new System.Drawing.Point(24, 386);
            this.lblfecha_de_Creacion.Name = "lblfecha_de_Creacion";
            this.lblfecha_de_Creacion.Size = new System.Drawing.Size(97, 13);
            this.lblfecha_de_Creacion.TabIndex = 11;
            this.lblfecha_de_Creacion.Text = "Fecha de Creación";
            this.lblfecha_de_Creacion.Visible = false;
            // 
            // lblmodificado_Por
            // 
            this.lblmodificado_Por.AutoSize = true;
            this.lblmodificado_Por.Location = new System.Drawing.Point(23, 412);
            this.lblmodificado_Por.Name = "lblmodificado_Por";
            this.lblmodificado_Por.Size = new System.Drawing.Size(78, 13);
            this.lblmodificado_Por.TabIndex = 12;
            this.lblmodificado_Por.Text = "Modificado Por";
            this.lblmodificado_Por.Visible = false;
            // 
            // lblcreado_Por
            // 
            this.lblcreado_Por.AutoSize = true;
            this.lblcreado_Por.Location = new System.Drawing.Point(24, 442);
            this.lblcreado_Por.Name = "lblcreado_Por";
            this.lblcreado_Por.Size = new System.Drawing.Size(60, 13);
            this.lblcreado_Por.TabIndex = 13;
            this.lblcreado_Por.Text = "Creado Por";
            this.lblcreado_Por.Visible = false;
            // 
            // lblActivo
            // 
            this.lblActivo.AutoSize = true;
            this.lblActivo.Location = new System.Drawing.Point(20, 259);
            this.lblActivo.Name = "lblActivo";
            this.lblActivo.Size = new System.Drawing.Size(97, 13);
            this.lblActivo.TabIndex = 14;
            this.lblActivo.Text = "Estado del usuario:";
            // 
            // txtIdParametro
            // 
            this.txtIdParametro.Location = new System.Drawing.Point(144, 9);
            this.txtIdParametro.Name = "txtIdParametro";
            this.txtIdParametro.Size = new System.Drawing.Size(176, 20);
            this.txtIdParametro.TabIndex = 1;
            // 
            // txtFechaModificacion
            // 
            this.txtFechaModificacion.Location = new System.Drawing.Point(144, 352);
            this.txtFechaModificacion.Name = "txtFechaModificacion";
            this.txtFechaModificacion.Size = new System.Drawing.Size(227, 20);
            this.txtFechaModificacion.TabIndex = 25;
            this.txtFechaModificacion.Visible = false;
            // 
            // txtModificadopor
            // 
            this.txtModificadopor.Location = new System.Drawing.Point(144, 405);
            this.txtModificadopor.Name = "txtModificadopor";
            this.txtModificadopor.Size = new System.Drawing.Size(227, 20);
            this.txtModificadopor.TabIndex = 26;
            this.txtModificadopor.Visible = false;
            // 
            // txtFechaCreacion
            // 
            this.txtFechaCreacion.Location = new System.Drawing.Point(144, 379);
            this.txtFechaCreacion.Name = "txtFechaCreacion";
            this.txtFechaCreacion.Size = new System.Drawing.Size(227, 20);
            this.txtFechaCreacion.TabIndex = 27;
            this.txtFechaCreacion.Visible = false;
            // 
            // txtActivo
            // 
            this.txtActivo.Location = new System.Drawing.Point(144, 470);
            this.txtActivo.Name = "txtActivo";
            this.txtActivo.Size = new System.Drawing.Size(227, 20);
            this.txtActivo.TabIndex = 28;
            this.txtActivo.Visible = false;
            // 
            // txtCreadopor
            // 
            this.txtCreadopor.Location = new System.Drawing.Point(144, 435);
            this.txtCreadopor.Name = "txtCreadopor";
            this.txtCreadopor.Size = new System.Drawing.Size(227, 20);
            this.txtCreadopor.TabIndex = 29;
            this.txtCreadopor.Visible = false;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(92, 289);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(193, 289);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ckdLunes
            // 
            this.ckdLunes.AutoSize = true;
            this.ckdLunes.Location = new System.Drawing.Point(151, 94);
            this.ckdLunes.Name = "ckdLunes";
            this.ckdLunes.Size = new System.Drawing.Size(55, 17);
            this.ckdLunes.TabIndex = 4;
            this.ckdLunes.Text = "Lunes";
            this.ckdLunes.UseVisualStyleBackColor = true;
            // 
            // ckdMartes
            // 
            this.ckdMartes.AutoSize = true;
            this.ckdMartes.Location = new System.Drawing.Point(151, 117);
            this.ckdMartes.Name = "ckdMartes";
            this.ckdMartes.Size = new System.Drawing.Size(58, 17);
            this.ckdMartes.TabIndex = 5;
            this.ckdMartes.Text = "Martes";
            this.ckdMartes.UseVisualStyleBackColor = true;
            // 
            // ckdMiercoles
            // 
            this.ckdMiercoles.AutoSize = true;
            this.ckdMiercoles.Location = new System.Drawing.Point(151, 140);
            this.ckdMiercoles.Name = "ckdMiercoles";
            this.ckdMiercoles.Size = new System.Drawing.Size(71, 17);
            this.ckdMiercoles.TabIndex = 6;
            this.ckdMiercoles.Text = "Miércoles";
            this.ckdMiercoles.UseVisualStyleBackColor = true;
            // 
            // ckdJueves
            // 
            this.ckdJueves.AutoSize = true;
            this.ckdJueves.Location = new System.Drawing.Point(151, 163);
            this.ckdJueves.Name = "ckdJueves";
            this.ckdJueves.Size = new System.Drawing.Size(60, 17);
            this.ckdJueves.TabIndex = 7;
            this.ckdJueves.Text = "Jueves";
            this.ckdJueves.UseVisualStyleBackColor = true;
            // 
            // ckdViernes
            // 
            this.ckdViernes.AutoSize = true;
            this.ckdViernes.Location = new System.Drawing.Point(151, 186);
            this.ckdViernes.Name = "ckdViernes";
            this.ckdViernes.Size = new System.Drawing.Size(61, 17);
            this.ckdViernes.TabIndex = 8;
            this.ckdViernes.Text = "Viernes";
            this.ckdViernes.UseVisualStyleBackColor = true;
            // 
            // ckdSabado
            // 
            this.ckdSabado.AutoSize = true;
            this.ckdSabado.Location = new System.Drawing.Point(151, 209);
            this.ckdSabado.Name = "ckdSabado";
            this.ckdSabado.Size = new System.Drawing.Size(63, 17);
            this.ckdSabado.TabIndex = 9;
            this.ckdSabado.Text = "Sábado";
            this.ckdSabado.UseVisualStyleBackColor = true;
            // 
            // ckdDomingo
            // 
            this.ckdDomingo.AutoSize = true;
            this.ckdDomingo.Location = new System.Drawing.Point(151, 232);
            this.ckdDomingo.Name = "ckdDomingo";
            this.ckdDomingo.Size = new System.Drawing.Size(68, 17);
            this.ckdDomingo.TabIndex = 10;
            this.ckdDomingo.Text = "Domingo";
            this.ckdDomingo.UseVisualStyleBackColor = true;
            // 
            // lblDiasLaborales
            // 
            this.lblDiasLaborales.AutoSize = true;
            this.lblDiasLaborales.Location = new System.Drawing.Point(20, 95);
            this.lblDiasLaborales.Name = "lblDiasLaborales";
            this.lblDiasLaborales.Size = new System.Drawing.Size(125, 13);
            this.lblDiasLaborales.TabIndex = 39;
            this.lblDiasLaborales.Text = "Dias de Jornada Laboral:";
            // 
            // ckdActivo
            // 
            this.ckdActivo.AutoSize = true;
            this.ckdActivo.Checked = true;
            this.ckdActivo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckdActivo.Location = new System.Drawing.Point(151, 255);
            this.ckdActivo.Name = "ckdActivo";
            this.ckdActivo.Size = new System.Drawing.Size(56, 17);
            this.ckdActivo.TabIndex = 11;
            this.ckdActivo.Text = "Activo";
            this.ckdActivo.UseVisualStyleBackColor = true;
            // 
            // txtHoraEntrada
            // 
            this.txtHoraEntrada.Location = new System.Drawing.Point(144, 35);
            this.txtHoraEntrada.Mask = "00:00";
            this.txtHoraEntrada.Name = "txtHoraEntrada";
            this.txtHoraEntrada.Size = new System.Drawing.Size(176, 20);
            this.txtHoraEntrada.TabIndex = 40;
            // 
            // txtHoraSalida
            // 
            this.txtHoraSalida.Location = new System.Drawing.Point(144, 61);
            this.txtHoraSalida.Mask = "00:00";
            this.txtHoraSalida.Name = "txtHoraSalida";
            this.txtHoraSalida.Size = new System.Drawing.Size(176, 20);
            this.txtHoraSalida.TabIndex = 41;
            // 
            // frmEdicionParametro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 324);
            this.Controls.Add(this.txtHoraSalida);
            this.Controls.Add(this.txtHoraEntrada);
            this.Controls.Add(this.ckdActivo);
            this.Controls.Add(this.lblDiasLaborales);
            this.Controls.Add(this.ckdDomingo);
            this.Controls.Add(this.ckdSabado);
            this.Controls.Add(this.ckdViernes);
            this.Controls.Add(this.ckdJueves);
            this.Controls.Add(this.ckdMiercoles);
            this.Controls.Add(this.ckdMartes);
            this.Controls.Add(this.ckdLunes);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtCreadopor);
            this.Controls.Add(this.txtActivo);
            this.Controls.Add(this.txtFechaCreacion);
            this.Controls.Add(this.txtModificadopor);
            this.Controls.Add(this.txtFechaModificacion);
            this.Controls.Add(this.txtIdParametro);
            this.Controls.Add(this.lblActivo);
            this.Controls.Add(this.lblcreado_Por);
            this.Controls.Add(this.lblmodificado_Por);
            this.Controls.Add(this.lblfecha_de_Creacion);
            this.Controls.Add(this.lblfecha_de_Modificacion);
            this.Controls.Add(this.lblhora_Salida);
            this.Controls.Add(this.lblhora_Entrada);
            this.Controls.Add(this.lblIdParametro);
            this.Name = "frmEdicionParametro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edición Parámetro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdParametro;
        private System.Windows.Forms.Label lblhora_Entrada;
        private System.Windows.Forms.Label lblhora_Salida;
        private System.Windows.Forms.Label lblfecha_de_Modificacion;
        private System.Windows.Forms.Label lblfecha_de_Creacion;
        private System.Windows.Forms.Label lblmodificado_Por;
        private System.Windows.Forms.Label lblcreado_Por;
        private System.Windows.Forms.Label lblActivo;
        private System.Windows.Forms.TextBox txtIdParametro;
        private System.Windows.Forms.TextBox txtFechaModificacion;
        private System.Windows.Forms.TextBox txtModificadopor;
        private System.Windows.Forms.TextBox txtFechaCreacion;
        private System.Windows.Forms.TextBox txtActivo;
        private System.Windows.Forms.TextBox txtCreadopor;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox ckdLunes;
        private System.Windows.Forms.CheckBox ckdMartes;
        private System.Windows.Forms.CheckBox ckdMiercoles;
        private System.Windows.Forms.CheckBox ckdJueves;
        private System.Windows.Forms.CheckBox ckdViernes;
        private System.Windows.Forms.CheckBox ckdSabado;
        private System.Windows.Forms.CheckBox ckdDomingo;
        private System.Windows.Forms.Label lblDiasLaborales;
        private System.Windows.Forms.CheckBox ckdActivo;
        private System.Windows.Forms.MaskedTextBox txtHoraEntrada;
        private System.Windows.Forms.MaskedTextBox txtHoraSalida;
    }
}