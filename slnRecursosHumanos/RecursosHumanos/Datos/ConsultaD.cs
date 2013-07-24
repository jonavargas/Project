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
   public class ConsultaD
    {

        /// <summary>
        /// Atributos de la clase Empleado en la parte de Datos donde establece conexión con la Base de Datos de Oracle,tambien se crea 
        /// un atributo por si ocurre un error en el proceso de conexión y adémas detalla que tipo de error fue el que se presento
        /// </summary>

        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        /// <summary>
        ///Método Constructor de la Clase Empleado el cual recibe como  parámetro una conexión a Acceso de datos Oracle el cual es el que 
        /// inicializa el atributo 
        /// </summary>
        /// <param name="pCnx"></param>

        public ConsultaD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }
       /// <summary>
        ///  Properties de la Clase Empleado en cual permite modificar o consultar los datos con los cuales fueron cargados los atributos de 
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
        /// Método que agrega un nueva marca a la Base de Datos de Oracle,el cual recibe por parámetro  que viene cargado con 
        /// los respectivos valores para ser pasados a la base de datos ya creada,ademas procede a realizar una consulta al sql para saber si
        /// los parámetros creados coinciden con los de la base de datos y si considen procede a insertarlos
       /// </summary>
       /// <param name="pConsultaL"></param>  

       
        public void agregarMarca(ConsultaL pConsultaL)
        {
            try
            {
                string sql = "insert into marca(idUnificacion, idEmpleado, fecha, tipo, estado, creadoPor, fechaCreacion, modificadoPor, fechaModificacion) " +
                             "values(:idUnificacion, :idEmpleado, :fecha, :tipo, :estado, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion)";

                 OracleParameter[] parametros = new OracleParameter[9];

                 parametros[0] = new OracleParameter();// Parámetro que va a la base de datos a agregar el idUnificación
                parametros[0].OracleType = OracleType.Double;
                parametros[0].ParameterName = ":idUnificacion";
                parametros[0].Value = pConsultaL.IdUnificacion;

                parametros[1] = new OracleParameter();// Parámetro que va a la base de datos a agregar el id Empleado
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":idEmpleado";
                parametros[1].Value = pConsultaL.IdEmpleado;

                parametros[2] = new OracleParameter();// Parámetro que va a la base de datos a agregar la fecha de la marca
                parametros[2].OracleType = OracleType.DateTime;
                parametros[2].ParameterName = ":fecha";
                parametros[2].Value = pConsultaL.Fecha;

                parametros[3] = new OracleParameter();// Parámetro que va a la base de datos a agregar el tipo de marca del empleado
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":tipo";
                parametros[3].Value = pConsultaL.Tipo;

                parametros[4] = new OracleParameter();// Parámetro que va a la base de datos a agregar el id Empleado
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":estado";
                parametros[4].Value = pConsultaL.Estado;

                parametros[5] = new OracleParameter();// Parámetro que va a la base de datos a agregar el creado por
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":creadoPor";
                parametros[5].Value = pConsultaL.CreadoPor;

                parametros[6] = new OracleParameter();// Parámetro que va a la base de datos a agregar la fecha de creación
                parametros[6].OracleType = OracleType.DateTime;
                parametros[6].ParameterName = ":fechaCreacion";
                parametros[6].Value = pConsultaL.FechaCreacion;

                parametros[7] = new OracleParameter();// Parámetro que va a la base de datos a agregar modificado por
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":modificadoPor";
                parametros[7].Value =pConsultaL.ModificadoPor;

                parametros[8] = new OracleParameter();// Parámetro que va a la base de datos a agregar la fecha de modificación
                parametros[8].OracleType = OracleType.DateTime;
                parametros[8].ParameterName = ":fechaModificacion";
                parametros[8].Value = pConsultaL.FechaModificacion;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando Marca:" + e.Message;
            }

        }
      
        ///  Método que obtiene las marcas realizadas, realiza una consulta a la base de datos en la tabla Marcas para obtener las marcas realizadas
       /// </summary>
      /// <returns></returns>
        public List<ConsultaL> obtenerMarcas()
        {
           
            List<ConsultaL> retorno = new List<ConsultaL>();
            try
            {
                
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Marca");
                if (this.cnx.IsError == false)
                {
                    
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                       
                        retorno.Add(
                                    new ConsultaL(int.Parse(fila["idMarca"].ToString()),                                         
                                                   fila["idEmpleado"].ToString(),
                                                   fila["idDepartamento"].ToString(),
                                                   (fila["idUnificacion"].ToString()),
                                                   fila["nombreCompleto"].ToString(),
                                                   Convert.ToDateTime(fila["fecha"].ToString()),
                                                   fila["tipo"].ToString(),
                                                   fila["estado"].ToString(),
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
                    this.errorDescription = "Error obteniendo marcas:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo marcas:" + e.Message;
            }

            return retorno;
        }

       /// <summary>
       /// Metodo para editar las marcas rezlidas y guardar los cambios realidos.
       /// </summary>
       /// <param name="pMarcaEditada"></param>
       /// <param name="pMarcaOriginal"></param>


        public void editarMarcas(ConsultaL pMarcaEditada, ConsultaL pMarcaOriginal)
        {
            try
            {
                string sql = "update marca " +
                             "set idMarca = :idMarca, " +
                             "idUnificacion = :idUnificacion, " +
                             "idEmpleado = :idEmpleado, " +
                             "fecha = :fecha, " +
                             "tipo = :tipo, " +
                             "estado = :estado, " +
                             "creadoPor = :creadoPor, " +
                             "fechaCreacion = :fechaCreacion, " +
                             "modificadoPor = :modificadoPor, " +
                             "fechaModificacion = :fechaModificacion " +
                             "where idMarca = :idMarcaOriginal";
                ;
                OracleParameter[] parametros = new OracleParameter[11];

                parametros[0] = new OracleParameter();// Parámetro que va a la base de datos a editar el id marca
                parametros[0].OracleType = OracleType.Double;
                parametros[0].ParameterName = ":idMarca";
                parametros[0].Value = pMarcaEditada.IdMarca;

                parametros[1] = new OracleParameter();// Parámetro que va a la base de daton editar la unificación
                parametros[1].OracleType = OracleType.Double;
                parametros[1].ParameterName = ":idUnificacion";
                parametros[1].Value = pMarcaEditada.IdUnificacion;

                parametros[2] = new OracleParameter();// Parámetro que va a la base de datos a editar el id empleado
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":idEmpleado";
                parametros[2].Value = pMarcaEditada.IdEmpleado;

                parametros[3] = new OracleParameter();// Parámetro que va a la base de datos a editar la fecha de la marca realizada
                parametros[3].OracleType = OracleType.DateTime;
                parametros[3].ParameterName = ":fecha";
                parametros[3].Value = pMarcaEditada.Fecha;

                parametros[4] = new OracleParameter();// Parámetro que va a la base de datos a editar el tipo de entrada
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":tipo";
                parametros[4].Value = pMarcaEditada.Tipo;

                parametros[5] = new OracleParameter();// Parámetro que va a la base de datos a editar el estado de la marca
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":estado";
                parametros[5].Value = pMarcaEditada.Estado;

                parametros[6] = new OracleParameter();// Parámetro que va a la base de datos a editar el creado por
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":creadoPor";
                parametros[6].Value = pMarcaEditada.CreadoPor;

                parametros[7] = new OracleParameter();// Parámetro que va a la base de datos a editar la fecha de creación
                parametros[7].OracleType = OracleType.DateTime;
                parametros[7].ParameterName = ":fechaCreacion";
                parametros[7].Value = pMarcaEditada.FechaCreacion;

                parametros[8] = new OracleParameter();// Parámetro que va a la base de datos a editar el modificado por
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":modificadoPor";
                parametros[8].Value = pMarcaEditada.ModificadoPor;

                parametros[9] = new OracleParameter();// Parámetro que va a la base de datos a editar la fecha de modificación
                parametros[9].OracleType = OracleType.DateTime;
                parametros[9].ParameterName = ":fechaModificacion";
                parametros[9].Value = pMarcaEditada.FechaModificacion;

                parametros[10] = new OracleParameter();// Parámetro que va a la base de datos a editar  la marca original por la editada
                parametros[10].OracleType = OracleType.Double;
                parametros[10].ParameterName = ":id_marcaOriginal";
                parametros[10].Value = pMarcaOriginal.IdMarca;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando marca:" + e.Message;
            }
        }
    }
}
