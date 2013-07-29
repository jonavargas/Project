using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OracleClient;
using Logica;
using GUI;


namespace Datos
{
    public class FechasDoblesD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public FechasDoblesD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }

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
