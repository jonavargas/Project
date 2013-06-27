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

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            frmEdicionEmpleado ofrmEdicionEmpleado = new frmEdicionEmpleado();
            ofrmEdicionEmpleado.ShowDialog();
            if (ofrmEdicionEmpleado.Aceptar)
            {
                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                oEmpleadoD.agregarEmpleado(ofrmEdicionEmpleado.OEmpleadoL);


                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oEmpleadoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Empleado agregado!!!");
                    this.cargarGrid();
                }

            }
           
            
        }
    }
}
