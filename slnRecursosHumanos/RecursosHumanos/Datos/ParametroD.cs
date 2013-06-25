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
    public class ParametroD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";


        public ParametroD(AccesoDatosOracle pCnx)
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
      public List<ParametroL> obtenerParametro()
      {
          List<ParametroL> retorno = new List<ParametroL>();
          try
          {
              DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Parametro");
              if (this.cnx.IsError == false)
              {
                  foreach (DataRow fila in datos.Tables[0].Rows)
                  {
                      retorno.Add(
                                  new ParametroL(  fila["idParametro"].ToString(),
                                                   DateTime.Parse(fila["horaEntrada"].ToString()),
                                                   DateTime.Parse(fila["horaSalida"].ToString()),
                                                   fila["lunes"].ToString(),
                                                   fila["martes"].ToString(),
                                                   fila["miercoles"].ToString(),
                                                   fila["jueves"].ToString(),
                                                   fila["viernes"].ToString(),
                                                   fila["sabado"].ToString(),
                                                   fila["domingo"].ToString(),
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
                  this.errorDescription = "Error obteniendo Parametro:" +
                                          this.cnx.ErrorDescripcion;
              }
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error obteniendo Parametro: " + e.Message;
          }
          return retorno;
      }
      public void agregarParametro(ParametroL pParametro)
      {
          try
          {
              string sql = "insert into Parametro(idParametro,horaEntrada,horaSalida ,lunes,martes,miercoles,jueves,viernes,sabado,domingo,fechaModificacion,fechaCreacion,creadoPor,modificadoPor,activo) " +
                           "values(:idParametro, :horaEntrada,:horaSalida ,:lunes ,:martes ,:miercoles ,:jueves ,:viernes ,:sabado,:domingo,:fechaModificacion,:fechaCreacion,:creadoPor,:modificadoPor,:activo)";

              OracleParameter[] parametros = new OracleParameter[15];

              parametros[0] = new OracleParameter();
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idParametro";
              parametros[0].Value = pParametro.IdParametro;

              parametros[1] = new OracleParameter();
              parametros[1].OracleType = OracleType.DateTime;
              parametros[1].ParameterName = ":horaEntrada";
              parametros[1].Value = pParametro.HoraEntrada;

              parametros[2] = new OracleParameter();
              parametros[2].OracleType = OracleType.DateTime;
              parametros[2].ParameterName = ":horaSalida";
              parametros[2].Value = pParametro.HoraSalida;

              parametros[3] = new OracleParameter();
              parametros[3].OracleType = OracleType.VarChar;
              parametros[3].ParameterName = ":lunes";
              parametros[3].Value = pParametro.Lunes;

              parametros[4] = new OracleParameter();
              parametros[4].OracleType = OracleType.VarChar;
              parametros[4].ParameterName = ":martes";
              parametros[4].Value = pParametro.Martes;

              parametros[5] = new OracleParameter();
              parametros[5].OracleType = OracleType.VarChar;
              parametros[5].ParameterName = ":miercoles";
              parametros[5].Value = pParametro.Miercoles;

              parametros[6] = new OracleParameter();
              parametros[6].OracleType = OracleType.VarChar;
              parametros[6].ParameterName = ":jueves";
              parametros[6].Value = pParametro.Jueves;

              parametros[7] = new OracleParameter();
              parametros[7].OracleType = OracleType.VarChar;
              parametros[7].ParameterName = ":viernes";
              parametros[7].Value = pParametro.Viernes;

              parametros[8] = new OracleParameter();
              parametros[8].OracleType = OracleType.VarChar;
              parametros[8].ParameterName = ":sabado";
              parametros[8].Value = pParametro.Sabado;

              parametros[9] = new OracleParameter();
              parametros[9].OracleType = OracleType.VarChar;
              parametros[9].ParameterName = ":domingo";
              parametros[9].Value = pParametro.Domingo;

              parametros[10] = new OracleParameter();
              parametros[10].OracleType = OracleType.DateTime;
              parametros[10].ParameterName = ":fechaModificacion";
              parametros[10].Value = pParametro.FechaModificacion;

              parametros[11] = new OracleParameter();
              parametros[11].OracleType = OracleType.DateTime;
              parametros[11].ParameterName = ":fechaCreacion";
              parametros[11].Value = pParametro.FechaCreacion;

              parametros[12] = new OracleParameter();
              parametros[12].OracleType = OracleType.VarChar;
              parametros[12].ParameterName = ":creadoPor";
              parametros[12].Value = pParametro.CreadoPor;

              parametros[13] = new OracleParameter();
              parametros[13].OracleType = OracleType.VarChar;
              parametros[13].ParameterName = ":modificadoPor";
              parametros[13].Value = pParametro.ModificadoPor;

              parametros[14] = new OracleParameter();
              parametros[14].OracleType = OracleType.VarChar;
              parametros[14].ParameterName = ":activo";
              parametros[14].Value = pParametro.Activo;

              this.cnx.ejecutarSQL(sql, parametros);
              this.error = this.cnx.IsError;
              this.errorDescription = this.cnx.ErrorDescripcion;
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error agregando Parametro: " + e.Message;
          }
      }
      public void borrarParametro(ParametroL pParametro)
      {
          try
          {
              string sql = "delete from Parametro where idParametro = :idParametro";

              OracleParameter[] parametros = new OracleParameter[1];

              parametros[0] = new OracleParameter();
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idParametro";
              parametros[0].Value = pParametro.IdParametro;

              this.cnx.ejecutarSQL(sql, parametros);
              this.error = this.cnx.IsError;
              this.errorDescription = this.cnx.ErrorDescripcion;
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error borrando Parametro:" + e.Message;
          }
      }

      public void editarParametro(ParametroL pParametroOriginal, ParametroL pParametroEditado)
      {
          try
          {
              string sql = "update Parametro " +
                           "set idParametro = :idParametro, horaEntrada  = :horaEntrada, horaSalida = :horaSalida, lunes = :lunes, martes = :martes, miercoles = :miercoles, jueves = :jueves, viernes = :viernes, sabado = :sabado, domingo = :domingo, fechaModificacion = :fechaModificacion, fechaCreacion = :fechaCreacion, creadoPor = :creadoPor, modificadoPor = :modificadoPor, activo = :activo " +
                           "where idParametro = :idParametroOriginal";

              OracleParameter[] parametros = new OracleParameter[16];

              parametros[0] = new OracleParameter();
              parametros[0].OracleType = OracleType.VarChar;
              parametros[0].ParameterName = ":idParametro";
              parametros[0].Value = pParametroEditado.IdParametro;

              parametros[1] = new OracleParameter();
              parametros[1].OracleType = OracleType.DateTime;
              parametros[1].ParameterName = ":horaEntrada";
              parametros[1].Value = pParametroEditado.HoraEntrada;

              parametros[2] = new OracleParameter();
              parametros[2].OracleType = OracleType.DateTime;
              parametros[2].ParameterName = ":horaSalida";
              parametros[2].Value = pParametroEditado.HoraSalida;

              parametros[3] = new OracleParameter();
              parametros[3].OracleType = OracleType.VarChar;
              parametros[3].ParameterName = ":lunes";
              parametros[3].Value = pParametroEditado.Lunes;

              parametros[4] = new OracleParameter();
              parametros[4].OracleType = OracleType.VarChar;
              parametros[4].ParameterName = ":martes";
              parametros[4].Value = pParametroEditado.Martes;

              parametros[5] = new OracleParameter();
              parametros[5].OracleType = OracleType.VarChar;
              parametros[5].ParameterName = ":miercoles";
              parametros[5].Value = pParametroEditado.Miercoles;

              parametros[6] = new OracleParameter();
              parametros[6].OracleType = OracleType.VarChar;
              parametros[6].ParameterName = ":jueves";
              parametros[6].Value = pParametroEditado.Jueves;

              parametros[7] = new OracleParameter();
              parametros[7].OracleType = OracleType.VarChar;
              parametros[7].ParameterName = ":viernes";
              parametros[7].Value = pParametroEditado.Viernes;

              parametros[8] = new OracleParameter();
              parametros[8].OracleType = OracleType.VarChar;
              parametros[8].ParameterName = ":sabado";
              parametros[8].Value = pParametroEditado.Sabado;

              parametros[9] = new OracleParameter();
              parametros[9].OracleType = OracleType.VarChar;
              parametros[9].ParameterName = ":domingo";
              parametros[9].Value = pParametroEditado.Domingo;

              parametros[10] = new OracleParameter();
              parametros[10].OracleType = OracleType.DateTime;
              parametros[10].ParameterName = ":fechaModificacion";
              parametros[10].Value = pParametroEditado.FechaModificacion;

              parametros[11] = new OracleParameter();
              parametros[11].OracleType = OracleType.DateTime;
              parametros[11].ParameterName = ":fechaCreacion";
              parametros[11].Value = pParametroEditado.FechaCreacion;

              parametros[12] = new OracleParameter();
              parametros[12].OracleType = OracleType.VarChar;
              parametros[12].ParameterName = ":creadoPor";
              parametros[12].Value = pParametroEditado.CreadoPor;
              
              parametros[13] = new OracleParameter();
              parametros[13].OracleType = OracleType.VarChar;
              parametros[13].ParameterName = ":modificadoPor";
              parametros[13].Value = pParametroEditado.ModificadoPor;

              parametros[14] = new OracleParameter();
              parametros[14].OracleType = OracleType.VarChar;
              parametros[14].ParameterName = ":activo";
              parametros[14].Value = pParametroEditado.Activo;

              parametros[15] = new OracleParameter();
              parametros[15].OracleType = OracleType.VarChar;
              parametros[15].ParameterName = ":idUsuarioOriginal";
              parametros[15].Value = pParametroOriginal.IdParametro;

              this.cnx.ejecutarSQL(sql, parametros);
              this.error = this.cnx.IsError;
              this.errorDescription = this.cnx.ErrorDescripcion;
          }
          catch (Exception e)
          {
              this.error = true;
              this.errorDescription = "Error editando Parametro: " + e.Message;
          }
       }
    }
}
