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
    public partial class frmEdicionMarcas : Form
    {
        /// <summary>
        ///  Atributos de la clase el cual verifica el botón aceptar y un objeto tipo Empleado en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private MarcaL oMarcaL;
        private AccesoDatosOracle cnx;

        /// <summary>
        /// Método constructor sin parámetros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>
        /// <param name="pcnx"></param>
        public frmEdicionMarcas(AccesoDatosOracle pcnx)
        {
            InitializeComponent();
            this.aceptar = false;
        }

        /// <summary>
        /// Properties de la Clase,el cual permite consultar los valores de los atributos
        /// </summary>
        public Boolean Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public MarcaL OMarcaL
        {
            get { return oMarcaL; }
            set { oMarcaL = value; }
        }
          
         public void cargarCmbDepartamento(AccesoDatosOracle pcnx)
        {
            DepartamentoD oDepartamentoD = new DepartamentoD(pcnx);
            cmbDepartamento.DataSource = oDepartamentoD.obtenerIdDepartamento().Tables[0].Copy();
            cmbDepartamento.DisplayMember = "idDepartamento";
            cmbDepartamento.ValueMember = "idDepartamento";
        }

         private void btnAceptar_Click(object sender, EventArgs e)
         {
             if (this.txtCodigo.Text == "")
             {
                 MessageBox.Show("Debe digitar un código");
                 this.txtCodigo.Text = "";
                 this.txtCodigo.Focus();
                 return;
             }

             EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
             List<EmpleadoL> empleado = oEmpleadoD.obtenerEmpleadoPorID(this.txtCodigo.Text);

             
             if (empleado.Count == 0)
             {
                 MessageBox.Show("No se encontro el código del empleado!!!!");
                 this.txtCodigo.Text = "";
                 this.txtCodigo.Focus();
                 return;
             }           
         }

         private void btnCancelar_Click(object sender, EventArgs e)
         {
             this.Close();
         }          
    }
}
