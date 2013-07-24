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
        private UsuarioL oLogin;
        
        private AccesoDatosOracle conexion;

        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }

        public UsuarioL OLogin
        {
            get { return oLogin; }
            set { oLogin = value; }
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
                if ((this.txtLogin.Text.Equals("proyecto")) && (txtClave.Text.Equals("oracle")))
                {
                    UsuarioD oUsuarioD = new UsuarioD(this.conexion);
                    List<UsuarioL> respuesta = oUsuarioD.usuarioAdministrador(new UsuarioL(this.txtLogin.Text, "Administrador", this.txtClave.Text));
                    if (oUsuarioD.Error)
                    {
                        this.txtLogin.Text = "";
                        this.txtClave.Text = "";
                        MessageBox.Show("Error validando login:" + oUsuarioD.ErrorDescription);
                        return;
                    }
                    if (respuesta.Count > 0)
                    {
                        this.aceptar = true;
                        this.OLogin = new UsuarioL(this.txtLogin.Text, respuesta[0].TipoUsuario, this.txtClave.Text);
                        this.Close();
                    }
                    else
                    {
                        this.txtLogin.Text = "";
                        this.txtClave.Text = "";
                        MessageBox.Show("Login o password inválidos");
                    }
                }
                else
                {
                    UsuarioD oUsuarioD = new UsuarioD(this.conexion);
                    List<UsuarioL> respuesta = oUsuarioD.validarLogin(new UsuarioL(this.txtLogin.Text, "", this.txtClave.Text));
                    if (oUsuarioD.Error)
                    {
                        this.txtLogin.Text = "";
                        this.txtClave.Text = "";
                        MessageBox.Show("Error validando login:" + oUsuarioD.ErrorDescription);
                        return;
                    }
                    if (respuesta.Count > 0)
                    {
                        this.aceptar = true;
                        this.OLogin = new UsuarioL(this.txtLogin.Text, respuesta[0].TipoUsuario, this.txtClave.Text);
                        this.Close();
                    }
                    else
                    {
                        this.txtLogin.Text = "";
                        this.txtClave.Text = "";
                        MessageBox.Show("Login o password inválidos");
                    }
                }
            }
            else
            {
                this.txtLogin.Text = "";
                this.txtClave.Text = "";
                MessageBox.Show("Faltan datos requeridos");
            }
        }
    }
}
