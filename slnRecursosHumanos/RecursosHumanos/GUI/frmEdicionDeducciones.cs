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
        /// Atributos de la clase Deducciones  el cual verifica el botón aceptar y un objeto tipo deducción en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private DeduccionesL oDeduccionesL;

        /// <summary>
        ///  Método constructor sin parametros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false 
        /// </summary>
        public frmEdicionDeducciones()
        {
            InitializeComponent();
            this.aceptar = false;
        }
        /// <summary>
        /// Método constructor el cual recibe por parámetro una Dedección el cual inicializa los atributos existentes
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
         /// Propiedades de los atributos Deducciones,el cual permite consultar los valores de los atributos
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
         /// Evento del botón Cancelar el cual cierra la ventada si dan click en el
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
         private void btnCancelar_Click(object sender, EventArgs e)
         {
             this.Close();
         }
        /// <summary>
         ///  Método del botón aceptar,el cual verifica si el usuario preciono el botón aceptar o no,si lo hizo procede a revisar si no dejo
         /// algún espacio en blanco sino lo hizo creando una deducción con los datos suministrados
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
