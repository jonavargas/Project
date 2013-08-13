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
        private bool edicion = false;
        List<UsuarioL> oUsuarioConectado;
        MarcaL oMarcaL, oMarcaCambioEstado;
        MarcaD oMarcaD;
        int numeroUnificacion = 0;
        

        public List<UsuarioL> OUsuarioConectado
        {
            get { return oUsuarioConectado; }
            set { oUsuarioConectado = value; }
        }

        public frmEdicionUnificacion(List<UsuarioL> pUsuarioConectado, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.conexion = pConexion;
            this.OUsuarioConectado = pUsuarioConectado;
            this.cargarComboCodigoEmpleado(pConexion);
            this.grpBotones.Visible = false;
            this.txthoraDoble.Text = Convert.ToString(0);
            this.txthoraExtra.Text = Convert.ToString(0);
            this.txthoraRegular.Text = Convert.ToString(0);
            this.txtmontoDobles.Text = Convert.ToString(0);
            this.txtmontoRegular.Text = Convert.ToString(0);
            this.txtmontoExtra.Text = Convert.ToString(0);
            this.txthoraDoble.Enabled = false;
            this.txthoraExtra.Enabled = false;
            this.txthoraRegular.Enabled = false;
            this.txtmontoDobles.Enabled = false;
            this.txtmontoRegular.Enabled = false;
            this.txtmontoExtra.Enabled = false;            
            this.lblEstadoUnificacion.Text = "OK";
            this.lblEstadoUnificacion.ForeColor = System.Drawing.Color.Blue;
            this.txtNumUni.Enabled = false;
        }
        public frmEdicionUnificacion(UnificacionL pUnificacionEditar,List<UsuarioL> pUsuarioConectado, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.conexion = pConexion;
            this.OUsuarioConectado = pUsuarioConectado;
            this.cargarComboCodigoEmpleado(pConexion);
            this.cmbIDEmpleado.SelectedItem = null;
            this.lblEstadoUnificacion.Text = "OK";
            this.lblEstadoUnificacion.ForeColor = System.Drawing.Color.Blue;
            this.txtNumUni.Enabled = false;
        }

        /// <summary>
        /// Método para cargar el combobox CodigoEmpleadoo con los codigos existentes en la base de datos.
        /// También rellena el combo box código empleado de acuerdo a los empleados que existen en el departamento seleccionado.
        /// </summary>
        /// <param name="pcnx"></param>
        public void cargarComboCodigoEmpleado(AccesoDatosOracle pcnx)
        {
            EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
            cmbIDEmpleado.DataSource = oEmpleadoD.obtenerCodigoEmpleado().Tables[0].Copy();
            cmbIDEmpleado.DisplayMember = "idEmpleado";
            cmbIDEmpleado.ValueMember = "idEmpleado";
        }

        private void btnCargarMarca_Click(object sender, EventArgs e)
        {
            string idEmpleado = "";
            string departamento = "";
            string nombreEmpleado = "";
            string estadoMarca = "";
            string activo = "Sí";

            {
                if ((this.dtpFecha1.Value < this.dtpFecha2.Value))
                {

                    MarcaD oMarcaD = new MarcaD(this.conexion);

                    if (this.cmbIDEmpleado.SelectedValue == null)
                    {
                        idEmpleado = "";
                    }
                    else
                    {
                        idEmpleado = this.cmbIDEmpleado.SelectedValue.ToString();


                    }                

                  

                    if (this.cmbEstado.SelectedIndex.ToString() != "-1")
                    {
                        estadoMarca = this.cmbEstado.SelectedItem.ToString();
                    }
                    else
                    {
                        estadoMarca = "";
                    }

                    
                    List<MarcaL> listaMarcas = oMarcaD.obtenerMarcaFiltro(this.dtpFecha1.Value, this.dtpFecha2.Value, idEmpleado, departamento,
                                                                             nombreEmpleado, estadoMarca, activo);


                    for (int i = 0; i < listaMarcas.Count; i++)
                    {
                        listaMarcas[i].IdUnificacion = this.numeroUnificacion;
                        listaMarcas[i].EstadoMarca = "Trámite";
                        listaMarcas[i].ModificadoPor = this.oUsuarioConectado[0].IdUsuario;
                        listaMarcas[i].FechaModificacion = DateTime.Now;
                        MarcaL marcaEditada = listaMarcas[i];

                        oMarcaD.editarMarca(marcaEditada, marcaEditada);
                        if (oMarcaD.Error)
                        {
                            this.conexion.rollbackTransaccion();
                            MessageBox.Show("Error, detalle:" + oMarcaD.ErrorDescription);
                            return;
                        }
                    }



                    
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

        private void btnBorrarMarca_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception)
            {
                MessageBox.Show("Error anulando");
                return;

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

        private void btnEditarMarca_Click(object sender, EventArgs e)
        {
            if (this.grdMarcas.RowCount > 0)
            {
                MarcaL oMarcaL = (MarcaL)this.grdMarcas.CurrentRow.DataBoundItem;


                if (oMarcaL.EstadoMarca == "Generada")
                {
                    frmEdicionMarcas ofrmEdicion = new frmEdicionMarcas(oMarcaL, this.oUsuarioConectado, this.conexion);
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
                            
                        }
                    }


                }

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionMarcas ofrmEdicionMarcas = new frmEdicionMarcas(this.oUsuarioConectado, this.conexion);
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            UnificacionD oUnificacionD = new UnificacionD(this.conexion);
            try
            {
                if (!this.conexion.IsError)
                {
                    UnificacionL oUnificacionL = new UnificacionL(0, this.cmbIDEmpleado.SelectedItem.ToString(), 0, this.cmbEstado.SelectedItem.ToString(), DateTime.Now, 0, 0, 0, "", "", 0, 0, 0, 0, 0, 0, 0, OUsuarioConectado[0].IdUsuario, DateTime.Parse(this.dtpFecha1.Text), OUsuarioConectado[0].IdUsuario, DateTime.Parse(this.dtpFecha2.Text), "Sí");

                    string numeroUnificacion = oUnificacionD.agregarUnificacion(oUnificacionL);
                    this.numeroUnificacion = int.Parse(numeroUnificacion);
                    this.txtNumUni.Text = numeroUnificacion;
                    this.cmbIDEmpleado.Enabled = false;
                    this.dtpFecha1.Enabled = false;
                    this.dtpFecha2.Enabled = false;
                    this.cmbEstado.Enabled = false;
                    this.grpBotones.Visible=true;

                    MessageBox.Show("La Unificacion fue agregada con exito");
                }
                else {
                    this.conexion.rollbackTransaccion();
                    MessageBox.Show("Error agregando Unificacion");
                
                }

            }
            catch (Exception)
            {
                this.conexion.rollbackTransaccion();
                MessageBox.Show("Error agregando Unificacion");



            }


        }

    


    }
}
