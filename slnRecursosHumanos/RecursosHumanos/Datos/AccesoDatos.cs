using System;
using System.Collections.Generic;
using System.Text;
using System.Data; // manejo de datos
using System.Xml;

namespace Datos
{
    public abstract class AccesoDatos
    {
        public AccesoDatos() { }
        // destructor
        ~AccesoDatos()
        {
        }

        // Indica el estado de la persistencia
        public abstract Boolean estado();

        //Metodos que regulan la conexion a la base de datos
        public abstract void conectar();
        public abstract void desconectar();

        // Método para manipular Select
        public abstract DataSet ejecutarConsultaSQL(String pSql, String pnTabla, Object[] myParamArray);
        public abstract DataSet ejecutarConsultaSQL(String pSql, String pnTabla);
        public abstract DataSet ejecutarConsultaSQL(String pSql);
        public abstract string ejecutarSQLReturning(string pSql, Object[] myParamArray, string retparameter);
        //
        // Método para manipular Insert, Update, Delete
        public abstract void ejecutarSQL(String pSql);

        // Método para manipular Insert, Update, Delete con identidad
        public abstract void ejecutarSQL(String pSql, Object[] myParamArray, ref string pNumero);

        //Método para manipular Insert, Update pero con parametros
        public abstract void ejecutarSQL(string sql, Object[] myParamArray);

        /// <summary>
        /// obtiene el siguiente valor para el sequence especificado
        /// </summary>
        /// <param name="pNombre">código del sequence</param>
        public abstract int NextValSequence(string pNombre);

        //Metodos de transaccion
        public abstract void iniciarTransaccion();
        //
        public abstract void commitTransaccion();
        //
        public abstract void rollbackTransaccion();

        //Metodo generales
        public abstract DateTime ObtieneFecha();
        // Metodos de Set & Get
        public abstract Boolean IsError
        {
            set;
            get;
        }
        //
        public abstract String ErrorDescripcion
        {
            set;
            get;
        }
        //
        public abstract string Schema
        {
            get;
        }
        //
        public abstract string TipoConexion
        {
            get;
        }
        //
        public abstract string Usuario
        {
            get;
        }
        public abstract string Puerto
        {
            get;
        }
        //
        public abstract string Contrasena
        {
            get;
        }
        //
        public abstract string DB
        {
            get;
        }
        //
        public abstract string Servidor
        {
            get;
        }

        //Elimina el estado de error de la clase.
        public abstract void limpiarEstado();
    }//Fin de la clase
}//Fin del namespace

