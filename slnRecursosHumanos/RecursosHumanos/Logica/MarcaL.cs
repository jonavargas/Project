using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;


namespace Logica
{
    public class MarcaL
    {
        /// <summary>
        /// Atributos de la clase MarcaL
        /// </summary>
        private int idMarca;
        private int idUnificacion;
        private string idEmpleado;
        private string nombreEmpleado;
        private DateTime fechaMarca;
        private string tipoMarca;
        private string estadoMarca;
        private bool buscarEmpleado = false;
        private bool buscarTipo = false;
        private AccesoDatosOracle cnx;
        private string creadoPor;
        private DateTime fechaCreacion;
        private string modificadoPor;
        private DateTime fechaModificacion;       

         
        /// Metodo constructor con parámetros

        public MarcaL(int pIdMarca, int pIdUnificacion, string pIdEmpleado, DateTime pFechaMarca,
                       string pTipoMarca, string pEstadoMarca, string pCreadoPor, DateTime pFechaCreacion, 
                       string pModificadoPor, DateTime pFechaModificacion, string pNombreEmpleado)
        {
            this.idMarca = pIdMarca;
            this.idUnificacion = pIdUnificacion;
            this.idEmpleado = pIdEmpleado;
            this.nombreEmpleado = pNombreEmpleado;
            this.fechaMarca = pFechaMarca;
            this.tipoMarca = pTipoMarca;
            this.estadoMarca = pEstadoMarca;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
        }


        public MarcaL(int pIdUnificacion, string pIdEmpleado, DateTime pFechaMarca,
                string pTipoMarca, string pEstadoMarca, string pCreadoPor, DateTime pFechaCreacion,
                string pModificadoPor, DateTime pFechaModificacion)
        {
            
            this.idUnificacion = pIdUnificacion;
            this.idEmpleado = pIdEmpleado;
            this.fechaMarca = pFechaMarca;
            this.tipoMarca = pTipoMarca;
            this.estadoMarca = pEstadoMarca;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
        }

        public MarcaL(AccesoDatosOracle pCnx)
        {
            this.cnx = pCnx;
        }


       /// <summary>
       /// Properties de la clase
       /// </summary>
       /// 
        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }

        public int IdUnificacion
        {
            get { return idUnificacion; }
            set { idUnificacion = value; }
        }

        public string IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public string NombreEmpleado
        {
            get { return nombreEmpleado; }
            set { nombreEmpleado = value; }
        }

        public DateTime FechaMarca
        {
            get { return fechaMarca; }
            set { fechaMarca = value; }
        }

        public string TipoMarca
        {
            get { return tipoMarca; }
            set { tipoMarca = value; }
        }

        public string EstadoMarca
        {
            get { return estadoMarca; }
            set { estadoMarca = value; }
        }

        public string CreadoPor
        {
            get { return creadoPor; }
            set { creadoPor = value; }
        }

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        public string ModificadoPor
        {
            get { return modificadoPor; }
            set { modificadoPor = value; }
        }

        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        public void validarTipoMarca(string pIdEmpleado)
        {
            this.idEmpleado = pIdEmpleado;

            MarcaD oMarcaD = new MarcaD(this.cnx);
            DataSet ObtenerTipoMarca = oMarcaD.TipoMarca(this.idEmpleado).Copy();

            
            if (ObtenerTipoMarca.Tables[0].Rows.Count > 0)
            {

                this.tipoMarca = ObtenerTipoMarca.Tables[0].Rows[0]["tipoMarca"].ToString();

                if (this.tipoMarca == "Entrada")
                {
                    this.tipoMarca = "Salida";
                    return;
                }
                if (this.tipoMarca == "Salida")
                {
                    this.tipoMarca = "Entrada";
                    return;
                }
            }
            else
            {
                this.tipoMarca = "Entrada";
            }
        }

        /// <summary>
        /// Metodo toString 
        /// </summary>
        /// <returns></returns>
        
        public override string ToString()
        {
            return  "ID Marca:" + this.IdMarca + "\n" +
                    "ID Empleado:" + this.IdEmpleado + "\n" +
                    "Estado Marca:" + this.estadoMarca + "\n" +
                    "Tipo de Marca:" + this.tipoMarca + "\n" +
                    "Creada por:" + this.CreadoPor + "\n" +
                    "Fecha de Creación:" + this.FechaCreacion + "\n" +
                    "Modificado Por:" + this.ModificadoPor + "\n" +
                    "Fecha de Modificación:" + this.FechaModificacion;
                    
        }
    }
}
