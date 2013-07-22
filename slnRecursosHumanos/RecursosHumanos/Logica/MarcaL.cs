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
        private DateTime fecha;
        private string tipo;
        private string estado;
        private bool buscarEmpleado = false;
        private bool buscarTipo = false;
        private AccesoDatosOracle cnx;
        private string creadoPor;
        private DateTime fechaCreacion;
        private string modificadoPor;
        private DateTime fechaModificacion;       

         
        /// Metodo constructor con parámetros
       
         public MarcaL(int pIdMarca, int pIdUnificacion, string pIdEmpleado, DateTime pFecha, 
                       string pTipo, string pEstado, string pCreadoPor, DateTime pFechaCreacion, 
                       string pModificadoPor, DateTime pFechaModificacion, string pNombreEmpleado)
        {
            this.idMarca = pIdMarca;
            this.idUnificacion = pIdUnificacion;
            this.idEmpleado = pIdEmpleado;
            this.nombreEmpleado = pNombreEmpleado;
            this.fecha = pFecha;
            this.tipo = pTipo;
            this.estado = pEstado;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
        }

     
       public MarcaL(int pIdUnificacion, string pIdEmpleado, DateTime pFecha,
                string pTipo, string pEstado, string pCreadoPor, DateTime pFechaCreacion,
                string pModificadoPor, DateTime pFechaModificacion)
        {
            
            this.idUnificacion = pIdUnificacion;
            this.idEmpleado = pIdEmpleado;
            this.fecha = pFecha;
            this.tipo = pTipo;
            this.estado = pEstado;
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

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
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

        public void validarTipo(string pIdEmpleado)
        {
            this.idEmpleado = pIdEmpleado;

            MarcaD oMarcaD = new MarcaD(this.cnx);
            DataSet ObtenerTipoMarca = oMarcaD.TipoMarca(this.idEmpleado).Copy();

            
            if (ObtenerTipoMarca.Tables[0].Rows.Count > 0)
            {
                
                this.tipo = ObtenerTipoMarca.Tables[0].Rows[0]["tipo"].ToString();

                if (this.tipo == "Entrada")
                {
                    this.tipo = "Salida";
                    return;
                }
                if (this.tipo == "Salida")
                {
                    this.tipo = "Entrada";
                    return;
                }
            }
            else
            {
                this.tipo = "Entrada";
            }
        }

        /// <summary>
        /// Metodo toString 
        /// </summary>
        /// <returns></returns>
        
        public override string ToString()
        {
            return "ID Marca:" + this.IdMarca + "\n" +
                    "ID Empleado:" + this.IdEmpleado + "\n" +
                    "Estado Marca:" + this.estado + "\n" +
                    "Tipo de Marca:" + this.Tipo + "\n" +
                    "Creada por:" + this.CreadoPor + "\n" +
                    "Fecha de Creación:" + this.FechaCreacion + "\n" +
                    "Modificado Por:" + this.ModificadoPor + "\n" +
                    "Fecha de Modificación:" + this.FechaModificacion;
                    
        }
    }
}
