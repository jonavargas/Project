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

        private void txtCodigoEmpleado_TextChanged(object sender, EventArgs e)
        {
            bool entrada = true;
            string marca = "Entrada";
            string estado = "Generado";
            try
            {
                if (this.txtCodigoEmpleado.Text != "")
                {
                    if (entrada == true)
                    {
                        marca = "Entrada";
                        estado = "Generado";
                    }
                }
                MessageBox.Show("Error el código de empleado esta en blanco!!!");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al ingresar el código de empleado!!!");
            }
        }

    }
}
