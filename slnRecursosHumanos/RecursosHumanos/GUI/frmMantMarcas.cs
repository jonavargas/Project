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
    public partial class frmMantMarcas : Form
    {
       
        MarcaD oMarcaD;
        MarcaL oMarcaEditarEstado;
        private AccesoDatosOracle cnx;


        public frmMantMarcas(AccesoDatosOracle pcnx)
        {
            InitializeComponent(); 
            this.cnx = pcnx;
            this.cargarGrid();
            this.dteFecha1.Value = DateTime.Today;
            this.dteFecha2.Value = DateTime.Today.AddHours(23).AddMinutes(59).AddSeconds(59);            
            this.cmbEstado.Items.Add("Generada");
            this.cmbEstado.Items.Add("En trámite");
            this.cmbEstado.Items.Add("Pagada");
            this.cmbEstado.Items.Add("Anulada");
            this.cargarCmbDepartamento(pcnx);
            this.cargarComboEmpleado(pcnx);
            this.cargarComboCodigoEmpleado(pcnx);
            
        }
        /// <summary>
        /// Método que se encarga de establecer la conexión con la base de datos adémas muestra los datos de esta en el grid
        /// /// </summary> 
        public void cargarGrid()
        {
            try
            {
               MarcaD oMarcaD = new MarcaD(this.cnx);
                this.grdConsultas.DataSource = oMarcaD.obtenerMarcas();
                if (oMarcaD.Error)
                {
                    MessageBox.Show("Error cargando los datos!!!" + oMarcaD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        public void cargarCmbDepartamento(AccesoDatosOracle pcnx)
        {
            DepartamentoD oDepartamentoD = new DepartamentoD(pcnx);
            cmbDepartamento.DataSource = oDepartamentoD.obtenerIdDepartamento().Tables[0].Copy();
            cmbDepartamento.DisplayMember = "idDepartamento";
            cmbDepartamento.ValueMember = "idDepartamento";
        }

       public void cargarComboEmpleado(AccesoDatosOracle pcnx)
        {
            EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
            cmbEmpleado.DataSource = oEmpleadoD.obtenerNombreEmpleado().Tables[0].Copy();
            cmbEmpleado.DisplayMember = "nombreCompleto";
            cmbEmpleado.ValueMember = "nombreCompleto";
        }

       public void cargarComboCodigoEmpleado(AccesoDatosOracle pcnx)
       {
           EmpleadoD oEmpleadoD = new EmpleadoD(pcnx);
           cmbCodigo.DataSource = oEmpleadoD.obtenerCodigoEmpleado().Tables[0].Copy();
           cmbCodigo.DisplayMember = "idEmpleado";
           cmbCodigo.ValueMember = "idEmpleado";
       }
        
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string departamento;
            string estado;

            if (this.dteFecha1.Value > this.dteFecha2.Value)
            {
                MessageBox.Show("Revisar el rango de fechas");
                return;
            }

             MarcaD oMarcaD = new MarcaD(this.cnx);

                if (this.cmbDepartamento.SelectedValue == null)
                {
                    departamento = "";
                }
                else
                {
                    departamento = this.cmbDepartamento.SelectedValue.ToString();
                }

                if (this.cmbEstado.SelectedIndex.ToString() != "-1")
                {
                    estado = this.cmbEstado.SelectedItem.ToString();
                }
                else
                {
                    estado = "";
                }

                List<MarcaL> listaMarcas = oMarcaD.MarcaFiltro(this.dteFecha1.Value, this.dteFecha2.Value, departamento,
                                                                         estado, this.cmbCodigo.Text, this.cmbEmpleado.Text);
                if (!oMarcaD.Error)
                {
                    this.grdConsultas.DataSource = listaMarcas;
                }
                else
                {
                    MessageBox.Show("Error cargando datos, detalle:" + oMarcaD.ErrorDescription);
                }
            }
        

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
            MessageBox.Show("Datos actualizados!!!");
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdConsultas.RowCount > 0)
            {               
                MarcaL oMarcaL = (MarcaL)this.grdConsultas.CurrentRow.DataBoundItem;
                //List <EmpleadoL> oAuxEmpleadoL = this.oDbEmpleado.obtenerEmpleadoPorID(oEmpleadoL.IdEmpleado);

                if (oMarcaL.EstadoMarca == "Generada")
                {
                    frmEdicionMarcas ofrmEdicion = new frmEdicionMarcas(this.cnx);
                    ofrmEdicion.ShowDialog();
                    if (ofrmEdicion.Aceptar)
                    {
                        this.oMarcaD = new MarcaD(this.cnx);
                        oMarcaD.editarMarca(ofrmEdicion.OMarcaL, oMarcaL);
                        if (oMarcaD.Error)
                        {
                            MessageBox.Show("Error actualizando los datos:" + oMarcaD.ErrorDescription);
                        }
                        else
                        {
                            MessageBox.Show("Marca actualizada!!!");
                            this.cargarGrid();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La marca solo se puede modificar si su estado es Generada");
                    return;
                }
            }
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (this.grdConsultas.RowCount > 0)
            {
                MarcaL oMarcaL = (MarcaL)this.grdConsultas.CurrentRow.DataBoundItem;

                if (oMarcaL.EstadoMarca == "Generada")
                {
                    
                    DialogResult confirmacion = MessageBox.Show("¿Está seguro de Anular este registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (confirmacion == DialogResult.No) return;

                    this.oMarcaEditarEstado = (MarcaL)this.grdConsultas.CurrentRow.DataBoundItem;
                    oMarcaEditarEstado.EstadoMarca = "Anulada";
                    oMarcaEditarEstado.FechaModificacion = DateTime.Now;

                    this.oMarcaD = new MarcaD(this.cnx);
                    oMarcaD.editarMarca(oMarcaEditarEstado, oMarcaL);

                    if (oMarcaD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oMarcaD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Marca Anulada!!!");
                        this.cargarGrid();
                    }
                }
                else
                {
                    MessageBox.Show("La marca solo se puede modificar si su estado es Generada");
                    return;
                }
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmEdicionMarcas ofrmEdicionMarcas = new frmEdicionMarcas(this.cnx);
            ofrmEdicionMarcas.ShowDialog();
            if (ofrmEdicionMarcas.Aceptar)
            {
                MarcaD oMarcaD = new MarcaD(this.cnx);
                oMarcaD.agregarMarca(ofrmEdicionMarcas.OMarcaL);
                if (oMarcaD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oMarcaD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Marca agregada!!!");
                    this.cargarGrid();
                }
            }
        }

        
    }
}
