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
        /// Atributos de la clase Empleado  el cual verifica el botón aceptar y un objeto tipo Empleado en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private EmpleadoL oEmpleadoL;
        /// <summary>
        /// Metodo constructor sin parametros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>

        public frmEdicionEmpleado()
        {
            InitializeComponent();
            this.aceptar = false;
        }
         /// <summary>
        /// Método constructor el cual recibe por parámetro un Emoleado el cual inicializa los atributos existentes
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
        /// Properties de la Clase Empleado,el cual permite consultar los valores de los atributos
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
        /// Evento del botón Cancelar el cual cierra la ventada si dan click en el
        /// </summary>
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
        /// <summary>
        /// Metodo del botón aceptar,el cual verifica si el usuario preciono el botón aceptar o no,si lo hizo procede a revizar si no dejo
        /// algún espacio en blanco sino lo hizo creado un empleado con los datos suministrados
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
      
    }
}
