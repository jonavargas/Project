using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class MarcaL
    {
        /// <summary>
        /// Atributos de la clase MarcaL
        /// </summary>
        private int idMarca;
        private string idEmpleado;
        private string estadoMarca;
        private string tipoMarca;
        private string creadoPor;
        private DateTime fechaCreacion;
        private string modificadoPor;
        private DateTime fechaModificacion;
        private string activo;



        /// Metodo constructor con parámetros

        public MarcaL(int pIdMarca, string pIdEmpleado, string pEstadoMarca, string pTipoMarca, string pCreadoPor, DateTime pFechaCreacion, string pModificadoPor, DateTime pFechaModificacion, string pActivo)
        {
            this.idMarca = pIdMarca;
            this.idEmpleado = pIdEmpleado;
            this.estadoMarca = pEstadoMarca;
            this.tipoMarca = pTipoMarca;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
            this.activo = pActivo;
        }
        public MarcaL(string pIdEmpleado, string pEstadoMarca, string pTipoMarca, string pCreadoPor, DateTime pFechaCreacion, string pModificadoPor, DateTime pFechaModificacion, string pActivo)
        {

            this.idEmpleado = pIdEmpleado;
            this.estadoMarca = pEstadoMarca;
            this.tipoMarca = pTipoMarca;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
            this.activo = pActivo;
        }

        public MarcaL()
        {

        }

        /// <summary>
        /// Properties de la clase
        /// </summary>
        public int IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }

        public string EstadoMarca
        {
            get { return estadoMarca; }
            set { estadoMarca = value; }
        }

        public string TipoMarca
        {
            get { return tipoMarca; }
            set { tipoMarca = value; }
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

        public string Activo
        {
            get { return activo; }
            set { activo = value; }
        }
        public string IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        /// <summary>
        /// Metodo toString 
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return "ID Marca:" + this.IdMarca + "\n" +
                    "ID Empleado:" + this.IdEmpleado + "\n" +
                    "Estado Marca:" + this.EstadoMarca + "\n" +
                    "Tipo de Marca:" + this.TipoMarca + "\n" +
                    "Creada por:" + this.CreadoPor + "\n" +
                    "Fecha de Creación:" + this.FechaCreacion + "\n" +
                    "Modificado Por:" + this.ModificadoPor + "\n" +
                    "Fecha de Modificación:" + this.FechaModificacion + "\n" +
                    "Activo:" + this.Activo;
        }
    }
}
