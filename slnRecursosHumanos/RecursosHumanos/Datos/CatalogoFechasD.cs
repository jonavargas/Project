using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using Logica;

namespace Datos
{
    /// <summary>
    /// Atributos de la clase 
    /// </summary>
    public class CatalogoFechasD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        /// <summary>
        /// Metodo costructor que recibe por parametro la conexión
        /// </summary>
        /// <param name="pCnx"></param>
        public CatalogoFechasD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }
        /// <summary>
        /// Propiedades de los atributos
        /// </summary>
        public bool Error
        {
            get { return error; }
        }

        public string ErrorDescription
        {
            get { return errorDescription; }
        }
        /// <summary>
        /// Metodo que obtiene de la base de datos el catalogo de fechas
        /// </summary>
        /// <returns></returns>
        public List<CatalogoFechasL> obtenerCatalogoFechas()
        {
            List<CatalogoFechasL> retorno = new List<CatalogoFechasL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from catalogoFechas");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new CatalogoFechasL(fila["idCatalogoFechas"].ToString(),
                                                        int.Parse(fila["dia"].ToString()),
                                                        fila["mes"].ToString(),
                                                        fila["descripcion"].ToString(),
                                                        DateTime.Parse(fila["fechaCreacion"].ToString()),
                                                        DateTime.Parse(fila["fechaModificacion"].ToString()),
                                                        fila["modificadoPor"].ToString(),
                                                        fila["creadoPor"].ToString(),
                                                        fila["activo"].ToString()

                                               )

                                   );
                    }
                }
                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo CatalogoFechas: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo CatalogoFechas: " + e.Message;
            }
            return retorno;
        }
        public void agregarCatalogoFechas(CatalogoFechasL pCatalogoFechas)
        {
            try
            {
                string sql = "insert into CatalogoFechas(idCatalogoFechas, dia, mes, descripcion, fechaCreacion, fechaModificacion, modificadoPor, creadoPor, activo) " +
                             "values(:idCatalogoFechas, :dia, :mes, :descripcion, :fechaCreacion, :fechaModificacion, :modificadoPor, :creadoPor, :activo)";

                OracleParameter[] parametros = new OracleParameter[9];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idCatalogoFechas";
                parametros[0].Value = pCatalogoFechas.IdCatalogoFechas;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Number;
                parametros[1].ParameterName = ":dia";
                parametros[1].Value = pCatalogoFechas.Dia;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":mes";
                parametros[2].Value = pCatalogoFechas.Mes;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":descripcion";
                parametros[3].Value = pCatalogoFechas.Descripcion;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fechaCreacion";
                parametros[4].Value = pCatalogoFechas.FechaCreacion;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.DateTime;
                parametros[5].ParameterName = ":fechaModificacion";
                parametros[5].Value = pCatalogoFechas.FechaModificacion;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":modificadoPor";
                parametros[6].Value = pCatalogoFechas.ModificadoPor;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":creadoPor";
                parametros[7].Value = pCatalogoFechas.CreadoPor;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":activo";
                parametros[8].Value = pCatalogoFechas.Activo;


                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando CatalogoFechas: " + e.Message;
            }
        }
        public void borrarCatalogoFechas(CatalogoFechasL pCatalogoFechas)
        {
            try
            {
                string sql = "delete from CatalogoFechas where idCatalogoFechas = :idCatalogoFechas";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idCatalogoFechas";
                parametros[0].Value = pCatalogoFechas.IdCatalogoFechas;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando CatalogoFechas: " + e.Message;
            }
        }
        public void editarCatalogoFechas(CatalogoFechasL pCatalogoFechasOriginal, CatalogoFechasL pCatalogoFechasEditado)
        {
            try
            {
                string sql = "update CatalogoFechas " +
                             "set idCatalogoFechas = :idCatalogoFechas, dia  = :dia, mes = :mes, descripcion = :descripcion, fechaModificacion = :fechaModificacion, fechaCreacion = :fechaCreacion, creadoPor = :creadoPor, modificadoPor = :modificadoPor, activo = :activo " +
                             "where idCatalogoFechas = :idCatalogoFechasOriginal";

                OracleParameter[] parametros = new OracleParameter[10];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idCatalogoFechas";
                parametros[0].Value = pCatalogoFechasEditado.IdCatalogoFechas;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Number;
                parametros[1].ParameterName = ":dia";
                parametros[1].Value = pCatalogoFechasEditado.Dia;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":mes";
                parametros[2].Value = pCatalogoFechasEditado.Mes;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":descripcion";
                parametros[3].Value = pCatalogoFechasEditado.Descripcion;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fechaModificacion";
                parametros[4].Value = pCatalogoFechasEditado.FechaModificacion;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.DateTime;
                parametros[5].ParameterName = ":fechaCreacion";
                parametros[5].Value = pCatalogoFechasEditado.FechaCreacion;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":creadoPor";
                parametros[6].Value = pCatalogoFechasEditado.CreadoPor;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":modificadoPor";
                parametros[7].Value = pCatalogoFechasEditado.ModificadoPor;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":activo";
                parametros[8].Value = pCatalogoFechasEditado.Activo;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":idCatalogoFechasOriginal";
                parametros[9].Value = pCatalogoFechasOriginal.IdCatalogoFechas;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando CatalogoFechas: " + e.Message;
            }
        }
    }
}
