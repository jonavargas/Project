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
            this.txtEmpleado.Text = (pEmpleadoL.IdEmpleado);
            this.txtDepartamento.Text = (pEmpleadoL.IdDepartamento);
            this.txtNombre.Text = (pEmpleadoL.NombreEmpleado);
            this.txtApellido1.Text = (pEmpleadoL.Apellido1);
            this.txtApellido2.Text = (pEmpleadoL.Apellido2);
            this.txtCedula.Text = (pEmpleadoL.NumCedula.ToString());
            this.txtTelefono.Text = (pEmpleadoL.Telefono.ToString());
            this.txtFechaNacimiento.Text = (pEmpleadoL.FechaNacimiento.ToString());
            this.txtSalarioPorHora.Value = (Decimal)(pEmpleadoL.SalarioPorHora); 
           
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
                                                (this.txtFechaNacimiento.Text),
                                                Double.Parse(this.txtSalarioPorHora.Text),
                                                Program.oUsuarioLogueado.ToString(),
                                                DateTime.Now,
                                                Program.oUsuarioLogueado.ToString(),
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
               (this.txtDepartamento.Text == "") || (this.txtNombre.Text == "") || (this.txtTelefono == null) )
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }
            this.oEmpleadoL = new EmpleadoL(this.txtEmpleado.Text, this.txtDepartamento.Text, this.txtNombre.Text, this.txtApellido1.Text, this.txtApellido2.Text,
                                     int.Parse(this.txtCedula.Text), int.Parse(this.txtTelefono.Text),(this.txtFechaNacimiento.Text),
                                     Double.Parse(this.txtSalarioPorHora.Text), Program.oUsuarioLogueado.IdUsuario, DateTime.Today, Program.oUsuarioLogueado.IdUsuario, DateTime.Now, activo);
            this.aceptar = true;
            this.Close();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
