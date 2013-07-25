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
    public partial class frmConsultaMarcas : Form
    {
        /// <summary>
        /// Variable para hacer la conexión a la base de datos
        /// </summary>
        private AccesoDatosOracle conexion;
       
        /// <summary>
        /// Constructor que recibe un
        /// </summary>
        /// <param name="pConexion"></param>
        public frmConsultaMarcas(AccesoDatosOracle pConexion)
        {
            InitializeComponent(); 
            InitializeComponent();
            this.conexion = pConexion;
            this.dteFecha1.Value = DateTime.Today;
            this.dteFecha2.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            


        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbDepartamento.SelectedIndex = 0;
            cmbEmpleado.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdConsultas.RowCount > 0)
            {

                ConsultaL oConsultaL = (ConsultaL)this.grdConsultas.CurrentRow.DataBoundItem;

                frmEdicionMarcas ofrmEdicionMarcas = new frmEdicionMarcas();
                ofrmEdicionDepartamento.ShowDialog();
                if (ofrmEdicionDepartamento.Aceptar)
                {
                    DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
                    oDepartamentoD.editarDepartamento(oDepartamentoOriginal, ofrmEdicionDepartamento.ODepartamentoL);
                    if (oDepartamentoD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oDepartamentoD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Departamento actualizada!!!");
                        this.cargarGrid();
                    }
                }
            }
        }
    }
}
