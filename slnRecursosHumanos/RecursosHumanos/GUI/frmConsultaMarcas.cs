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
    public partial class frmConsultaMarcas : Form
    {
        /// <summary>
        /// Variable para hacer la conexión a la base de datos
        /// </summary>
        private AccesoDatosOracle conexion;
       
        /// <summary>
        /// Metodo constructor que recibe por parámetro la conexión a la base de datos.
        /// </summary>
        /// <param name="pConexion"></param>
        public frmConsultaMarcas(AccesoDatosOracle pConexion)
        {
            InitializeComponent(); 
            this.conexion = pConexion;
            this.dteFecha1.Value = DateTime.Today;
            this.dteFecha2.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            this.cargarCmbDepartamento(pConexion);
            this.cargarComboEmpleado(pConexion);
            this.cargarComboCodigoEmpleado(pConexion);
            this.cmbEstado.Items.Add("Generada");
            this.cmbEstado.Items.Add("En trámite");
            this.cmbEstado.Items.Add("Pagada");
            this.cmbEstado.Items.Add("Anulada");

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

        /// <summary>
        /// Método para cargar el combobox CodigoEmpleadoo con los codigos existentes en la base de datos.
        /// </summary>
        /// <param name="pcnx"></param>


        public void cargarComboCodigoEmpleado(AccesoDatosOracle pcnx)
        {
            EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
            cmbCodigo.DataSource = oEmpleadoD.obtenerCodigoEmpleado().Tables[0].Copy();
            cmbCodigo.DisplayMember = "idEmpleado";
            cmbCodigo.ValueMember = "idEmpleado";
        }

        /// <summary>
        /// Evento del botón filtrar que nos filtra la información para emcontrarla más rapido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            


        }
        /// <summary>
        /// Método para limpiar los datos que se encuentran seleccionados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

       
        /// <summary>
        /// Boton nuevo que llama al frmedición marcas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        public void cargarGrid()
        {
            try
            {
                MarcaD oMarcaD = new MarcaD(this.conexion);
                this.grdConsultas.DataSource = oMarcaD.obtenerMarca();
                if (oMarcaD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oMarcaD.ErrorDescription);
                
                }
            }catch(Exception e){

                MessageBox.Show("Error cargando los datos" + e.Message);
            }  
        }


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionMarcas ofrmEdicionMarcas = new frmEdicionMarcas(conexion);
            ofrmEdicionMarcas.ShowDialog();

            if (ofrmEdicionMarcas.Aceptar)
            {
                MarcaD oMarcaD = new MarcaD(this.conexion);
                oMarcaD.agregarMarca3(ofrmEdicionMarcas.MarcaL);
                if (!oMarcaD.Error)
                {

                    MessageBox.Show("Registro agregado!!!");
                    

                }else {
                    MessageBox.Show("Error agregando los datos:" + oMarcaD.ErrorDescription);                
                
                }
            
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this.cmbCodigo.SelectedItem = null;
            this.cmbDepartamento.SelectedItem = null;
            this.cmbEmpleado.SelectedItem = null;
            this.cmbEstado.SelectedItem = null;
            this.rbtActivo.Checked = false;
            this.rbtInactivo.Checked = false;
            this.dteFecha1.Value = DateTime.Today;
            this.dteFecha2.Value = DateTime.Today;     
        }
    }
}
