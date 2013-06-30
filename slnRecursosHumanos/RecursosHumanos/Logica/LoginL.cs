using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class LoginL
    {
        private string login;
        private string descripcion;
        private string clave;

        public string Login
        {
            get { return login; }
            set { login = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string Clave
        {
            get { return clave; }
            set { clave = value; }
        }

        public LoginL(string pLogin, string pDescripcion, string pClave)
        {
            this.login = pLogin;
            this.descripcion = pDescripcion;
            this.clave = pClave;
        }

        public override string ToString()
        {
            return "Login: " + this.login + ", Descripcion: " + this.descripcion;
        }
    }
}
