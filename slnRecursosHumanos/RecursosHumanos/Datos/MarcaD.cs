using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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





    }
}
