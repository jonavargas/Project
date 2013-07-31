using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
     public class ParametroL
    {
         /// <summary>
         ///Atributos de la clase
         /// </summary>
        private string idParametro;
        private DateTime horaEntrada;       
        private DateTime horaSalida;       
        private string lunes;
        private string martes;       
        private string miercoles;       
        private string jueves;      
        private string viernes;      
        private string sabado;
        private string domingo;
        private DateTime fechaModificacion;       
        private DateTime fechaCreacion;      
        private string creadoPor;
        private string modificadoPor;
        private string activo;

        /// <summary>
        /// Metodo constructor con parametros
        /// </summary>
      
        public ParametroL(string pIdParametro, DateTime pHoraEntrada, DateTime pHoraSalida, string pLunes, string pMartes,
                           string pMiercoles, string pJueves, string pViernes, string pSabado, string pDomingo, DateTime pFechaModificacion, DateTime pFechaCreacion, string pCreadoPor, string pModificadoPor, string pActivo)
        {
            this.idParametro = pIdParametro;
            this.horaEntrada = pHoraEntrada;
            this.horaSalida = pHoraSalida;
            this.lunes= pLunes;
            this.martes = pMartes;
            this.miercoles = pMiercoles;
            this.jueves = pJueves;
            this.viernes =pViernes;
            this.sabado = pSabado;
            this.domingo = pDomingo;
            this.fechaModificacion = pFechaModificacion;
            this.fechaCreacion = pFechaCreacion;            
            this.creadoPor = pCreadoPor;
            this.modificadoPor = pModificadoPor;
            this.activo = pActivo;            
        }
         /// <summary>
         /// Propiedades de la clase
         /// </summary>

        public string IdParametro
        {
            get { return idParametro; }
            set { idParametro = value; }
        }
        public DateTime HoraEntrada
        {
            get { return horaEntrada; }
            set { horaEntrada = value; }
        }
        public DateTime HoraSalida
        {
            get { return horaSalida; }
            set { horaSalida = value; }
        }
        public string Lunes
        {
            get { return lunes; }
            set { lunes = value; }
        }
        public string Martes
        {
            get { return martes; }
            set { martes = value; }
        }
        public string Miercoles
        {
            get { return miercoles; }
            set { miercoles = value; }
        }
        public string Jueves
        {
            get { return jueves; }
            set { jueves = value; }
        }
        public string Viernes
        {
            get { return viernes; }
            set { viernes = value; }
        }
        public string Sabado
        {
            get { return sabado; }
            set { sabado = value; }
        }
        public string Domingo
        {
            get { return domingo; }
            set { domingo = value; }
        }
        public DateTime FechaModificacion
        {
            get { return fechaModificacion; }
            set { fechaModificacion = value; }
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
            return "Cod. Parametro: " + this.IdParametro + "\n" +
                   "Hora Entrada: " + this.HoraEntrada + "\n" +
                   "Hora Salida: " + this.HoraSalida + "\n" +
                   "Lunes: " + this.Lunes + "\n" +
                   "Martes: " + this.Martes + "\n" +
                   "Miércoles: " + this.Miercoles + "\n" +
                   "Jueves: " + this.Jueves + "\n" +
                   "Viernes: " + this.Viernes + "\n" +
                   "Sabado: " + this.Sabado + "\n" +
                   "Domingo: " + this.Domingo + "\n" +
                   "Fecha de Modificación: " + this.FechaModificacion + "\n" +
                   "Fecha de Creación: " + this.FechaCreacion + "\n" +
                   "Creado por: " + this.CreadoPor + "\n" +
                   "Modificado por: " + this.ModificadoPor + "\n" +
                   "Activo: " + this.Activo;
        }
    }
}
