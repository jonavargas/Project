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
using Datos;


namespace GUI
{
    public partial class frmEdicionEmpleado : Form
    {/// <summary>
        /// Atributos de la clase Empleado  el cual verifica el botón aceptar y un objeto tipo Empleado en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private EmpleadoL oEmpleadoL;
        /// <summary>
        /// Método constructor sin parámetros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>

        public frmEdicionEmpleado(AccesoDatosOracle pcnx)
        {
            InitializeComponent();
            this.aceptar = false;
            this.cargarCombobox(pcnx);
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
            this.cmbDepartamento.Text = (pEmpleadoL.IdDepartamento);
            this.txtNombre.Text = (pEmpleadoL.NombreEmpleado);
            this.txtApellido1.Text = (pEmpleadoL.Apellido1);
            this.txtApellido2.Text = (pEmpleadoL.Apellido2);
            this.txtCedula.Text = Convert.ToString(pEmpleadoL.NumCedula);
            this.txtTelefono.Text = Convert.ToString(pEmpleadoL.Telefono);
            this.dtpFechaNacimiento.Text = Convert.ToString(pEmpleadoL.FechaNacimiento);
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
        /// Método del botón aceptar,el cual verifica si el empleado preciono el botón aceptar o no,si lo hizo procede a revisar si no dejo
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
               (this.cmbDepartamento.Text == "") || (this.txtNombre.Text == ""))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;    
          
            
            
                
            }else{

            oEmpleadoL = new EmpleadoL(this.txtEmpleado.Text, this.cmbDepartamento.Text, this.txtNombre.Text, this.txtApellido1.Text, this.txtApellido2.Text,
                                     int.Parse(this.txtCedula.Text), int.Parse(this.txtTelefono.Text),(this.dtpFechaNacimiento.Text),

                                     Double.Parse(this.txtSalarioPorHora.Text), Program.oUsuarioLogueado.IdUsuario, DateTime.Now, Program.oUsuarioLogueado.IdUsuario, DateTime.Now, activo);
            this.aceptar = true;
            this.Close();
            
            }
            
            
        }
        /// <summary>
        /// Evento del botón Cancelar el cual cierra la ventada si dan click en el
        /// </summary>

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Metodo que valida que solo entren números al txt de cedula
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Debe de digitar solo números!!!");
            }

        }
        /// <summary>
        /// Metodo que valida que solo entren números en el txt de teléfono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Debe de digitar solo números!!!");
            }

        }

        /// <summary>
        /// Metodo que se encarga de llenar el combo box departamento con los departamentos existentes.
        /// </summary>
        /// <param name="pcnx"></param>
        public void cargarCombobox(AccesoDatosOracle pcnx)
        {
            DepartamentoD oDepartamentoD = new DepartamentoD(pcnx);
            cmbDepartamento.DataSource = oDepartamentoD.obtenerIdDepartamento().Tables[0].Copy();
            cmbDepartamento.DisplayMember = "idDepartamento";
            cmbDepartamento.ValueMember = "idDepartamento";
        }
    }
}
