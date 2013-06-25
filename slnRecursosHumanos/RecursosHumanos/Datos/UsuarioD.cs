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
      
      public UsuarioD(AccesoDatosOracle pCnx)
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
      public void agregarUsuario(UsuarioL pUsuario)
      {
          try
          {
              string sql = "insert into Usuario(idUsuario,tipoUsuario,password,fechaModificacion,fechaCreacion,creadoPor,modificadoPor,activo) " +
                           "values(:idUsuario, :tipoUsuario,:password,:fechaModificacion,:fechaCreacion,:creadoPor,:modificadoPor,:activo)";

              OracleParameter[] parametros = new OracleParameter[8];

              parametros[0] = new OracleParameter();
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idUsuario";
              parametros[0].Value = pUsuario.IdUsuario;

              parametros[1] = new OracleParameter();
              parametros[1].OracleType = OracleType.VarChar;
              parametros[1].ParameterName = ":tipoUsuario";
              parametros[1].Value = pUsuario.TipoUsuario;

              parametros[2] = new OracleParameter();
              parametros[2].OracleType = OracleType.VarChar;
              parametros[2].ParameterName = ":password";
              parametros[2].Value = pUsuario.Password;

              parametros[3] = new OracleParameter();
              parametros[3].OracleType = OracleType.DateTime;
              parametros[3].ParameterName = ":fechaCreacion";
              parametros[3].Value = pUsuario.FechaCreacion;

              parametros[4] = new OracleParameter();
              parametros[4].OracleType = OracleType.DateTime;
              parametros[4].ParameterName = ":fechaModificacion";
              parametros[4].Value = pUsuario.FechaModificacion;

              parametros[5] = new OracleParameter();
              parametros[5].OracleType = OracleType.VarChar;
              parametros[5].ParameterName = ":creadoPor";
              parametros[5].Value = pUsuario.CreadoPor;

              parametros[6] = new OracleParameter();
              parametros[6].OracleType = OracleType.VarChar;
              parametros[6].ParameterName = ":modificadoPor";
              parametros[6].Value = pUsuario.ModificadoPor;

              

              parametros[7] = new OracleParameter();
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
      public void borrarUsuario(UsuarioL pUsuario)
      {
          try
          {
              string sql = "delete from Usuario where idUsuario = :idUsuario";

              OracleParameter[] parametros = new OracleParameter[1];

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
      public void editarUsuario(UsuarioL pUsuarioOriginal, UsuarioL pUsuarioEditado)
      {
          try
          {
              string sql = "update Usuario " +
                           "set idUsuario = :idUsuario, tipoUsuario  = :tipoUsuario, password= :password,fechaModificacion= :fechaModificacion, fechaCreacion= :fechaCreacion, creadoPor= :creadoPor,  modificadoPor= :modificadoPor,activo= :activo " +
                           "where idUsuario = :idUsuarioOriginal";

              OracleParameter[] parametros = new OracleParameter[9];

              parametros[0] = new OracleParameter();
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idUsuario";
              parametros[0].Value = pUsuarioEditado.IdUsuario;

              parametros[1] = new OracleParameter();
              parametros[1].OracleType = OracleType.VarChar;
              parametros[1].ParameterName = ":tipoUsuario";
              parametros[1].Value = pUsuarioEditado.TipoUsuario;

              parametros[2] = new OracleParameter();
              parametros[2].OracleType = OracleType.VarChar;
              parametros[2].ParameterName = ":password";
              parametros[2].Value = pUsuarioEditado.Password;

              parametros[3] = new OracleParameter();
              parametros[3].OracleType = OracleType.DateTime;
              parametros[3].ParameterName = ":fechaModificacion";
              parametros[3].Value = pUsuarioEditado.FechaModificacion;
              
              parametros[4] = new OracleParameter();
              parametros[4].OracleType = OracleType.DateTime;
              parametros[4].ParameterName = ":fechaCreacion";
              parametros[4].Value = pUsuarioEditado.FechaCreacion;

              parametros[5] = new OracleParameter();
              parametros[5].OracleType = OracleType.VarChar;
              parametros[5].ParameterName = ":creadoPor";
              parametros[5].Value = pUsuarioEditado.CreadoPor;

              parametros[6] = new OracleParameter();
              parametros[6].OracleType = OracleType.VarChar;
              parametros[6].ParameterName = ":modificadoPor";
              parametros[6].Value = pUsuarioEditado.ModificadoPor;

              parametros[7] = new OracleParameter();
              parametros[7].OracleType = OracleType.VarChar;
              parametros[7].ParameterName = ":activo";
              parametros[7].Value = pUsuarioEditado.Activo;

              parametros[8] = new OracleParameter();
              parametros[8].OracleType = OracleType.VarChar;
              parametros[8].ParameterName = ":idUsuarioOriginal";
              parametros[8].Value = pUsuarioOriginal.IdUsuario;

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
    }
}
