using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class FechasDoblesL
    {
        private string detalleFechaDoble;
        private int dia;
        private string mes;
        private string creadoPor;
        private DateTime fechaCreacion;
        private string modificadoPor;
        private DateTime fechaModificacion;

        public FechasDoblesL(string pDetalleFechaDoble, int pDia, string pMes, string pCreadoPor, DateTime pFechaCreacion, string pModificadoPor, DateTime pFechaModificacion) 
        {
            this.detalleFechaDoble = pDetalleFechaDoble;
            this.dia = pDia;
            this.mes = pMes;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
        }

        public string DetalleFechaDoble
        {
            get { return detalleFechaDoble; }
            set { detalleFechaDoble = value; }
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

        public override string ToString()
        {
            return "Detalle de Fechas Dobles: " + this.DetalleFechaDoble + "\n" +
                   "Dia: " + this.Dia + "\n" +
                   "Mes: " + this.Mes + "\n" +
                   "Creado por: " + this.CreadoPor + "\n" +
                   "Fecha de Creación: " + this.FechaCreacion + "\n" +
                   "Modificado por: " + this.ModificadoPor + "\n" +
                   "Fecha de Modificación: " + this.FechaModificacion;
        }
    }
}
