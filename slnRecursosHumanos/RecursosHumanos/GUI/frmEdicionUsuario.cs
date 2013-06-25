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
        private Boolean aceptar;
        private UsuarioL oUsuarioL;

        
        public frmEdicionUsuario()
        {
            InitializeComponent();
            this.aceptar = false;

        }
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

           public UsuarioL OUsuarioL
           {
               get { return oUsuarioL; }
           }

           public Boolean Aceptar
           {
               get { return aceptar; }
           }
           private void btnCancelar_Click(object sender, EventArgs e)
           {
               this.Close();
           }
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
                                         DateTime.Now, Program.usuario, Program.usuario,
                                         activo);   
               this.aceptar = true;
               this.Close();
           }
     }
}
