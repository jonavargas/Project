﻿using System;
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
    public partial class frmMantCatalogoFechas : Form
    {
        /// <summary>
        /// Attributos de la clase
        /// </summary>
       
        AccesoDatosOracle cnx;
        List<UsuarioL> oUsuarioL;

        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="pConexion"></param>
        public frmMantCatalogoFechas(List<UsuarioL> pOUsuarioL, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.oUsuarioL = pOUsuarioL;
            this.cargarGrid();
        }
        /// <summary>
        /// Metodo que carga el Datagridview
        /// </summary>
        public void cargarGrid()
        {
            try
            {
                CatalogoFechasD oCatalogoFechasD = new CatalogoFechasD(this.cnx);
                this.grdCatalogoFechas.DataSource = oCatalogoFechasD.obtenerCatalogoFechas();
                if (oCatalogoFechasD.Error)
                {
                    MessageBox.Show("Error cargando los datos" + oCatalogoFechasD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }
        /// <summary>
        /// Metodo que refresca los cambios realizados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
            MessageBox.Show("Datos Actualizados!!!");
        }
        /// <summary>
        /// Metodo que borra la linea que elimina la línea 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdCatalogoFechas.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este Catalogo de Fechas?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;

                CatalogoFechasL oCatalogoFechasL = (CatalogoFechasL)this.grdCatalogoFechas.CurrentRow.DataBoundItem;

                CatalogoFechasD oCatalogoFechasD = new CatalogoFechasD(this.cnx);
                oCatalogoFechasD.borrarCatalogoFechas(oCatalogoFechasL);

                if (oCatalogoFechasD.Error)
                {
                    MessageBox.Show("Error borrando el Catalogo de Fechas: " + oCatalogoFechasD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Catalogo de Fechas borrado!!!");
                    this.cargarGrid();
                }
            }
        }
        /// <summary>
        /// Metodo que realiza un nuevo registro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionCatalogoFechas ofrmEdicion = new frmEdicionCatalogoFechas(this.oUsuarioL, this.cnx);
            ofrmEdicion.ShowDialog();
            if (ofrmEdicion.Aceptar)
            {
                CatalogoFechasD oCatalogoFechasD = new CatalogoFechasD(this.cnx);
                oCatalogoFechasD.agregarCatalogoFechas(ofrmEdicion.OCatalogoFechasL);
                if (oCatalogoFechasD.Error)
                {
                    MessageBox.Show("Error agregando los datos: " + oCatalogoFechasD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Catalogo de Fechas agregado!!!");
                    this.cargarGrid();
                }
            }
        }
        /// <summary>
        /// Metodo que edita la línea selecciona
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grdCatalogoFechas.RowCount > 0)
            {

                CatalogoFechasL oCatalogoFechasOriginal = (CatalogoFechasL)this.grdCatalogoFechas.CurrentRow.DataBoundItem;

                frmEdicionCatalogoFechas ofrmEdicion = new frmEdicionCatalogoFechas(oCatalogoFechasOriginal, this.oUsuarioL, this.cnx);
                ofrmEdicion.ShowDialog();
                if (ofrmEdicion.Aceptar)
                {
                    CatalogoFechasD oCatalogoFechasD = new CatalogoFechasD(this.cnx);
                    oCatalogoFechasD.editarCatalogoFechas(oCatalogoFechasOriginal, ofrmEdicion.OCatalogoFechasL);
                    if (oCatalogoFechasD.Error)
                    {
                        MessageBox.Show("Error actualizando los datos: " + oCatalogoFechasD.ErrorDescription);
                    }
                    else
                    {
                        MessageBox.Show("Catalogo de Fechas actualizado!!!");
                        this.cargarGrid();
                    }
                }
            }
        }
    }
}
