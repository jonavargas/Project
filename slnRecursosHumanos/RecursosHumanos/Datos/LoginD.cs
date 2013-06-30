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
    public class LoginD
    {
        private AccesoDatosOracle cnx;
        private bool error = false;
        private string errorDescription = "";

        public LoginD(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
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

        public List<LoginL> validarLogin(LoginL pLogin)
        {
            List<LoginL> retorno = new List<LoginL>();
            try
            {
                OracleParameter[] parametros = new OracleParameter[2];

                parametros[0] = new OracleParameter();
                parametros[0].OracleType = OracleType.VarChar;
                parametros[0].ParameterName = ":login";
                parametros[0].Value = pLogin.Login;

                parametros[1] = new OracleParameter();
                parametros[1].OracleType = OracleType.VarChar;
                parametros[1].ParameterName = ":clave";
                parametros[1].Value = pLogin.Clave;

                DataSet datos = this.cnx.ejecutarConsultaSQL("select * from login where login = :login and clave = :clave", "login", parametros);
                if (this.cnx.IsError == false)
                {
                    foreach (DataRow fila in datos.Tables[0].Rows)
                    {
                        retorno.Add(
                                    new LoginL(fila["login"].ToString(),
                                               fila["descripcion"].ToString(),
                                               fila["clave"].ToString())
                                   );
                    }
                }
                else
                {
                    this.error = true;
                    this.errorDescription = "Error validando inicio de sesión: " +
                                            this.cnx.ErrorDescripcion;
                }
            }
            catch (Exception e)
            {
                this.error = true;
                this.errorDescription = "Error validando inicio de sesión: " + e.Message;
            }
            return retorno;
        }
    }
}
