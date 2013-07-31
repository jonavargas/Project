namespace RecursosHumanos.GUI
{
    partial class frmUnificacion
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
            this.toolBotones = new System.Windows.Forms.ToolStrip();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.btnAprobar = new System.Windows.Forms.ToolStripButton();
            this.tcUnificacion = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.toolBotones.SuspendLayout();
            this.tcUnificacion.SuspendLayout();
            this.tp2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolBotones
            // 
            this.toolBotones.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolBotones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalvar,
            this.btnAprobar});
            this.toolBotones.Location = new System.Drawing.Point(0, 0);
            this.toolBotones.Name = "toolBotones";
            this.toolBotones.Size = new System.Drawing.Size(756, 52);
            this.toolBotones.TabIndex = 0;
            this.toolBotones.Text = "toolStrip1";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::RecursosHumanos.Properties.Resources.salvar;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 49);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnAprobar
            // 
            this.btnAprobar.Image = global::RecursosHumanos.Properties.Resources.Check;
            this.btnAprobar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(54, 49);
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tcUnificacion
            // 
            this.tcUnificacion.Controls.Add(this.tp1);
            this.tcUnificacion.Controls.Add(this.tp2);
            this.tcUnificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcUnificacion.Location = new System.Drawing.Point(0, 55);
            this.tcUnificacion.Name = "tcUnificacion";
            this.tcUnificacion.SelectedIndex = 0;
            this.tcUnificacion.Size = new System.Drawing.Size(756, 325);
            this.tcUnificacion.TabIndex = 2;
            // 
            // tp1
            // 
            this.tp1.Location = new System.Drawing.Point(4, 25);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(676, 235);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Datos";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.dateTimePicker1);
            this.tp2.Controls.Add(this.dateTimePicker2);
            this.tp2.Controls.Add(this.label5);
            this.tp2.Controls.Add(this.label6);
            this.tp2.Controls.Add(this.comboBox2);
            this.tp2.Controls.Add(this.label3);
            this.tp2.Location = new System.Drawing.Point(4, 25);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(748, 296);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Totales";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.ItemHeight = 16;
            this.comboBox2.Location = new System.Drawing.Point(117, 11);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(259, 24);
            this.comboBox2.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 29;
            this.label3.Text = "Empleado: ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(263, 49);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(113, 22);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(120, 49);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(112, 22);
            this.dateTimePicker2.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Fechas del:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(238, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 16);
            this.label6.TabIndex = 33;
            this.label6.Text = "al";
            // 
            // frmUnificacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 382);
            this.Controls.Add(this.tcUnificacion);
            this.Controls.Add(this.toolBotones);
            this.Name = "frmUnificacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unificación";
            this.toolBotones.ResumeLayout(false);
            this.toolBotones.PerformLayout();
            this.tcUnificacion.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.tp2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolBotones;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripButton btnAprobar;
        private System.Windows.Forms.TabControl tcUnificacion;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}