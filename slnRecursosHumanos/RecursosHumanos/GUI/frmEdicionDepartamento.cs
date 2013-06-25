using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace GUI
{
    public partial class frmEdicionDepartamento : Form
    {
        private Boolean aceptar;
        private DepartamentoL oDepartamentoL;

        public frmEdicionDepartamento()
        {
            InitializeComponent();
            this.aceptar = false;
        }

        public frmEdicionDepartamento(DepartamentoL pDepartamentoL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtIdDepartamento.Text = pDepartamentoL.IdDepartamento.ToString();
            this.txtNombreDepa.Text = pDepartamentoL.NombreDepartamento.ToString();
            this.oDepartamentoL = pDepartamentoL;
        }
        public DepartamentoL ODepartamentoL
        {
            get { return oDepartamentoL; }
            set { oDepartamentoL = value; }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String activo = "No";

            if (this.chkActivo.Checked)
            {
                activo = "Sí";
            }

            if ((this.txtIdDepartamento.Text == "") ||
               (this.txtNombreDepa.Text == ""))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }
            this.oDepartamentoL = new DepartamentoL(this.txtIdDepartamento.Text,
                                      this.txtNombreDepa.Text, DateTime.Now,
                                         DateTime.Now, Program.usuario, Program.usuario,
                                         activo);
            this.aceptar = true;
            this.Close();

        }

    }
}
