using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class DeduccionesL
    {
       /// <summary>
       /// Atributos de la clase
       /// </summary>
        private string idDeducciones;
        private double porcentaje;
        private string descripcion;       
        private DateTime fechaCreacion;        
        private DateTime fechaModificacion;
        private string modificadoPor;     
        private string creadoPor;        
        private string activo;

       /// <summary>
       /// Metodo constructor con parametros
       /// </summary>
       /// <param name="pIdDeducciones"></param>
       /// <param name="pPorcentaje"></param>
       /// <param name="pDescripcion"></param>
       /// <param name="pFechaModificacion"></param>
       /// <param name="pFechaCreacion"></param>
       /// <param name="pCreadoPor"></param>
       /// <param name="pModificadoPor"></param>
       /// <param name="pActivo"></param>
        public DeduccionesL(string pIdDeducciones, double pPorcentaje, string pDescripcion, DateTime pFechaModificacion, DateTime pFechaCreacion, string pCreadoPor, string pModificadoPor, string pActivo)
        {
            this.idDeducciones = pIdDeducciones;
            this.porcentaje = pPorcentaje;
            this.descripcion = pDescripcion;
            this.fechaModificacion = pFechaModificacion;
            this.fechaCreacion = pFechaCreacion;            
            this.creadoPor = pCreadoPor;
            this.modificadoPor = pModificadoPor;
            this.activo = pActivo;
        }
       /// <summary>
       /// Propiedades de los atributos
       /// </summary>
        public string IdDeducciones
        {
            get { return idDeducciones; }
            set { idDeducciones = value; }
        }
        public double Porcentaje
        {
            get { return porcentaje; }
            set { porcentaje = value; }
        } 
       
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
            return "ID Deducciones: " + this.IdDeducciones +
                   "Porcentaje: " + this.Porcentaje+
                   "Descripción" + this.Descripcion +
                   "Fecha de Modificación" + this.FechaModificacion +
                   "Fecha de Creación" + this.FechaCreacion +                  
                   "Creado por" + this.CreadoPor +
                   "Modificado por" + this.ModificadoPor +
                   "Activo:" + this.Activo;
        }
    }
}
