using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
  public  class CatalogoFechasL
    {
        private string idCatalogoFechas;       
        private int dia;       
        private string mes;        
        private string descripcion;       
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        private string modificadoPor;
        private string creadoPor;
        private string activo;

        public CatalogoFechasL(string pIdCatalogoFechas, int pDia, string pMes, string pDescripcion, DateTime pFechaModificacion, DateTime pFechaCreacion, string pCreadoPor, string pModificadoPor, string pActivo)
        {
            this.idCatalogoFechas = pIdCatalogoFechas;
            this.dia= pDia;
            this.mes= pMes;
            this.descripcion = pDescripcion;
            this.fechaCreacion = pFechaCreacion;
            this.fechaModificacion = pFechaModificacion;
            this.modificadoPor = pModificadoPor;
            this.creadoPor = pCreadoPor;
            this.activo = pActivo;
        }
        public string IdCatalogoFechas
        {
            get { return idCatalogoFechas; }
            set { idCatalogoFechas = value; }
        }
        public int Dia
        {
            get { return dia; }
            set { dia = value; }
        }
        public string Mes
        {
            get { return mes; }
            set { mes = value; }
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
        public override string ToString()
        {
            return "ID Catalogo de Fechas: " + this.idCatalogoFechas +
                   "Dia: " + this.dia+
                   "Mes: " + this.mes +
                   "Descripción: " + this.descripcion +
                   "Fecha de Modificación: " + this.fechaModificacion +
                   "Fecha de Creación: " + this.fechaCreacion +
                   "Creado por: " + this.creadoPor +
                   "Modificado por: " + this.modificadoPor +
                   "Activo: " + this.activo;
        }
    }

}
