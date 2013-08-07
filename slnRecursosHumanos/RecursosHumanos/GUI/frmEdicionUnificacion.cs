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

        public List<UsuarioL> OUsuarioConectado
        {
            get { return oUsuarioConectado; }
            set { oUsuarioConectado = value; }
        }

        public frmEdicionUnificacion(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.conexion = pConexion;
            this.cargarComboCodigoEmpleado(pConexion);
            this.cmbIDEmpleado.SelectedItem = null;
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

         private void validarMarcas()
        {
            this.txthoraDoble.Text = "0";
            this.txtmontoDobles.Text = "0";
            this.txthoraExtra.Text = "0";
            this.txthoraRegular.Text = "0";
            this.txtmontoExtraOrdinario.Text = "0";
            this.txtmontoRegular.Text = "0";
            this.txtPorcentajeDeduccion.Text = "0";
            this.txtMontoDeduccion.Text = "0";
            this.txtNeto.Text = "0";
            this.txtBruto.Text = "0";
            this.pagoDoble = 0;
            this.pagoExtra = 0;
            this.pagoOrdinario = 0;
            this.montoDeduccion = 0;
            Boolean banderaError = false;
            this.txtEstadoMarcas.BackColor = System.Drawing.Color.LightBlue;

            if (this.grdMarcas.RowCount > 0)
            {
                                    #region Crear parejas de marcas
                                    //int contador = 0;
                                    int cantidadFilas = this.grdMarcas.RowCount;
                                    for (int contador = 0; contador < cantidadFilas; contador++)
                                    //if (this.grdMarcas.RowCount >= contador)
                                    {

                                        #region marcaEntrada
                                        int idMarca = Convert.ToInt32(this.grdMarcas["idMarca", contador].Value.ToString());
                                        int idUnificacion = Convert.ToInt32(this.grdMarcas["idUnificacion", contador].Value.ToString());
                                        string idEmpleado = this.grdMarcas["idEmpleado", contador].Value.ToString();
                                        string nombre = this.grdMarcas[3, contador].Value.ToString();
                                        DateTime fecha = DateTime.Parse(this.grdMarcas["fecha", contador].Value.ToString());
                                        string tipo = this.grdMarcas["tipo", contador].Value.ToString();
                                        string estado = this.grdMarcas["estado", contador].Value.ToString();
                                        string creadoPor = this.grdMarcas["creadoPor", contador].Value.ToString();
                                        DateTime fechaCreacion = DateTime.Parse(this.grdMarcas["fechaCreacion", contador].Value.ToString());
                                        string modificadoPor = this.grdMarcas["modificadoPor", contador].Value.ToString();
                                        DateTime fechaModificacion = DateTime.Parse(this.grdMarcas["fechaModificacion", contador].Value.ToString());
                                        #endregion

                                        marcaEntrada = new MarcasL(idMarca, idUnificacion, idEmpleado, fecha, tipo, estado, creadoPor, fechaCreacion, modificadoPor, fechaModificacion, nombre);
                                        marcaSalida = new MarcasL(idMarca, idUnificacion, idEmpleado, fecha, tipo, estado, creadoPor, fechaCreacion, modificadoPor, fechaModificacion, nombre);
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

                                            marcaSalida = new MarcasL(idMarca, idUnificacion, idEmpleado, fecha, tipo, estado, creadoPor, fechaCreacion, modificadoPor, fechaModificacion, nombre);
                                        }
                                    #endregion

                                    #region verificar errores de marcas
                                        //iguala las marcas para descartar alguna ultima marca que sea de entrada y no se le alla asignado una salida
                                        if (marcaEntrada.IdMarca != marcaSalida.IdMarca)
                                        {
                                            fechaEntrada = marcaEntrada.Fecha.Date;
                                            fechaSalida = marcaSalida.Fecha.Date;

                                            if (fechaEntrada == fechaSalida)
                                            {
                                                if (marcaEntrada.Tipo == "e" && marcaSalida.Tipo == "s")
                                                {
                                                    if (banderaError == false)
                                                    {
                                        #endregion

                                    #region cálculoHorasDobles
                                    this.horasTotales = marcaSalida.Fecha - marcaEntrada.Fecha;
                                    CategoriaFechasDoblesL objFechasDobles = new CategoriaFechasDoblesL(this.cnx);
                                    //EmpleadoL obj = new EmpleadoL();

                                    if (objFechasDobles.validarFechaDoble(marcaEntrada.Fecha) == true)
                                    {
                                        horasDobles = Convert.ToDouble(this.txtHorasDobles.Text) + objFechasDobles.horasDobles(this.horasTotales);
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
                                    #endregion

                                    #region cálculo horas Ordinarias y extras
                                    else
                                    {

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

                                            HorarioL objHorario = new HorarioL(this.cnx);
                                            //objHorario.calculaExtraYOrdinaria(marcaEntrada, marcaSalida, this.horasTotales);
                                            objHorario.calculaExtraYOrdinariaPrueba(marcaEntrada, marcaSalida);

                                            this.horasExtras = objHorario.HorasExtrasConvertidas + Convert.ToDouble(this.txtHoraExtraOrdinaria.Text);
                                            this.txtHoraExtraOrdinaria.Text = this.horasExtras.ToString();

                                            this.pagoExtra = /*Convert.ToDouble(this.txtPagoExtraOrdinario.Text) + */empleado.pagoExtraOrdinario(Convert.ToDouble(this.horasExtras));
                                            this.txtPagoExtraOrdinario.Text = this.pagoExtra.ToString();

                                            this.horasOrdinarias = objHorario.HorasOrdinariasConvertidas + Convert.ToDouble(this.txtHorasOrdinarias.Text);
                                            this.txtHorasOrdinarias.Text = this.horasOrdinarias.ToString();

                                            this.pagoOrdinario = /*Convert.ToDouble(this.txtPagoOrdinario.Text) +*/ empleado.pagoOrdinario(Convert.ToDouble(this.horasOrdinarias));
                                            this.txtPagoOrdinario.Text = this.pagoOrdinario.ToString();

                                            this.txtEstadoMarcas.Text = "Ok";
                                        }
                                    }
                                    #endregion

                                    #region Calcula salario Bruto

                                    this.calcularSalarioBruto();
                                    this.txtBruto.Text = salarioBruto.ToString();

                                    #endregion

                                    #region Calcula Deducciones Empleados

                                    DeduccionEmpleadoL oDeduccionEmpleado = new DeduccionEmpleadoL(this.cnx);
                                    oDeduccionEmpleado.calcularDeduccionesEmpleado(this.empleado);
                                    this.porcentajeDeduccion = oDeduccionEmpleado.PorcentajeSumado;
                                    this.txtPorcentajeDeduccion.Text = Convert.ToString(this.porcentajeDeduccion) + " %";

                                    this.montoDeduccion = this.salarioBruto * (porcentajeDeduccion / 100);
                                    this.txtMontoDeduccion.Text = this.montoDeduccion.ToString();
                                    #endregion

                                    #region Calcula Salario Neto

                                    this.calcularSalarioNeto();
                                    this.txtNeto.Text = this.salarioNeto.ToString();
                                }

                            }
                                    #endregion

                                    #region ErrorMarcas
                            else
                            {
                                banderaError = true;
                                this.porcentajeDeduccion = 0.0;
                                this.pagoOrdinario = 0.0;
                                this.pagoExtra = 0.0;
                                this.pagoDoble = 0.0;
                                this.montoDeduccion = 0.0;
                                this.salarioBruto = 0.0;
                                this.salarioNeto = 0.0;                                        
                                this.txtBruto.Text = "0.0";
                                this.txtNeto.Text = "0.0";
                                this.txtHorasDobles.Text = "0.0";
                                this.txtPagoDoble.Text = "0.0";
                                this.txtHoraExtraOrdinaria.Text = "0.0";
                                this.txtHorasOrdinarias.Text = "0.0";
                                this.txtEstadoMarcas.BackColor = System.Drawing.Color.Red;
                                this.txtEstadoMarcas.Text = "Error";
                                //this.grdMarcas.ForeColor = Color.Red;
                                //return;
                            }
                        }
                        else
                        {
                            banderaError = true;
                            this.porcentajeDeduccion = 0.0;
                            this.pagoOrdinario = 0.0;
                            this.pagoExtra = 0.0;
                            this.pagoDoble = 0.0;
                            this.montoDeduccion = 0.0;
                            this.salarioBruto = 0.0;
                            this.salarioNeto = 0.0; 
                            this.txtBruto.Text = "0.0";
                            this.txtNeto.Text = "0.0";
                            this.txtHorasDobles.Text = "0.0";
                            this.txtPagoDoble.Text = "0.0";
                            this.txtHoraExtraOrdinaria.Text = "0.0";
                            this.txtHorasOrdinarias.Text = "0.0";
                            this.txtEstadoMarcas.BackColor = System.Drawing.Color.Red;
                            this.txtEstadoMarcas.Text = "Error";
                            //this.grdMarcas.ForeColor = Color.Red;
                            //return;
                        }

                    }
                    else
                    {
                        banderaError = true;
                        this.porcentajeDeduccion = 0.0;
                        this.pagoOrdinario = 0.0;
                        this.pagoExtra = 0.0;
                        this.pagoDoble = 0.0;
                        this.montoDeduccion = 0.0;
                        this.salarioBruto = 0.0;
                        this.salarioNeto = 0.0; 
                        this.txtBruto.Text = "0.0";
                        this.txtNeto.Text = "0.0";
                        this.txtHorasDobles.Text = "0.0";
                        this.txtPagoDoble.Text = "0.0";
                        this.txtHoraExtraOrdinaria.Text = "0.0";
                        this.txtHorasOrdinarias.Text = "0.0";
                        this.txtEstadoMarcas.BackColor = System.Drawing.Color.Red;
                        this.txtEstadoMarcas.Text = "Error";

                            #endregion
                    }
                }
            }


    }
}
