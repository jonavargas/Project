using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public  class DepartamentoL
    {
        private string idDepartamento;
        private string nombreDepartamento;
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        private string modificadoPor;
        private string creadoPor;
        private string activo;

        public DepartamentoL(string pIdDepartamento, string pNombreDepartamento, DateTime pFechaModificacion, DateTime pFechaCreacion, string pCreadoPor, string pModificadoPor, string pActivo)
        {
            this.idDepartamento = pIdDepartamento;
            this.nombreDepartamento = pNombreDepartamento;
            this.fechaModificacion = pFechaModificacion;
            this.fechaCreacion = pFechaCreacion;
            this.creadoPor = pCreadoPor;
            this.modificadoPor = pModificadoPor;
            this.activo = pActivo;
        }   
         
        public string NombreDepartamento
        {
            get { return nombreDepartamento; }
            set { nombreDepartamento = value; }
        }

        public string IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
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

        public override string ToString()
        {
            return "Id Departamento: " + this.idDepartamento +
                   "Nombre Departamento: " + this.nombreDepartamento +
                   "Fecha de Modificación: " + this.fechaModificacion +
                   "Fecha de Creación: " + this.fechaCreacion +
                   "Creado por: " + this.creadoPor +
                   "Modificado por: " + this.modificadoPor +
                   "Activo: " + this.activo;
        }
    }
}
