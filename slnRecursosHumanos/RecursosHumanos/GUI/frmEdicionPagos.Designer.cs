namespace GUI
{
    partial class frmEdicionPagos
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
            this.tbVE = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dtpFecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumeroPago = new System.Windows.Forms.Label();
            this.lblTotalDeducciones = new System.Windows.Forms.Label();
            this.lblTotalPagos = new System.Windows.Forms.Label();
            this.txtTotalPagos = new System.Windows.Forms.TextBox();
            this.txtTotalDeducciones = new System.Windows.Forms.TextBox();
            this.txtNumPagos = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.tbVE.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbVE
            // 
            this.tbVE.Controls.Add(this.tabPage1);
            this.tbVE.Controls.Add(this.tabPage2);
            this.tbVE.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbVE.Location = new System.Drawing.Point(0, 202);
            this.tbVE.Name = "tbVE";
            this.tbVE.SelectedIndex = 0;
            this.tbVE.Size = new System.Drawing.Size(817, 278);
            this.tbVE.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(809, 252);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vista Unificaciones";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView2);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(809, 246);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(803, 240);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(809, 252);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vista Empleados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(0, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 252);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 247);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(817, 52);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::RecursosHumanos.Properties.Resources.salvar;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 49);
            this.toolStripButton1.Text = "Salvar";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::RecursosHumanos.Properties.Resources.Anular;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(46, 49);
            this.toolStripButton2.Text = "Anular";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(31, 123);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(91, 18);
            this.lblDescripcion.TabIndex = 41;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // dtpFecha2
            // 
            this.dtpFecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha2.Location = new System.Drawing.Point(334, 74);
            this.dtpFecha2.Name = "dtpFecha2";
            this.dtpFecha2.Size = new System.Drawing.Size(129, 22);
            this.dtpFecha2.TabIndex = 35;
            // 
            // dtpFecha1
            // 
            this.dtpFecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha1.Location = new System.Drawing.Point(153, 74);
            this.dtpFecha1.Name = "dtpFecha1";
            this.dtpFecha1.Size = new System.Drawing.Size(128, 22);
            this.dtpFecha1.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 38;
            this.label5.Text = "Fechas del:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(297, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "al";
            // 
            // lblNumeroPago
            // 
            this.lblNumeroPago.AutoSize = true;
            this.lblNumeroPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroPago.Location = new System.Drawing.Point(502, 161);
            this.lblNumeroPago.Name = "lblNumeroPago";
            this.lblNumeroPago.Size = new System.Drawing.Size(105, 18);
            this.lblNumeroPago.TabIndex = 42;
            this.lblNumeroPago.Text = "Número Pago:";
            // 
            // lblTotalDeducciones
            // 
            this.lblTotalDeducciones.AutoSize = true;
            this.lblTotalDeducciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDeducciones.Location = new System.Drawing.Point(502, 120);
            this.lblTotalDeducciones.Name = "lblTotalDeducciones";
            this.lblTotalDeducciones.Size = new System.Drawing.Size(136, 18);
            this.lblTotalDeducciones.TabIndex = 43;
            this.lblTotalDeducciones.Text = "Total Deducciones:";
            // 
            // lblTotalPagos
            // 
            this.lblTotalPagos.AutoSize = true;
            this.lblTotalPagos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPagos.Location = new System.Drawing.Point(502, 79);
            this.lblTotalPagos.Name = "lblTotalPagos";
            this.lblTotalPagos.Size = new System.Drawing.Size(92, 18);
            this.lblTotalPagos.TabIndex = 44;
            this.lblTotalPagos.Text = "Total Pagos:";
            // 
            // txtTotalPagos
            // 
            this.txtTotalPagos.Location = new System.Drawing.Point(650, 80);
            this.txtTotalPagos.Name = "txtTotalPagos";
            this.txtTotalPagos.Size = new System.Drawing.Size(144, 20);
            this.txtTotalPagos.TabIndex = 45;
            // 
            // txtTotalDeducciones
            // 
            this.txtTotalDeducciones.Location = new System.Drawing.Point(650, 121);
            this.txtTotalDeducciones.Name = "txtTotalDeducciones";
            this.txtTotalDeducciones.Size = new System.Drawing.Size(144, 20);
            this.txtTotalDeducciones.TabIndex = 46;
            // 
            // txtNumPagos
            // 
            this.txtNumPagos.Location = new System.Drawing.Point(650, 162);
            this.txtNumPagos.Name = "txtNumPagos";
            this.txtNumPagos.Size = new System.Drawing.Size(144, 20);
            this.txtNumPagos.TabIndex = 47;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(146, 116);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(317, 67);
            this.txtDescripcion.TabIndex = 48;
            // 
            // frmEdicionPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 480);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNumPagos);
            this.Controls.Add(this.txtTotalDeducciones);
            this.Controls.Add(this.txtTotalPagos);
            this.Controls.Add(this.lblTotalPagos);
            this.Controls.Add(this.lblTotalDeducciones);
            this.Controls.Add(this.lblNumeroPago);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.dtpFecha2);
            this.Controls.Add(this.dtpFecha1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tbVE);
            this.Name = "frmEdicionPagos";
            this.Text = "Edición Pagos";
            this.tbVE.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tbVE;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DateTimePicker dtpFecha2;
        private System.Windows.Forms.DateTimePicker dtpFecha1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumeroPago;
        private System.Windows.Forms.Label lblTotalDeducciones;
        private System.Windows.Forms.Label lblTotalPagos;
        private System.Windows.Forms.TextBox txtTotalPagos;
        private System.Windows.Forms.TextBox txtTotalDeducciones;
        private System.Windows.Forms.TextBox txtNumPagos;
        private System.Windows.Forms.TextBox txtDescripcion;
    }
}