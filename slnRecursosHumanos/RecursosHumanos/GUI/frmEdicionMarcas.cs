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
        ///  Atributos de la clase el cual verifica el botón aceptar.
        /// </summary>
        private AccesoDatosOracle cnx;
        private Boolean aceptar;
        public MarcaL MarcaL;

        

        public MarcaL MarcaL1
        {
            get { return MarcaL; }
            set { MarcaL = value; }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }

        /// <summary>
        /// Metodo constructor que recibe por parámetro la conexión a la base de datos
        /// </summary>
        /// <param name="pcnx"></param>
        public frmEdicionMarcas(AccesoDatosOracle pcnx)
        {
            InitializeComponent();
            rdoEntrada.Checked = true;
            
            this.cargarComboCodigoEmpleado(pcnx);
            this.txtEstado.Text = "Generada";
            this.txtEstado.ReadOnly = true;
           
            
        }
        /// <summary>
        /// Método para cargar el combobox CodigoEmpleado con los codigos existentes en la base de datos.
        /// </summary>
        /// <param name="pcnx"></param>
        public void cargarComboCodigoEmpleado(AccesoDatosOracle pcnx)
        {
            EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
            cmbCodigo.DataSource = oEmpleadoD.obtenerCodigoEmpleado().Tables[0].Copy();
            cmbCodigo.DisplayMember = "idEmpleado";
            cmbCodigo.ValueMember = "idEmpleado";
            this.cmbCodigo.SelectedItem = null;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string codigo =Convert.ToString(cmbCodigo.SelectedValue);

            
            if(rdoSalida.Checked==true){               
                
                MarcaL = new MarcaL(codigo,txtEstado.Text,"Salida","Proyecto",dtpFecha.Value.Date,"Proyecto",dtpFecha.Value.Date,"Sí");

            
            }else{
                MarcaL = new MarcaL(codigo, txtEstado.Text, "Entrada", "Proyecto", dtpFecha.Value.Date, "Proyecto", dtpFecha.Value.Date, "Sí");
            
            }
            this.Aceptar = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
