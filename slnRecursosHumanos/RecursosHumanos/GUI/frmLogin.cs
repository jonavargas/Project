using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Datos;

namespace GUI
{
    public partial class frmLogin : Form
    {
        private bool aceptar;
        private LoginL oUsuario;
        
        private AccesoDatosOracle conexion;

        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }

        public LoginL OUsuario1
        {
            get { return oUsuario; }
            set { oUsuario = value; }
        }

        public frmLogin(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.aceptar = false;
            this.conexion = pConexion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((this.txtLogin.Text != "") && (this.txtClave.Text != ""))
            {
                LoginD oLoginD = new LoginD(this.conexion);
                List<LoginL> respuesta = oLoginD.validarLogin(new LoginL(this.txtLogin.Text, "", this.txtClave.Text));
                if (oLoginD.Error)
                {
                    MessageBox.Show("Error validando login:" + oLoginD.ErrorDescription);
                    return;
                }
                if (respuesta.Count > 0)
                {
                    this.aceptar = true;
                    this.OUsuario1 = new LoginL(this.txtLogin.Text, respuesta[0].Descripcion, this.txtClave.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Login o password inválidos");
                }
            }
            else
            {
                MessageBox.Show("Faltan datos requeridos");
            }
        }
    }
}
