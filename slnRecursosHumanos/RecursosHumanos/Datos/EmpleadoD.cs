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
        /// Atributos de la clase
        /// </summary>
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public EmpleadoD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }
        /// <summary>
        /// Propiedades de los atributos
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
        /// Metodo que obtiene el empleado
        /// </summary>
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
                                    new EmpleadoL(fila["idEmpleado"].ToString(),
                                                     fila["idDepartamento"].ToString(),
                                                     fila["nombreEmpleado"].ToString(),
                                                     fila["apellido1"].ToString(),
                                                     fila["apellido2"].ToString(),
                                                     int.Parse(fila["numCedula"].ToString()),
                                                     int.Parse(fila["telefono"].ToString()),
                                                     (fila["fechaNacimiento"].ToString()),
                                                     Double.Parse(fila["salarioPorHora"].ToString()),
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
        /// Metodo que agrega un nuevo usuario
        /// </summary>
        /// <param name="pEmpleado"></param>

        public void agregarEmpleado(EmpleadoL pEmpleado)
        {
            try
            {
                string sql = "insert into Empleado(idEmpleado,idDepartamento,nombreEmpleado,apellido1,apellido2,numCedula,telefono,fechaNacimiento,salarioPorHora,creadoPor,fechaCreacion,modificadoPor,fechaModificacion,activo) " +
                             "values(:idEmpleado, :idDepartamento, :nombreEmpleado, :apellido1, :apellido2, :numCedula, :telefono, :fechaNacimiento, :salarioPorHora, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion, :activo)";

                OracleParameter[] parametros = new OracleParameter[14];// Parametros

                parametros[0] = new OracleParameter();// Parametro que va a la base de datos a agregar el id Empleado
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idEmpleado";
                parametros[0].Value = pEmpleado.IdEmpleado;

                parametros[1] = new OracleParameter();// Parametro que va a la base de datos a agregar el id Departamento
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":idDepartamento";
                parametros[1].Value = pEmpleado.IdDepartamento;

                parametros[2] = new OracleParameter();// Parametro que va a la base de datos a agregar el Nombre del Empleado
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":nombreEmpleado";
                parametros[2].Value = pEmpleado.NombreEmpleado;

                parametros[3] = new OracleParameter();// Parametro que va a la base de datos a agregar el Apellido1
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":apellido1";
                parametros[3].Value = pEmpleado.Apellido1;

                parametros[4] = new OracleParameter();// Parametro que va a la base de datos a agregar el Apellido2
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":apellido2";
                parametros[4].Value = pEmpleado.Apellido2;

                parametros[5] = new OracleParameter();// Parametro que va a la base de datos a agregar el Numero de Cedula
                parametros[5].OracleType = OracleType.Number;
                parametros[5].ParameterName = ":numCedula";
                parametros[5].Value = pEmpleado.NumCedula;

                parametros[6] = new OracleParameter();// Parametro que va a la base de datos a agregar el Telefono 
                parametros[6].OracleType = OracleType.Number;
                parametros[6].ParameterName = ":telefono";
                parametros[6].Value = pEmpleado.ModificadoPor;

                parametros[7] = new OracleParameter();// Parametro que va a la base de datos a agregar la Fecha de Nacimiento 
                parametros[7].OracleType = OracleType.VarChar;
                parametros[7].ParameterName = ":fechaNacimiento";
                parametros[7].Value = pEmpleado.FechaNacimiento;

                parametros[8] = new OracleParameter();// Parametro que va a la base de datos a agregar el Salario Por Hora  
                parametros[8].OracleType = OracleType.Number;
                parametros[8].ParameterName = ":salarioPorHora";
                parametros[8].Value = pEmpleado.SalarioPorHora;

                parametros[9] = new OracleParameter();// Parametro que va a la base de datos a agregar Creado Por 
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":creadoPor";
                parametros[9].Value = pEmpleado.CreadoPor;

                parametros[10] = new OracleParameter();// Parametro que va a la base de datos a agregar la FechaCreacion
                parametros[10].OracleType = OracleType.DateTime;
                parametros[10].ParameterName = ":fechaCreacion";
                parametros[10].Value = pEmpleado.FechaCreacion;

                parametros[11] = new OracleParameter();// Parametro que va a la base de datos a agregar Modificado Por 
                parametros[11].OracleType = OracleType.VarChar;
                parametros[11].ParameterName = ":modificadoPor";
                parametros[11].Value = pEmpleado.ModificadoPor;

                parametros[12] = new OracleParameter();// Parametro que va a la base de datos a agregar la FechaCreacion
                parametros[12].OracleType = OracleType.DateTime;
                parametros[12].ParameterName = ":fechaModificacion";
                parametros[12].Value = pEmpleado.FechaModificacion;

                parametros[13] = new OracleParameter();// Parametro que va a la base de datos a agregar el Activo
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
        /// Metodo que borra un empleado 
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
        /// Metodo que edita la línea que se encuentra seleccionada
        /// </summary>
        /// <param name="pEmpleadoOriginal"></param>
        /// <param name="pEmpleadoEditado"></param>

        public void editarEmpleado(EmpleadoL pEmpleadoOriginal, EmpleadoL pEmpleadoEditado)
        {
            try
            {
                string sql = "update Empleado " +
                             "set idEmpleado = :idEmpleado, :idDepartamento, :nombreEmpleado, :apellido1, :apellido2, :numCedula, :telefono, :fechaNacimiento, :salarioPorHora, :creadoPor, :fechaCreacion, :modificadoPor, :fechaModificacion, :activo" +
                             "where idEmpleado = :idEmpleadoOriginal";

                OracleParameter[] parametros = new OracleParameter[15];//Parametros

                parametros[0] = new OracleParameter();// Parametro que va a la base de datos a editar el id Empleado
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":idEmpleado";
                parametros[0].Value = pEmpleadoEditado.IdEmpleado;

                parametros[1] = new OracleParameter();// Parametro que va a la base de datos a editar el id Departamento
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":idDepartamento";
                parametros[1].Value = pEmpleadoEditado.IdDepartamento;

                parametros[2] = new OracleParameter();// Parametro que va a la base de datos a editar el Nombre del Empleado
                parametros[2].OracleType = OracleType.VarChar;
                parametros[2].ParameterName = ":nombreEmpleado";
                parametros[2].Value = pEmpleadoEditado.NombreEmpleado;

                parametros[3] = new OracleParameter();// Parametro que va a la base de datos a editar el Apellido1
                parametros[3].OracleType = OracleType.VarChar;
                parametros[3].ParameterName = ":apellido1";
                parametros[3].Value = pEmpleadoEditado.Apellido1;

                parametros[4] = new OracleParameter();// Parametro que va a la base de datos a editar el Apellido2
                parametros[4].OracleType = OracleType.VarChar;
                parametros[4].ParameterName = ":apellido2";
                parametros[4].Value = pEmpleadoEditado.Apellido2;

                parametros[5] = new OracleParameter();// Parametro que va a la base de datos a editar el Numero de Cedula
                parametros[5].OracleType = OracleType.Number;
                parametros[5].ParameterName = ":numCedula";
                parametros[5].Value = pEmpleadoEditado.NumCedula;

                parametros[6] = new OracleParameter();// Parametro que va a la base de datos a editar el Telefono 
                parametros[6].OracleType = OracleType.Number;
                parametros[6].ParameterName = ":telefono";
                parametros[6].Value = pEmpleadoEditado.ModificadoPor;

                parametros[7] = new OracleParameter();// Parametro que va a la base de datos a editar la Fecha de Nacimiento 
                parametros[7].OracleType = OracleType.DateTime;
                parametros[7].ParameterName = ":fechaNacimiento";
                parametros[7].Value = pEmpleadoEditado.FechaNacimiento;

                parametros[8] = new OracleParameter();// Parametro que va a la base de datos a editar el Salario Por Hora  
                parametros[8].OracleType = OracleType.Double;
                parametros[8].ParameterName = ":salarioPorHora";
                parametros[8].Value = pEmpleadoEditado.SalarioPorHora;

                parametros[9] = new OracleParameter();// Parametro que va a la base de datos a editar Creado Por 
                parametros[9].OracleType = OracleType.VarChar;
                parametros[9].ParameterName = ":creadoPor";
                parametros[9].Value = pEmpleadoEditado.CreadoPor;

                parametros[10] = new OracleParameter();// Parametro que va a la base de datos a editar la FechaCreacion
                parametros[10].OracleType = OracleType.DateTime;
                parametros[10].ParameterName = ":fechaCreacion";
                parametros[10].Value = pEmpleadoEditado.FechaCreacion;

                parametros[11] = new OracleParameter();// Parametro que va a la base de datos a editar Modificado Por 
                parametros[11].OracleType = OracleType.VarChar;
                parametros[11].ParameterName = ":modificadoPor";
                parametros[11].Value = pEmpleadoEditado.ModificadoPor;

                parametros[12] = new OracleParameter();// Parametro que va a la base de datos a editar la FechaCreacion
                parametros[12].OracleType = OracleType.DateTime;
                parametros[12].ParameterName = ":fechaModificacion";
                parametros[12].Value = pEmpleadoEditado.FechaModificacion;                             

                parametros[13] = new OracleParameter();// Parametro que va a la base de datos a editar el Activo
                parametros[13].OracleType = OracleType.VarChar;
                parametros[13].ParameterName = ":activo";
                parametros[13].Value = pEmpleadoEditado.Activo;

                parametros[14] = new OracleParameter();// Parametro que va a la base de datos a editar la linea editada por la original
                parametros[14].OracleType = OracleType.VarChar;
                parametros[14].ParameterName = ":idEmpleadoOriginal";
                parametros[14].Value = pEmpleadoOriginal.IdEmpleado;

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
    }
}
