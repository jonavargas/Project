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

namespace GUI
{
    public partial class frmEdicionUsuario : Form
    {
        /// <summary>
        /// Atributos de la clase Usuario el cual verifica el botón aceptar y un objeto tipo usuario en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private UsuarioL oUsuarioL;

        /// <summary>
        /// Método constructor sin parametros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>
        public frmEdicionUsuario()
        {
            InitializeComponent();
            this.aceptar = false;
        }
        /// <summary>
        /// Método constructor el cual recibe por parámetro un usuario el cual inicializa los atributos existentes
        /// </summary>
        /// <param name="pUsuarioL"></param>
        public frmEdicionUsuario(UsuarioL pUsuarioL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtidUsuario.Text = Convert.ToString(pUsuarioL.IdUsuario);
            this.txtpassword.Text = pUsuarioL.Password;
            this.txtfecha_de_Modificacion.Text = string.Format("{0:d}", pUsuarioL.FechaModificacion);
            this.txtFechaCreacion.Text = string.Format("{0:d}", pUsuarioL.FechaCreacion);
            this.txtcreadoPor.Text = pUsuarioL.CreadoPor;
            this.txtModificadoPor.Text = pUsuarioL.ModificadoPor;
            this.oUsuarioL = pUsuarioL;

        }
        /// <summary>
        /// Properties de la Clase usuario,el cual permite consultar los valores de los atributos
        /// </summary>

        public UsuarioL OUsuarioL
         {
             get { return oUsuarioL; }
         }

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

             string tUsuario = "";
             bool estado = false;

             try
             {
                 if (this.cmbTipoUsuario.SelectedItem.Equals("Supervisor"))
                 {
                     tUsuario = "Supervisor";
                     estado = true;
                 }
                 else if (this.cmbTipoUsuario.SelectedItem.Equals("Regular"))
                 {
                     tUsuario = "Regular";
                     estado = true;
                 }

                 if ((this.txtidUsuario.Text == "") || (estado == false) ||
                     (this.txtpassword.Text == ""))
                 {
                     MessageBox.Show("Faltan datos requeridos!!!");
                     return;
                 }
             }
             catch (Exception E)
             {

                    MessageBox.Show("Faltan datos requeridos!!!");
                    return;
             }

             this.oUsuarioL = new UsuarioL(this.txtidUsuario.Text,
                                         Convert.ToString(this.cmbTipoUsuario.SelectedItem), this.txtpassword.Text, DateTime.Now,
                                         DateTime.Now, Program.oUsuarioLogueado.IdUsuario, Program.oUsuarioLogueado.IdUsuario,
                                         activo);   
             this.aceptar = true;
             this.Close();
           }
     }
}
