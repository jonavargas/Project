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
      // *****************************************************************************************************************************************************************
        public List<MarcaL> obtenerMarcas()
        {
            List<MarcaL> retorno = new List<MarcaL>();
            try
            {
                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from Marca");
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new MarcaL(fila["idMarca"].ToString(),
                                                     fila["idEmpleado"].ToString(),
                                                     fila["estadoMarca"].ToString(),
                                                     DateTime.Parse(fila["fechaMarca"].ToString()),
                                                     fila["tipoMarca"].ToString(),
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
                    this.errorDescription = "Error obteniendo Marca: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error obteniendo Marca: " + e.Message;
            }
            return retorno;
        }

    }
}
