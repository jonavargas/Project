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

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (this.grdEmpleado.RowCount > 0)
            {

                EmpleadoL oEmpleadoOriginal = (EmpleadoL)this.grdEmpleado.CurrentRow.DataBoundItem;

                frmEdicionEmpleado ofrmEdicion = new frmEdicionEmpleado(oEmpleadoOriginal);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    EmpleadoD oParametroD = new EmpleadoD(this.cnx);
                    oParametroD.editarEmpleado(oEmpleadoOriginal, ofrmEdicion.OEmpleadoL);
                    if (oParametroD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos del Empleado: " + oParametroD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Empleado actualizado!!!");
                        this.cargarGrid();
                    }
                }
            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdEmpleado.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este Empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;
                EmpleadoL oEmpleadoL = (EmpleadoL)this.grdEmpleado.CurrentRow.DataBoundItem;

                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                oEmpleadoD.borrarEmpleado(oEmpleadoL);

                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error borrando el Empleado: " + oEmpleadoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Empleado borrado!!!");
                    this.cargarGrid();
                }
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
            MessageBox.Show("Datos actualizados!!!");
        }
    }
}
