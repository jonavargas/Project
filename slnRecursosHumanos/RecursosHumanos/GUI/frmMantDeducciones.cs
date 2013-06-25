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
    public partial class frmMantDeducciones : Form
    {
        AccesoDatosOracle cnx;
        public frmMantDeducciones(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.cargarGrid();
        }
        public void cargarGrid()
        {
            try
            {
                DeduccionesD oDeduccionesD = new DeduccionesD(this.cnx);
                this.grdDeducciones.DataSource = oDeduccionesD.obtenerDeducciones();
                if (oDeduccionesD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oDeduccionesD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
            MessageBox.Show("Datos actualizados!!!");
        }
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdDeducciones.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar esta Deducción?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                DeduccionesL oDeduccionesL = (DeduccionesL)this.grdDeducciones.CurrentRow.DataBoundItem;

                DeduccionesD oDeduccionesD = new DeduccionesD(this.cnx);
                oDeduccionesD.borrarDeduccion(oDeduccionesL);

                if (oDeduccionesD.Error)
                {
                    MessageBox.Show("Error borrando la Deducción:" + oDeduccionesD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Deducción borrada!!!");
                    this.cargarGrid();
                }
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionDeducciones ofrmEdicion = new frmEdicionDeducciones();
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                DeduccionesD oDeduccionesD = new DeduccionesD(this.cnx);
                oDeduccionesD.agregarDeduccion(ofrmEdicion.ODeduccionesL);
                if (oDeduccionesD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oDeduccionesD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Deducción agregada!!!");
                    this.cargarGrid();
                }
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdDeducciones.RowCount > 0)
            {
                DeduccionesL oDeduccionesOriginal = (DeduccionesL)this.grdDeducciones.CurrentRow.DataBoundItem;

                frmEdicionDeducciones ofrmEdicion = new frmEdicionDeducciones(oDeduccionesOriginal);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    DeduccionesD oDeduccionesD = new DeduccionesD(this.cnx);
                    oDeduccionesD.editarDeducciones(oDeduccionesOriginal, ofrmEdicion.ODeduccionesL);
                    if (oDeduccionesD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oDeduccionesD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Deducción actualizada!!!");
                        this.cargarGrid();
                    }
                }
            }
        }
    }
}
