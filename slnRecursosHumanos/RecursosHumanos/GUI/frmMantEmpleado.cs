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
    public partial class frmMantEmpleado : Form
    {
        /// <summary>
        /// Atributos de la clase Empleado  el cual recibe en su parte lógica un solo parámetro el cual es la conexión con Oracle
        /// </summary>
      private  AccesoDatosOracle cnx;

        /// <summary>
        /// Método Constructor de la parte grafica Empleado el cual recibe la conexión a la base de datos Oraclr 
        /// e inicializa los atributos con el parámetro que recibe y además llama al método cargar grid
        /// </summary> 
        public frmMantEmpleado(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            this.cnx = pConexion;
            this.cargarGrid();
            frmEdicionEmpleado ofrmEdicionEmpleado = new frmEdicionEmpleado(pConexion);
            ofrmEdicionEmpleado.cargarCombobox(pConexion);
            
        }
        /// <summary>
        /// Método que se encarga de establecer la conexión con la base de datos adémas muestra los datos de esta en el grid
        /// /// </summary> 
        public void cargarGrid()
        {
            try
            {
                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                this.grdEmpleado.DataSource = oEmpleadoD.obtenerEmpleado();
                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error cargando los datos!!!" + oEmpleadoD.ErrorDescription);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error cargando los datos" + e.Message);
            }
        }
        /// <summary>
        /// Método que se encarga de crear un objeto de edición empleado el cual biene cargado con los datos suministrados por el usuario
        ///luego establece conexión con la clase datos de Empleado y cuadno la establece crea un objeto en la clase lógica de  empleado
        ///
        /// /// </summary> 
        private void btnNuevo_Click_1(object sender, EventArgs e)
        {

            frmEdicionEmpleado ofrmEdicionEmpleado = new frmEdicionEmpleado(this.cnx);
            ofrmEdicionEmpleado.ShowDialog();
            if (ofrmEdicionEmpleado.Aceptar)
            {
                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                oEmpleadoD.agregarEmpleado(ofrmEdicionEmpleado.OEmpleadoL);
                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error agregando los datos:" + oEmpleadoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Empleado agregado!!!");
                    this.cargarGrid();
                }

            }
            
        }
        /// <summary>
        /// Método que se encarga de editar un Empleado ya existente y procede de la siguiente manera toma el empleado existente y lo modifica por el suministrado 
        ///
        /// /// </summary> 
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try{
                if (this.grdEmpleado.RowCount > 0)
                {
                    EmpleadoL oEmpleadoOriginal = (EmpleadoL)this.grdEmpleado.CurrentRow.DataBoundItem;
                    frmEdicionEmpleado ofrmEdicionEmpleado = new frmEdicionEmpleado(oEmpleadoOriginal);
                    ofrmEdicionEmpleado.cargarCombobox(this.cnx);
                    ofrmEdicionEmpleado.ShowDialog();
                    if (ofrmEdicionEmpleado.Aceptar)
                    {
                        EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                        oEmpleadoD.editarEmpleado(oEmpleadoOriginal, ofrmEdicionEmpleado.OEmpleadoL);

                        if (oEmpleadoD.Error)
                        {
                        MessageBox.Show("Error actualizando los datos del Empleado: " + oEmpleadoD.ErrorDescription);
                        }
                        else
                        {
                            MessageBox.Show("Empleado actualizado!!!");
                            this.cargarGrid();
                        }
                    }
                }
            } catch(Exception E)
            {
                MessageBox.Show("No hay datos para editar");
            }

        }
        /// <summary>
        /// Método que se encarga de borrar un Empleado ya existe primero consulta al usuario si desea elinarlo y si esta de acuerdo procede a establecer
        /// la conexión con la base de datos y borra ese elemento
        /// /// </summary> 
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (this.grdEmpleado.RowCount > 0)
            {
                //pide confirmación:
                DialogResult confirmacion = MessageBox.Show("¿Está seguro de borrar este Empleado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.No) return;
                EmpleadoL oEmpleadoL = (EmpleadoL)this.grdEmpleado.CurrentRow.DataBoundItem;

                EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
                oEmpleadoD.borrarEmpleado(oEmpleadoL);

                if (oEmpleadoD.Error)
                {
                    MessageBox.Show("Error borrando el Empleado: " + oEmpleadoD.ErrorDescription);
                }
                else
                {
                    MessageBox.Show("Empleado borrado!!!");
                    this.cargarGrid();
                }
            }
        }
        /// <summary>
        /// Método que se encarga de actualizar los datos de los empleados existentes
        /// /// </summary>
        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.cargarGrid();
            MessageBox.Show("Datos actualizados!!!");
        }

    }
}
