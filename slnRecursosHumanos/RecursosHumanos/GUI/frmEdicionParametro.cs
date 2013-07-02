using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace GUI
{
    public partial class frmEdicionParametro : Form
    {
        /// <summary>
        ///  Atributos de la clase Parámetro el cual verifica el botón aceptar y un objeto tipo parámetro en la parte lógica
        /// </summary>
        private Boolean aceptar;
        private ParametroL oParametroL;

        /// <summary>
        /// Método constructor sin parámetros y que además inializa el atributo aceptar que corresponde al botón aceptar
        /// en false
        /// </summary>
        public frmEdicionParametro()
        {
            InitializeComponent();
            this.aceptar = false;
        }
        /// <summary>
        ///Método constructor el cual recibe por parámetro un parametro el cual inicializa los atributos existentes
        /// </summary>
        /// <param name="pParametroL"></param>
        public frmEdicionParametro(ParametroL pParametroL)
        {
            InitializeComponent();
            this.aceptar = false;
            this.txtIdParametro.Text = Convert.ToString(pParametroL.IdParametro);
            this.txtHoraEntrada.Text = Convert.ToString(pParametroL.HoraEntrada);
            this.txtHoraSalida.Text = Convert.ToString( pParametroL.HoraSalida);            
            this.oParametroL = pParametroL;
        }
        /// <summary>
        /// Properties de la Clase parámetro,el cual permite consultar los valores de los atributos
        /// </summary>
        public ParametroL OParametroL
        {
            get { return oParametroL; }
        }

        public Boolean Aceptar
        {
            get { return aceptar; }
        }
        /// <summary>
        /// Evento del botón Cancelar el cual cierra la ventada si dan click en el 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarSeleccionDias() {
            bool respuesta = false;
            if ((ckdLunes.Checked == true) || (ckdMartes.Checked == true) || (ckdMiercoles.Checked == true) || (ckdJueves.Checked == true)
                || (ckdViernes.Checked == true) || (ckdSabado.Checked == true) || (ckdDomingo.Checked == true))
            {
                respuesta = true;
            }
            return respuesta;       
        }
        /// <summary>
        /// Metodo para validar si el check de activo se encuentra seleccionado
        /// </summary>
        /// <returns></returns>
        private bool validarSeleccionActivo() {
            bool respuesta = false;
            if(ckdActivo.Checked){
                respuesta = true;
            }
            return respuesta;        
        }
        /// <summary>
        /// Metodo para validar si activo esta activo
        /// </summary>
        /// <returns></returns>
        private string validarActivo()
        {
            string respuesta = "No";
            if (ckdActivo.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        /// <summary>
        ///  Metodo para validar si lunes tiene el check
        /// </summary>
        /// <returns></returns>
        private string validarLunes() {
            string respuesta ="No";
            if(ckdLunes.Checked){
                respuesta = "Sí";
            }
            return respuesta;
        }
        /// <summary>
        /// Metodo para validar si Martes tiene el check
        /// </summary>
        /// <returns></returns>
        private string validarMartes()
        {
            string respuesta = "No";
            if (ckdMartes.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        /// <summary>
        /// Metodo para validar si Miércoles tiene el check
        /// </summary>
        /// <returns></returns>
        private string validarMiercoles()
        {
            string respuesta = "No";
            if (ckdMiercoles.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        /// <summary>
        /// Metodo para validar si jueves tiene el check
        /// </summary>
        /// <returns></returns>
        private string validarJueves()
        {
            string respuesta = "No";
            if (ckdJueves.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        /// <summary>
        /// Metodo para validar si Viernes tiene el check
        /// </summary>
        /// <returns></returns>
        private string validarViernes()
        {
            string respuesta = "No";
            if (ckdViernes.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        /// <summary>
        /// Metodo para validar si Sábado tiene el check
        /// </summary>
        /// <returns></returns>
        private string validarSabado()
        {
            string respuesta = "No";
            if (ckdSabado.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        /// <summary>
        /// Metodo para validar si Domingo tiene el check
        /// </summary>
        /// <returns></returns>
        private string validarDomingo()
        {
            string respuesta = "No";
            if (ckdDomingo.Checked)
            {
                respuesta = "Sí";
            }
            return respuesta;
        }
        /// <summary>
        /// Método del botón aceptar,el cual verifica si el usuario preciono el botón aceptar o no,si lo hizo procede a revisar si no dejo
        /// algún espacio en blanco sino lo hizo creado un parámetro con los datos suministrados
        /// </summary>
        /// <param name="sender"></param>
      

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if ((this.txtIdParametro.Text == "") ||
               (this.txtHoraEntrada.Text == "") || (this.txtHoraSalida.Text == "") || (this.ValidarSeleccionDias() == false))
            {
                MessageBox.Show("Faltan datos requeridos");
                return;
            }
            this.oParametroL = new ParametroL(this.txtIdParametro.Text,
                                        DateTime.Parse(this.txtHoraEntrada.Text.ToString()),
                                        DateTime.Parse(this.txtHoraSalida.Text.ToString()),
                                        this.validarLunes(),
                                        this.validarMartes(),
                                        this.validarMiercoles(),
                                        this.validarJueves(),
                                        this.validarViernes(),
                                        this.validarSabado(),
                                        this.validarDomingo(),
                                        DateTime.Now,
                                        DateTime.Now, Program.oUsuarioLogueado.IdUsuario, Program.oUsuarioLogueado.IdUsuario,
                                        this.validarActivo());
            this.aceptar = true;
            this.Close();
        }

    }
}
