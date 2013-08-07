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
    public partial class frmEdicionUnificacion : Form
    {

        /// <summary>
        /// Variable para hacer la conexión a la base de datos
        /// </summary>
        private AccesoDatosOracle conexion;

        public frmEdicionUnificacion(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.conexion = pConexion;
            this.cargarComboCodigoEmpleado(pConexion);
            this.cmbCodEmpleado.SelectedItem = null;
            this.lblEstadoUnificacion.Text = "OK";
            this.lblEstadoUnificacion.ForeColor = System.Drawing.Color.Blue;
            this.txNumUni.Enabled = false;
        }

        /// <summary>
        /// Método para cargar el combobox CodigoEmpleadoo con los codigos existentes en la base de datos.
        /// También rellena el combo box código empleado de acuerdo a los empleados que existen en el departamento seleccionado.
        /// </summary>
        /// <param name="pcnx"></param>
        public void cargarComboCodigoEmpleado(AccesoDatosOracle pcnx)
        {
            EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
            cmbCodEmpleado.DataSource = oEmpleadoD.obtenerCodigoEmpleado().Tables[0].Copy();
            cmbCodEmpleado.DisplayMember = "idEmpleado";
            cmbCodEmpleado.ValueMember = "idEmpleado";
        }
    }
}
