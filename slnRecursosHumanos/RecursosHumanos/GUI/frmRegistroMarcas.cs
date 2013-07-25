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
    public partial class frmRegistroMarcas : Form
    {
        AccesoDatosOracle cnx;
        public frmRegistroMarcas(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
        }

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            int contMarcas=1;
            
            MarcaD oMarcaD=new MarcaD(this.cnx);
            EmpleadoD oEmpleadoD=new EmpleadoD(this.cnx);
            List<EmpleadoL> empleado = oEmpleadoD.buscarEmpleado(this.txtCodigoEmpleado.Text);
            
            if(txtCodigoEmpleado.Text!=""){

                if (empleado.Count>0)
                {
                    MarcaL oMarcaL = new MarcaL(contMarcas, txtCodigoEmpleado.Text, "Generado", oMarcaD.tipoMarca(txtCodigoEmpleado.Text), "Empleado", DateTime.Now, "Empleado", DateTime.Now, "Sí");
                    oMarcaD.agregarMarca2(oMarcaL);
                    txtCodigoEmpleado.Text = "";
                }
                else {
                    MessageBox.Show("El empleado no existe ó se encuentra inactivo en la empresa");
                    txtCodigoEmpleado.Text = "";
                }
            }
        }

        private void frmRegistroMarcas_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.btnMarcar_Click(sender, e);
            }
        }
    }
}
