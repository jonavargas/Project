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
        private AccesoDatosOracle conexion;
       
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
            /*MarcaD oMarcaD = new MarcaD(this.conexion);
            
            List<MarcaL> listaMarcas = oMarcaD.obtenerMarcas(this.txtFactura.Text, this.dteFecha1.Value, this.dteFecha2.Value, this.txtCliente.Text, anulada);
            if (!ofacturaD.Error)
            {
                this.grdFacturas.DataSource = listaFacturas;
            }
            else
            {
                MessageBox.Show("Error cargando datos, detalle:" + ofacturaD.ErrorDescription);
            }
             * */

        }
    }
}
