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
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private Boolean aceptar;
        private DepartamentoL oDepartamentoL;

        /// <summary>
        /// Metodo constructor que no recibe parametro
        /// </summary>
        public frmEdicionDepartamento()
        {
            InitializeComponent();
            this.aceptar = false;
        }
        /// <summary>
        /// Metodo costructor con parametros
        /// </summary>
        /// <param name="pDepartamentoL"></param>
        public frmEdicionDepartamento(DepartamentoL pDepartamentoL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtIdDepartamento.Text = pDepartamentoL.IdDepartamento.ToString();
            this.txtNombreDepa.Text = pDepartamentoL.NombreDepartamento.ToString();
            this.oDepartamentoL = pDepartamentoL;
        }
        /// <summary>
        /// Propiedades de los atributos
        /// </summary>
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
        /// <summary>
        /// Metodo del botón Aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
                                         DateTime.Now, Program.oUsuarioLogueado.Login, Program.oUsuarioLogueado.Login,
                                         activo);
            this.aceptar = true;
            this.Close();

        }
        /// <summary>
        /// Metodo del botón cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
