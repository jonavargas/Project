using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public  class DepartamentoL
    {
       /// <summary>
       /// Atributos de la clase
       /// </summary>
        private string idDepartamento;
        private string nombreDepartamento;
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        private string modificadoPor;
        private string creadoPor;
        private string activo;

       /// <summary>
       /// Metodo constructor con parametros
       /// </summary>
       /// <param name="pIdDepartamento"></param>
       /// <param name="pNombreDepartamento"></param>
       /// <param name="pFechaModificacion"></param>
       /// <param name="pFechaCreacion"></param>
       /// <param name="pCreadoPor"></param>
       /// <param name="pModificadoPor"></param>
       /// <param name="pActivo"></param>
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
       /// <summary>
       /// Propiedades de los atributos
       /// </summary>
         
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
       /// <summary>
       /// Metodo ToString
       /// </summary>
       /// <returns></returns>

        public override string ToString()
        {
            return "Cod. Departamento: " + this.idDepartamento + "\n" +
                   "Nombre Departamento: " + this.nombreDepartamento + "\n" +
                   "Fecha de Modificación: " + this.fechaModificacion + "\n" +
                   "Fecha de Creación: " + this.fechaCreacion + "\n" +
                   "Creado por: " + this.creadoPor + "\n" +
                   "Modificado por: " + this.modificadoPor + "\n" +
                   "Activo: " + this.activo;
        }
    }
}
