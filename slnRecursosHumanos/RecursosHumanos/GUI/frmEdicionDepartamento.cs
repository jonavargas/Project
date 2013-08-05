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
    public partial class frmEdicionDepartamento : Form
    {
        /// <summary>
        /// Atributos de la clase Empleado  el cual verifica el botón aceptar y un objeto tipo Departamento en la parte lógica
        /// </summary>
        private Boolean aceptar;        
        private DepartamentoL oDepartamentoL;        
        List<UsuarioL> oUsuarioL;       
        AccesoDatosOracle conexion;
        private bool edicion = false;
        
        public Boolean Aceptar1
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        public DepartamentoL ODepartamentoL1
        {
            get { return oDepartamentoL; }
            set { oDepartamentoL = value; }
        }
        public List<UsuarioL> OUsuarioL
        {
            get { return oUsuarioL; }
            set { oUsuarioL = value; }
        }

        /// <summary>
        /// Método constructor sin parametros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>
        public frmEdicionDepartamento(List<UsuarioL> pOUsuarioL, AccesoDatosOracle pCnx)
        {
            InitializeComponent();
            this.conexion = pCnx;
            this.oUsuarioL = pOUsuarioL;
            this.chkActivo.Checked = true;
            this.aceptar = false;
        }
        /// <summary>
        /// Método constructor el cual recibe por parámetro un EDepartamento el cual inicializa los atributos existentes
        /// </summary>
        /// <param name="pDepartamentoL"></param>
        public frmEdicionDepartamento(DepartamentoL pDepartamentoL, List<UsuarioL> pOUsuarioLConectado, AccesoDatosOracle pCnx)
        {
            InitializeComponent();
            this.conexion = pCnx;            
            this.txtIdDepartamento.Text = pDepartamentoL.IdDepartamento.ToString();
            this.txtNombreDepa.Text = pDepartamentoL.NombreDepartamento.ToString();
            this.chkActivo.Text = pDepartamentoL.Activo.ToString();
            this.oDepartamentoL = pDepartamentoL;
            this.edicion = true;
            this.aceptar = false;
        }
        /// <summary>
        /// Propiedades de los atributos de la clase Departamento,el cual permite consultar los valores de los atributos
        /// </summary>
        public DepartamentoL ODepartamentoL
        {
            get { return oDepartamentoL; }
            set { oDepartamentoL = value; }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
            set { aceptar = value; }
        }
        /// <summary>
        /// Método del botón aceptar,el cual verifica si el usuario preciono el botón aceptar o no,si lo hizo procede a revisar si no dejo
        /// algún espacio en blanco sino lo hizo creando un departamento con los datos suministrados
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

            if ((this.txtIdDepartamento.Text == "") ||
               (this.txtNombreDepa.Text == ""))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }

            DepartamentoD oDepartamentoD = new DepartamentoD(this.conexion);
            List<DepartamentoL> listaDepartamento = oDepartamentoD.obtenerIdDepartamento(this.txtIdDepartamento.Text);
            if (this.edicion == false)
            {
                if (listaDepartamento.Count > 0)
                {
                    MessageBox.Show("El código de Departamento ya existe");
                    this.txtIdDepartamento.Text = "";
                    this.txtIdDepartamento.Focus();
                    return;

                }
                else
                {

                    this.oDepartamentoL = new DepartamentoL(this.txtIdDepartamento.Text,
                                         this.txtNombreDepa.Text, DateTime.Now,
                                            DateTime.Now, oUsuarioL[0].IdUsuario, oUsuarioL[0].IdUsuario,
                                            activo);


                }




            }
            else {
                this.txtIdDepartamento.ReadOnly = false;
                this.oDepartamentoL = new DepartamentoL(this.txtIdDepartamento.Text,
                                         this.txtNombreDepa.Text, DateTime.Now,
                                            DateTime.Now, oUsuarioL[0].IdUsuario, oUsuarioL[0].IdUsuario,
                                            activo);         
            
            
            
            }

           
            this.aceptar = true;
            this.Close();

        }
        /// <summary>
        /// Metodo del botón cancelar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
