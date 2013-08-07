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
    public partial class frmUnificacion : Form
    {
        /// <summary>
        /// Variable para hacer la conexión a la base de datos
        /// </summary>
        private AccesoDatosOracle conexion;
        MarcaL oMarcaL, oMarcaCambioEstado;
        MarcaD oMarcaD;
        private bool edicion = false;
        List<UsuarioL> oUsuarioActual;

        /// <summary>
        /// Metodo constructor que recibe por parámetro la conexión a la base de datos.
        /// </summary>
        /// <param name="pConexion"></param>
        public frmUnificacion(List<UsuarioL> pUsuarioActual, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.dtpFecha1.Value = DateTime.Today;
            this.dtpFecha2.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            this.conexion = pConexion;
            this.cargarCmbDepartamento(pConexion);
            this.cargarComboCodigoEmpleado(pConexion);
            this.cmbCodigo.SelectedItem = null;
            this.cmbDepartamento.SelectedItem = null;
            this.lblEstadoUnificacion.Text = "OK";
            this.lblEstadoUnificacion.ForeColor = System.Drawing.Color.Blue;
        }

        public frmUnificacion(UnificacionL pUnificacionEditar, List<UsuarioL> pUsuarioActual, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.dtpFecha1.Value = DateTime.Today;
            this.dtpFecha2.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            this.conexion = pConexion;
            this.cargarCmbDepartamento(pConexion);
            this.cargarComboCodigoEmpleado(pConexion);
            this.cmbCodigo.SelectedItem = null;
            this.cmbDepartamento.SelectedItem = null;
            this.lblEstadoUnificacion.Text = "OK";
            this.lblEstadoUnificacion.ForeColor = System.Drawing.Color.Blue;
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
        public void cargarComboCodigoEmpleado(AccesoDatosOracle pcnx)
        {
            if (this.cmbDepartamento.Text == "")
            {
                EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
                cmbCodigo.DataSource = oEmpleadoD.obtenerCodigoEmpleado().Tables[0].Copy();
                cmbCodigo.DisplayMember = "idEmpleado";
                cmbCodigo.ValueMember = "idEmpleado";
                this.cmbCodigo.SelectedItem = null;
            }
            else
            {
                EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
                cmbCodigo.DataSource = oEmpleadoD.obtenerIdEmpleadoPorDepartameno(this.cmbDepartamento.SelectedValue.ToString()).Tables[0].Copy();
                cmbCodigo.DisplayMember = "idEmpleado";
                cmbCodigo.ValueMember = "idEmpleado";
                this.cmbCodigo.SelectedItem = null;
            }
        }

        public void cargarGrid()
        {
            try
            {
                MarcaD oMarcaD = new MarcaD(this.conexion);
                this.grdMarcas.DataSource = oMarcaD.obtenerMarca();
                if (oMarcaD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oMarcaD.ErrorDescription);

                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string idEmpleado = "";
            string departamento = "";
            string nombreEmpleado = "";
            string estadoMarca = "";
            string activo = "Activo";

            {
                if ((this.dtpFecha1.Value < this.dtpFecha2.Value))
                {

                    MarcaD oMarcaD = new MarcaD(this.conexion);

                    

                    if (this.cmbDepartamento.SelectedValue == null)
                    {
                        departamento = "";
                    }
                    else
                    {
                        departamento = this.cmbDepartamento.SelectedValue.ToString();
                    }

                    if (this.cmbCodigo.SelectedValue == null)
                    {
                        nombreEmpleado = "";
                    }
                    else
                    {
                        nombreEmpleado = this.cmbCodigo.SelectedValue.ToString();
                    }

                  


                    List<MarcaL> listaMarcas = oMarcaD.obtenerMarcaFiltro(this.dtpFecha1.Value, this.dtpFecha2.Value, idEmpleado, departamento,
                                                                             nombreEmpleado, estadoMarca, activo);
                    if (!oMarcaD.Error)
                    {
                        this.grdMarcas.DataSource = listaMarcas;
                    }
                    else
                    {
                        MessageBox.Show("Error cargando los datos!!!");
                    }


                }
                else
                {
                    MessageBox.Show("Revisar el rango de fechas ya que alguna de las suministradas es errónea");
                    return;
                }


            }
        }

        private void cmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.cargarComboCodigoEmpleado(this.conexion);
        }


    }
}
