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
        List<UsuarioL> oUsuarioL;       
        AccesoDatosOracle conexion;
        private bool edicion = false;
        /// <summary>
        /// Método constructor sin parámetros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>

        public frmEdicionEmpleado(List<UsuarioL> pOUsuarioL, AccesoDatosOracle pcnx)
        {
            InitializeComponent();
            this.conexion = pcnx;
            this.oUsuarioL = pOUsuarioL;
            this.cargarCombobox(pcnx);
            this.aceptar = false;
            
        }
         /// <summary>
        /// Método constructor el cual recibe por parámetro un Emoleado el cual inicializa los atributos existentes
        /// </summary>
        /// <param name="pParametroL"></param>
        public frmEdicionEmpleado(EmpleadoL pEmpleadoL, List<UsuarioL> pOUsuarioLConectado, AccesoDatosOracle pCnx)
        {
            InitializeComponent();
            this.conexion = pCnx;
            this.aceptar = false;
            this.txtEmpleado.Enabled = false;
            this.txtNombre.Enabled = false;
            this.txtApellido1.Enabled = false;
            this.txtApellido2.Enabled = false;
            this.txtCedula.Enabled = false;
            this.dtpFechaNacimiento.Enabled = false;
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
            this.oUsuarioL = pOUsuarioLConectado;
            this.edicion = true;
           
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
        public List<UsuarioL> OUsuarioL
        {
            get { return oUsuarioL; }
            set { oUsuarioL = value; }
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
             try{
                 if ((this.txtEmpleado.Text == "") ||
                    (this.txtApellido1.Text == "") || (this.txtApellido2.Text == "") || (this.txtNombre.Text == "") || (this.txtSalarioPorHora.Value == 0))
                 {
                     MessageBox.Show("Faltan datos requeridos");
                     return;

                 }
                 else
                 {
                     EmpleadoD oEmpleadoD = new EmpleadoD(this.conexion);
                     List<EmpleadoL> listaEmpleado = oEmpleadoD.buscarEmpleado(this.txtEmpleado.Text);
                     if (this.edicion == false)
                     {
                         if (listaEmpleado.Count > 0)
                         {
                             MessageBox.Show("El código de Empleado ya existe");
                             this.txtEmpleado.Text = "";
                             this.txtEmpleado.Focus();
                             return;
                         }
                         else
                         {
                             oEmpleadoL = new EmpleadoL(this.txtEmpleado.Text, this.cmbDepartamento.Text, this.txtNombre.Text, this.txtApellido1.Text, this.txtApellido2.Text,
                                             int.Parse(this.txtCedula.Text), int.Parse(this.txtTelefono.Text), (this.dtpFechaNacimiento.Text),
                                             Double.Parse(this.txtSalarioPorHora.Text), oUsuarioL[0].IdUsuario, DateTime.Now, oUsuarioL[0].IdUsuario, DateTime.Now, activo);

                         }


                     }
                     else
                     {
                        
                         oEmpleadoL = new EmpleadoL(this.txtEmpleado.Text, this.cmbDepartamento.Text, this.txtNombre.Text, this.txtApellido1.Text, this.txtApellido2.Text,
                                             int.Parse(this.txtCedula.Text), int.Parse(this.txtTelefono.Text), (this.dtpFechaNacimiento.Text),
                                             Double.Parse(this.txtSalarioPorHora.Text), oUsuarioL[0].IdUsuario, DateTime.Now, oUsuarioL[0].IdUsuario, DateTime.Now, activo);
                     }

                 }
           
            
            }catch(Exception){
                MessageBox.Show("Error agregando Empleado");
            
            
            }
             this.aceptar = true;
             this.Close();
            
            
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
