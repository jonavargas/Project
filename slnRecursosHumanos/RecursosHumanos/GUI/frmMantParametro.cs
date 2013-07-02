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
        /// <summary>
        ///     Metodo costructor con parametros
        /// </summary>
        /// <param name="pConexion"></param>
        public frmMantParametro(AccesoDatosOracle pConexion)
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
        /// Metodo que refresca los cambios realizados en una línea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
            MessageBox.Show("Datos actualizados!!!");
        }
        /// <summary>
        /// Metodo que borra la linea que se encuentra seleccionada
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
        /// Metodo que crea un nuevo registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionParametro ofrmEdicion = new frmEdicionParametro(null,null,null,null,null,null,null,null);
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
        /// Metodo que edita la línea que se encuentra seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdParametro.RowCount > 0)
            {
                string lunes;
                string martes;
                string miercoles;
                string jueves;
                string viernes;
                string sabado;
                string domingo; 


                ParametroL oParametroOriginal = (ParametroL)this.grdParametro.CurrentRow.DataBoundItem;

                
                lunes = oParametroOriginal.Lunes;
                martes = oParametroOriginal.Martes;
                miercoles = oParametroOriginal.Miercoles;
                jueves = oParametroOriginal.Jueves;
                viernes = oParametroOriginal.Viernes;
                sabado = oParametroOriginal.Sabado;
                domingo = oParametroOriginal.Domingo;
                frmEdicionParametro ofrmEdicion = new frmEdicionParametro(oParametroOriginal, lunes, martes, miercoles, jueves, viernes, sabado, domingo);
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
