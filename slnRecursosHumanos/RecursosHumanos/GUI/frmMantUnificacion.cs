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
    public partial class frmMantUnificacion : Form
    {
        /// <summary>
        /// Variable para hacer la conexión a la base de datos
        /// </summary>
        private AccesoDatosOracle conexion;
        MarcaL oMarcaL, oMarcaCambioEstado;
        MarcaD oMarcaD;

        /// <summary>
        /// Metodo constructor que recibe por parámetro la conexión a la base de datos.
        /// </summary>
        /// <param name="pConexion"></param>
        public frmMantUnificacion(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.dtpFecha1.Value = DateTime.Today;
            this.dtpFecha2.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            this.conexion = pConexion;
            this.cargarCmbDepartamento(pConexion);
            this.cargarComboEmpleado(pConexion);
            this.cmbEmpleado.SelectedItem = null;
            this.cmbEstadoMarca.SelectedItem = null;
            this.cmbDepartamento.SelectedItem = null;
        }

        /// <summary>
        /// Método para cargar el combobox Departamento con los departamentos existentes en la base de datos.
        /// </summary>
        /// <param name="pcnx"></param>

        public void cargarCmbDepartamento(AccesoDatosOracle pcnx)
        {
            DepartamentoD oDepartamentoD = new DepartamentoD(pcnx);
            cmbDepartamento.DataSource = oDepartamentoD.obtenerIdDepartamento().Tables[0].Copy();
            cmbDepartamento.DisplayMember = "idDepartamento";
            cmbDepartamento.ValueMember = "idDepartamento";
        }

        /// <summary>
        /// Método para cargar el combobox Empleado con los enpleados existentes en la base de datos.
        /// </summary>
        /// <param name="pcnx"></param>

        public void cargarComboEmpleado(AccesoDatosOracle pcnx)
        {
            EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
            cmbEmpleado.DataSource = oEmpleadoD.obtenerNombreEmpleado().Tables[0].Copy();
            cmbEmpleado.DisplayMember = "nombreCompleto";
            cmbEmpleado.ValueMember = "nombreCompleto";
        }


    }
}
