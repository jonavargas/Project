using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using Logica;
using GUI;


namespace Datos
{
    public class FechasDoblesD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public FechasDoblesD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }

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

        public List<FechasDoblesL> obtenerFechasPagoDoble()
        {
            List<FechasDoblesL> retorno = new List<FechasDoblesL>();

            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from fechasPagoDoble");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new FechasDoblesL(         fila["detalleFechaDoble"].ToString(), 
                                                               int.Parse(fila["dia"].ToString()),
                                                               fila["mes"].ToString(),
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
                    this.errorDescription = "Error obteniendo la fecha de pago doble:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo la fecha de pago doble:" + e.Message;
            }

            return retorno;
        }

        public List<FechasDoblesL> obtenerFechaPagoDoble(string pDetalle)
        {
            List<FechasDoblesL> retorno = new List<FechasDoblesL>();
            try
            {
                string sql = ("select * from fechasPagoDoble where detalleFechaDoble = :detalleFechaDoble");

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":detalleFechaDoble";
                parametros[0].Value = pDetalle;

                DataSet datos = this.cnx.ejecutarConsultaSQL(sql, "detalleFechaDoble", parametros);

                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new FechasDoblesL(         fila["detalleFechaDoble"].ToString(),
                                                               int.Parse(fila["dia"].ToString()),
                                                               fila["mes"].ToString(),
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
                    this.errorDescription = "Error obteniendo el detalle de pago doble:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo el detalle de pago doble:" + e.Message;
            }

            return retorno;
        }

        public void agregarFechaPagoDoble(FechasDoblesL pFechasDoblesL)
        {
            try
            {
                string sql = "insert into fechasPagoDoble(detalleFechaDoble, dia, mes, creadoPor, fechaCreacion, modificadoPor, fechaModificacion) " +
                             "values(:detalleFechaDoble, :dia, :mes, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion)";

                OracleParameter[] parametros = new OracleParameter[7];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":detalleFechaDoble";
                parametros[0].Value = pFechasDoblesL.DetalleFechaDoble;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Number;
                parametros[1].ParameterName = ":dia";
                parametros[1].Value = pFechasDoblesL.Dia;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":mes";
                parametros[2].Value = pFechasDoblesL.Mes;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":creadoPor";
                parametros[3].Value = pFechasDoblesL.CreadoPor;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fechaCreacion";
                parametros[4].Value = pFechasDoblesL.FechaCreacion;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":modificadoPor";
                parametros[5].Value = pFechasDoblesL.ModificadoPor;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.DateTime;
                parametros[6].ParameterName = ":fechaModificacion";
                parametros[6].Value = pFechasDoblesL.FechaModificacion;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando fechas de pago doble:" + e.Message;
            }
        }

        public void borrarFechaPagoDoble(FechasDoblesL pFechasDobles)
        {
            try
            {
                string sql = "delete from fechasPagoDoble where detalleFechaDoble = :detalleFechaDoble";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":detalleFechaDoble";
                parametros[0].Value = pFechasDobles.DetalleFechaDoble;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando fechas de pago doble:" + e.Message;
            }
        }

        public void editarFechaPagoDoble(FechasDoblesL pDetalleOriginal, FechasDoblesL pDetalleEditado)
        {
            try
            {
                string sql = "update fechasPagoDoble " +
                             "set detalleFechaDoble = :detalleFechaDoble, dia = :dia, mes = :mes, creadoPor = :creadoPor, fechaCreacion = :fechaCreacion, modificadoPor = :modificadoPor, fechaModificacion = :fechaModificacion " +
                             "where detalleFechaDoble = :detalleFechaDobleOriginal";

                OracleParameter[] parametros = new OracleParameter[8];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":detalleFechaDoble";
                parametros[0].Value = pDetalleEditado.DetalleFechaDoble;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Number;
                parametros[1].ParameterName = ":dia";
                parametros[1].Value = pDetalleEditado.Dia;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":mes";
                parametros[2].Value = pDetalleEditado.Mes;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":creadoPor";
                parametros[3].Value = pDetalleEditado.CreadoPor;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fechaCreacion";
                parametros[4].Value = pDetalleEditado.FechaCreacion;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":modificadoPorEditado";
                parametros[5].Value = pDetalleEditado.ModificadoPor;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.DateTime;
                parametros[6].ParameterName = ":fechaModificacion";
                parametros[6].Value = pDetalleEditado.FechaModificacion;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":detalleFechaDobleOriginal";
                parametros[7].Value = pDetalleEditado.DetalleFechaDoble;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando fechas de pago doble:" + e.Message;
            }
        }
    }
}
