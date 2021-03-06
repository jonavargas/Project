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
    public partial class frmPagos : Form
    {
        /// <summary>
        /// Variable para hacer la conexión a la base de datos
        /// </summary>
        private AccesoDatosOracle conexion;
        PagosL oPagosL;
        PagosD oPagosD;
        List<UsuarioL> oUsuarioActual;
        List<UnificacionL> oUnificacion;
        List<MarcaL> oMarca;
        int idPago = 0;
        string descripcion;
        string estado = "Pagado";
        string anulado = "No";
        double totalPago = 0;
        double totalDeducciones = 0;
        DateTime fechaCreacion = DateTime.Now;
        DateTime fechaModificacion = DateTime.Now;
        string creadoPor;

        public frmPagos(List<UsuarioL> pUsuarioActual, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cargarCmbDepartamento(pConexion);
            this.cmbDepartamento.SelectedItem = null;
        }

        /// <summary>
        /// Método para cargar el combobox Departamento con los departamentos existentes en la base de datos.
        /// </summary>
        /// <param name="pcnx"></param>

        public void cargarCmbDepartamento(AccesoDatosOracle pcnx)
        {
            DepartamentoD oDepartamentoD = new DepartamentoD(pcnx);
            cmbDepartamento.DataSource = oDepartamentoD.obtenerIdDepartamento().Tables[0].Copy();
            cmbDepartamento.DisplayMember = "idDepartamento";
            cmbDepartamento.ValueMember = "idDepartamento";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmEdicionPagos ofrmEdicionMarcas = new frmEdicionPagos();
            ofrmEdicionMarcas.ShowDialog();
        }
    }
}
