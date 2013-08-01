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
    public partial class frmEdicionCatalogoFechas : Form
    {
        /// <summary>
        /// Atributos de la clase Catalogo fechas  el cual verifica el botón aceptar y un objeto tipo Empleado en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private CatalogoFechasL oCatalogoFechasL;

        /// <summary>
        /// Método constructor sin parametros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>
        
        public frmEdicionCatalogoFechas()
        {
            InitializeComponent();
            this.aceptar = false;
            this.cmbDia.Enabled = false;
        }
        /// <summary>
        /// Método constructor el cual recibe por parámetro un catalogo fechas el cual inicializa los atributos existentes
        /// </summary>
        /// <param name="pCatalogoFechasL"></param>
        public frmEdicionCatalogoFechas(CatalogoFechasL pCatalogoFechasL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtCatalogoFechas.Text = Convert.ToString(pCatalogoFechasL.IdCatalogoFechas);
            this.txtDescripcion.Text = pCatalogoFechasL.Descripcion;
            this.txtFechaModificacion.Text = string.Format("{0:d}", pCatalogoFechasL.FechaModificacion);
            this.txtFechaCreacion.Text = string.Format("{0:d}", pCatalogoFechasL.FechaCreacion);
            this.txtCreadopor.Text = pCatalogoFechasL.CreadoPor;
            this.txtModificadopor.Text = pCatalogoFechasL.ModificadoPor;
            this.txtActivo.Text = pCatalogoFechasL.Activo;
            this.oCatalogoFechasL = pCatalogoFechasL;
            this.cmbDia.SelectedValue = pCatalogoFechasL.Dia;
            this.cmbMes.SelectedValue = pCatalogoFechasL.Mes; 
           
        }
        /// <summary>
        /// Properties de la Clase Catalogo fechas,el cual permite consultar los valores de los atributos
        /// </summary>
        public CatalogoFechasL OCatalogoFechasL
        {
            get { return oCatalogoFechasL; }
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
        /// Método del botón aceptar,el cual verifica si el usuario preciono el botón aceptar o no,si lo hizo procede a revizar si no dejo
        /// algún espacio en blanco sino lo hizo creando un nuevo catalogo fechas con los datos suministrados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

         private void btnAceptar_Click(object sender, EventArgs e)
         {
             bool estadoFecha = false;
             String activo = "No";

             if (this.chkActivo.Checked)
             {
                 activo = "Sí";
             }

             try
             {
                 if (!this.cmbMes.SelectedItem.Equals("") && (!this.cmbDia.SelectedItem.Equals("")))
                 {
                     estadoFecha = true;
                 }
                 else
                 {
                     estadoFecha = true;
                 }

                 if ((this.txtCatalogoFechas.Text == "") || (estadoFecha == false) ||
                       (this.txtDescripcion.Text == ""))
                 {
                     MessageBox.Show("Faltan datos requeridos!!!");
                     return;
                 }
               }
               catch(Exception E) 
               {
                   MessageBox.Show("Faltan datos requeridos!!!");
                   return;
               }

               this.oCatalogoFechasL = new CatalogoFechasL(this.txtCatalogoFechas.Text,
                                        int.Parse(this.cmbDia.SelectedItem.ToString()), this.cmbMes.SelectedItem.ToString(), this.txtDescripcion.Text, DateTime.Now,
                                         DateTime.Now, Program.oUsuarioLogueado.IdUsuario, Program.oUsuarioLogueado.IdUsuario, activo);
               this.aceptar = true;
               this.Close();
           }
        /// <summary>
        /// Metodo que realiza el cambio de dias dependiendo del mes que seleccionara el usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

         private void cmbMes_SelectedIndexChanged_1(object sender, EventArgs e)
         {
             this.cmbDia.Enabled = true;
             this.lblAviso.Visible = false;
             switch (this.cmbMes.SelectedIndex)
             {

                 case 0:
                 case 2:
                 case 4:
                 case 6:
                 case 7:
                 case 9:
                 case 11:
                     cmbDia.Items.Clear();
                     for (int cont = 1; cont < 32; cont++)
                     {
                         cmbDia.Items.Add(cont);
                     }
                     break;
                 case 3:
                 case 5:
                 case 8:
                 case 10:
                     cmbDia.Items.Clear();
                     for (int cont = 1; cont < 31; cont++)
                     {
                         cmbDia.Items.Add(cont);
                     }
                     break;
                 case 1:
                     cmbDia.Items.Clear();
                     for (int cont = 1; cont < 29; cont++)
                     {
                         cmbDia.Items.Add(cont);
                     }
                     break;
             }
         }
    }
}
