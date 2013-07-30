using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Text;
using Datos;
using Logica;

namespace GUI
{
    public partial class frmRegistroMarcas : Form
    {
        /// <summary>
        /// Atributos de la clase frmRegistroMarcas 
        /// </summary>
        /// 
        AccesoDatosOracle cnx;

        /// <summary>
        /// Atributos necesarios para cargar el tipo de fuente personalizada
        /// </summary>
        /// <param name="pbFont"></param>
        /// <param name="cbFont"></param>
        /// <param name="pdv"></param>
        /// <param name="pcFonts"></param>
        /// <returns></returns>

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);
        FontFamily ff;
        Font font;

        public frmRegistroMarcas(AccesoDatosOracle pConexion)
        {
            InitializeComponent();
            timReloj.Start();
            this.cnx = pConexion;
            this.txtCodigoEmpleado.Focus();

        }
        /// <summary>
        /// Evento del botón Marcar que realiza la marca en la base de datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnMarcar_Click(object sender, EventArgs e)
        {
            int contMarcas = 1;
            int contUnificacion = 1;
            MarcaD oMarcaD = new MarcaD(this.cnx);
            EmpleadoD oEmpleadoD = new EmpleadoD(this.cnx);
            List<EmpleadoL> empleado = oEmpleadoD.buscarEmpleado(this.txtCodigoEmpleado.Text);

            if (txtCodigoEmpleado.Text != "")
            {

                if (empleado.Count > 0)
                {
                    MarcaL oMarcaL = new MarcaL(contMarcas, contUnificacion, txtCodigoEmpleado.Text, "Generada", oMarcaD.tipoMarca(txtCodigoEmpleado.Text), DateTime.Now, "Empleado", DateTime.Now, "Empleado", DateTime.Now, "Sí");
                    oMarcaD.agregarMarca2(oMarcaL);
                    txtCodigoEmpleado.Text = "";
                }
                else
                {
                    MessageBox.Show("El empleado no existe ó se encuentra inactivo en la empresa");
                    txtCodigoEmpleado.Text = "";
                }
            }
        }
        /// <summary>
        /// Evento de teclado que nos permite salir de la pantalla presionando la tecla Esc
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void frmRegistroMarcas_KeyDown(object sender, KeyEventArgs e)
       {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

            if (e.KeyCode == Keys.Enter)
            {
                this.btnMarcar_Click(sender, e);
            }
        }

        /// <summary>
        /// Método encargado de cargar la funte personalizada
        /// </summary>
        /// 
        private void CargoPrivateFontCollection()
        {
            
            byte[] fontArray = RecursosHumanos.Properties.Resources.Radioland;
            int dataLength = RecursosHumanos.Properties.Resources.Radioland.Length;


           
            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);


            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();
           
            pfc.AddMemoryFont(ptrData, dataLength);

      
            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];
            font = new Font(ff, 15f, FontStyle.Bold);
        }

        /// <summary>
        /// Método encargado de elegir el tamaña y el tipo de fuente
        /// </summary>
        /// <param name="font"></param>
        /// 
        private void CargoEtiqueta(Font font)
        {
            float size = 48f;
            FontStyle fontStyle = FontStyle.Regular;

            this.lblReloj.Font = new Font(ff, size, fontStyle);

        }

        /// <summary>
        /// Evento encargado de iniciar el reloj y la fuente personalizada de esté al iniciar la aplicación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        private void timReloj_Tick(object sender, EventArgs e)
        {
            this.lblReloj.Text = DateTime.Now.ToLongTimeString();
            this.lblFecha.Text = DateTime.Now.ToLongDateString();
            CargoPrivateFontCollection();
            CargoEtiqueta(font);
        }

        private void frmRegistroMarcas_Load(object sender, EventArgs e)
        {
            this.txtCodigoEmpleado.Focus();
        }
    }
}
