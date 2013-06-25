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
using GUI;

namespace GUI
{
    public partial class frmMantDepartamento : Form
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        AccesoDatosOracle cnx;
        /// <summary>
        /// Metodo costructor con parametros
        /// </summary>
        /// <param name="pConexion"></param>
        public frmMantDepartamento(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.cargarGrid();

        }
        /// <summary>
        /// Metodo que carga el datagridview
        /// </summary>
        public void cargarGrid()
        {
            try
            {
                DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
                this.grdDepartamento.DataSource = oDepartamentoD.obtenerDepartamentos();
                if (oDepartamentoD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oDepartamentoD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }
        /// <summary>
        /// Metodo que agrega un nuevo registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionDepartamento ofrmEdicionDepa = new frmEdicionDepartamento();
            ofrmEdicionDepa.ShowDialog();
            if (ofrmEdicionDepa.Aceptar)
            {
                DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
                oDepartamentoD.agregarDepartamento(ofrmEdicionDepa.ODepartamentoL);
                if (oDepartamentoD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oDepartamentoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Departamento agregada!!!");
                    this.cargarGrid();
                }
            }
        }  
        /// <summary>
        /// Metodo que refresca los datos con los cambios realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
        }
        /// <summary>
        /// Metodo que edita los cambios que se realizan en esa línea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdDepartamento.RowCount > 0)
            {

                DepartamentoL oDepartamentoOriginal = (DepartamentoL)this.grdDepartamento.CurrentRow.DataBoundItem;

                frmEdicionDepartamento ofrmEdicionDepartamento = new frmEdicionDepartamento(oDepartamentoOriginal);
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
        /// <summary>
        /// Metodo que borra la línea seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnBorrar_Click(object sender, EventArgs e)
        {

            if (this.grdDepartamento.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este Departamento?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                DepartamentoL oDepartamentoL = (DepartamentoL)this.grdDepartamento.CurrentRow.DataBoundItem;

                DepartamentoD oDepartamentoD = new DepartamentoD(this.cnx);
                oDepartamentoD.borrarDepartamento(oDepartamentoL);

                if (oDepartamentoD.Error)
                {
                    MessageBox.Show("Error borrando el departamento: " + oDepartamentoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Departamento borrado!!!");
                    this.cargarGrid();
                }
            }
        }
    }
}
