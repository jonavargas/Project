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

        public string agregarPagos(PagosL pPagosL)
        {
            string retorno = "";
            try
            {
                string sql = "insert into pago(fechaPago1, fechaPago2, totalPagos, totalDeducciones, anulado, descripcion, creadoPor, fechaCreacion, modificadoPor, fechaModificacion) " +
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
                parametros[2].ParameterName = ":totalPagos";
                parametros[2].Value = pPagosL.TotalPagos;

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
                this.errorDescription = "Error agregando pago:" + e.Message;
            }

            return retorno;
        }
    }
}
