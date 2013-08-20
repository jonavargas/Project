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
        List<UsuarioL> oUsuarioL;
        string tipo;

        /// <summary>
        /// Método constructor con parametros
        /// </summary>
        /// <param name="pConexion"></param>

        public frmPrincipal(List<UsuarioL> pUsuarioL, AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.oUsuarioL = pUsuarioL;
            
        }

        /// <summary>
        /// Método que levanta el formulario de mantenimiento de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantUsuario oFrmMantUsuario = new frmMantUsuario(oUsuarioL,this.cnx);
            oFrmMantUsuario.ShowDialog();
        }

        /// <summary>
        /// Método que levanta el formulario de mantenimiento de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantDepartamento oFrmMantDepa = new frmMantDepartamento(oUsuarioL,this.cnx);
            oFrmMantDepa.ShowDialog();
        }

        /// <summary>
        /// Método que levanta el formulario de mantenimiento de deducciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void deduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantDeducciones oFrmMantDeducciones = new frmMantDeducciones(oUsuarioL,this.cnx);
            oFrmMantDeducciones.ShowDialog();
        }

        /// <summary>
        /// Método que levanta el formulario de mantenimiento de catalogo de fechas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void catalogoFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantCatalogoFechas oFrmMantCatalogoFechas = new frmMantCatalogoFechas(oUsuarioL,this.cnx);
            oFrmMantCatalogoFechas.ShowDialog();
        }

        /// <summary>
        /// Método que levanta el formulario de mantenimiento de parametro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void parametroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantParametro oFrmMantParametro = new frmMantParametro(oUsuarioL,this.cnx);
            oFrmMantParametro.ShowDialog();

        }

        /// <summary>
        /// Método que levanta el formulario de mantenimiento de empleado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantEmpleado oFrmMantEmpleado = new frmMantEmpleado(oUsuarioL,this.cnx);
            oFrmMantEmpleado.ShowDialog();

        }

        /// <summary>
        /// Método que levanta el formulario de registro de marcas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmRegistroMarcas ofrmRegistroMarcas = new frmRegistroMarcas(this.cnx);
            ofrmRegistroMarcas.ShowDialog();
        }

        /// <summary>
        ///  Método que levanta el formulario de mantenimiento de las marcas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void maToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMarcas ofrmConsultaMarcas = new frmConsultaMarcas(oUsuarioL,this.cnx);
            ofrmConsultaMarcas.ShowDialog();
        }

        /// <summary>
        /// Método que levanta el formulario de unificación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CrearUnificacion_Click(object sender, EventArgs e)
        {
            frmUnificacion oFrmEdicion = new frmUnificacion(oUsuarioL, this.cnx);
            oFrmEdicion.ShowDialog();
        }

        /// <summary>
        /// Método que levanta el formulario de Pagos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagos oFrmPagos = new frmPagos(oUsuarioL, this.cnx);
            oFrmPagos.ShowDialog();
        }
    }
}
