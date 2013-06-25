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
        AccesoDatosOracle cnx;

        public frmPrincipal(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
        }
        

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantUsuario oFrmMantUsuario = new frmMantUsuario(this.cnx);
            oFrmMantUsuario.ShowDialog();
        }

        private void departamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantDepartamento oFrmMantDepa = new frmMantDepartamento(this.cnx);
            oFrmMantDepa.ShowDialog();
        }

        private void deduccionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantDeducciones oFrmMantDeducciones = new frmMantDeducciones(this.cnx);
            oFrmMantDeducciones.ShowDialog();
        }

        private void catalogoFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantCatalogoFechas oFrmMantCatalogoFechas = new frmMantCatalogoFechas(this.cnx);
            oFrmMantCatalogoFechas.ShowDialog();
        }

        private void parametroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMantParametro oFrmMantParametro = new frmMantParametro(this.cnx);
            oFrmMantParametro.ShowDialog();

        }
    }
}
