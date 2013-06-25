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
        private Boolean aceptar;
        private DeduccionesL oDeduccionesL;
        public frmEdicionDeducciones()
        {
            InitializeComponent();
            this.aceptar = false;
        }
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
         public DeduccionesL ODeduccionesL
         {
             get { return oDeduccionesL; }
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
             
             if ((this.txtIdDeducciones.Text == "") ||
                (this.txtPorcentaje.Text == "") || (this.txtDescripcion.Text == ""))
             {
                 MessageBox.Show("Faltan datos requeridos");
                 return;
             }
             this.oDeduccionesL = new DeduccionesL(this.txtIdDeducciones.Text,
                                      double.Parse(this.txtPorcentaje.Text), this.txtDescripcion.Text, DateTime.Now, DateTime.Now, Program.usuario, Program.usuario,
                                      activo);
             this.aceptar = true;
             this.Close();
         }

    }
}
