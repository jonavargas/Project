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
   public class DeduccionesD
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
       public DeduccionesD(AccesoDatosOracle pCnx)
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
       /// Metodo que obtiene las deducciones.
       /// </summary>
       /// <returns></returns>
       public List<DeduccionesL> obtenerDeducciones()
       {
           List<DeduccionesL> retorno = new List<DeduccionesL>();
           try
           {
               DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Deducciones");
               if (this.cnx.IsError == false)
               {
                   foreach (DataRow fila in datos.Tables[0].Rows)
                   {
                       retorno.Add(// Agrega los datos nuevos a la base de datos
                                   new DeduccionesL(fila["idDeducciones"].ToString(),
                                                    double.Parse(fila["porcentaje"].ToString()),
                                                    fila["descripcion"].ToString(),
                                                    DateTime.Parse(fila["fechaModificacion"].ToString()),
                                                    DateTime.Parse( fila["fechaCreacion"].ToString()),
                                                    fila["creadoPor"].ToString(),
                                                    fila["modificadoPor"].ToString(),                                                    
                                                    fila["activo"].ToString()

                                                   )                                                
                                                
                                  );
                   }
               }
               else
               {
                   this.error = true;
                   this.errorDescription = "Error obteniendo Deducción:" +
                                           this.cnx.ErrorDescripcion;
               }
           }
           catch (Exception e)
           {
               this.error = true;
               this.errorDescription = "Error obteniendo Deducción:" + e.Message;
           }
           return retorno;
       }
       /// <summary>
       /// Metodo que agrega nuevos datos a la tabla de deducciones.
       /// </summary>
       /// <param name="pDeducciones"></param>
       public void agregarDeduccion(DeduccionesL pDeducciones)
       {
           try
           {
               string sql = "insert into Deducciones(idDeducciones, porcentaje,descripcion,fechaModificacion,fechaCreacion,creadoPor,modificadoPor,activo) " +
                            "values(:idDeducciones, :porcentaje,:descripcion,:fechaModificacion,:fechaCreacion,:creadoPor,:modificadoPor,:activo)";

               OracleParameter[] parametros = new OracleParameter[8];//Parametros

               parametros[0] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo idDeducciones 
               parametros[0].OracleType = OracleType.VarChar;
               parametros[0].ParameterName = ":idDeducciones";
               parametros[0].Value = pDeducciones.IdDeducciones;

               parametros[1] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo porcentaje
               parametros[1].OracleType = OracleType.Double;
               parametros[1].ParameterName = ":porcentaje";
               parametros[1].Value = pDeducciones.Porcentaje;

               parametros[2] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo descripción
               parametros[2].OracleType = OracleType.VarChar;
               parametros[2].ParameterName = ":descripcion";
               parametros[2].Value = pDeducciones.Descripcion;

               parametros[3] = new OracleParameter();// Parametro que va a la base de datos a agregar una nueva fechaModificación 
               parametros[3].OracleType = OracleType.DateTime;
               parametros[3].ParameterName = ":fechaModificacion";
               parametros[3].Value = pDeducciones.FechaModificacion;

               parametros[4] = new OracleParameter();// Parametro que va a la base de datos a agregar una nueva fechaCreación 
               parametros[4].OracleType = OracleType.DateTime;
               parametros[4].ParameterName = ":fechaCreacion";
               parametros[4].Value = pDeducciones.FechaCreacion;

               parametros[5] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo creado por
               parametros[5].OracleType = OracleType.VarChar;
               parametros[5].ParameterName = ":creadoPor";
               parametros[5].Value = pDeducciones.CreadoPor;

               parametros[6] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo modificado por
               parametros[6].OracleType = OracleType.VarChar;
               parametros[6].ParameterName = ":modificadoPor";
               parametros[6].Value = pDeducciones.ModificadoPor;

               parametros[7] = new OracleParameter();// Parametro que va a la base de datos a agregar un nuevo estado de decucción
               parametros[7].OracleType = OracleType.VarChar;
               parametros[7].ParameterName = ":activo";
               parametros[7].Value = pDeducciones.Activo;


               this.cnx.ejecutarSQL(sql, parametros);
               this.error = this.cnx.IsError;
               this.errorDescription = this.cnx.ErrorDescripcion;
           }
           catch (Exception e)
           {
               this.error = true;
               this.errorDescription = "Error agregando Deducción:" + e.Message;
           }
       }
       /// <summary>
       /// Metodo que borra una deducción
       /// </summary>
       /// <param name="pDeducciones"></param>
       public void borrarDeduccion(DeduccionesL pDeducciones)
       {
           try
           {
               string sql = "delete from Deducciones where idDeducciones = :idDeducciones";

               OracleParameter[] parametros = new OracleParameter[1];

               parametros[0] = new OracleParameter();// Parametro que va a la base de datos a borrar la deducción
               parametros[0].OracleType = OracleType.VarChar;
               parametros[0].ParameterName = ":idDeducciones";
               parametros[0].Value = pDeducciones.IdDeducciones;

               this.cnx.ejecutarSQL(sql, parametros);
               this.error = this.cnx.IsError;
               this.errorDescription = this.cnx.ErrorDescripcion;
           }
           catch (Exception e)
           {
               this.error = true;
               this.errorDescription = "Error borrando Deducción:" + e.Message;
           }
       }
       /// <summary>
       /// Metodo que edita  las deducciones en la base de datos.
       /// </summary>
       /// <param name="pDeduccionOriginal"></param>
       /// <param name="pDeduccionEditada"></param>
       public void editarDeducciones(DeduccionesL pDeduccionOriginal, DeduccionesL pDeduccionEditada)
       {
           try
           {
               string sql = "update Deducciones " +
                            "set idDeducciones = :idDeducciones, porcentaje  = :porcentaje, descripcion = :descripcion, fechaModificacion = :fechaModificacion, fechaCreacion = :fechaCreacion, creadoPor = :creadoPor, modificadoPor = :modificadoPor, activo = :activo " +
                            "where idDeducciones = :idDeduccionesOriginal";

               OracleParameter[] parametros = new OracleParameter[9];// parametros

               parametros[0] = new OracleParameter();// Parametro que va a la base de datos a editar el idDeducciones
               parametros[0].OracleType = OracleType.VarChar;
               parametros[0].ParameterName = ":idDeducciones";
               parametros[0].Value = pDeduccionEditada.IdDeducciones;

               parametros[1] = new OracleParameter();// Parametro que va a la base de datos a editar el porcentaje
               parametros[1].OracleType = OracleType.Double;
               parametros[1].ParameterName = ":porcentaje";
               parametros[1].Value = pDeduccionEditada.Porcentaje;

               parametros[2] = new OracleParameter();// Parametro que va a la base de datos a editar la descripción
               parametros[2].OracleType = OracleType.VarChar;
               parametros[2].ParameterName = ":descripcion";
               parametros[2].Value = pDeduccionEditada.Descripcion;

               parametros[3] = new OracleParameter();// Parametro que va a la base de datos a editar la fecha de modificación
               parametros[3].OracleType = OracleType.DateTime;
               parametros[3].ParameterName = ":fechaModificacion";
               parametros[3].Value = pDeduccionEditada.FechaModificacion;

               parametros[4] = new OracleParameter();// Parametro que va a la base de datos a editar la fecha de creación
               parametros[4].OracleType = OracleType.DateTime;
               parametros[4].ParameterName = ":fechaCreacion";
               parametros[4].Value = pDeduccionEditada.FechaCreacion;

               parametros[5] = new OracleParameter();// Parametro que va a la base de datos a editar el creado por
               parametros[5].OracleType = OracleType.VarChar;
               parametros[5].ParameterName = ":creadoPor";
               parametros[5].Value = pDeduccionEditada.CreadoPor;

               parametros[6] = new OracleParameter();// Parametro que va a la base de datos a editar el modificado por
               parametros[6].OracleType = OracleType.VarChar;
               parametros[6].ParameterName = ":modificadoPor";
               parametros[6].Value = pDeduccionEditada.ModificadoPor;

               parametros[7] = new OracleParameter();// Parametro que va a la base de datos a editar el estado de las deducciones
               parametros[7].OracleType = OracleType.VarChar;
               parametros[7].ParameterName = ":activo";
               parametros[7].Value = pDeduccionEditada.Activo;

               parametros[8] = new OracleParameter();// Parametro que va a la base de datos a editar la original por la editada
               parametros[8].OracleType = OracleType.VarChar;
               parametros[8].ParameterName = ":idDeduccionesOriginal";
               parametros[8].Value = pDeduccionOriginal.IdDeducciones;

               this.cnx.ejecutarSQL(sql, parametros);
               this.error = this.cnx.IsError;
               this.errorDescription = this.cnx.ErrorDescripcion;
           }
           catch (Exception e)
           {
               this.error = true;
               this.errorDescription = "Error editando Deducción:" + e.Message;
           }
       }
    }
}
