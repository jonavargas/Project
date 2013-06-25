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
   public  class DepartamentoD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public DepartamentoD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }

        public bool Error
        {
            get { return error; }
        }
       
        public string ErrorDescription
        {
            get { return errorDescription; }
        }

        public List<DepartamentoL> obtenerDepartamentos()
        {
            List<DepartamentoL> retorno = new List<DepartamentoL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Departamento");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new DepartamentoL(fila["idDepartamento"].ToString(),
                                                      fila["nombreDepartamento"].ToString(),
                                                      DateTime.Parse(fila["fechaModificacion"].ToString()),
                                                      DateTime.Parse(fila["fechaCreacion"].ToString()),
                                                      fila["creadoPor"].ToString(),
                                                      fila["modificadoPor"].ToString(),                                                  
                                                      fila["activo"].ToString())                                                      
                                   );      
                   }
                }
                else {
                    this.error = true;
                    this.errorDescription = "Error obteniendo departamentos:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo departamentos:" + e.Message;
            }
            return retorno;
        }

        public void agregarDepartamento(DepartamentoL pDepartamento)
        {
            try
            {
                string sql = "insert into Departamento(idDepartamento, nombreDepartamento,fechaModificacion,fechaCreacion,creadoPor,modificadoPor,activo) " +
                             "values(:idDepartamento, :nombreDepartamento,:fechaModificacion,:fechaCreacion,:creadoPor,:modificadoPor,:activo)";
                
                OracleParameter[] parametros = new OracleParameter[7];
                
                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idDepartamento";
                parametros[0].Value = pDepartamento.IdDepartamento;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":nombreDepartamento";
                parametros[1].Value = pDepartamento.NombreDepartamento;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.DateTime;
                parametros[2].ParameterName = ":fechaCreacion";
                parametros[2].Value = pDepartamento.FechaCreacion;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.DateTime;
                parametros[3].ParameterName = ":fechaModificacion";
                parametros[3].Value = pDepartamento.FechaModificacion;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":creadoPor";
                parametros[4].Value = pDepartamento.CreadoPor;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":modificadoPor";
                parametros[5].Value = pDepartamento.ModificadoPor;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":activo";
                parametros[6].Value = pDepartamento.Activo;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch(Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando departamento:" + e.Message;    
            }
        }

        public void borrarDepartamento(DepartamentoL pDepartamento)
        {
            try
            {
                string sql = "delete from Departamento where idDepartamento = :idDepartamento";

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idDepartamento";
                parametros[0].Value = pDepartamento.IdDepartamento;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando departamento:" + e.Message;
            }
        }

        public void editarDepartamento(DepartamentoL pDepartamentoOriginal, DepartamentoL pDepartamentoEditado)
        {
            try
            {
                string sql = "update Departamento " +
                             "set idDepartamento = :idDepartamento, nombreDepartamento = :nombreDepartamento, fechaModificacion= :fechaModificacion, fechaCreacion= :fechaCreacion, creadoPor= :creadoPor,  modificadoPor= :modificadoPor,activo= :activo " +
                             "where idDepartamento = :idDepartamentoOriginal";

                OracleParameter[] parametros = new OracleParameter[8];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idDepartamento";
                parametros[0].Value = pDepartamentoEditado.IdDepartamento;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":nombreDepartamento";
                parametros[1].Value = pDepartamentoEditado.NombreDepartamento;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.DateTime;
                parametros[2].ParameterName = ":fechaCreacion";
                parametros[2].Value = pDepartamentoEditado.FechaCreacion;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.DateTime;
                parametros[3].ParameterName = ":fechaModificacion";
                parametros[3].Value = pDepartamentoEditado.FechaModificacion;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":creadoPor";
                parametros[4].Value = pDepartamentoEditado.CreadoPor;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":modificadoPor";
                parametros[5].Value = pDepartamentoEditado.ModificadoPor;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":activo";
                parametros[6].Value = pDepartamentoEditado.Activo;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":idDepartamentoOriginal";
                parametros[7].Value = pDepartamentoOriginal.IdDepartamento;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando departamento:" + e.Message;
            }
        }
       
    
    }
}
