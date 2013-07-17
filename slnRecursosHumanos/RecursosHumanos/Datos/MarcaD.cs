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
   public class MarcaD
    {
        /// <summary>
        /// Atributos de la clase 
        /// </summary>
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

         /// <summary>
        /// Metodo costructor que recibe por parametro la conexión
        /// </summary>
        /// <param name="pCnx"></param>
        public MarcaD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }

        /// <summary>
        /// Propiedades de los atributos 
        /// </summary>
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
     
       public List<MarcaL> obtenerMarcas()
        {
            List<MarcaL> retorno = new List<MarcaL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Marca");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new MarcaL(fila["idMarca"].ToString(),
                                                     fila["idEmpleado"].ToString(),
                                                     fila["estadoMarca"].ToString(),                                                     
                                                     fila["tipoMarca"].ToString(),
                                                     fila["creadoPor"].ToString(),
                                                     DateTime.Parse(fila["fechaCreacion"].ToString()),
                                                     fila["modificadoPor"].ToString(),
                                                     DateTime.Parse(fila["fechaModificacion"].ToString()),
                                                     fila["activo"].ToString()
                                                    )
                                   );
                    }
                }
                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo Marca " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Marca" + e.Message;
            }
            return retorno;
        }

        public void agregarMarca(MarcaL pMarca)
        {
            try
            {
                string sql = "insert into Marca(idMarca,idEmpleado,estadoMarca,tipoMarca,creadoPor,fechaCreacion,modificadoPor,fechaModificacion,activo) " +
                             "values(:idMarca, :idEmpleado, :estadoMarca, :tipoMarca,:creadoPor,:fechaCreacion,:modificadoPor,:fechaModificacion,:activo)";

                OracleParameter[] parametros = new OracleParameter[9];// Parametros

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idMarca";
                parametros[0].Value = pMarca.IdMarca;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":idEmpleado";
                parametros[1].Value = pMarca.IdEmpleado;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":estadoMarca";
                parametros[2].Value = pMarca.EstadoMarca;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":tipoMarca";
                parametros[3].Value = pMarca.TipoMarca;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":creadoPor";
                parametros[4].Value = pMarca.CreadoPor;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.DateTime;
                parametros[5].ParameterName = ":fechaCreacion";
                parametros[5].Value = pMarca.FechaCreacion;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":modificadoPor";
                parametros[6].Value = pMarca.ModificadoPor;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.DateTime;
                parametros[7].ParameterName = ":fechaModificacion";
                parametros[7].Value = pMarca.FechaModificacion;

                parametros[8] = new OracleParameter();  
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":activo";
                parametros[8].Value = pMarca.Activo;

               

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando la Marca: " + e.Message;
            }
        }


    }
}
