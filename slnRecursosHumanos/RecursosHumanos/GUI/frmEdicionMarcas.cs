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
        private AccesoDatosOracle conexion;
        private Boolean aceptar;
        public MarcaL MarcaL;        
        private bool edicion = false;
        MarcaL oMarcaL;
        string tipo;
        DateTime fechaMarca;
        List<UsuarioL> oUsuarioConectado;

        public List<UsuarioL> OUsuarioConectado
        {
            get { return oUsuarioConectado; }
            set { oUsuarioConectado = value; }
        }

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

       
        public frmEdicionMarcas(List<UsuarioL> pUsuarioConectado, AccesoDatosOracle pCnx)
        {
            InitializeComponent();
            this.conexion = pCnx;
            this.OUsuarioConectado = pUsuarioConectado;
            rdoEntrada.Checked = true;
            this.cargarComboCodigoEmpleado(pCnx);
            txtEstadoMarca.Text = "Generada";
            this.oUsuarioConectado = pUsuarioConectado;
            this.edicion = false;
        }

        public frmEdicionMarcas(MarcaL pMarcaEditar, List<UsuarioL> pUsuarioConectado, AccesoDatosOracle pcnx)
        {
            InitializeComponent();
            this.conexion = pcnx;
            this.OUsuarioConectado = pUsuarioConectado;
            this.oMarcaL = pMarcaEditar;
            this.oUsuarioConectado = pUsuarioConectado;
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


        /// <summary>
        /// Método que ejecuta el botón aceptar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idUnificacion = 0;
            this.fechaMarca = dtpFecha.Value.Date;
            string estado = Convert.ToString(txtEstadoMarca.Text);
            try
            {

                if (edicion == false)
                {
                    string codigo = (cmbCodigo.SelectedValue.ToString());

                    if (rdoSalida.Checked == true)
                    {

                        MarcaL = new MarcaL(codigo, idUnificacion, estado, "Salida", fechaMarca, this.OUsuarioConectado[0].IdUsuario, DateTime.Now, this.OUsuarioConectado[0].IdUsuario, DateTime.Now, "Sí");


                    }
                    else
                    {
                        MarcaL = new MarcaL(codigo, idUnificacion, estado, "Entrada", fechaMarca, this.OUsuarioConectado[0].IdUsuario, DateTime.Now, this.OUsuarioConectado[0].IdUsuario, DateTime.Now, "Sí");

                    }
                }
                else
                {
                    int Unificacion = int.Parse(txtNumUnificacion.Text);
                    int numMarca = int.Parse(txtNumMarca.Text);
                    string codigo2 = (cmbCodigo.SelectedItem.ToString());
                    if (rdoSalida.Checked == true)
                    {

                        MarcaL = new MarcaL(numMarca, codigo2, Unificacion, estado, "Salida", fechaMarca, OUsuarioConectado[0].IdUsuario, DateTime.Now, OUsuarioConectado[0].IdUsuario, DateTime.Now, "Sí");


                    }
                    else
                    {
                        MarcaL = new MarcaL(numMarca, codigo2, idUnificacion, estado, "Entrada", fechaMarca, OUsuarioConectado[0].IdUsuario, DateTime.Now, OUsuarioConectado[0].IdUsuario, DateTime.Now, "Sí");

                    }
                }
            }catch(Exception){
            MessageBox.Show("Error agregando Marca");
            
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
            if (this.tipo=="Entrada")
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
