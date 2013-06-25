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


    }
}
