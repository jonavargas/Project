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
    public partial class frmEdicionEmpleado : Form
    {/// <summary>
        /// Atributos de la clase.
        /// </summary>
        private Boolean aceptar;
        private EmpleadoL oEmpleadoL;
        /// <summary>
        /// Metodo constructor sin parametros
        /// </summary>

        public frmEdicionEmpleado()
        {
            InitializeComponent();
            this.aceptar = false;
        }
         /// <summary>
        /// Metodo constructor con parametros
        /// </summary>
        /// <param name="pParametroL"></param>
        public frmEdicionEmpleado(EmpleadoL pEmpleadoL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtEmpleado.Text = Convert.ToString(pEmpleadoL.IdEmpleado);
            this.txtDepartamento.Text = Convert.ToString(pEmpleadoL.IdDepartamento);
            this.txtNombre.Text = Convert.ToString( pEmpleadoL.NombreEmpleado);
            this.txtApellido1.Text = Convert.ToString(pEmpleadoL.Apellido1);
            this.txtApellido2.Text = Convert.ToString(pEmpleadoL.Apellido2);
            this.txtCedula.Text = Convert.ToString(pEmpleadoL.NumCedula);
            this.txtTelefono.Text = Convert.ToString(pEmpleadoL.Telefono);
            this.txtFechaNacimiento.Text = Convert.ToString(pEmpleadoL.FechaNacimiento);
            this.txtSalarioPorHora.Text = Convert.ToString(pEmpleadoL.SalarioPorHora);   
            this.oEmpleadoL = pEmpleadoL;
        }

        /// <summary>
        /// Propiedades de los atributos
        /// </summary>
        public EmpleadoL OEmpleadoL
        {
            get { return oEmpleadoL; }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
        }
        /// <summary>
        /// Metodo del botón Cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string validarActivo()
        {
            string respuesta = "No";
            if (chkActivo.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
       
        private void btnAceptar_Click_1(object sender, EventArgs e)
        {
            if ((this.txtEmpleado.Text == "") ||
              (this.txtDepartamento.Text == "") || (this.txtNombre.Text == "") || (this.txtSalarioPorHora.Text == ""))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }
            this.oEmpleadoL = new EmpleadoL(this.txtEmpleado.Text,
                                                this.txtDepartamento.Text,
                                                this.txtNombre.Text,
                                                this.txtApellido1.Text,
                                                this.txtApellido2.Text,
                                                int.Parse(this.txtCedula.Text),
                                                int.Parse(this.txtTelefono.Text),
                                                DateTime.Parse(this.txtFechaNacimiento.Text),
                                                double.Parse(this.txtSalarioPorHora.Text),
                                                Program.usuario,
                                                DateTime.Now,
                                                Program.usuario,
                                                DateTime.Now,
                                                this.validarActivo());
            this.aceptar = true;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            String activo = "No";

            if (this.chkActivo.Checked)
            {
                activo = "Sí";
            }

            if ((this.txtEmpleado.Text == "") ||
               (this.txtDepartamento.Text == "") || (this.txtNombre.Text == "") || (this.txtSalarioPorHora == null) || (this.txtTelefono == null) )
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }
            this.oEmpleadoL = new EmpleadoL(this.txtEmpleado.Text, this.txtDepartamento.Text, this.txtNombre.Text, this.txtApellido1.Text, this.txtApellido2.Text,
                                     int.Parse(this.txtCedula.Text), int.Parse(this.txtTelefono.Text), DateTime.Parse(this.txtFechaNacimiento.Text),
                                     double.Parse(this.txtSalarioPorHora.Text), Program.usuario, DateTime.Today, Program.usuario, DateTime.Now, activo);
            this.aceptar = true;
            this.Close();
        }
    }
}
