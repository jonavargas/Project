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
        private bool edicion = false;
        MarcaL oMarcaL;
        string tipo;
        DateTime fechaMarca;

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
        /// 

       
        public frmEdicionMarcas(AccesoDatosOracle pcnx)
        {
            InitializeComponent();
            rdoEntrada.Checked = true;
            this.cargarComboCodigoEmpleado(pcnx);

            txtEstadoMarca.Text = "Generada";
            
            
           
        }
        public frmEdicionMarcas(MarcaL pMarcaEditar, AccesoDatosOracle pcnx)
        {
            InitializeComponent();
            this.oMarcaL = pMarcaEditar;
            this.txtNumMarca.Text = this.oMarcaL.IdMarca.ToString();
            this.txtNumUnificacion.Text = this.oMarcaL.IdUnificacion.ToString();
            this.cmbCodigo.Items.Add(this.oMarcaL.IdEmpleado);
            
            this.dtpFecha.Value = this.oMarcaL.FechaMarca;
            this.validarBotonEditar();
            this.txtEstadoMarca.Text = this.oMarcaL.EstadoMarca;
            txtNumMarca.Enabled = false;
            txtNumUnificacion.Enabled = false;
            this.edicion = true;
            

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
            int idUnificacion = 0;
            
            string codigo = (cmbCodigo.SelectedItem.ToString());
            this.fechaMarca = dtpFecha.Value.Date;
           
            //
           
            string estado = Convert.ToString(txtEstadoMarca.Text);
            if (edicion == false)
            {
                
               
                if (rdoSalida.Checked == true)
                {
                    
                    MarcaL = new MarcaL(idUnificacion, codigo, estado, "Salida", fechaMarca, "Proyecto", DateTime.Now, "Proyecto", DateTime.Now, "Sí");


                }
                else
                {
                    MarcaL = new MarcaL(idUnificacion, codigo, estado, "Entrada", fechaMarca, "Proyecto", DateTime.Now, "Proyecto", DateTime.Now, "Sí");

                }
            }
            else {
                int numMarca = int.Parse(txtNumMarca.Text);
                int Unificacion =int.Parse(txtNumUnificacion.Text);
                if (rdoSalida.Checked == true)
                {
                    
                    MarcaL = new MarcaL(numMarca, Unificacion, codigo, estado, "Salida", fechaMarca, "Proyecto", DateTime.Now, "Proyecto", DateTime.Now, "Sí");


                }
                else
                {
                    MarcaL = new MarcaL(numMarca, Unificacion, codigo, estado, "Salida", fechaMarca, "Proyecto", DateTime.Now, "Proyecto", DateTime.Now, "Sí"); 

                }
            
            
            }
            this.Aceptar = true;
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        public void validarBotonEditar()
        {
            //se valida cual radio button se debe seleccionar cargando el dato a la variable tipo
            this.tipo = this.oMarcaL.TipoMarca;
            if (this.tipo == "Entrada")
            {
                this.rdoEntrada.Checked = true;
            }
            //si no es usuario regular
            else
            {
                this.rdoSalida.Checked = true;
            }

        }

        
    }
}
