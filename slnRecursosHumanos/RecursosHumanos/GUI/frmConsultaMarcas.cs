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
        MarcaL oMarcaL,oMarcaCambioEstado;
        MarcaD oMarcaD;
      

        /// <summary>
        /// Metodo constructor que recibe por parámetro la conexión a la base de datos.
        /// </summary>
        /// <param name="pConexion"></param>
        public frmConsultaMarcas(AccesoDatosOracle pConexion)
        {
            InitializeComponent();            
            this.conexion = pConexion;
            this.cargarGrid();
            this.dtpFecha1.Value = DateTime.Today;
            this.dtpFecha2.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
            this.cargarCmbDepartamento(pConexion);
            this.cargarComboEmpleado(pConexion);
            this.cargarComboCodigoEmpleado(pConexion);
            this.cmbCodigo.SelectedItem = null;
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
        /// Boton nuevo que llama al frmedición marcas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionMarcas ofrmEdicionMarcas = new frmEdicionMarcas(conexion);
            ofrmEdicionMarcas.ShowDialog();

            if (ofrmEdicionMarcas.Aceptar)
            {
                MarcaD oMarcaD = new MarcaD(this.conexion);
                oMarcaD.agregarMarca2(ofrmEdicionMarcas.MarcaL);
                if (!oMarcaD.Error)
                {

                    MessageBox.Show("Registro agregado!!!");
                    this.cargarGrid();


                }
                else
                {
                    MessageBox.Show("Error agregando los datos:" + oMarcaD.ErrorDescription);

                }

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdMarcas.RowCount > 0)
            {
                MarcaL oMarcaL = (MarcaL)this.grdMarcas.CurrentRow.DataBoundItem;


                if (oMarcaL.EstadoMarca == "Generada")
                {
                    frmEdicionMarcas ofrmEdicion = new frmEdicionMarcas(oMarcaL, this.conexion);
                    ofrmEdicion.ShowDialog();
                    if (ofrmEdicion.Aceptar)
                    {
                        this.oMarcaD = new MarcaD(this.conexion);
                        oMarcaD.editarMarca(ofrmEdicion.MarcaL, oMarcaL);
                        if (oMarcaD.Error)
                        {
                            MessageBox.Show("Error actualizando los datos:" + oMarcaD.ErrorDescription);
                        }
                        else
                        {
                            MessageBox.Show("Registro actualizada!!!");
                            this.cargarGrid();
                        }
                    }


                }

            }
        }

        /// <summary>
        /// Método para limpiar los datos que se encuentran seleccionados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            this.cmbCodigo.SelectedItem = null;
            this.cmbDepartamento.SelectedItem = null;
            this.cmbEmpleado.SelectedItem = null;
            this.cmbEstadoMarca.SelectedItem = null;
            this.rbtActivo.Checked = false;
            this.rbtInactivo.Checked = false;
            this.dtpFecha1.Value = DateTime.Today;
            this.dtpFecha2.Value = DateTime.Today;     
        }

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

        /// <summary>
        /// Evento del botón filtrar que nos filtra la información para emcontrarla más rapido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFiltrar_Click_1(object sender, EventArgs e)
        {
            string idEmpleado = "";
            string departamento = "";
            string nombreEmpleado = "";
            string estadoMarca = "";
            string activo = "Activo";

            {
                if (this.dtpFecha1.Value > this.dtpFecha2.Value)
                {
                    MessageBox.Show("Revisar el rango de fechas");
                    return;
                }

                MarcaD oMarcaD = new MarcaD(this.conexion);

                if (this.cmbCodigo.SelectedValue == null)
                {
                    idEmpleado = "";
                }
                else
                {
                    idEmpleado = this.cmbCodigo.SelectedValue.ToString();
                }

                if (this.cmbDepartamento.SelectedValue == null)
                {
                    departamento = "";
                }
                else
                {
                    departamento = this.cmbDepartamento.SelectedValue.ToString();
                }

                if (this.cmbEmpleado.SelectedValue == null)
                {
                    nombreEmpleado = "";
                }
                else
                {
                    nombreEmpleado = this.cmbEmpleado.SelectedValue.ToString();
                }

                if (this.cmbEstadoMarca.SelectedIndex.ToString() != "-1")
                {
                    estadoMarca = this.cmbEstadoMarca.SelectedItem.ToString();
                }
                else
                {
                    estadoMarca = "";
                }

                if (this.rbtActivo.Checked == true)
                {
                    activo = "Sí";
                }
                else if (this.rbtInactivo.Checked == true)
                {
                    activo = "No";
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
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {

            if (this.grdMarcas.RowCount > 0)
            {
                MarcaL oMarcaL = (MarcaL)this.grdMarcas.CurrentRow.DataBoundItem;

                if (oMarcaL.EstadoMarca == "Generada")
                {
                    DialogResult confirmacion = MessageBox.Show("¿Está seguro de Anular esta Marca?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmacion == DialogResult.No) return;
                    this.oMarcaCambioEstado = (MarcaL)this.grdMarcas.CurrentRow.DataBoundItem;
                    oMarcaCambioEstado.EstadoMarca = "Anulada";
                    oMarcaCambioEstado.FechaModificacion = DateTime.Now;
                    MarcaD oMarcaD = new MarcaD(this.conexion);
                    oMarcaD.editarMarca(oMarcaCambioEstado, oMarcaL);
                    if (oMarcaD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oMarcaD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Marca Anulada!!!");
                        this.cargarGrid();
                    }
                }
                else
                {
                    MessageBox.Show("La Marca solo se puede modificar si su estado es 'Generada'");
                    return;
                }
            }
        }
    }
}
