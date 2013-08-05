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
    public partial class frmEdicionCatalogoFechas : Form
    {
        /// <summary>
        /// Atributos de la clase Catalogo fechas  el cual verifica el botón aceptar y un objeto tipo Empleado en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private CatalogoFechasL oCatalogoFechasL;       
        private bool edicion = false;        
        AccesoDatosOracle conexion;
        List<UsuarioL> oUsuarioL;

        public CatalogoFechasL OCatalogoFechasL1
        {
            get { return oCatalogoFechasL; }
            set { oCatalogoFechasL = value; }
        }


        public bool Edicion
        {
            get { return edicion; }
            set { edicion = value; }
        }

        public List<UsuarioL> OUsuarioL
        {
            get { return oUsuarioL; }
            set { oUsuarioL = value; }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }

        /// <summary>
        /// Método constructor sin parametros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>

        public frmEdicionCatalogoFechas(List<UsuarioL> pOUsuarioL, AccesoDatosOracle pCnx)
        {
            InitializeComponent();
            this.conexion = pCnx;
            this.oUsuarioL = pOUsuarioL;
            this.aceptar = false;
            this.cmbDia.Enabled = false;
            chkActivo.Checked = true;
        }
        /// <summary>
        /// Método constructor el cual recibe por parámetro un catalogo fechas el cual inicializa los atributos existentes
        /// </summary>
        /// <param name="pCatalogoFechasL"></param>
        public frmEdicionCatalogoFechas(CatalogoFechasL pCatalogoFechasL, List<UsuarioL> pOUsuarioLConectado, AccesoDatosOracle pCnx)
        {
            InitializeComponent();
            this.conexion = pCnx;
            this.aceptar = false;
            this.txtCatalogoFechas.Enabled = false;
            this.txtDescripcion.Text = pCatalogoFechasL.Descripcion;
            this.txtCatalogoFechas.Text = pCatalogoFechasL.IdCatalogoFechas;
            this.cmbDia.Text = pCatalogoFechasL.Dia.ToString();
            this.cmbMes.Text = pCatalogoFechasL.Mes.ToString();
            this.OUsuarioL = pOUsuarioLConectado;            
            this.oCatalogoFechasL = pCatalogoFechasL;
            chkActivo.Checked = true;
            this.edicion = true;
             
           
        }
        /// <summary>
        /// Properties de la Clase Catalogo fechas,el cual permite consultar los valores de los atributos
        /// </summary>
        public CatalogoFechasL OCatalogoFechasL
        {
            get { return oCatalogoFechasL; }
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
             
             String activo = "No";

             if (this.chkActivo.Checked)
             {
                 activo = "Sí";
             }
             try
             {
                 if ((this.txtCatalogoFechas.Text != "") && (this.txtDescripcion.Text != "") && (this.cmbDia.SelectedItem != null) && (this.cmbMes.SelectedItem != null))
                 {
                     if (this.Edicion == false)
                     {
                         this.oCatalogoFechasL = new CatalogoFechasL(this.txtCatalogoFechas.Text,
                                               int.Parse(this.cmbDia.SelectedItem.ToString()), this.cmbMes.SelectedItem.ToString(), this.txtDescripcion.Text, DateTime.Now,
                                                DateTime.Now, oUsuarioL[0].IdUsuario, oUsuarioL[0].IdUsuario, activo);



                     }
                     else
                     {
                         
                         this.oCatalogoFechasL = new CatalogoFechasL(this.txtCatalogoFechas.Text,
                                               int.Parse(this.cmbDia.SelectedItem.ToString()), this.cmbMes.SelectedItem.ToString(), this.txtDescripcion.Text, DateTime.Now,
                                                DateTime.Now, oUsuarioL[0].IdUsuario, oUsuarioL[0].IdUsuario, activo);



                     }


                 }
                 else {
                     MessageBox.Show("Error faltan datos requeridos");
                 
                 
                 }

             }catch(Exception){

                 MessageBox.Show("Error faltan datos requeridos");
             }
             
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
