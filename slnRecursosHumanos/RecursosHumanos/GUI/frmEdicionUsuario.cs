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
    public partial class frmEdicionUsuario : Form
    {
        /// <summary>
        /// Atributos de la clase Usuario el cual verifica el botón aceptar y un objeto tipo usuario en la parte lógica
        /// </summary>
        private Boolean aceptar;
        List<UsuarioL> oUsuarioL;
        AccesoDatosOracle conexion;
        private UsuarioL oUsuarioLNuevo;
        private bool edicion = false;

        /// <summary>
        /// Métodos Gets y Sets
        /// </summary>
        public UsuarioL OUsuarioLNuevo
        {
            get { return oUsuarioLNuevo; }
            set { oUsuarioLNuevo = value; }
        }

        public List<UsuarioL> OUsuarioL1
        {
            get { return oUsuarioL; }
            set { oUsuarioL = value; }
        }

        /// <summary>
        /// Método constructor sin parametros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>
        public frmEdicionUsuario(UsuarioL pUsuarioL, List<UsuarioL> pUsuarioConectado, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.conexion = pConexion;
            this.txtidUsuario.Text = pUsuarioL.IdUsuario;
            this.txtpassword.Text = pUsuarioL.Password;
            this.chkActivo.Text = pUsuarioL.Activo;
            this.cmbTipoUsuario.Text = pUsuarioL.TipoUsuario;
            this.aceptar = false;
            this.oUsuarioL = pUsuarioConectado;
            this.txtidUsuario.Enabled = false;
            this.edicion = true;
        }
        /// <summary>
        /// Método constructor el cual recibe por parámetro un usuario el cual inicializa los atributos existentes
        /// </summary>
        /// <param name="pUsuarioL"></param>
        public frmEdicionUsuario(List<UsuarioL> pUsuarioL, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.conexion = pConexion;
            this.aceptar = false;            
            this.OUsuarioL1 = pUsuarioL;


        }
        /// <summary>
        /// Properties de la Clase usuario,el cual permite consultar los valores de los atributos
        /// </summary>

        public Boolean Aceptar
        {
            get { return aceptar; }
        }
        /// <summary>
        /// Evento del botón Cancelar el cual cierra la ventada si dan click en el
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Método del botón aceptar,el cual verifica si el usuario preciono el botón aceptar o no,si lo hizo procede a revisar si no dejo
        /// algún espacio en blanco sino lo hizo creado un usuario con los datos suministrados
        /// </summary>
        /// <param name="sender"></param>

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            String activo = "No";

            if (this.chkActivo.Checked)
            {
                activo = "Sí";
            }
            try
            {
                if (edicion == false)
                {

                    if ((this.txtidUsuario.Text == "") ||
                       (this.txtpassword.Text == "")||(this.cmbTipoUsuario.SelectedItem==""))
                    {
                        MessageBox.Show("Faltan datos requeridos!!!");
                        return;
                    }
                    else
                    {
                        UsuarioD oUsuarioD = new UsuarioD(this.conexion);
                        List<UsuarioL> listaUsuario = oUsuarioD.obtenerUsuarioID(this.txtidUsuario.Text);
                        if (listaUsuario.Count != 0)
                        {
                            MessageBox.Show("Error Usuario ya existe por favor ingrese otro nombre!!!");
                            return;
                        }
                        else
                        {
                            this.OUsuarioLNuevo = new UsuarioL(this.txtidUsuario.Text,
                                                   Convert.ToString(this.cmbTipoUsuario.SelectedValue), this.txtpassword.Text, DateTime.Now,
                                                   DateTime.Now, OUsuarioL1[0].IdUsuario, OUsuarioL1[0].IdUsuario,
                                                   activo);
                        }

                    }

                }
                else
                {

                    if (this.chkActivo.Checked)
                    {
                        activo = "Sí";
                    }
                    txtidUsuario.ReadOnly = false;

                    this.OUsuarioLNuevo = new UsuarioL(this.txtidUsuario.Text,
                                                   Convert.ToString(this.cmbTipoUsuario.SelectedItem), this.txtpassword.Text, DateTime.Now,
                                                   DateTime.Now, OUsuarioL1[0].IdUsuario, OUsuarioL1[0].IdUsuario,
                                                   activo);

                }
            }
            catch (Exception) {

                MessageBox.Show("Error agreagando Usuario");
            
            }
           this.aceptar = true;
                    this.Close();

            }
        }
    }
  
           
