using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; // manejo de datos
using System.Data.OleDb;
using System.Xml;
using System.Data.OracleClient;

namespace Datos
{
    public class AccesoDatosOracle : AccesoDatos
    {
        private Boolean isError = false;        //Una bandera, para determinar si existe o no algun error
        private String errorDescripcion;        //Almacena la descripcion del error        
        private string usuario;
        private string contrasena;
        private string bd;
        private string servidor;
        public OracleConnection conexion;       //Objeto de tipo conexion, para establecer comunicacion con la BD
        private OracleTransaction transaccion;  //Objeto de tipo transaccion de base de datos, para iniciar, procesar y cerrar transacciones
        private bool hayTransaccion;            //Bandera que determina si hay una transaccion activa
        private string schema;                  //Almacena el esquema con el cual se trabaja en la base de datos, para devolverlo mediante un metodo get
        string tipoconexion = "1";

        static int instancias = 0;              //Contador de cuanta veces se ha instanciado la clase, para evitar que se instancie mas de una vez
        // Constructor
        public AccesoDatosOracle(string ConnectionString)
        {
            limpiarEstado();

            conexion = new OracleConnection(ConnectionString);
            instancias += 1;

            // no puede haber + de una instancia de la clase
            if (instancias > 1)
                return;

            try
            {
                conexion.Open();
            }
            catch (OracleException error)
            {
                instancias = 0;
                ProcesarExcepcion(error);
            }

        }
        // Indica el estado de la persistencia
        public override Boolean estado()
        {
            limpiarEstado();

            String mensaje = "";

            // estado dela conexión
            switch (conexion.State)
            {
                case System.Data.ConnectionState.Broken:
                    mensaje = "NCQ-0010|| ||La conexión con la base de datos fue interrumpida.";
                    break;
                case System.Data.ConnectionState.Closed:
                    mensaje = "NCQ-0011|| ||La conexión con la base de datos fue cerrada o no pudo ser establecida.";
                    break;
                case System.Data.ConnectionState.Connecting:
                    mensaje = "NCQ-0012|| ||Conectandose.";
                    break;
                case System.Data.ConnectionState.Executing:
                    mensaje = "NCQ-0013|| ||Ejecutando.";
                    break;
                case System.Data.ConnectionState.Fetching:
                    mensaje = "NCQ-0014|| ||Extrayendo.";
                    break;
                case System.Data.ConnectionState.Open:
                    mensaje = "NCQ-0015|| ||Abierta.";
                    break;
            }

            // cargar la propiedad con el estado de la conexion
            ErrorDescripcion = mensaje;

            if ((conexion.State == ConnectionState.Open) ||
                  (conexion.State == ConnectionState.Executing) ||
                  (conexion.State == ConnectionState.Fetching))
                return true;
            else
                return false;
        }
        // destructor
        ~AccesoDatosOracle()
        {
        }
        //
        public override void conectar()
        {
            try
            {
                if (!(conexion.State == ConnectionState.Open))
                {
                    conexion.Open();
                    instancias = 1;
                }
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
            }
            catch
            {

            }
        }
        //
        public override void desconectar()
        {
            try
            {
                conexion.Close();
                instancias = 0;
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
            }
        }

        //Manipulacion de select
        public override DataSet ejecutarConsultaSQL(String pSql)
        {
            limpiarEstado();

            OracleDataAdapter oDataAdapter = new OracleDataAdapter(pSql, conexion);
            DataSet oDataSet = new DataSet();
            if (this.hayTransaccion) 
            {
                oDataAdapter.SelectCommand.Transaction = this.transaccion;
            }
            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet);
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);

            }

            return oDataSet;
        }
        //
        public override DataSet ejecutarConsultaSQL(String pSql, String pnTabla, Object[] myParamArray)
        {
            limpiarEstado();

            OracleCommand cmd = new OracleCommand(pSql, conexion);

            cmd.CommandType = CommandType.Text;

            for (int j = 0; j < myParamArray.Length; j++)
            {
                cmd.Parameters.Add(((OracleParameter)myParamArray[j]));
            }


            OracleDataAdapter oDataAdapter = new OracleDataAdapter(cmd);
            DataSet oDataSet = new DataSet();
            if (this.hayTransaccion)
            {
                oDataAdapter.SelectCommand.Transaction = this.transaccion;
            }
            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet, pnTabla);
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
            }

            return oDataSet;
        }
        //
        public override DataSet ejecutarConsultaSQL(String pSql, String pnTabla)
         {
            limpiarEstado();


            OracleDataAdapter oDataAdapter = new OracleDataAdapter(pSql, conexion);
            DataSet oDataSet = new DataSet();

            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet, pnTabla);
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
            }

            return oDataSet;
        }
        // Método para manipular Insert, Update, Delete
        public override void ejecutarSQL(String pSql)
        {
            limpiarEstado();

            // Definicion de Command
            OracleCommand cmd = null;

            try
            {
                cmd = new OracleCommand(pSql, conexion);

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                cmd.ExecuteNonQuery();
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
            }

        }
        // Método para manipular Insert, Update, Delete con identidad
        public override void ejecutarSQL(string pSql, Object[] myParamArray, ref string pNumero)
        {
            limpiarEstado();

            try
            {
                OracleCommand cmd = new OracleCommand(pSql, conexion);
                cmd.CommandType = CommandType.Text;
                for (int j = 0; j < myParamArray.Length; j++)
                {
                    cmd.Parameters.Add((OracleParameter)myParamArray[j]);
                }

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                pNumero = "";
                pNumero = cmd.ExecuteScalar().ToString();
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
            }
        }
        //Método para manipular Insert, Update pero con parametros
        public override void ejecutarSQL(string sql, Object[] myParamArray)
        {
            limpiarEstado();

            try
            {

                OracleCommand cmd = new OracleCommand(sql, conexion);
                cmd.CommandType = CommandType.Text;
                for (int j = 0; j < myParamArray.Length; j++)
                {
                    cmd.Parameters.Add((OracleParameter)myParamArray[j]);
                }

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                cmd.ExecuteNonQuery();
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
            }

        }

        /// <summary>
        /// obtiene el siguiente valor para el sequence especificado
        /// </summary>
        /// <param name="pNombre">código del sequence</param>
        public override int NextValSequence(string pNombre) 
        {
            int valor = 0;
            limpiarEstado();
            try
            {
                DataSet dsetDatos = new DataSet();
                dsetDatos = this.ejecutarConsultaSQL("select " + pNombre + ".NEXTVAL from dual ");
                valor = Convert.ToInt32(dsetDatos.Tables[0].Rows[0][0].ToString());
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
            }
            return valor;
        }

        //Metodos de transaccion
        public override void iniciarTransaccion()
        {
            if (this.hayTransaccion == false)
            {
                this.transaccion = this.conexion.BeginTransaction();
                this.hayTransaccion = true;
            }
        }
        //
        public override void commitTransaccion()
        {
            if (this.hayTransaccion)
            {
                this.transaccion.Commit();
                this.hayTransaccion = false;
            }
        }
        //
        public override void rollbackTransaccion()
        {
            if (this.hayTransaccion)
            {
                this.transaccion.Rollback();
                this.hayTransaccion = false;
            }
        }

        //
        //
        public override DateTime ObtieneFecha()
        {

            string sql = "select getdate()";

            DataSet dsetDatos = new DataSet();
            dsetDatos = ejecutarConsultaSQL(sql, "Fecha");

            return Convert.ToDateTime(dsetDatos.Tables[0].Rows[0][0].ToString());
        }
        //
        // Metodos de Set & Get

        public override string Usuario
        {
            get { return usuario; }
        }

        public override string Servidor
        {
            get { return servidor; }
        }

        public override string DB
        {
            get { return bd; }
        }

        public override string Contrasena
        {
            get { return contrasena; }
        }

        public override string Puerto
        {
            get { return ""; }
        }
        
        public override Boolean IsError
        {
            set { isError = value; }
            get { return isError; }
        }
        //
        public override String ErrorDescripcion
        {
            set { errorDescripcion = value; }
            get { return errorDescripcion; }
        }
        //
        public override string Schema
        {
            get { return this.schema; }
        }
        //
        public override string TipoConexion
        {
            get { return this.tipoconexion; }
        }

        //Elimina el estado de error de la clase.
        public override void limpiarEstado()
        {
            this.errorDescripcion = "";
            this.isError = false;
        }

        private void ProcesarExcepcion(OracleException pExcepcion)
        {
            IsError = true;
            ErrorDescripcion += " \n" + pExcepcion.Message + " \n";
            ErrorDescripcion += pExcepcion.ErrorCode + " \n";
            ErrorDescripcion += pExcepcion.StackTrace;
        }

        private void BuscarError(string pCodigo, ref string pDescripcion) 
        {
            StringBuilder sql = new StringBuilder();

            sql.AppendLine("select descripcion from " + this.schema + "errores_oracle ");
            sql.AppendLine("where codigo = '" + pCodigo + "'");
            DataSet dsetDatos = new DataSet();
            dsetDatos = this.ejecutarConsultaSQL2(sql.ToString());
            if (dsetDatos.Tables[0].Rows.Count == 0)
                return;
            pDescripcion = dsetDatos.Tables[0].Rows[0][0].ToString();
            //si no hay descripcion y ocurre hay que marcarlo
            if (pDescripcion != "")
                return;
            sql = new StringBuilder();
            sql.AppendLine("update " + this.schema + "errores_oracle set ");
            sql.AppendLine("ocurrio = 'S' where codigo = '" + pCodigo + "'");
            this.ejecutarSQL2(sql.ToString());
        }

        private DataSet ejecutarConsultaSQL2(String pSql)
        {
            OracleDataAdapter oDataAdapter = new OracleDataAdapter(pSql, conexion);
            DataSet oDataSet = new DataSet();
            if (this.hayTransaccion)
            {
                oDataAdapter.SelectCommand.Transaction = this.transaccion;
            }
            // capturar la excepción
            try
            {
                oDataAdapter.Fill(oDataSet);
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);

            }

            return oDataSet;
        }

        private void ejecutarSQL2(String pSql)
        {
            // Definicion de Command
            OracleCommand cmd = null;

            try
            {
                cmd = new OracleCommand(pSql, conexion);

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                cmd.ExecuteNonQuery();
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
            }

        }

        public override string ejecutarSQLReturning(string pSql, Object[] myParamArray, string retparameter)
        {
            limpiarEstado();

            try
            {
                OracleCommand cmd = new OracleCommand(pSql, conexion);
                cmd.CommandType = CommandType.Text;
                for (int j = 0; j < myParamArray.Length; j++)
                {
                    cmd.Parameters.Add((OracleParameter)myParamArray[j]);
                }

                if (this.hayTransaccion)
                {
                    cmd.Transaction = this.transaccion;
                }

                cmd.ExecuteNonQuery();
                return cmd.Parameters["" + retparameter].Value.ToString();
            }
            catch (OracleException error)
            {
                ProcesarExcepcion(error);
                return "";
            }
        }
    }//finaliza clase
}//finaliza namespace
