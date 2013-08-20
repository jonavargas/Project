using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logica;
using System.Data;
using System.Data.OracleClient;

namespace Datos
{
    class PagosD
    {
        /// <summary>
        /// Atributos de la clase Empleado en la parte de Datos donde establece conexión con la Base de Datos de Oracle,tambien se crea 
        /// un atributo por si ocurre un error en el proceso de conexión y adémas detalla que tipo de error fue el que se presento
        /// </summary>

        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        /// <summary>
        /// Método Constructor de la Clase Empleado el cual recibe como  parámetro una conexión a Acceso de datos Oracle el cual es el que 
        /// inicializa el atributo 
        /// </summary>
        public PagosD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }

        /// <summary>
        /// Properties de la Clase Pagos en cual permite modificar o consultar los datos con los cuales fueron cargados los atributos de 
        /// la clase existente
        /// </summary>
        public AccesoDatosOracle Cnx
        {
            get { return cnx; }
            set { cnx = value; }
        }

        public bool Error
        {
            get { return error; }
            set { error = value; }
        }

        public string ErrorDescription
        {
            get { return errorDescription; }
            set { errorDescription = value; }
        }

        /// <summary>
        /// Método que obtiene el Pago el cual realiza una consulta a la base de datos en la tabla Pago,luego consulta si 
        /// ocurrio algún error y sino lo hubo procede a crear un Pago con los datos correspondientes y se los envia a la clase de
        /// lógica de Pagos
        /// /// </summary>
     
        public List<PagosL> obtenerPagos()
        {
            List<PagosL> retorno = new List<PagosL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Pago");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new PagosL(
                                                       int.Parse(fila["idPago"].ToString()),
                                                       Convert.ToDateTime(fila["fechaPago1"].ToString()),
                                                       Convert.ToDateTime(fila["fechaPago2"].ToString()),
                                                       Convert.ToDouble(fila["totalPago"].ToString()),
                                                       Convert.ToDouble(fila["totalDeducciones"].ToString()),
                                                       fila["anulado"].ToString(),
                                                       fila["descripcion"].ToString(),
                                                       fila["creadoPor"].ToString(),
                                                       Convert.ToDateTime(fila["fechaCreacion"].ToString()),
                                                       fila["modificadoPor"].ToString(),
                                                       Convert.ToDateTime(fila["fechaModificacion"].ToString())

                                              )
                                   );
                    }
                }
                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo pagos:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo pagos:" + e.Message;
            }

            return retorno;
        }
        
        /// <summary>
        /// Método que agrega un nuevo Pago a la Base de Datos de Oracle,el cual recibe por parámetro un Pago que viene cargado con 
        /// los respectivos valores para ser pasados a la base de datos ya creada,ademas procede a realizar una consulta al sql para saber si
        /// los parámetros creados coinciden con los de la base de datos y si coinciden procede a insertarlos.
        /// </summary>
        /// <param name="pPagosL"></param>
        
        public string agregarPagos(PagosL pPagosL)
        {
            string retorno = "";
            try
            {
                string sql = "insert into pago(fechaPago1, fechaPago2, totalPago, totalDeducciones, anulado, descripcion, creadoPor, fechaCreacion, modificadoPor, fechaModificacion) " +
                             "values(:fechaPago1, :fechaPago2, :totalPagos, :totalDeducciones, :anulado, :descripcion, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion) " +
                             "returning idPago into :idPago";

                OracleParameter[] parametros = new OracleParameter[11];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.DateTime;
                parametros[0].ParameterName = ":fechaPago1";
                parametros[0].Value = pPagosL.Fecha1;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.DateTime;
                parametros[1].ParameterName = ":fechaPago2";
                parametros[1].Value = pPagosL.Fecha2;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.Double;
                parametros[2].ParameterName = ":totalPago";
                parametros[2].Value = pPagosL.TotalPago;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.Double;
                parametros[3].ParameterName = ":totalDeducciones";
                parametros[3].Value = pPagosL.TotalDeducciones;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":anulado";
                parametros[4].Value = pPagosL.Anulado;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":descripcion";
                parametros[5].Value = pPagosL.Descripcion;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":creadoPor";
                parametros[6].Value = pPagosL.CreadoPor;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.DateTime;
                parametros[7].ParameterName = ":fechaCreacion";
                parametros[7].Value = pPagosL.FechaCreacion;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":modificadoPor";
                parametros[8].Value = pPagosL.ModificadoPor;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.DateTime;
                parametros[9].ParameterName = ":fechaModificacion";
                parametros[9].Value = pPagosL.FechaModificacion;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.Number;
                parametros[10].ParameterName = ":idPago";
                parametros[10].Direction = ParameterDirection.Output;

                retorno = this.cnx.ejecutarSQLReturning(sql, parametros, ":idPago");

                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando el pago:" + e.Message;
            }

            return retorno;
        }

        /// <summary>
        /// Método que nos facilita editar una linea del Pago que se encuentre seleccionada
        /// </summary>
        /// <param name="pPagosL"></param>

        public void editarPago(PagosL pPagosL)
        {
            try
            {
                string sql = "update Pago " +
                             "set idPago = :idPago, " +
                             "fechaPago1 = :fechaPago1, " +
                             "fechaPago2 = :fechaPago2, " +
                             "totalPago = :totalPago, " +
                             "totalDeducciones = :totalDeducciones, " +
                             "anulado = :anulado, " +
                             "descripcion = :descripcion, " +
                             "creadoPor = :creadoPor, " +
                             "fechaCreacion = :fechaCreacion, " +
                             "modificadoPor = :modificadoPor, " +
                             "fechaModificacion = :fechaModificacion " +
                             "where idPago = :idPagoOriginal";

                OracleParameter[] parametros = new OracleParameter[12];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Number;
                parametros[0].ParameterName = ":idPago";
                parametros[0].Value = pPagosL.IdPago;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.DateTime;
                parametros[1].ParameterName = ":fechaPago1";
                parametros[1].Value = pPagosL.Fecha1;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.DateTime;
                parametros[2].ParameterName = ":fechaPago2";
                parametros[2].Value = pPagosL.Fecha2;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.Double;
                parametros[3].ParameterName = ":totalPago";
                parametros[3].Value = pPagosL.TotalPago;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.Double;
                parametros[4].ParameterName = ":totalDeducciones";
                parametros[4].Value = pPagosL.TotalDeducciones;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":anulado";
                parametros[5].Value = pPagosL.Anulado;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":descripcion";
                parametros[6].Value = pPagosL.Descripcion;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":creadoPor";
                parametros[7].Value = pPagosL.CreadoPor;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.DateTime;
                parametros[8].ParameterName = ":fechaCreacion";
                parametros[8].Value = pPagosL.FechaCreacion;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":modificadoPor";
                parametros[9].Value = pPagosL.ModificadoPor;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.DateTime;
                parametros[10].ParameterName = ":fechaModificacion";
                parametros[10].Value = pPagosL.FechaModificacion;

                parametros[11] = new OracleParameter();
                parametros[11].OracleType = OracleType.Double;
                parametros[11].ParameterName = ":idPagoOriginal";
                parametros[11].Value = pPagosL.IdPago;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error actualizando el pago:" + e.Message;
            }
        }

        /// <summary>
        /// Método que borra un Pago,el cual procede a recibir un parámetro de tipo Pago y verifica que en la base de datos 
        /// exista un parámetro igual y procede a eliminar esté
        /// </summary>
        /// <param name="pIdPago"></param>
        public void borrarPagos(double pIdPago)
        {
            try
            {
                string sql = "delete from Pago where idPago = :idPago";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Number;
                parametros[0].ParameterName = ":idPago";
                parametros[0].Value = pIdPago;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando el pago:" + e.Message;
            }
        }
    }
}
