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
    public partial class frmEdicionDeducciones : Form
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        private Boolean aceptar;
        private DeduccionesL oDeduccionesL;

        /// <summary>
        /// Metodo Costructor sin parametros
        /// </summary>
        public frmEdicionDeducciones()
        {
            InitializeComponent();
            this.aceptar = false;
        }
        /// <summary>
        /// Metodo constructor con parametros
        /// </summary>
        /// <param name="pDeduccionesL"></param>
         public frmEdicionDeducciones(DeduccionesL pDeduccionesL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtIdDeducciones.Text = Convert.ToString( pDeduccionesL.IdDeducciones);
            this.txtPorcentaje.Text = Convert.ToString(pDeduccionesL.Porcentaje);            
            this.txtDescripcion.Text = pDeduccionesL.Descripcion;
            this.txtFecha_Modificacion.Text = string.Format("{0:d}", pDeduccionesL.FechaModificacion);
            this.txtFecha_Creacion.Text = string.Format("{0:d}", pDeduccionesL.FechaCreacion);
            this.txtCreado_por.Text = pDeduccionesL.CreadoPor;
            this.txtModificado_por.Text = pDeduccionesL.ModificadoPor;
            this.oDeduccionesL = pDeduccionesL;
        }
        /// <summary>
        /// Propiedades de los atributos
        /// </summary>
         public DeduccionesL ODeduccionesL
         {
             get { return oDeduccionesL; }
         }

         public Boolean Aceptar
         {
             get { return aceptar; }
         }
        /// <summary>
        /// Metodo el botón cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void btnCancelar_Click(object sender, EventArgs e)
         {
             this.Close();
         }
        /// <summary>
        /// Metodo del botón Aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void btnAceptar_Click(object sender, EventArgs e)
         {

             String activo = "No";

             if (this.chkActivo.Checked)
             {
                 activo = "Sí";
             }
             
             if ((this.txtIdDeducciones.Text == "") ||
                (this.txtPorcentaje.Text == "") || (this.txtDescripcion.Text == ""))
             {
                 MessageBox.Show("Faltan datos requeridos");
                 return;
             }
             this.oDeduccionesL = new DeduccionesL(this.txtIdDeducciones.Text,
                                      double.Parse(this.txtPorcentaje.Text), this.txtDescripcion.Text, DateTime.Now, DateTime.Now, Program.oUsuarioLogueado.IdUsuario, Program.oUsuarioLogueado.IdUsuario,
                                      activo);
             this.aceptar = true;
             this.Close();
         }

         private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')              
             {

                 MessageBox.Show("Solo se permiten números!!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                 e.Handled = true;
                 return;                          
             }
                     
        }

    }
}
