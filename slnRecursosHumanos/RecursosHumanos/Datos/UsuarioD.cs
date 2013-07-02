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
    public  class UsuarioD
    {   
      /// <summary>
      /// Atributos de la clase
      /// </summary>
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

      /// <summary>
      /// Metodo constructor que recibe por parametro la conexión a la base de datos
      /// </summary>
      /// <param name="pCnx"></param>
      public UsuarioD(AccesoDatosOracle pCnx)
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
      /// Metodo que obtiene los usuarios
      /// </summary>
      /// <returns></returns>
      public List<UsuarioL> obtenerUsuario()
      {
          List<UsuarioL> retorno = new List<UsuarioL>();
          try
          {
              DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Usuario");
              if (this.cnx.IsError == false)
              {
                  foreach (DataRow fila in datos.Tables[0].Rows)
                  {
                      retorno.Add(
                                  new UsuarioL(    fila["idUsuario"].ToString(),
                                                   fila["tipoUsuario"].ToString(),
                                                   fila["password"].ToString(),
                                                   DateTime.Parse(fila["fechaModificacion"].ToString()),
                                                   DateTime.Parse(fila["fechaCreacion"].ToString()),
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
                  this.errorDescription = "Error obteniendo Usuario:" +
                                          this.cnx.ErrorDescripcion;
              }
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error obteniendo Usuario:" + e.Message;
          }
          return retorno;
      }
      /// <summary>
      /// Metodo que agrega nuevos usuarios a la base de datos
      /// </summary>
      /// <param name="pUsuario"></param>
      public void agregarUsuario(UsuarioL pUsuario)
      {
          try
          {
              string sql = "insert into Usuario(idUsuario,tipoUsuario,password,fechaModificacion,fechaCreacion,creadoPor,modificadoPor,activo) " +
                           "values(:idUsuario, :tipoUsuario,:password,:fechaModificacion,:fechaCreacion,:creadoPor,:modificadoPor,:activo)";

              OracleParameter[] parametros = new OracleParameter[8];// Parametros

              parametros[0] = new OracleParameter();// Parametro que va a la base de datos a agregar el id usuario
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idUsuario";
              parametros[0].Value = pUsuario.IdUsuario;

              parametros[1] = new OracleParameter();// Parametro que va a la base de datos a agregar el tipo de usuario
              parametros[1].OracleType = OracleType.VarChar;
              parametros[1].ParameterName = ":tipoUsuario";
              parametros[1].Value = pUsuario.TipoUsuario;

              parametros[2] = new OracleParameter();// Parametro que va a la base de datos a agregar password del usuario
              parametros[2].OracleType = OracleType.VarChar;
              parametros[2].ParameterName = ":password";
              parametros[2].Value = pUsuario.Password;

              parametros[3] = new OracleParameter();// Parametro que va a la base de datos a agregar la fecha de creación
              parametros[3].OracleType = OracleType.DateTime;
              parametros[3].ParameterName = ":fechaCreacion";
              parametros[3].Value = pUsuario.FechaCreacion;

              parametros[4] = new OracleParameter();// Parametro que va a la base de datos a agregar la fecha de modificación
              parametros[4].OracleType = OracleType.DateTime;
              parametros[4].ParameterName = ":fechaModificacion";
              parametros[4].Value = pUsuario.FechaModificacion;

              parametros[5] = new OracleParameter();// Parametro que va a la base de datos a agregar el creado por
              parametros[5].OracleType = OracleType.VarChar;
              parametros[5].ParameterName = ":creadoPor";
              parametros[5].Value = pUsuario.CreadoPor;

              parametros[6] = new OracleParameter();// Parametro que va a la base de datos a agregar el modificado por
              parametros[6].OracleType = OracleType.VarChar;
              parametros[6].ParameterName = ":modificadoPor";
              parametros[6].Value = pUsuario.ModificadoPor;

              parametros[7] = new OracleParameter();// Parametro que va a la base de datos a agregar el estado del usuario
              parametros[7].OracleType = OracleType.VarChar;
              parametros[7].ParameterName = ":activo";
              parametros[7].Value = pUsuario.Activo;


              this.cnx.ejecutarSQL(sql, parametros);
              this.error = this.cnx.IsError;
              this.errorDescription = this.cnx.ErrorDescripcion;
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error agregando Usuario:" + e.Message;
          }
      }
      /// <summary>
      /// Metodo que borra el usuario que se encuentra seleccionado
      /// </summary>
      /// <param name="pUsuario"></param>
      public void borrarUsuario(UsuarioL pUsuario)
      {
          try
          {
              string sql = "delete from Usuario where idUsuario = :idUsuario";

              OracleParameter[] parametros = new OracleParameter[1];//Parametro

              parametros[0] = new OracleParameter();
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idUsuario";
              parametros[0].Value = pUsuario.IdUsuario;

              this.cnx.ejecutarSQL(sql, parametros);
              this.error = this.cnx.IsError;
              this.errorDescription = this.cnx.ErrorDescripcion;
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error borrando Usuario:" + e.Message;
          }
      }
      /// <summary>
      /// Metodo que edita el usuario seleccionado
      /// </summary>
      /// <param name="pUsuarioOriginal"></param>
      /// <param name="pUsuarioEditado"></param>
      public void editarUsuario(UsuarioL pUsuarioOriginal, UsuarioL pUsuarioEditado)
      {
          try
          {
              string sql = "update Usuario " +
                           "set idUsuario = :idUsuario, tipoUsuario  = :tipoUsuario, password= :password,fechaModificacion= :fechaModificacion, modificadoPor= :modificadoPor,activo= :activo " +
                           "where idUsuario = :idUsuarioOriginal";

              OracleParameter[] parametros = new OracleParameter[7];//Parametros

              parametros[0] = new OracleParameter();// Parametro que va a la base de datos a editar el id usuario
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idUsuario";
              parametros[0].Value = pUsuarioEditado.IdUsuario;

              parametros[1] = new OracleParameter();// Parametro que va a la base de datos a editar el tipo de usuario
              parametros[1].OracleType = OracleType.VarChar;
              parametros[1].ParameterName = ":tipoUsuario";
              parametros[1].Value = pUsuarioEditado.TipoUsuario;

              parametros[2] = new OracleParameter();// Parametro que va a la base de datos a editar el password del usuario
              parametros[2].OracleType = OracleType.VarChar;
              parametros[2].ParameterName = ":password";
              parametros[2].Value = pUsuarioEditado.Password;

              parametros[3] = new OracleParameter();// Parametro que va a la base de datos a agregar la fecha de modificación
              parametros[3].OracleType = OracleType.DateTime;
              parametros[3].ParameterName = ":fechaModificacion";
              parametros[3].Value = pUsuarioEditado.FechaModificacion;

              parametros[4] = new OracleParameter();// Parametro que va a la base de datos a agregar el modificado por
              parametros[4].OracleType = OracleType.VarChar;
              parametros[4].ParameterName = ":modificadoPor";
              parametros[4].Value = pUsuarioEditado.ModificadoPor;

              parametros[5] = new OracleParameter();// Parametro que va a la base de datos a editar el estado del usuario
              parametros[5].OracleType = OracleType.VarChar;
              parametros[5].ParameterName = ":activo";
              parametros[5].Value = pUsuarioEditado.Activo;

              parametros[6] = new OracleParameter();// Parametro que va a la base de datos a agregar la linea editada por la original
              parametros[6].OracleType = OracleType.VarChar;
              parametros[6].ParameterName = ":idUsuarioOriginal";
              parametros[6].Value = pUsuarioOriginal.IdUsuario;

              this.cnx.ejecutarSQL(sql, parametros);
              this.error = this.cnx.IsError;
              this.errorDescription = this.cnx.ErrorDescripcion;
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error editando Usuario:" + e.Message;
          }
       }

      public List<UsuarioL> validarLogin(UsuarioL pLogin)
      {
          List<UsuarioL> retorno = new List<UsuarioL>();
          try
          {
              OracleParameter[] parametros = new OracleParameter[2];

              parametros[0] = new OracleParameter();
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idUsuario";
              parametros[0].Value = pLogin.IdUsuario;

              parametros[1] = new OracleParameter();
              parametros[1].OracleType = OracleType.VarChar;
              parametros[1].ParameterName = ":password";
              parametros[1].Value = pLogin.Password;

              DataSet datos = this.cnx.ejecutarConsultaSQL("select * from usuario where idUsuario = :idUsuario and password = :password", "usuario", parametros);
              if (this.cnx.IsError == false)
              {
                  foreach (DataRow fila in datos.Tables[0].Rows)
                  {
                      retorno.Add(
                                  new UsuarioL(fila["idUsuario"].ToString(),
                                              fila["tipoUsuario"].ToString(),
                                              fila["password"].ToString())
                                 );
                  }
              }
              else
              {
                  this.error = true;
                  this.errorDescription = "Error validando inicio de sesión: " +
                                          this.cnx.ErrorDescripcion;
              }
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error validando inicio de sesión: " + e.Message;
          }
          return retorno;
      }

      public List<UsuarioL> usuarioAdministrador(UsuarioL pLogin)
      {
          List<UsuarioL> retorno = new List<UsuarioL>();
          {
              retorno.Add(
                          new UsuarioL("idUsuario".ToString(),
                                       "tipoUsuario".ToString(),
                                       "password".ToString())
                         );
          }
          return retorno;
      }
   }
}
