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
            MarcaD oMarcaD=new MarcaD(this.cnx);
           EmpleadoD oEmpleadoD=new EmpleadoD(this.cnx);
           MarcaL oMarcaL = new MarcaL();
           
            

            if(txtCodigoEmpleado.Text!=""){

                if (!oEmpleadoD.buscarEmpleado(txtCodigoEmpleado.Text).Equals(""))
                {
                    oMarcaD.agregarMarca();



                }
                else {
                    MessageBox.Show("El empleado no existe ó se encuentra inactivo en la empresa");
                
                }

            
            }
        }

    }
}
