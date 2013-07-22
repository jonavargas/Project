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


        /// <summary>
        /// Metodo para agregar la marca a la base de datos
        /// </summary>
        /// <param name="pMarcaL"></param>

        public void agregarMarca(MarcaL pMarcaL)
        {
            try
            {
                string sql = "insert into marca(iUnificacion, idEmpleado, fechaMarca, tipoMarca, estadoMarca, creadoPor, fechaCreacion, modificadoPor, fechaModificacion) " +
                             "values(:idUnificacion, :idEmpleado, :fechaMarca, :tipoMarca, :estadoMarca, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion)";

                OracleParameter[] parametros = new OracleParameter[9];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Double;
                parametros[0].ParameterName = ":idUnificacion";
                parametros[0].Value = pMarcaL.IdUnificacion;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":idEmpleado";
                parametros[1].Value = pMarcaL.IdEmpleado;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.DateTime;
                parametros[2].ParameterName = ":fechaMarca";
                parametros[2].Value = pMarcaL.FechaMarca;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":tipoMarca";
                parametros[3].Value = pMarcaL.TipoMarca;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":estadoMarca";
                parametros[4].Value = pMarcaL.EstadoMarca;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":creadoPor";
                parametros[5].Value = pMarcaL.CreadoPor;

                parametros[6] = new OracleParameter();
                parametros[6].OracleType = OracleType.DateTime;
                parametros[6].ParameterName = ":fechaCreacion";
                parametros[6].Value = pMarcaL.FechaCreacion;

                parametros[7] = new OracleParameter();
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":modificadoPor";
                parametros[7].Value = pMarcaL.ModificadoPor;

                parametros[8] = new OracleParameter();
                parametros[8].OracleType = OracleType.DateTime;
                parametros[8].ParameterName = ":fechaModificacion";
                parametros[8].Value = pMarcaL.FechaModificacion;

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
        /// <summary>
        /// Metodo para obtener de la base de datos la ultima marca realizada
        /// </summary>
        /// <param name="pIdEmpleado"></param>
        /// <returns></returns>
        public DataSet TipoMarca(string pIdEmpleado)
        {

            string sql = "Select tipo from (select * from Marca) where idEmpleado = :idEmpleado and rownum = 1";

            OracleParameter[] parametros = new OracleParameter[1];

            parametros[0] = new OracleParameter();
            parametros[0].OracleType = OracleType.VarChar;
            parametros[0].ParameterName = ":idEmpleado";
            parametros[0].Value = pIdEmpleado;

            DataSet datos = this.cnx.ejecutarConsultaSQL(sql, "empleado", parametros);

            if (this.cnx.IsError)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo el tipo de marca:";
            }

            return datos;
        }


        public List<MarcaL> obtenerMarcas()
        {
           List<MarcaL> retorno = new List<MarcaL>();
            try
            {
                //Select para obtener los datos que necesitamos de la base de datos
                DataSet datos = this.cnx.ejecutarConsultaSQL("select m.*, e.nombreEmpleado || ' ' || e.apellido1 || ' ' || e.apellido2 as nombreCompleto from marca m, empleado e where m.idEmpleado = e.idEmpleado");
                if (this.cnx.IsError == false)
                {
                   
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        
                        retorno.Add(
                                    new MarcaL(    int.Parse(fila["idMarca"].ToString()),
                                                   int.Parse(fila["idUnificacion"].ToString()),
                                                   fila["idEmpleado"].ToString(),
                                                   Convert.ToDateTime(fila["fechaMarca"].ToString()),
                                                   fila["tipoMarca"].ToString(),
                                                   fila["estadoMarca"].ToString(),
                                                   fila["creadoPor"].ToString(),
                                                   Convert.ToDateTime(fila["fechaCreacion"].ToString()),
                                                   fila["modificadoPor"].ToString(),
                                                   Convert.ToDateTime(fila["fechaModificacion"].ToString()),
                                                   fila["nombreCompleto"].ToString()
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
        /// Metodo que obtiene las marcas para poner editarlas y guarda los cambios realizados
        /// </summary>
        /// <param name="pMarcaEditada"></param>
        /// <param name="pMarcaOriginal"></param>
        /// 
        public void editarMarca(MarcaL pMarcaEditada, MarcaL pMarcaOriginal)
        {
            try
            {
                string sql = "update marca " +
                             "set idMarca = :idMarca, idUnificacion = :idUnificacion, idEmpleado = :idEmpleado, fechaMarca = :fechaMarca, tipoMarca = :tipoMarca, " +
                             "estadoMarca = :estadoMarca, creadoPor = :creadoPor, fechaCreacion = :fechaCreacion,m odificadoPor = :modificadoPor, fechaModificacion = :fechaModificacion " +
                             "where idMarca = :idMarcaOriginal";

                
                OracleParameter[] parametros = new OracleParameter[11];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.Double;
                parametros[0].ParameterName = ":idMarca";
                parametros[0].Value = pMarcaEditada.IdMarca;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.Double;
                parametros[1].ParameterName = ":idUnificacion";
                parametros[1].Value = pMarcaEditada.IdUnificacion;

                parametros[2] = new OracleParameter();
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":idEmpleado";
                parametros[2].Value = pMarcaEditada.IdEmpleado;

                parametros[3] = new OracleParameter();
                parametros[3].OracleType = OracleType.DateTime;
                parametros[3].ParameterName = ":fechaMarca";
                parametros[3].Value = pMarcaEditada.FechaMarca;

                parametros[4] = new OracleParameter();
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":tipoMarca";
                parametros[4].Value = pMarcaEditada.TipoMarca;

                parametros[5] = new OracleParameter();
                parametros[5].OracleType = OracleType.VarChar;
                parametros[5].ParameterName = ":estadoMarca";
                parametros[5].Value = pMarcaEditada.EstadoMarca;

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
                this.errorDescription = "Error editando las marca:" + e.Message;
            }
        }

        /// <summary>
        /// Metodo para obtener las marcas por el filtro
        /// </summary>
       
        public List<MarcaL> MarcaFiltro(DateTime pFecha1, DateTime pFecha2, string pDepartamento,
                                       string pEstado, string pIdEmpleado, string pNombreEmpleado)
        {
            List<MarcaL> retorno = new List<MarcaL>();
            try
            {

                string sql = "select m.*, e.nombreEmpleado || ' ' || e.apellido1 || ' ' || e.apellido2 as nombreCompleto from marca m, empleado e where m.idEmpleado = e.idEmpleado and  m.fecha >= :fecha1 and m.fecha <= :fecha2";
                int indices = 2;

                if (pDepartamento != "")
                {
                    sql += " and e.idDepartamento = :idDepartamento";
                    indices++;
                }

                if (pEstado != "")
                {
                    sql += " and m.estadoMarca = :estadoMarca";
                    indices++;
                }

                if (pIdEmpleado != "")
                {
                    sql += " and m.idEmpleado = :idEmpleado";
                    indices++;
                }

                if (pNombreEmpleado != "")
                {
                    sql += " and e.nombreEmpleado || ' ' || e.apellido1 || ' ' || e.apellido2 like :nombreEmpleado";
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

                if (pEstado != "")
                {
                    parametros[indices] = new OracleParameter();
                    parametros[indices].OracleType = OracleType.VarChar;
                    parametros[indices].ParameterName = ":estadoMarca";
                    parametros[indices].Value = pEstado;
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
                    parametros[indices].ParameterName = ":nombre";
                    parametros[indices].Value = "%" + pNombreEmpleado + "%";

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
                                                   Convert.ToDateTime(fila["fechaMarca"].ToString()),
                                                   fila["tipoMarca"].ToString(),
                                                   fila["estadoMarca"].ToString(),
                                                   fila["creadoPor"].ToString(),
                                                   Convert.ToDateTime(fila["fechaCreacion"].ToString()),
                                                   fila["modificadoPor"].ToString(),
                                                   Convert.ToDateTime(fila["fechaModificacion"].ToString()),
                                                   fila["nombreCompleto"].ToString()
                                                 )
                                   );
                    }
                }

                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo las marcas:" +
                                            this.cnx.ErrorDescripcion;

                }
            }

            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo las marcas:" + e.Message;
            }
            return retorno;
        }

    }


    
}
