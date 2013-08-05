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
    public class EmpleadoD
    {
        /// <summary>
        /// Atributos de la clase Empleado en la parte de Datos donde establece conexión con la Base de Datos de Oracle,tambien se crea 
        /// un atributo por si ocurre un error en el proceso de conexión y adémas detalla que tipo de error fue el que se presento
        /// </summary>
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";


        /// <summary>
        /// Método Constructor de la Clase Empleado el cual recibe como  parámetro una conexión a Acceso de datos Oracle el cual es el que 
        /// inicializa el atributo 
        /// </summary>
        public EmpleadoD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }
        /// <summary>
        /// Properties de la Clase Empleado en cual permite modificar o consultar los datos con los cuales fueron cargados los atributos de 
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
        /// Método que obtiene el Empleado el cual realiza una consulta a la base de datos en la tabla Empleado,luego consulta si 
        /// ocurrio algún error y sino lo hubo procede a crear un empleado con los datos correspondientes y se los envia a la clase de
        /// lógica del Empleado
        /// /// </summary>
        /// <returns></returns>

        public List<EmpleadoL> obtenerEmpleado()
        {
            List<EmpleadoL> retorno = new List<EmpleadoL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Empleado");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new EmpleadoL(   fila["idEmpleado"].ToString(),
                                                     fila["idDepartamento"].ToString(),
                                                     fila["nombreEmpleado"].ToString(),
                                                     fila["apellido1"].ToString(),
                                                     fila["apellido2"].ToString(),
                                                     int.Parse(fila["numCedula"].ToString()),
                                                     int.Parse(fila["telefono"].ToString()),
                                                     (fila["fechaNacimiento"].ToString()),
                                                     double.Parse(fila["salarioPorHora"].ToString()),
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
                    this.errorDescription = "Error obteniendo Empleado: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Empleado: " + e.Message;
            }
            return retorno;
        }
        /// <summary>
        /// Método que agrega unnuevo empleado a la Base de Datos de Oracle,el cual recibe por parámetro un Empleado que viene cargado con 
        /// los respectivos valores para ser pasados a la base de datos ya creada,ademas procede a realizar una consulta al sql para saber si
        /// los parámetros creados coinciden con los de la base de datos y si considen procede a insertarlos
        /// </summary>
        /// <param name="pEmpleado"></param>

        public void agregarEmpleado(EmpleadoL pEmpleado)
        {
            try
            {
                string sql = "insert into Empleado(idEmpleado,idDepartamento,nombreEmpleado,apellido1,apellido2,numCedula,telefono,fechaNacimiento,salarioPorHora,creadoPor,fechaCreacion,modificadoPor,fechaModificacion,activo) " +
                             "values(:idEmpleado, :idDepartamento, :nombreEmpleado, :apellido1, :apellido2, :numCedula, :telefono, :fechaNacimiento, :salarioPorHora, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion, :activo)";

                OracleParameter[] parametros = new OracleParameter[14];// Parametros

                parametros[0] = new OracleParameter();// Parámetro que va a la base de datos a agregar el id Empleado
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idEmpleado";
                parametros[0].Value = pEmpleado.IdEmpleado;

                parametros[1] = new OracleParameter();// Parámetro que va a la base de datos a agregar el id Departamento
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":idDepartamento";
                parametros[1].Value = pEmpleado.IdDepartamento;

                parametros[2] = new OracleParameter();// Parámetro que va a la base de datos a agregar el Nombre del Empleado
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":nombreEmpleado";
                parametros[2].Value = pEmpleado.NombreEmpleado;

                parametros[3] = new OracleParameter();// Parámetro que va a la base de datos a agregar el Apellido1
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":apellido1";
                parametros[3].Value = pEmpleado.Apellido1;

                parametros[4] = new OracleParameter();// Parámetro que va a la base de datos a agregar el Apellido2
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":apellido2";
                parametros[4].Value = pEmpleado.Apellido2;

                parametros[5] = new OracleParameter();// Parámetro que va a la base de datos a agregar el Numero de Cedula
                parametros[5].OracleType = OracleType.Number;
                parametros[5].ParameterName = ":numCedula";
                parametros[5].Value = pEmpleado.NumCedula;

                parametros[6] = new OracleParameter();// Parámetro que va a la base de datos a agregar el Telefono 
                parametros[6].OracleType = OracleType.Number;
                parametros[6].ParameterName = ":telefono";
                parametros[6].Value = pEmpleado.Telefono;

                parametros[7] = new OracleParameter();// Parámetro que va a la base de datos a agregar la Fecha de Nacimiento 
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":fechaNacimiento";
                parametros[7].Value = pEmpleado.FechaNacimiento;

                parametros[8] = new OracleParameter();// Parámetro que va a la base de datos a agregar el Salario Por Hora  
                parametros[8].OracleType = OracleType.Number;
                parametros[8].ParameterName = ":salarioPorHora";
                parametros[8].Value = pEmpleado.SalarioPorHora;

                parametros[9] = new OracleParameter();// Parámetro que va a la base de datos a agregar Creado Por 
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":creadoPor";
                parametros[9].Value = pEmpleado.CreadoPor;

                parametros[10] = new OracleParameter();// Parámetro que va a la base de datos a agregar la FechaCreacion
                parametros[10].OracleType = OracleType.DateTime;
                parametros[10].ParameterName = ":fechaCreacion";
                parametros[10].Value = pEmpleado.FechaCreacion;

                parametros[11] = new OracleParameter();// Parámetro que va a la base de datos a agregar Modificado Por 
                parametros[11].OracleType = OracleType.VarChar;
                parametros[11].ParameterName = ":modificadoPor";
                parametros[11].Value = pEmpleado.ModificadoPor;

                parametros[12] = new OracleParameter();// Parámetro que va a la base de datos a agregar la FechaCreacion
                parametros[12].OracleType = OracleType.DateTime;
                parametros[12].ParameterName = ":fechaModificacion";
                parametros[12].Value = pEmpleado.FechaModificacion;

                parametros[13] = new OracleParameter();// Parámetro que va a la base de datos a agregar el Activo
                parametros[13].OracleType = OracleType.VarChar;
                parametros[13].ParameterName = ":activo";
                parametros[13].Value = pEmpleado.Activo;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error agregando Empleado: " + e.Message;
            }
        }
        /// <summary>
        /// Método que borra un Empleado,el cual procede a recibir un parámetro de tipo Empleado y verifica que en la base de datos 
        /// exista un parámetro igual y procede a eliminar este
        /// </summary>
        /// <param name="pEmpleado"></param>

        public void borrarEmpleado(EmpleadoL pEmpleado)
        {
            try
            {
                string sql = "delete from Empleado where idEmpleado = :idEmpleado";

                OracleParameter[] parametros = new OracleParameter[1];//Parametro

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idEmpleado";
                parametros[0].Value = pEmpleado.IdEmpleado;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error borrando Empleado: " + e.Message;
            }
        }
        /// <summary>
        /// Método que Edita los datos ya existentes en la Clase Empleado el cual recibe por parámetro los datos originales y los que vamos a editar para que 
        /// pueda realizar el cambio
        /// </summary>
        /// <param name="pEmpleadoOriginal"></param>
        /// <param name="pEmpleadoEditado"></param>
        /// 

        public List<EmpleadoL> buscarEmpleado(string pEmpleado)
        {
            List<EmpleadoL> retorno = new List<EmpleadoL>();
            try
            {
                //select que carga el dataset con los datos de los usuarios
                string sql = ("select * from Empleado where idEmpleado = :idEmpleado");

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idEmpleado";
                parametros[0].Value = pEmpleado;

                DataSet datos = this.cnx.ejecutarConsultaSQL(sql, "Empleado", parametros);

                if (this.cnx.IsError == false)
                {
                    //se recorre el dataset por cada fila
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        //se carca la lista de la lógica de usuario con sus siete atributos
                        retorno.Add(
                                    new EmpleadoL(fila["idEmpleado"].ToString(),
                                                  fila["idDepartamento"].ToString(),           
                                                   fila["nombreEmpleado"].ToString(),
                                                   fila["apellido1"].ToString(),
                                                   fila["apellido2"].ToString(),
                                                   int.Parse(fila["numCedula"].ToString()),                                                   
                                                   int.Parse(fila["telefono"].ToString()),
                                                   fila["fechaNacimiento"].ToString(),
                                                   double.Parse(fila["salarioPorHora"].ToString()),                                                   
                                                   fila["creadoPor"].ToString(),
                                                   DateTime.Parse(fila["fechaCreacion"].ToString()),
                                                   fila["modificadoPor"].ToString(),
                                                   DateTime.Parse(fila["fechaModificacion"].ToString()),
                                                   fila["activo"].ToString())
                                                 
                                   );
                    }
                }
                //se validan los errores 
                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo empleado:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Empleado:" + e.Message;
            }

            return retorno;            
        }

        /// <summary>
        /// Metodo que nos facilita editar una linea del empleado que se encuentre seleccionada
        /// </summary>
        /// <param name="pEmpleadoOriginal"></param>
        /// <param name="pEmpleadoEditado"></param>

        public void editarEmpleado(EmpleadoL pEmpleadoOriginal, EmpleadoL pEmpleadoEditado)
        {
            try
            {
                string sql = "update Empleado " +
                             "set idEmpleado = :idEmpleado, idDepartamento = :idDepartamento, nombreEmpleado = :nombreEmpleado, apellido1 = :apellido1, apellido2 = :apellido2, numCedula = :numCedula, telefono = :telefono, fechaNacimiento = :fechaNacimiento, salarioPorHora = :salarioPorHora, modificadoPor = :modificadoPor, fechaModificacion = :fechaModificacion, activo = :activo " +
                             "where idEmpleado = :idEmpleadoOriginal";

                OracleParameter[] parametros = new OracleParameter[13];//Parametros

                parametros[0] = new OracleParameter();// Parámetro que va a la base de datos a editar el id Empleado
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idEmpleado";
                parametros[0].Value = pEmpleadoEditado.IdEmpleado;

                parametros[1] = new OracleParameter();// Parámetro que va a la base de datos a editar el id Departamento
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":idDepartamento";
                parametros[1].Value = pEmpleadoEditado.IdDepartamento;

                parametros[2] = new OracleParameter();// Parámetro que va a la base de datos a editar el Nombre del Empleado
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":nombreEmpleado";
                parametros[2].Value = pEmpleadoEditado.NombreEmpleado;

                parametros[3] = new OracleParameter();// Parámetro que va a la base de datos a editar el Apellido1
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":apellido1";
                parametros[3].Value = pEmpleadoEditado.Apellido1;

                parametros[4] = new OracleParameter();// Parámetro que va a la base de datos a editar el Apellido2
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":apellido2";
                parametros[4].Value = pEmpleadoEditado.Apellido2;

                parametros[5] = new OracleParameter();// Parámetro que va a la base de datos a editar el Numero de Cedula
                parametros[5].OracleType = OracleType.Number;
                parametros[5].ParameterName = ":numCedula";
                parametros[5].Value = pEmpleadoEditado.NumCedula;

                parametros[6] = new OracleParameter();// Parámetro que va a la base de datos a editar el Telefono 
                parametros[6].OracleType = OracleType.Number;
                parametros[6].ParameterName = ":telefono";
                parametros[6].Value = pEmpleadoEditado.Telefono;

                parametros[7] = new OracleParameter();// Parametro que va a la base de datos a editar la Fecha de Nacimiento 
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":fechaNacimiento";
                parametros[7].Value = pEmpleadoEditado.FechaNacimiento;

                parametros[8] = new OracleParameter();// Parámetro que va a la base de datos a editar el Salario Por Hora  
                parametros[8].OracleType = OracleType.Double;
                parametros[8].ParameterName = ":salarioPorHora";
                parametros[8].Value = pEmpleadoEditado.SalarioPorHora;

                parametros[9] = new OracleParameter();// Parámetro que va a la base de datos a editar Modificado Por 
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":modificadoPor";
                parametros[9].Value = pEmpleadoEditado.ModificadoPor;

                parametros[10] = new OracleParameter();// Parámetro que va a la base de datos a editar la FechaCreacion
                parametros[10].OracleType = OracleType.DateTime;
                parametros[10].ParameterName = ":fechaModificacion";
                parametros[10].Value = pEmpleadoEditado.FechaModificacion;                             

                parametros[11] = new OracleParameter();// Parámetro que va a la base de datos a editar el Activo
                parametros[11].OracleType = OracleType.VarChar;
                parametros[11].ParameterName = ":activo";
                parametros[11].Value = pEmpleadoEditado.Activo;

                parametros[12] = new OracleParameter();// Parámetro que va a la base de datos a editar la linea editada por la original
                parametros[12].OracleType = OracleType.VarChar;
                parametros[12].ParameterName = ":idEmpleadoOriginal";
                parametros[12].Value = pEmpleadoOriginal.IdEmpleado;

                this.cnx.ejecutarSQL(sql, parametros);
                this.error = this.cnx.IsError;
                this.errorDescription = this.cnx.ErrorDescripcion;
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error editando Empleado: " + e.Message;
            }
        }
        /// <summary>
        /// Metodo que obtiene el nombre del empleado, realizando una consulta en la base de datos
        /// </summary>
        /// <returns></returns>

        public DataSet obtenerNombreEmpleado()
        {
            DataSet datos = this.cnx.ejecutarConsultaSQL("select nombreEmpleado || ' ' || apellido1 || ' ' || apellido2 as nombreCompleto from Empleado");
            try
            {
                if (this.cnx.IsError == true)
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo Empleados: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Empleados: " + e.Message;
            }
            return datos;
        }
        /// <summary>
        /// Metodo que obtiene el codig del empleado, y realiza una consulta en la base de datos.
        /// </summary>
        /// <returns></returns>

        public List<EmpleadoL> obtenerDepartamentoEmpleado(string pDepartamento)
        {
            //lista de la lógica usuario
            List<EmpleadoL> retorno = new List<EmpleadoL>();
            try
            {
                //select que carga el dataset con los datos de los usuarios
                string sql = ("select * from Empleado where idDepartamento = :pidDepartamento");

                OracleParameter[] parametros = new OracleParameter[1];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":pidDepartamento";
                parametros[0].Value = pDepartamento;

                DataSet datos = this.cnx.ejecutarConsultaSQL(sql, "Empleado", parametros);

                if (this.cnx.IsError == false)
                {
                    //se recorre el dataset por cada fila
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        //se carca la lista de la lógica de usuario con sus siete atributos
                        retorno.Add(
                                    new EmpleadoL(fila["idEmpleado"].ToString(),
                                                     fila["idDepartamento"].ToString(),
                                                     fila["nombreEmpleado"].ToString(),
                                                     fila["apellido1"].ToString(),
                                                     fila["apellido2"].ToString(),
                                                     int.Parse(fila["numCedula"].ToString()),
                                                     int.Parse(fila["telefono"].ToString()),
                                                     (fila["fechaNacimiento"].ToString()),
                                                     double.Parse(fila["salarioPorHora"].ToString()),
                                                     fila["creadoPor"].ToString(),
                                                     DateTime.Parse(fila["fechaCreacion"].ToString()),
                                                     fila["modificadoPor"].ToString(),
                                                     DateTime.Parse(fila["fechaModificacion"].ToString()),
                                                     fila["activo"].ToString()
                                                 )
                                   );
                    }
                }
                //se validan los errores 
                else
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo Empleado:" +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Empleado:" + e.Message;
            }

            return retorno;
        }

        public DataSet obtenerCodigoEmpleado()
        {
            DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Empleado");
            try
            {
                if (this.cnx.IsError == true)
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo Empleados: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Empleados: " + e.Message;
            }
            return datos;
        }

        /// <summary>
        /// Método que se encarga de traer de la base de datos los códigos de empleado que pertenecen
        /// a un departamento determinado, que se recibe por parámetro,
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns></returns>

        public DataSet obtenerIdEmpleadoPorDepartameno(string idDepartamento)
        {

            DataSet datos = this.cnx.ejecutarConsultaSQL("select idEmpleado from Empleado where idDepartamento = '" + idDepartamento + "'");
            try
            {
                if (this.cnx.IsError == true)
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo Empleados: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Empleados: " + e.Message;
            }
            return datos;
        }

        /// <summary>
        /// Método que se encarga de traer de la base de datos los nombres de empleado que pertenecen
        /// a un departamento determinado, que se recibe por parámetro,
        /// </summary>
        /// <param name="idDepartamento"></param>
        /// <returns></returns>

        public DataSet obtenerNombreEmpleadoPorDepartameno(string idDepartamento)
        {

            DataSet datos = this.cnx.ejecutarConsultaSQL("select nombreEmpleado || ' ' || apellido1 || ' ' || apellido2 as nombreCompleto from Empleado where idDepartamento = '" + idDepartamento + "'");
            try
            {
                if (this.cnx.IsError == true)
                {
                    this.error = true;
                    this.errorDescription = "Error obteniendo Empleados: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Empleados: " + e.Message;
            }
            return datos;
        }

    }
}
