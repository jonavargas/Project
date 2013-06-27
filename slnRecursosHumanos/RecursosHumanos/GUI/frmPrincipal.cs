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
    public partial class frmPrincipal : Form
    {
        /// <summary>
        /// Atributos de la clase
        /// </summary>
        AccesoDatosOracle cnx;

        /// <summary>
        /// Metodo constructor con parametros
        /// </summary>
        /// <param name="pConexion"></param>

        public frmPrincipal(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
        }
        /// <summary>
        /// Metodo que levanta el formulario de mantenimiento de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantUsuario oFrmMantUsuario = new frmMantUsuario(this.cnx);
            oFrmMantUsuario.ShowDialog();
        }
        /// <summary>
        /// Metodo que levanta el formulario de mantenimiento de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantDepartamento oFrmMantDepa = new frmMantDepartamento(this.cnx);
            oFrmMantDepa.ShowDialog();
        }
        /// <summary>
        /// Metodo que levanta el formulario de mantenimiento de deducciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void deduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantDeducciones oFrmMantDeducciones = new frmMantDeducciones(this.cnx);
            oFrmMantDeducciones.ShowDialog();
        }
        /// <summary>
        /// Metodo que levanta el formulario de mantenimiento de catalogo de fechas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void catalogoFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantCatalogoFechas oFrmMantCatalogoFechas = new frmMantCatalogoFechas(this.cnx);
            oFrmMantCatalogoFechas.ShowDialog();
        }
        /// <summary>
        /// Metodo que levanta el formulario de mantenimiento de parametro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void parametroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantParametro oFrmMantParametro = new frmMantParametro(this.cnx);
            oFrmMantParametro.ShowDialog();

        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantEmpleado oFrmMantEmpleado = new frmMantEmpleado(this.cnx);
            oFrmMantEmpleado.ShowDialog();

        }
    }
}
