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
        private string idMarca;       
        private string idEmpleado;
        private string idDepartamento;  
        private string estadoMarca;
        private DateTime fechaMarca;
        private string tipoMarca;
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        private string modificadoPor;
        private string creadoPor;
        private string activo;
        

         /// <summary>
        /// Metodo constructor con parametros
        /// </summary>
        /// <param name="pIdMarca"></param>
        /// <param name="pIdEmpleado"></param>
        /// <param name="pIdDepartamento"></param>
        /// <param name="pEstadoMarca"></param>
        /// <param name="pFechaMarca"></param>
        /// <param name="pTipoMarca"></param>
        /// <param name="pFechaModificacion"></param>
        /// <param name="pFechaCreacion"></param>
        /// <param name="pCreadoPor"></param>
        /// <param name="pModificadoPor"></param>
        /// <param name="pActivo"></param>
        public MarcaL(string pIdMarca, string pIdEmpleado, string pIdDepartamento, string pEstadoMarca, DateTime pFechaMarca, string pTipoMarca, DateTime pFechaModificacion, DateTime pFechaCreacion, string pCreadoPor, string pModificadoPor, string pActivo)
        {
            this.idMarca = pIdMarca;
            this.idEmpleado = pIdEmpleado;
            this.idDepartamento = pIdDepartamento;
            this.estadoMarca = pEstadoMarca;
            this.fechaMarca = pFechaMarca;
            this.tipoMarca = pTipoMarca;
            this.fechaModificacion = pFechaModificacion;
            this.fechaCreacion = pFechaCreacion;
            this.creadoPor = pCreadoPor;
            this.modificadoPor = pModificadoPor;
            this.activo = pActivo;
        }

        /// <summary>
        /// Propiedades de la clase
        /// </summary>
        public string IdMarca
        {
            get { return idMarca; }
            set { idMarca = value; }
        }

        public string IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }

        public string EstadoMarca
        {
            get { return estadoMarca; }
            set { estadoMarca = value; }
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

        public DateTime FechaCreacion
        {
            get { return fechaCreacion; }
            set { fechaCreacion = value; }
        }

        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
        }

        public string ModificadoPor
        {
            get { return modificadoPor; }
            set { modificadoPor = value; }
        }

        public string CreadoPor
        {
            get { return creadoPor; }
            set { creadoPor = value; }
        }

        public string Activo
        {
            get { return activo; }
            set { activo = value; }
        }

        /// <summary>
        /// Metodo toString 
        /// </summary>
        /// <returns></returns>
        /// MODIFICARLO
        public override string ToString()
        {
            return "Id Departamento: " + this.idDepartamento +                   
                   "Fecha de Modificación: " + this.fechaModificacion +
                   "Fecha de Creación: " + this.fechaCreacion +
                   "Creado por: " + this.creadoPor +
                   "Modificado por: " + this.modificadoPor +
                   "Activo: " + this.activo;
        }



    }


}
