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
    public partial class frmEdicionDeducciones : Form
    {
        /// <summary>
        /// Atributos de la clase Deducciones  el cual verifica el botón aceptar y un objeto tipo deducción en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private DeduccionesL oDeduccionesL;
        List<UsuarioL> oUsuarioL;
        AccesoDatosOracle conexion;        
        private bool edicion = false;
        private double monto;

        public List<UsuarioL> OUsuarioL1
        {
            get { return oUsuarioL; }
            set { oUsuarioL = value; }
        }

        /// <summary>
        ///  Método constructor sin parametros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false 
        /// </summary>
        public frmEdicionDeducciones(List<UsuarioL> pOUsuarioL, AccesoDatosOracle pCnx)
        {
            InitializeComponent();
            this.conexion = pCnx;
            this.oUsuarioL = pOUsuarioL;            
            this.aceptar = false;
        }
        /// <summary>
        /// Método constructor el cual recibe por parámetro una Dedección el cual inicializa los atributos existentes
        /// </summary>
        /// <param name="pDeduccionesL"></param>
        public frmEdicionDeducciones(DeduccionesL pDeduccionesLEdicion, List<UsuarioL> pOUsuarioLConectado, AccesoDatosOracle pCnx)
        {
            InitializeComponent();
            this.conexion = pCnx;
            this.txtIdDeducciones.Text = pDeduccionesLEdicion.IdDeducciones;          
            this.txtDescripcion.Text = pDeduccionesLEdicion.Descripcion;
            this.txtPorcentaje.Value = decimal.Parse(pDeduccionesLEdicion.Porcentaje.ToString());
            this.oUsuarioL = pOUsuarioLConectado;
            chkActivo.Checked = true;
            this.edicion = true;
            this.aceptar = false;
         
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
             else {

                 try
                 {
                     //se verifica que lo que se alla puesto en este campo sea un valor númerico
                     this.monto = double.Parse(this.txtPorcentaje.Value.ToString());
                 }
                 catch
                 {
                     MessageBox.Show("El porcentaje es incorrecto");
                     this.txtPorcentaje.Text = "";
                     //se queda el scrol en el txt para modificar el dato mal ingresado
                     this.txtPorcentaje.Focus();
                     return;
                 }
                 DeduccionesD oDeduccionesD = new DeduccionesD(this.conexion);
                 List<DeduccionesL> listaDeducciones = oDeduccionesD.obtenerDeduccionId(this.txtIdDeducciones.Text);
                 if (this.edicion == false)
                 {

                     if (listaDeducciones.Count > 0)
                     {
                         MessageBox.Show("El código de deducción ya existe");
                         this.txtIdDeducciones.Text = "";
                         this.txtIdDeducciones.Focus();
                         return;
                     }
                     else
                     {

                         this.oDeduccionesL = new DeduccionesL(this.txtIdDeducciones.Text,
                                          double.Parse(this.txtPorcentaje.Text), this.txtDescripcion.Text, DateTime.Now, DateTime.Now, oUsuarioL[0].IdUsuario, oUsuarioL[0].IdUsuario,
                                          activo);

                     }

                 }
                 else {

                     txtIdDeducciones.ReadOnly = false;
                     this.oDeduccionesL = new DeduccionesL(this.txtIdDeducciones.Text,
                                          double.Parse(this.txtPorcentaje.Text), this.txtDescripcion.Text, DateTime.Now, DateTime.Now, oUsuarioL[0].IdUsuario, oUsuarioL[0].IdUsuario,
                                          activo);
                 
                 }
             }

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
