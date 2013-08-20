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
    public partial class frmMantUsuario : Form
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        AccesoDatosOracle cnx;
        List<UsuarioL> oUsuarioL;
        public frmMantUsuario(List<UsuarioL> pUsuarioL, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.oUsuarioL = pUsuarioL;
            this.cargarGrid();
        }
        /// <summary>
        /// Metodo que se encarga de cargar el datagridview
        /// </summary>
        public void cargarGrid()
        {
            try
            {
                UsuarioD oUsuarioD = new UsuarioD(this.cnx);
                this.grdUsuario.DataSource = oUsuarioD.obtenerUsuario();
                if (oUsuarioD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oUsuarioD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }

        /// <summary>
        /// Metodo que refresca los datos realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
            MessageBox.Show("Datos actualizados!!!");
        }

        /// <summary>
        /// Metodo que borra la línea seleccionada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdUsuario.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este Usuario?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                UsuarioL oUsuarioL = (UsuarioL)this.grdUsuario.CurrentRow.DataBoundItem;

                UsuarioD oUsuarioD = new UsuarioD(this.cnx);
                oUsuarioD.borrarUsuario(oUsuarioL);

                if (oUsuarioD.Error)
                {
                    MessageBox.Show("Error borrando el Usuario:" + oUsuarioD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Usuario borrado!!!");
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
            frmEdicionUsuario ofrmEdicion = new frmEdicionUsuario(this.oUsuarioL,this.cnx);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                UsuarioD oUsuarioD = new UsuarioD(this.cnx);
                oUsuarioD.agregarUsuario(ofrmEdicion.OUsuarioLNuevo);
                if (oUsuarioD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oUsuarioD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Usuario agregado!!!");
                    this.cargarGrid();
                }
            }
        }

        /// <summary>
        /// Metodo que edita la línea seleccionada 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdUsuario.RowCount > 0)
            {               
                UsuarioL oUsuarioOriginal = (UsuarioL)this.grdUsuario.CurrentRow.DataBoundItem;

                frmEdicionUsuario ofrmEdicion = new frmEdicionUsuario(oUsuarioOriginal, this.oUsuarioL,this.cnx);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    UsuarioD oUsuarioD = new UsuarioD(this.cnx);
                    oUsuarioD.editarUsuario(oUsuarioOriginal, ofrmEdicion.OUsuarioLNuevo);
                    if (oUsuarioD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos:" + oUsuarioD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Usuario actualizado!!!");
                        this.cargarGrid();
                    }
                }
            }
        }
    }
}
