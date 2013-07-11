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
        /// <summary>
        /// Atributos de la clase.
        /// </summary>
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public DepartamentoD(AccesoDatosOracle pCnx)
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
        /// Metodo que obtiene los departamentos de la base de datos.
        /// </summary>
        /// <returns></returns>

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
                        retorno.Add(// Obtiene los datos de la base de datos
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
        /// <summary>
        /// Metodo que agrega un nuevo departamento a la base de datos
        /// </summary>
        /// <param name="pDepartamento"></param>

        public void agregarDepartamento(DepartamentoL pDepartamento)
        {
            try
            {
                string sql = "insert into Departamento(idDepartamento, nombreDepartamento,fechaModificacion,fechaCreacion,creadoPor,modificadoPor,activo) " +
                             "values(:idDepartamento, :nombreDepartamento,:fechaModificacion,:fechaCreacion,:creadoPor,:modificadoPor,:activo)";

                OracleParameter[] parametros = new OracleParameter[7];// Parametros

                parametros[0] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo id departamento
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idDepartamento";
                parametros[0].Value = pDepartamento.IdDepartamento;

                parametros[1] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo nombre de departamento
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":nombreDepartamento";
                parametros[1].Value = pDepartamento.NombreDepartamento;

                parametros[2] = new OracleParameter();// Parametro que va a la base de datos a agregar un nueva fecha de creación
                parametros[2].OracleType = OracleType.DateTime;
                parametros[2].ParameterName = ":fechaCreacion";
                parametros[2].Value = pDepartamento.FechaCreacion;

                parametros[3] = new OracleParameter();// Parametro que va a la base de datos a agregar un nueva fecha de modificación
                parametros[3].OracleType = OracleType.DateTime;
                parametros[3].ParameterName = ":fechaModificacion";
                parametros[3].Value = pDepartamento.FechaModificacion;

                parametros[4] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo creado por
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":creadoPor";
                parametros[4].Value = pDepartamento.CreadoPor;

                parametros[5] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo modificado por
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":modificadoPor";
                parametros[5].Value = pDepartamento.ModificadoPor;

                parametros[6] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo estado del departamento
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
        /// <summary>
        /// Metodo que borra el departamento seleccionado
        /// </summary>
        /// <param name="pDepartamento"></param>

        public void borrarDepartamento(DepartamentoL pDepartamento)
        {
            try
            {
                string sql = "delete from Departamento where idDepartamento = :idDepartamento";

                OracleParameter[] parametros = new OracleParameter[1];// Parametro

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
        /// <summary>
        /// Metodo que edita el departamento seleccionado
        /// </summary>
        /// <param name="pDepartamentoOriginal"></param>
        /// <param name="pDepartamentoEditado"></param>

        public void editarDepartamento(DepartamentoL pDepartamentoOriginal, DepartamentoL pDepartamentoEditado)
        {
            try
            {
                string sql = "update Departamento " +
                             "set idDepartamento = :idDepartamento, nombreDepartamento = :nombreDepartamento, fechaModificacion= :fechaModificacion, modificadoPor= :modificadoPor,activo= :activo " +
                             "where idDepartamento = :idDepartamentoOriginal";

                OracleParameter[] parametros = new OracleParameter[6];//Parametro

                parametros[0] = new OracleParameter();// Parametro que va a la base de datos a editar un nuevo id departamento
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idDepartamento";
                parametros[0].Value = pDepartamentoEditado.IdDepartamento;

                parametros[1] = new OracleParameter();// Parametro que va a la base de datos a editar un nuevo nombre de departamento
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":nombreDepartamento";
                parametros[1].Value = pDepartamentoEditado.NombreDepartamento;

                parametros[2] = new OracleParameter();// Parametro que va a la base de datos a editar una nueva fecha de modificación
                parametros[2].OracleType = OracleType.DateTime;
                parametros[2].ParameterName = ":fechaModificacion";
                parametros[2].Value = pDepartamentoEditado.FechaModificacion;

                parametros[3] = new OracleParameter();// Parametro que va a la base de datos a editar una nuevo modificado por
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":modificadoPor";
                parametros[3].Value = pDepartamentoEditado.ModificadoPor;

                parametros[4] = new OracleParameter();// Parametro que va a la base de datos a editar una nuevo estado del departamento
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":activo";
                parametros[4].Value = pDepartamentoEditado.Activo;

                parametros[5] = new OracleParameter();// Parametro que va a la base de a modificar la linea original por una editada
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":idDepartamentoOriginal";
                parametros[5].Value = pDepartamentoOriginal.IdDepartamento;

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

        public DataSet obtenerIdDepartamento()
        {
            DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Departamento");
            try
            {
                
                if (this.cnx.IsError == true)
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo Departamento: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Departamento: " + e.Message;
            }
            return datos;
        }    
    }
}
