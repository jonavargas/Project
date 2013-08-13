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
    public partial class frmMantParametro : Form
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        AccesoDatosOracle cnx;
        List<UsuarioL> oUsuarioL;
        CatalogoFechasD OCatalogofechasD;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="pOUsuarioL"></param>
        /// <param name="pConexion"></param>
        public frmMantParametro(List<UsuarioL> pOUsuarioL, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.oUsuarioL = pOUsuarioL;
            this.cargarGrid();

        }
        /// <summary>
        /// Método que se encarga de cargar el grid
        /// </summary>
        public void cargarGrid()
        {
            try
            {
                ParametroD oParametroD = new ParametroD(this.cnx);
                this.grdParametro.DataSource = oParametroD.obtenerParametro();
                if (oParametroD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oParametroD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }
        /// <summary>
        /// Método que se encarga de refrescar el grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
            MessageBox.Show("Datos actualizados!!!");
        }

        /// <summary>
        /// Método que se encarga de borrar el arametro seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdParametro.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este Parametro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;
                ParametroL oParametroL = (ParametroL)this.grdParametro.CurrentRow.DataBoundItem;

                ParametroD oParametroD = new ParametroD(this.cnx);
                oParametroD.borrarParametro(oParametroL);

                if (oParametroD.Error)
                {
                    MessageBox.Show("Error borrando el Parametro: " + oParametroD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Parametro borrado!!!");
                    this.cargarGrid();
                }
            }
        }

        /// <summary>
        /// Método que se encarga de crear un nuevo párametro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionParametro ofrmEdicion = new frmEdicionParametro(this.oUsuarioL, this.cnx);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                ParametroD oParametroD = new ParametroD(this.cnx);
                oParametroD.agregarParametro(ofrmEdicion.OParametroL);
                if (oParametroD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oParametroD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Parametro agregado!!!");
                    this.cargarGrid();
                }
            }
        }

        /// <summary>
        /// Método que se encarga de editar un párametro seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdParametro.RowCount > 0)
            {

                ParametroL oParametroOriginal = (ParametroL)this.grdParametro.CurrentRow.DataBoundItem;

                frmEdicionParametro ofrmEdicion = new frmEdicionParametro(oParametroOriginal, this.oUsuarioL, this.cnx);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    ParametroD oParametroD = new ParametroD(this.cnx);
                    oParametroD.editarParametro(oParametroOriginal, ofrmEdicion.OParametroL);
                    if (oParametroD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oParametroD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Parametro actualizado!!!");
                        this.cargarGrid();
                    }
                }
            }
        }

    }
}
