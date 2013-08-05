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
        private AccesoDatosOracle conexion;
        string idUsuario;
        private bool error = false;
        string tipoUsuario;
        public List<UsuarioL> oUsuarioL;

        

        public string TipoUsuario
        {
            get { return tipoUsuario; }
            set { tipoUsuario = value; }
        }

        public bool Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public List<UsuarioL> OUsuarioL
        {
            get { return oUsuarioL; }
            set { oUsuarioL = value; }
        }

        

        public frmLogin(AccesoDatosOracle pConexion)
        {
            InitializeComponent();            
            this.conexion = pConexion;
            this.txtLogin.Text = "Bryan";
            this.txtClave.Text = "oracle";
            this.aceptar = false;
            string nombreUsuario = this.txtLogin.Text;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            //si se oprime la tecla esc el form termina la aplicacion y la cierra
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            //si se oprime la tecla enter el programa hace la funcion que le corresponde al boton aceptar
            if (e.KeyCode == Keys.Enter)
            {
                this.btnAceptar_Click(sender, e);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {

                if ((this.txtLogin.Text != "") && (this.txtClave.Text != ""))
                {


                    UsuarioD oUsuarioD = new UsuarioD(this.conexion);
                    this.idUsuario = txtLogin.Text;
                    oUsuarioL = new List<UsuarioL>(oUsuarioD.obtenerUsuarioID(this.idUsuario));
                    this.error = oUsuarioD.Error;
                    if ((this.error == false) || (oUsuarioL.Count > 0))
                    {

                        UsuarioL datosObtenidos = new UsuarioL(
                                                                oUsuarioL[0].IdUsuario.ToString(),
                                                                oUsuarioL[0].TipoUsuario.ToString(),
                                                                oUsuarioL[0].Password.ToString(),
                                                                Convert.ToDateTime(oUsuarioL[0].FechaModificacion),
                                                                Convert.ToDateTime(oUsuarioL[0].FechaCreacion),
                                                                oUsuarioL[0].CreadoPor.ToString(),
                                                                oUsuarioL[0].ModificadoPor.ToString(),
                                                                oUsuarioL[0].Activo.ToString()

                                                              );

                        if ((datosObtenidos.IdUsuario.ToString() == txtLogin.Text) && (datosObtenidos.Password.ToString() == txtClave.Text))
                        {

                            this.tipoUsuario = datosObtenidos.TipoUsuario.ToString();
                            this.aceptar = true;
                            this.Close();


                        }
                        else
                        {

                            MessageBox.Show("El Logging ó Password ingresados son incorrectos verifique que haya ingresado los datos correctos");
                            return;

                        }



                    }
                    else
                    {

                        MessageBox.Show("El Logging ó Password ingresados son incorrectos verifique que haya ingresado los datos correctos");
                        return;

                    }

                }
                else
                {
                    this.txtLogin.Text = "";
                    this.txtClave.Text = "";
                    MessageBox.Show("Faltan datos requeridos");
                }
            }
            catch(Exception) 
            {
                this.txtLogin.Text = "";
                this.txtClave.Text = "";
                MessageBox.Show("El Logging ó Password ingresados son incorrectos verifique que haya ingresado los datos correctos");
                return;

            
            }
        }
    }
}
