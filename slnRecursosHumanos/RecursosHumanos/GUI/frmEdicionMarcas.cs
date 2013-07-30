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
        int idUnificacion = 0;
        

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
            this.txtEstadoMarca.Text = "Generada";
            this.txtEstadoMarca.ReadOnly = true;
           
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
            string codigo = Convert.ToString(cmbCodigo.SelectedValue);
            this.idUnificacion = int.Parse(txtNumUnificacion.Text);
            string estado = Convert.ToString(txtEstadoMarca.Text);


            if (rdoSalida.Checked == true)
            {

                MarcaL = new MarcaL(idUnificacion, codigo, estado, "Salida", dtpFecha.Value.Date, "Proyecto", DateTime.Now, "Proyecto", DateTime.Now, "Sí");


            }
            else
            {
                MarcaL = new MarcaL(idUnificacion, codigo, estado, "Entrada", dtpFecha.Value.Date, "Proyecto", DateTime.Now, "Proyecto", DateTime.Now, "Sí");

            }
            this.Aceptar = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void cargarComboEmpleado(string idEmpleado)
        {
            this.cmbCodigo.Items.Add(idEmpleado);

        }
    }
}
