using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Logica;

namespace GUI
{
    public partial class frmMantEmpleado : Form
    {
        AccesoDatosOracle cnx;

        public frmMantEmpleado(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.cargarGrid();
        }

        public void cargarGrid()
        {
            try
            {
                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                this.grdEmpleado.DataSource = oEmpleadoD.obtenerEmpleado();
                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error cargando los datos!!!" + oEmpleadoD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionEmpleado ofrmEmpleado = new frmEdicionEmpleado();
            ofrmEmpleado.ShowDialog();
            if (ofrmEmpleado.Aceptar)
            {
                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                oEmpleadoD.agregarEmpleado(ofrmEmpleado.oEmpleadoL);
                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oEmpleadoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Parametro agregado!!!");
                    this.cargarGrid();
                }
            }
        }
    }
}
