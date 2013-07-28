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


        public List<MarcaL> obtenerMarca()
        {
            //lista de la lógica empleado
            List<MarcaL> retorno = new List<MarcaL>();
            try
            {
                //select que carga el dataset con los datos de los usuarios
                DataSet datos = this.cnx.ejecutarConsultaSQL("select m.*, e.nombreEmpleado || ' ' || e.apellido1 || ' ' || e.apellido2 as nombreEmpleado from marca m, Empleado e where m.idEmpleado = e.idEmpleado");
                if (this.cnx.IsError == false)
                {
                    //se recorre el dataset por cada fila
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        //se carga la lista de la lógica de empleado con sus siete atributos
                        retorno.Add(
                                    new MarcaL(    int.Parse(fila["idMarca"].ToString()),
                                                   int.Parse(fila["idUnificacion"].ToString()),
                                                   fila["idEmpleado"].ToString(),
                                                   fila["estadoMarca"].ToString(),
                                                   fila["tipoMarca"].ToString(),
                                                   DateTime.Parse(fila["fechaMarca"].ToString()),
                                                   fila["creadoPor"].ToString(),
                                                   DateTime.Parse(fila["fechaCreacion"].ToString()),
                                                   fila["modificadoPor"].ToString(),
                                                   Convert.ToDateTime(fila["fechaModificacion"].ToString()),
                                                   fila["activo"].ToString()
                                                 )
                                   );
                    }
                }
                //se validan los errores 
                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo Marca:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Marca:" + e.Message;
            }

            return retorno;
        }

        public string agregarMarca(MarcaL pMarca)
        {
            string retorno = "";
            try
            {
                string sql = "insert into marca(idUnificacion, idEmpleado, estadoMarca, tipoMarca, fechaMarca, creadoPor, fechaCreacion, modificadoPor, fechaModificacion, activo) " +
                             "values(:idUnificacion, :idEmpleado, :estadoMarca, :tipoMarca, :fechaMarca, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion, :activo) " +
                             "returning idMarca into :idMarca";

                OracleParameter[] parametros = new OracleParameter[11];// Parametros


                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Number;
                parametros[0].ParameterName = ":idUnificacion";
                parametros[0].Value = pMarca.IdUnificacion;

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
                parametros[4].OracleType = OracleType.DateTime;
                parametros[4].ParameterName = ":fechaMarca";
                parametros[4].Value = pMarca.FechaMarca;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":creadoPor";
                parametros[5].Value = pMarca.CreadoPor;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.DateTime;
                parametros[6].ParameterName = ":fechaCreacion";
                parametros[6].Value = pMarca.FechaCreacion;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":modificadoPor";
                parametros[7].Value = pMarca.ModificadoPor;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.DateTime;
                parametros[8].ParameterName = ":fechaModificacion";
                parametros[8].Value = pMarca.FechaModificacion;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":activo";
                parametros[9].Value = pMarca.Activo;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.Number;
                parametros[10].ParameterName = ":idMarca";
                parametros[10].Direction = ParameterDirection.Output;


                retorno = this.cnx.ejecutarSQLReturning(sql, parametros, ":idMarca");
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando la Marca: " + e.Message;
            }
            return retorno;
        }
        public void agregarMarca2(MarcaL pMarca)
        {

            try
            {
                string sql = "insert into marca(idMarca, idUnificacion, idEmpleado, estadoMarca, tipoMarca, fechaMarca, creadoPor, fechaCreacion, modificadoPor, fechaModificacion, activo) " +
                             "values(:idMarca, :idUnificacion, :idEmpleado, :estadoMarca, :tipoMarca, :fechaMarca, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion, :activo) ";

                OracleParameter[] parametros = new OracleParameter[11];// Parametros

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Number;
                parametros[0].ParameterName = ":idMarca";
                parametros[0].Value = pMarca.IdMarca;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Number;
                parametros[1].ParameterName = ":idUnificacion";
                parametros[1].Value = pMarca.IdUnificacion;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":idEmpleado";
                parametros[2].Value = pMarca.IdEmpleado;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":estadoMarca";
                parametros[3].Value = pMarca.EstadoMarca;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":tipoMarca";
                parametros[4].Value = pMarca.TipoMarca;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.DateTime;
                parametros[5].ParameterName = ":fechaMarca";
                parametros[5].Value = pMarca.FechaMarca;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":creadoPor";
                parametros[6].Value = pMarca.CreadoPor;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.DateTime;
                parametros[7].ParameterName = ":fechaCreacion";
                parametros[7].Value = pMarca.FechaCreacion;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":modificadoPor";
                parametros[8].Value = pMarca.ModificadoPor;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.DateTime;
                parametros[9].ParameterName = ":fechaModificacion";
                parametros[9].Value = pMarca.FechaModificacion;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.VarChar;
                parametros[10].ParameterName = ":activo";
                parametros[10].Value = pMarca.Activo;

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

        private DataSet tipoMarca1(string pEmpleado)
        {

            this.ErrorDescription = "";
            string datos = "Select tipoMarca from (select * from Marca order by fechaCreacion desc  ) where idEmpleado = :idEmpleado and rownum = 1 ";
            OracleParameter[] parametros = new OracleParameter[1];

            parametros[0] = new OracleParameter();
            parametros[0].OracleType = OracleType.VarChar;
            parametros[0].ParameterName = ":idEmpleado";
            parametros[0].Value = pEmpleado;

            DataSet retorno = this.cnx.ejecutarConsultaSQL(datos, "Empleado", parametros);
            if (this.cnx.IsError)
            {

                this.error = true;
                this.errorDescription = "Error obteniendo marca:";
            }
            return retorno;

        }
        public string tipoMarca(string pEmpleado)
        {
            MarcaL oMarcaL = new MarcaL();

            string tipo = "";

            DataSet tipoMarca = this.tipoMarca1(pEmpleado).Copy();
            if (tipoMarca.Tables[0].Rows.Count > 0)
            {
                oMarcaL.TipoMarca = tipoMarca.Tables[0].Rows[0]["tipoMarca"].ToString();

                if (oMarcaL.TipoMarca.Equals(null))
                {
                    tipo = "Entrada";
                }
                else
                {
                    if (oMarcaL.TipoMarca == "Entrada")
                    {
                        tipo = "Salida";

                    }
                    else
                    {
                        if (oMarcaL.TipoMarca == "Salida")
                        {
                            tipo = "Entrada";
                        }
                    }
                }

            }
            return tipo;

        }

        public void editarMarca(MarcaL pMarcaEditada, MarcaL pMarcaOriginal)
        {
            try
            {
                string sql = "update marca " +
                             "set idMarca = :idMarca, " +
                             "idUnificacion = :idUnificacion, " +
                             "idEmpleado = :idEmpleado, " +
                             "estadoMarca = :estadoMarca, " +
                             "tipoMarca = :tipoMarca, " +
                             "fechaMarca = :fechaMarca, " +
                             "creadoPor = :creadoPor, " +
                             "fechaCreacion = :fechaCreacion, " +
                             "modificadoPor = :modificadoPor, " +
                             "fechaModificacion = :fechaModificacion " +
                             "activo = :activo " +
                             "where idMarca = :idMarcaOriginal";
                ;
                OracleParameter[] parametros = new OracleParameter[11];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Int32;
                parametros[0].ParameterName = ":idMarca";
                parametros[0].Value = pMarcaEditada.IdMarca;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Int32;
                parametros[1].ParameterName = ":idUnificacion";
                parametros[1].Value = pMarcaEditada.IdUnificacion;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":idEmpleado";
                parametros[2].Value = pMarcaEditada.IdEmpleado;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":estadoMarca";
                parametros[3].Value = pMarcaEditada.EstadoMarca;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":tipoMarca";
                parametros[4].Value = pMarcaEditada.TipoMarca;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.DateTime;
                parametros[5].ParameterName = ":fechaMarca";
                parametros[5].Value = pMarcaEditada.CreadoPor;


                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.VarChar;
                parametros[6].ParameterName = ":creadoPor";
                parametros[6].Value = pMarcaEditada.CreadoPor;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.DateTime;
                parametros[7].ParameterName = ":fechaCreacion";
                parametros[7].Value = pMarcaEditada.FechaCreacion;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.VarChar;
                parametros[8].ParameterName = ":modificadoPor";
                parametros[8].Value = pMarcaEditada.ModificadoPor;

                parametros[9] = new OracleParameter();
                parametros[9].OracleType = OracleType.DateTime;
                parametros[9].ParameterName = ":fechaModificacion";
                parametros[9].Value = pMarcaEditada.FechaModificacion;

                parametros[10] = new OracleParameter();
                parametros[10].OracleType = OracleType.Double;
                parametros[10].ParameterName = ":idMarcaOriginal";
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

        public List<MarcaL> obtenerMarcaFiltro(DateTime pFecha1, DateTime pFecha2, string pIdEmpleado, string pDepartamento,
                                               string pNombreEmpleado, string  pEstadoMarca, string pActivo)
        {
            List<MarcaL> retorno = new List<MarcaL>();
            try
            {

                string sql = "select m.*, e.nombreEmpleado || ' ' || e.apellido1 || ' ' || e.apellido2 as nombreCompleto from marca m, Empleado e where m.idEmpleado = e.idEmpleado and  m.fechaMarca >= :fecha1 and m.fechaMarca <= :fecha2";
                int indices = 2;

                if (pIdEmpleado != "")
                {
                    sql += " and m.idEmpleado = :idEmpleado";
                    indices++;
                }

                if (pDepartamento != "")
                {
                    sql += " and e.idDepartamento = :idDepartamento";
                    indices++;
                }

                if (pNombreEmpleado != "")
                {
                    sql += " and e.nombreEmpleado || ' ' || e.apellido1 || ' ' || e.apellido2 like :nombreEmpleado";
                    indices++;
                }

                if (pEstadoMarca != "")
                {
                    sql += " and m.estadoMarca = :estadoMarca";
                    indices++;
                }

                if (pActivo != "")
                {
                    sql += " and m.Activo = :Activo";
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

                if (pEstadoMarca != "")
                {
                    parametros[indices] = new OracleParameter();
                    parametros[indices].OracleType = OracleType.VarChar;
                    parametros[indices].ParameterName = ":estadoMarca";
                    parametros[indices].Value = pEstadoMarca;
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
                    parametros[indices].ParameterName = ":nombreEmpleado";
                    parametros[indices].Value = "%" + pNombreEmpleado + "%";
                    indices++;
                }

                if (pActivo != "")
                {
                    parametros[indices] = new OracleParameter();
                    parametros[indices].OracleType = OracleType.VarChar;
                    parametros[indices].ParameterName = ":Activo";
                    parametros[indices].Value = pActivo;
                    indices++;
                }

                DataSet datos = this.cnx.ejecutarConsultaSQL(sql, "marca", parametros);
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new MarcaL(    int.Parse(fila["idMarca"].ToString()),
                                                   int.Parse(fila["idUnificacion"].ToString()),
                                                   fila["idEmpleado"].ToString(),
                                                   fila["estadoMarca"].ToString(),
                                                   fila["tipoMarca"].ToString(),
                                                   DateTime.Parse(fila["fechaMarca"].ToString()),
                                                   fila["creadoPor"].ToString(),
                                                   DateTime.Parse(fila["fechaCreacion"].ToString()),
                                                   fila["modificadoPor"].ToString(),
                                                   DateTime.Parse(fila["fechaModificacion"].ToString()),
                                                   fila["activo"].ToString())

                                   );
                    }
                }

                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo Marca:" +
                                            this.cnx.ErrorDescripcion;

                }
            }

            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Marca:" + e.Message;
            }
            return retorno;

        }
    }
}