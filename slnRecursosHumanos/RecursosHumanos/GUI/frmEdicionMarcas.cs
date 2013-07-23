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
    public partial class frmEdicionMarcas : Form
    {
        /// <summary>
        ///  Atributos de la clase el cual verifica el botón aceptar y un objeto tipo Empleado en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private MarcaL oMarcaL;
        private AccesoDatosOracle cnx;

        /// <summary>
        /// Método constructor sin parámetros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>
        /// <param name="pcnx"></param>
        public frmEdicionMarcas(AccesoDatosOracle pcnx)
        {
            InitializeComponent();
            this.aceptar = false;
            this.cmbEstado.Items.Add("Generada");
            this.cmbEstado.Items.Add("En trámite");
            this.cmbEstado.Items.Add("Pagada");
            this.cmbEstado.Items.Add("Anulada");
            this.cargarComboDepartamento(pcnx);
            this.cargarComboEmpleado(pcnx);
            this.cargarComboCodigoEmpleado(pcnx);
        }

        /// <summary>
        /// Properties de la Clase,el cual permite consultar los valores de los atributos
        /// </summary>
        public Boolean Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public MarcaL OMarcaL
        {
            get { return oMarcaL; }
            set { oMarcaL = value; }
        }
                  
        public void cargarComboDepartamento(AccesoDatosOracle pcnx)
        {
            DepartamentoD oDepartamentoD = new DepartamentoD(pcnx);
            cmbDepartamento.DataSource = oDepartamentoD.obtenerIdDepartamento().Tables[0].Copy();
            cmbDepartamento.DisplayMember = "idDepartamento";
            cmbDepartamento.ValueMember = "idDepartamento";
        }

        public void cargarComboEmpleado(AccesoDatosOracle pcnx)
        {
            EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
            cmbEmpleado.DataSource = oEmpleadoD.obtenerNombreEmpleado().Tables[0].Copy();
            cmbEmpleado.DisplayMember = "nombreCompleto";
            cmbEmpleado.ValueMember = "nombreCompleto";
        }

        public void cargarComboCodigoEmpleado(AccesoDatosOracle pcnx)
        {
            EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
            cmbCodigo.DataSource = oEmpleadoD.obtenerCodigoEmpleado().Tables[0].Copy();
            cmbCodigo.DisplayMember = "idEmpleado";
            cmbCodigo.ValueMember = "idEmpleado";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.cmbCodigo.Text == "")
            {
                MessageBox.Show("Debe digitar un código!!!");
                this.cmbCodigo.Focus();
                return;
            }

            EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
            List<EmpleadoL> empleado = oEmpleadoD.(this.cmbCodigo.Text);
           
            if (empleado.Count == 0)
            {
                MessageBox.Show("No se encontro el código del empleado!!!");
                this.cmbCodigo.Text = "";
                this.cmbCodigo.Focus();
                return;
            }          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }          
    }
}
