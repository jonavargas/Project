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
    public partial class frmEdicionDepartamento : Form
    {
        /// <summary>
        /// Atributos de la clase Empleado  el cual verifica el botón aceptar y un objeto tipo Departamento en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private DepartamentoL oDepartamentoL;

        /// <summary>
        /// Método constructor sin parametros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>
        public frmEdicionDepartamento()
        {
            InitializeComponent();
            this.aceptar = false;
        }
        /// <summary>
        /// Método constructor el cual recibe por parámetro un EDepartamento el cual inicializa los atributos existentes
        /// </summary>
        /// <param name="pDepartamentoL"></param>
        public frmEdicionDepartamento(DepartamentoL pDepartamentoL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtIdDepartamento.Text = pDepartamentoL.IdDepartamento.ToString();
            this.txtNombreDepa.Text = pDepartamentoL.NombreDepartamento.ToString();
            this.oDepartamentoL = pDepartamentoL;
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
            this.oDepartamentoL = new DepartamentoL(this.txtIdDepartamento.Text,
                                      this.txtNombreDepa.Text, DateTime.Now,
                                         DateTime.Now, Program.oUsuarioLogueado.IdUsuario, Program.oUsuarioLogueado.IdUsuario,
                                         activo);
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
