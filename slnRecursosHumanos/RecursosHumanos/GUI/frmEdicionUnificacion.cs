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
        MarcaL marcaEntrada;
        MarcaL marcaSalida;
        DateTime fechaEntrada;
        DateTime fechaSalida;
        double horasDobles;
        TimeSpan horasTotales;//se utliza timespan la que es la opcion que nos permite capturar el intervalo de timepo que exite entre la hora de entrada y salida

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


            if ((this.dtpFecha1.Value < this.dtpFecha2.Value))
            {
                Boolean banderaError = false;
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





                if (this.grdMarcas.RowCount > 0)
                {
                    int cantidadFilas = this.grdMarcas.RowCount;
                    for (int contador = 0; contador < cantidadFilas; contador++)
                    {

                        int idMarca = Convert.ToInt32(this.grdMarcas["idMarca", contador].Value.ToString());
                        int idUnificacion = Convert.ToInt32(this.grdMarcas["idUnificacion", contador].Value.ToString());
                        idEmpleado = this.grdMarcas["idEmpleado", contador].Value.ToString();
                        string nombre = this.grdMarcas[3, contador].Value.ToString();
                        DateTime fecha = DateTime.Parse(this.grdMarcas["fecha", contador].Value.ToString());
                        string tipo = this.grdMarcas["tipo", contador].Value.ToString();
                        string estado = this.grdMarcas["estado", contador].Value.ToString();
                        string creadoPor = this.grdMarcas["creadoPor", contador].Value.ToString();
                        DateTime fechaCreacion = DateTime.Parse(this.grdMarcas["fechaCreacion", contador].Value.ToString());
                        string modificadoPor = this.grdMarcas["modificadoPor", contador].Value.ToString();
                        DateTime fechaModificacion = DateTime.Parse(this.grdMarcas["fechaModificacion", contador].Value.ToString());
                        activo = this.grdMarcas["activo", contador].Value.ToString();


                        marcaEntrada = new MarcaL(idMarca, idEmpleado, idUnificacion, nombre, estado, tipo, fecha, creadoPor, fechaCreacion, modificadoPor, fechaModificacion, activo);
                        marcaSalida = new MarcaL(idMarca, idEmpleado, idUnificacion, nombre, estado, tipo, fecha, creadoPor, fechaCreacion, modificadoPor, fechaModificacion, activo);
                        contador++;

                        if (contador < cantidadFilas)
                        {
                            #region marcaSalida
                            idMarca = Convert.ToInt32(this.grdMarcas["idMarca", contador].Value.ToString());
                            idUnificacion = Convert.ToInt32(this.grdMarcas["idUnificacion", contador].Value.ToString());
                            idEmpleado = this.grdMarcas["idEmpleado", contador].Value.ToString();
                            nombre = this.grdMarcas[3, contador].Value.ToString();
                            fecha = DateTime.Parse(this.grdMarcas["fecha", contador].Value.ToString());
                            tipo = this.grdMarcas["tipo", contador].Value.ToString();
                            estado = this.grdMarcas["estado", contador].Value.ToString();
                            creadoPor = this.grdMarcas["creadoPor", contador].Value.ToString();
                            fechaCreacion = DateTime.Parse(this.grdMarcas["fechaCreacion", contador].Value.ToString());
                            modificadoPor = this.grdMarcas["modificadoPor", contador].Value.ToString();
                            fechaModificacion = DateTime.Parse(this.grdMarcas["fechaModificacion", contador].Value.ToString());
                            #endregion

                            marcaSalida = new MarcaL(idMarca, idEmpleado, idUnificacion, nombre, estado, tipo, fecha, creadoPor, fechaCreacion, modificadoPor, fechaModificacion, activo);

                        }
                        if (marcaEntrada.IdMarca != marcaSalida.IdMarca)
                        {
                            fechaEntrada = marcaEntrada.FechaMarca.Date;
                            fechaSalida = marcaSalida.FechaMarca.Date;

                            if (fechaEntrada == fechaSalida)
                            {
                                if (marcaEntrada.TipoMarca == "Entrada" && marcaSalida.TipoMarca == "Salida")
                                {
                                    if (banderaError == false)
                                    {

                                        this.horasTotales =marcaSalida.FechaMarca - marcaEntrada.FechaMarca;
                                        CatalogoFechasL oFechasDobles = new CatalogoFechasL();


                                        if (oFechasDobles.validarFecha(marcaEntrada.FechaMarca) == true)
                                        {
                                            horasDobles = Convert.ToDouble(this.txthoraDoble.Text) + oFechasDobles.horasDobles(this.horasTotales);
                                            this.txtHorasDobles.Text = horasDobles.ToString();

                                            if (this.grdEmpleadosUnificar.RowCount > 0)
                                            {
                                                int fila = this.grdEmpleadosUnificar.CurrentRow.Index;

                                                string pId = this.grdEmpleadosUnificar["colId", fila].Value.ToString();
                                                string pNombre = this.grdEmpleadosUnificar["colNombre", fila].Value.ToString();
                                                string pApellido1 = this.grdEmpleadosUnificar["colApellido1", fila].Value.ToString();
                                                string pApellido2 = this.grdEmpleadosUnificar["colApellido2", fila].Value.ToString();
                                                string pNombreCompleto = this.grdEmpleadosUnificar["colNombreCompelto", fila].Value.ToString();
                                                string pEmail = this.grdEmpleadosUnificar["colEmail", fila].Value.ToString();
                                                int pTelefono = Convert.ToInt32(this.grdEmpleadosUnificar["colTelefono", fila].Value.ToString());
                                                string pDepartamento = this.grdEmpleadosUnificar["colIdDepartamento", fila].Value.ToString();
                                                double pSalario = Convert.ToDouble(this.grdEmpleadosUnificar["colPrecioHora", fila].Value.ToString());
                                                string pEstado = this.grdEmpleadosUnificar["colEstado", fila].Value.ToString();
                                                string pCreadoPor = this.grdEmpleadosUnificar["colCreadoPor", fila].Value.ToString();
                                                DateTime pFechaCreacion = Convert.ToDateTime(this.grdEmpleadosUnificar["colFechaCreacion", fila].Value.ToString());
                                                string pModificadoPor = this.grdEmpleadosUnificar["colModificadoPor", fila].Value.ToString();
                                                DateTime pFechaMod = Convert.ToDateTime(this.grdEmpleadosUnificar["colFechaModificacion", fila].Value.ToString());


                                                empleado = new EmpleadoL(pId, pNombre, pApellido1, pApellido2, pNombreCompleto, pEmail,
                                                                                    pTelefono, pDepartamento, pSalario, pEstado, pCreadoPor,
                                                                                    pFechaCreacion, pModificadoPor, pFechaMod);

                                                pagoDoble = empleado.pagoDoble(Convert.ToDouble(this.txtHorasDobles.Text));
                                                this.txtPagoDoble.Text = pagoDoble.ToString();


                                                this.txtEstadoMarcas.Text = "Ok";
                                            }
                                        }




                                    }






                                }




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
            UnificacionD oUnificacionD = new UnificacionD( this.conexion);
            try
            {
                if (!this.conexion.IsError)
                {
                 
                    UnificacionL oUnificacionL = new UnificacionL(0, this.cmbIDEmpleado.SelectedValue.ToString(), 0, this.cmbEstado.SelectedItem.ToString(), DateTime.Now, 0, 0, 0, "", "", 0, 0, 0, 0, 0, 0, 0, this.OUsuarioConectado[0].IdUsuario, DateTime.Parse(this.dtpFecha1.Text),this.OUsuarioConectado[0].IdUsuario, DateTime.Parse(this.dtpFecha2.Text), "Sí");

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
