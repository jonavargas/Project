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
  public  class UnificacionD
    {
       /// <summary>
        /// /// <summary>
        /// Atributos de la clase UnificacionD en la parte de Datos donde establece conexión con la Base de Datos de Oracle,tambien se crea 
        /// un atributo por si ocurre un error en el proceso de conexión y adémas detalla que tipo de error fue el que se presento
        /// </summary>
       /// </summary>
      
        private AccesoDatosOracle conexion;
        private bool error = false;        
        private string errorDescription = "";

      /// <summary>
      /// Propiedades de la clase
      /// </summary>
      /// <param name="pCnx"></param>
      public UnificacionD(AccesoDatosOracle pCnx)
        {
            this.conexion = pCnx;
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
      /// Método para Obtener la unificación
      /// </summary>
      /// <returns></returns>
      public List<UnificacionL> obtenerUnificacion()
      {
          
          List<UnificacionL> retorno = new List<UnificacionL>();
          try
          {
              
              DataSet datos = this.conexion.ejecutarConsultaSQL("select u.*, e.nombre || ' ' || e.apellido1 || ' ' || e.apellido2 as nombreCompleto from Unificacion u, Empleado e where u.idEmpleado = e.idEmpleado");
              if (this.conexion.IsError == false)
              {
                  
                  foreach (DataRow fila in datos.Tables[0].Rows)
                  {
                      
                      retorno.Add(
                                  new UnificacionL(  int.Parse(fila["idUnificacion"].ToString()),
                                                     fila["idEmpleado"].ToString(),
                                                     int.Parse(fila["idPago"].ToString()),
                                                     fila["estadoUnificacion"].ToString(),
                                                     DateTime.Parse(fila["fechaUnificacion"].ToString()),
                                                     Double.Parse(fila["horaRegular"].ToString()),
                                                     Double.Parse(fila["hroaExtra"].ToString()),
                                                     Double.Parse(fila["horaDoble"].ToString()),
                                                     fila["aprobacionExtra"].ToString(),
                                                     fila["notasAprovacion"].ToString(),
                                                     Double.Parse(fila["pagoRegular"].ToString()),
                                                     Double.Parse(fila["pagoExtra"].ToString()),
                                                     Double.Parse(fila["pagoDoble"].ToString()),
                                                     Double.Parse(fila["porcentajeDeduccion"].ToString()),
                                                     Double.Parse( fila["montoDeduccion"].ToString()),
                                                     Double.Parse(fila["salarioBruto"].ToString()),
                                                     Double.Parse(fila["montoUnificacion"].ToString()),
                                                     fila["creadoPor"].ToString(),
                                                     Convert.ToDateTime(fila["fechaCreacion"].ToString()),
                                                     fila["modificadoPor"].ToString(),
                                                     Convert.ToDateTime(fila["fechaModificacion"].ToString()),
                                                     fila["nombreCompleto"].ToString(),
                                                     fila["activo"].ToString()
                                                     
                                               )
                                 );
                  }
              }
               
              else
              {
                  this.error = true;
                  this.errorDescription = "Error obteniendo Unificacion:" +
                                          this.conexion.ErrorDescripcion;
              }
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error obteniendo Unificacion:" + e.Message;
          }

          return retorno;
      }


       /// <summary>
       /// Método que agrega una nueva unificación.
       /// </summary>
       /// <param name="pUnificacion"></param>
       /// <returns></returns>
     public string agregarUnificacion(UnificacionL pUnificacion)
      {
          string retorno = "";
          try
          {
              string sql = "insert into unificacion(idEmpleado, idPago, estadoUnificacion, fechaUnificacion, horaRegular, horaExtra, horaDoble, aprobacionExtra, notasAprobacion, pagoRegular, pagoExtra, pagoDoble, porcentajeDeduccion, montoDeduccion, salarioBruto, montoUnificacion,  creadoPor, fechaCreacion, modificadoPor, fechaModificacion, activo) " +
                           "values(:idEmpleado, :idPago, :estadoUnificacion, :fechaUnificacion, :horaRegular, :horaExtra, :horaDoble, :aprobacionExtra, :notasAprobacion, :pagoRegular, :pagoExtra, :pagoDoble, :porcentajeDeduccion, :montoDeduccion, :salarioBruto, :montoUnificacion, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion, :activo) " +
                           "returning idUnificacion into :idUnificacion";

              OracleParameter[] parametros = new OracleParameter[22];//Parámetros

              parametros[0] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo idEmpleado.
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idEmpleado";
              parametros[0].Value = pUnificacion.IdEmpleado;

              parametros[1] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo idPago.
              parametros[1].OracleType = OracleType.Number;
              parametros[1].ParameterName = ":idPago";
              parametros[1].Value = pUnificacion.IdPago;

              parametros[2] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo estadoUnificacion.
              parametros[2].OracleType = OracleType.VarChar;
              parametros[2].ParameterName = ":estadoUnificacion";
              parametros[2].Value = pUnificacion.EstadoUnificacion;

              parametros[3] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo fechaUnificacion.
              parametros[3].OracleType = OracleType.DateTime;
              parametros[3].ParameterName = ":fechaUnificacion";
              parametros[3].Value = pUnificacion.FechaUnificacion;

              parametros[4] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo horaRegular.
              parametros[4].OracleType = OracleType.Double;
              parametros[4].ParameterName = ":horaRegular";
              parametros[4].Value = pUnificacion.HoraRegular;

              parametros[5] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo horaExtra.
              parametros[5].OracleType = OracleType.Double;
              parametros[5].ParameterName = ":horaExtra";
              parametros[5].Value = pUnificacion.HoraExtra;

              parametros[6] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo horaDoble.
              parametros[6].OracleType = OracleType.Double;
              parametros[6].ParameterName = ":horaDoble";
              parametros[6].Value = pUnificacion.HoraDoble;

              parametros[7] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo aprobacionExtra.
              parametros[7].OracleType = OracleType.VarChar;
              parametros[7].ParameterName = ":aprobacionExtra";
              parametros[7].Value = pUnificacion.AprobacionExtra;

              parametros[8] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo notasAprobacion.
              parametros[8].OracleType = OracleType.VarChar;
              parametros[8].ParameterName = ":notasAprobacion";
              parametros[8].Value = pUnificacion.DetalleAprobacionExtra;

              parametros[9] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo pagoRegular.
              parametros[9].OracleType = OracleType.Double;
              parametros[9].ParameterName = ":pagoRegular";
              parametros[9].Value = pUnificacion.PagoRegular;

              parametros[10] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo pagoExtra.
              parametros[10].OracleType = OracleType.Double;
              parametros[10].ParameterName = ":pagoExtra";
              parametros[10].Value = pUnificacion.PagoExtra;

              parametros[11] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo pagoDoble.
              parametros[11].OracleType = OracleType.Double;
              parametros[11].ParameterName = ":pagoDoble";
              parametros[11].Value = pUnificacion.PagoDoble;

              parametros[12] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo porcentajeDeduccion.
              parametros[12].OracleType = OracleType.Double;
              parametros[12].ParameterName = ":porcentajeDeduccion";
              parametros[12].Value = pUnificacion.PorcentajeDeduccion;

              parametros[13] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo montoDeduccion.
              parametros[13].OracleType = OracleType.Double;
              parametros[13].ParameterName = ":montoDeduccion";
              parametros[13].Value = pUnificacion.MontoDeduccion;

              parametros[14] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo salarioBruto.
              parametros[14].OracleType = OracleType.Double;
              parametros[14].ParameterName = ":salarioBruto";
              parametros[14].Value = pUnificacion.SalarioBruto;

              parametros[15] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo montoUnificacion.
              parametros[15].OracleType = OracleType.Double;
              parametros[15].ParameterName = ":montoUnificacion";
              parametros[15].Value = pUnificacion.MontoUnificacion;

              parametros[16] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo creadoPor.
              parametros[16].OracleType = OracleType.VarChar;
              parametros[16].ParameterName = ":creadoPor";
              parametros[16].Value = pUnificacion.CreadoPor;

              parametros[17] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo fechaCreacion.
              parametros[17].OracleType = OracleType.DateTime;
              parametros[17].ParameterName = ":fechaCreacion";
              parametros[17].Value = pUnificacion.FechaCreacion;

              parametros[18] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo modificadoPor.
              parametros[18].OracleType = OracleType.VarChar;
              parametros[18].ParameterName = ":modificadoPor";
              parametros[18].Value = pUnificacion.ModificadoPor;

              parametros[19] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo fechaModificacion.
              parametros[19].OracleType = OracleType.DateTime;
              parametros[19].ParameterName = ":fechaModificacion";
              parametros[19].Value = pUnificacion.FechaModificacion;

              parametros[20] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo activo.
              parametros[20].OracleType = OracleType.VarChar;
              parametros[20].ParameterName = ":activo";
              parametros[20].Value = pUnificacion.Activo;

              parametros[21] = new OracleParameter();//Parámetro que agrega a la base de datos un nuevo idUnificacion.
              parametros[21].OracleType = OracleType.Number;
              parametros[21].ParameterName = ":idUnificacion";
              parametros[21].Direction = ParameterDirection.Output;

              retorno = this.conexion.ejecutarSQLReturning(sql, parametros, ":idUnificacion");

              this.error = this.conexion.IsError;
              this.errorDescription = this.conexion.ErrorDescripcion;

          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error agregando Unificacion:" + e.Message;
          }
          return retorno;
      }

      /// <summary>
      /// Método que edita las unificaciones, y reemplaza el valor que cambio
      /// </summary>
      /// <param name="pUnificacionEditar"></param>
     public void editarUnificacion(UnificacionL pUnificacionEditar)
     {
         try
         {
             string sql = "update Unificacion " +
                          "set idUnificacion = :idUnificacion, " +
                          "idEmpleado = :idEmpleado, " +
                          "idPago = :idPago, " +
                          "estadoUnificacion = :estadoUnificacion, " +
                          "fechaUnificacion = :fechaUnificacion, " +
                          "horaRegular = :horaRegular, " +
                          "horaExtra = :horaExtra, " +
                          "aprobacionExtra = :aprobacionExtra, " +
                          "notasAprobacion = :notasAprobacion, " +
                          "horaDoble = :horaDoble, " +
                          "porcentajeDeduccion = :porcentajeDeduccion, " +
                          "montoDeduccion = :montoDeduccion, " +
                          "pagoRegular = :pagoRegular, " +
                          "pagoExtra = :pagoExtra, " +
                          "pagoDoble = :pagoDoble, " +                     
                          "salarioBruto = :salarioBruto, " +
                          "montoUnificacion = :montoUnificacion, " +
                          "creadoPor = :creadoPor, " +
                          "fechaCreacion = :fechaCreacion, " +
                          "modificadoPor = :modificadoPor, " +
                          "fechaModificacion = :fechaModificacion " +
                          "activo = :activo " +
                          "where idUnificacion = :idUnificacionOriginal";

             OracleParameter[] parametros = new OracleParameter[23];

             parametros[0] = new OracleParameter();//Parámetro que edita en la base de datos la idUnificacion.
             parametros[0].OracleType = OracleType.Number;
             parametros[0].ParameterName = ":idUnificacion";
             parametros[0].Value = pUnificacionEditar.IdUnificacion;

             parametros[1] = new OracleParameter();//Parámetro que edita en la base de datos la idEmpleado.
             parametros[1].OracleType = OracleType.VarChar;
             parametros[1].ParameterName = ":idEmpleado";
             parametros[1].Value = pUnificacionEditar.IdEmpleado;

             parametros[2] = new OracleParameter();//Parámetro que edita en la base de datos la idPago.
             parametros[2].OracleType = OracleType.Number;
             parametros[2].ParameterName = ":idPago";
             parametros[2].Value = pUnificacionEditar.IdPago;

             parametros[3] = new OracleParameter();//Parámetro que edita en la base de datos la estadoUnificacion.
             parametros[3].OracleType = OracleType.VarChar;
             parametros[3].ParameterName = ":estadoUnificacion";
             parametros[3].Value = pUnificacionEditar.EstadoUnificacion;

             parametros[4] = new OracleParameter();//Parámetro que edita en la base de datos la fechaUnificacion.
             parametros[4].OracleType = OracleType.DateTime;
             parametros[4].ParameterName = ":fechaUnificacion";
             parametros[4].Value = pUnificacionEditar.FechaUnificacion;

             parametros[5] = new OracleParameter();//Parámetro que edita en la base de datos la horaRegular.
             parametros[5].OracleType = OracleType.Double;
             parametros[5].ParameterName = ":horaRegular";
             parametros[5].Value = pUnificacionEditar.HoraRegular;

             parametros[6] = new OracleParameter();//Parámetro que edita en la base de datos la horaExtra.
             parametros[6].OracleType = OracleType.Double;
             parametros[6].ParameterName = ":horaExtra";
             parametros[6].Value = pUnificacionEditar.HoraExtra;

             parametros[7] = new OracleParameter();//Parámetro que edita en la base de datos la horaDoble.
             parametros[7].OracleType = OracleType.Double;
             parametros[7].ParameterName = ":horaDoble";
             parametros[7].Value = pUnificacionEditar.HoraDoble;

             parametros[8] = new OracleParameter();//Parámetro que edita en la base de datos la aprobacionExtra.
             parametros[8].OracleType = OracleType.VarChar;
             parametros[8].ParameterName = ":aprobacionExtra";
             parametros[8].Value = pUnificacionEditar.AprobacionExtra;

             parametros[9] = new OracleParameter();//Parámetro que edita en la base de datos la notasAprobacion.
             parametros[9].OracleType = OracleType.VarChar;
             parametros[9].ParameterName = ":notasAprobacion";
             parametros[9].Value = pUnificacionEditar.DetalleAprobacionExtra;

             parametros[10] = new OracleParameter();//Parámetro que edita en la base de datos la porcentajeDeduccion.
             parametros[10].OracleType = OracleType.Double;
             parametros[10].ParameterName = ":porcentajeDeduccion";
             parametros[10].Value = pUnificacionEditar.PorcentajeDeduccion;

             parametros[11] = new OracleParameter();//Parámetro que edita en la base de datos la montoDeduccion.
             parametros[11].OracleType = OracleType.Double;
             parametros[11].ParameterName = ":montoDeduccion";
             parametros[11].Value = pUnificacionEditar.MontoDeduccion;

             parametros[12] = new OracleParameter();//Parámetro que edita en la base de datos la pagoRegular.
             parametros[12].OracleType = OracleType.Double;
             parametros[12].ParameterName = ":pagoRegular";
             parametros[12].Value = pUnificacionEditar.PagoRegular;

             parametros[13] = new OracleParameter();//Parámetro que edita en la base de datos la pagoExtra.
             parametros[13].OracleType = OracleType.Double;
             parametros[13].ParameterName = ":pagoExtra";
             parametros[13].Value = pUnificacionEditar.PagoExtra;

             parametros[14] = new OracleParameter();//Parámetro que edita en la base de datos la pagoDoble.
             parametros[14].OracleType = OracleType.Double;
             parametros[14].ParameterName = ":pagoDoble";
             parametros[14].Value = pUnificacionEditar.PagoDoble;

             parametros[15] = new OracleParameter();//Parámetro que edita en la base de datos la salarioBruto.
             parametros[15].OracleType = OracleType.Double;
             parametros[15].ParameterName = ":salarioBruto";
             parametros[15].Value = pUnificacionEditar.SalarioBruto;

             parametros[16] = new OracleParameter();//Parámetro que edita en la base de datos la montoUnificacion.
             parametros[16].OracleType = OracleType.Double;
             parametros[16].ParameterName = ":montoUnificacion";
             parametros[16].Value = pUnificacionEditar.MontoUnificacion;

             parametros[17] = new OracleParameter();//Parámetro que edita en la base de datos lel creadoPor.
             parametros[17].OracleType = OracleType.VarChar;
             parametros[17].ParameterName = ":creadoPor";
             parametros[17].Value = pUnificacionEditar.CreadoPor;

             parametros[18] = new OracleParameter();//Parámetro que edita en la base de datos la fechaCreacion.
             parametros[18].OracleType = OracleType.DateTime;
             parametros[18].ParameterName = ":fechaCreacion";
             parametros[18].Value = pUnificacionEditar.FechaCreacion;

             parametros[19] = new OracleParameter();//Parámetro que edita en la base de datos el modificadoPor.
             parametros[19].OracleType = OracleType.VarChar;
             parametros[19].ParameterName = ":modificadoPor";
             parametros[19].Value = pUnificacionEditar.ModificadoPor;

             parametros[20] = new OracleParameter();//Parámetro que edita en la base de datos la fechaModificacion.
             parametros[20].OracleType = OracleType.DateTime;
             parametros[20].ParameterName = ":fechaModificacion";
             parametros[20].Value = pUnificacionEditar.FechaModificacion;

             parametros[21] = new OracleParameter();//Parámetro que edita en la base de datos la activo.
             parametros[21].OracleType = OracleType.VarChar;
             parametros[21].ParameterName = ":activo";
             parametros[21].Value = pUnificacionEditar.Activo;

             parametros[22] = new OracleParameter();//Parámetro que edita en la base de datos la idUnificacionOriginal.
             parametros[22].OracleType = OracleType.Double;
             parametros[22].ParameterName = ":idUnificacionOriginal";
             parametros[22].Value = pUnificacionEditar.IdUnificacion;

             this.conexion.ejecutarSQL(sql, parametros);
             this.error = this.conexion.IsError;
             this.errorDescription = this.conexion.ErrorDescripcion;
         }
         catch (Exception e)
         {
             this.error = true;
             this.errorDescription = "Error editando Unificación:" + e.Message;
         }
     }

      /// <summary>
      /// Método para borrar una unificacion de la base de datos
      /// </summary>
      /// <param name="pUnificacion"></param>

     public void borrarUnificacion(UnificacionL pUnificacion)
     {
         try
         {
             string sql = "delete from Unificacion where idUnificacion = :idUnificacion";

             OracleParameter[] parametros = new OracleParameter[1];

             parametros[0] = new OracleParameter();
             parametros[0].OracleType = OracleType.Double;
             parametros[0].ParameterName = ":idUnificacion";
             parametros[0].Value = pUnificacion.IdUnificacion;

             this.conexion.ejecutarSQL(sql, parametros);
             this.error = this.conexion.IsError;
             this.errorDescription = this.conexion.ErrorDescripcion;
         }
         catch (Exception e)
         {
             this.error = true;
             this.errorDescription = "Error borrando Unificación:" + e.Message;
         }
     }

     public List<UnificacionL> obtenerUnificacionFiltro(DateTime pFecha1, DateTime pFecha2, string pIdEmpleado, string pDepartamento,
                                                 string pNombreEmpleado, string pEstadoUnificacion, string pActivo)
     {
         List<UnificacionL> retorno = new List<UnificacionL>();
         try
         {

             string sql = "select u.*, e.nombreEmpleado || ' ' || e.apellido1 || ' ' || e.apellido2 as nombreCompleto from Unificacion u, Empleado e where u.idEmpleado = e.idEmpleado and  u.fechaUnificacion >= :fecha1 and u.fechaMarca <= :fecha2";
             int indices = 2;

             if (pIdEmpleado != "")
             {
                 sql += " and u.idEmpleado = :idEmpleado";
                 indices++;
             }

             if (pDepartamento != "")
             {
                 sql += " and e.idDepartamento = :idDepartamento";
                 indices++;
             }

             if (pNombreEmpleado != "")
             {
                 sql += " and e.nombreEmpleado || ' ' || e.apellido1 || ' ' || e.apellido2 like :nombreCompleto";
                 indices++;
             }

             if (pEstadoUnificacion != "")
             {
                 sql += " and u.estadoUnificacion = :estadoUnificacion";
                 indices++;
             }

             if (pActivo != "")
             {
                 sql += " and u.Activo = :activo";
                 indices++;
             }

             OracleParameter[] parametros = new OracleParameter[indices];

             parametros[0] = new OracleParameter();
             parametros[0].OracleType = OracleType.DateTime;
             parametros[0].ParameterName = ":fecha1";
             parametros[0].Value = pFecha1;

             parametros[1] = new OracleParameter();
             parametros[1].OracleType = OracleType.DateTime;
             parametros[1].ParameterName = ":fecha2";
             parametros[1].Value = pFecha2;

             indices = 2;

             if (pDepartamento != "")
             {
                 parametros[indices] = new OracleParameter();
                 parametros[indices].OracleType = OracleType.VarChar;
                 parametros[indices].ParameterName = ":idDepartamento";
                 parametros[indices].Value = pDepartamento;
                 indices++;
             }

             if (pEstadoUnificacion != "")
             {
                 parametros[indices] = new OracleParameter();
                 parametros[indices].OracleType = OracleType.VarChar;
                 parametros[indices].ParameterName = ":estadoUnificacion";
                 parametros[indices].Value = pEstadoUnificacion;
                 indices++;
             }

             if (pIdEmpleado != "")
             {
                 parametros[indices] = new OracleParameter();
                 parametros[indices].OracleType = OracleType.VarChar;
                 parametros[indices].ParameterName = ":idEmpleado";
                 parametros[indices].Value = pIdEmpleado;
                 indices++;
             }

             if (pNombreEmpleado != "")
             {
                 parametros[indices] = new OracleParameter();
                 parametros[indices].OracleType = OracleType.VarChar;
                 parametros[indices].ParameterName = ":nombreCompleto";
                 parametros[indices].Value = "%" + pNombreEmpleado + "%";
                 indices++;
             }

             if (pActivo != "")
             {
                 parametros[indices] = new OracleParameter();
                 parametros[indices].OracleType = OracleType.VarChar;
                 parametros[indices].ParameterName = ":activo";
                 parametros[indices].Value = pActivo;

             }

             DataSet datos = this.conexion.ejecutarConsultaSQL(sql, "Unificacion", parametros);
             if (this.conexion.IsError == false)
             {
                 foreach (DataRow fila in datos.Tables[0].Rows)
                 {
                     
                     retorno.Add(
                                 new UnificacionL(int.Parse(fila["idUnificacion"].ToString()),
                                                     fila["idEmpleado"].ToString(),
                                                     int.Parse(fila["idPago"].ToString()),
                                                     fila["estadoUnificacion"].ToString(),
                                                     DateTime.Parse(fila["fechaUnificacion"].ToString()),
                                                     Double.Parse(fila["horaRegular"].ToString()),
                                                     Double.Parse(fila["hroaExtra"].ToString()),
                                                     Double.Parse(fila["horaDoble"].ToString()),
                                                     fila["aprobacionExtra"].ToString(),
                                                     fila["notasAprovacion"].ToString(),
                                                     Double.Parse(fila["pagoRegular"].ToString()),
                                                     Double.Parse(fila["pagoExtra"].ToString()),
                                                     Double.Parse(fila["pagoDoble"].ToString()),
                                                     Double.Parse(fila["porcentajeDeduccion"].ToString()),
                                                     Double.Parse(fila["montoDeduccion"].ToString()),
                                                     Double.Parse(fila["salarioBruto"].ToString()),
                                                     Double.Parse(fila["montoUnificacion"].ToString()),
                                                     fila["creadoPor"].ToString(),
                                                     Convert.ToDateTime(fila["fechaCreacion"].ToString()),
                                                     fila["modificadoPor"].ToString(),
                                                     Convert.ToDateTime(fila["fechaModificacion"].ToString()),
                                                     fila["nombreCompleto"].ToString(),
                                                     fila["activo"].ToString()
                                                     
                                              )
                                );
                 }
             }

             else
             {
                 this.error = true;
                 this.errorDescription = "Error obteniendo Unificación:" +
                                         this.conexion.ErrorDescripcion;

             }
         }

         catch (Exception e)
         {
             this.error = true;
             this.errorDescription = "Error obteniendo Unificación:" + e.Message;
         }
         return retorno;
     }


    }
}
