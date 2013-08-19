using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
    class PagosL
    {
        private int idPago;
        private DateTime fecha1;
        private DateTime fecha2;
        private double totalPagos;
        private double totalDeducciones;
        private string anulado;
        private string descripcion;
        private string creadoPor;
        private DateTime fechaCreacion;
        private string modificadoPor;
        private DateTime fechaModificacion;

        public PagosL(int pIdPago, DateTime pFecha1, DateTime pFecha2, double pTotalPagos, double pTotalDeducciones, 
                     string pAnulado, string pDescripcion, string pCreadoPor, DateTime pFechaCreacion, string pModificadoPor, 
                     DateTime pFechaModificacion)
        {
            this.idPago = pIdPago;
            this.fecha1 = pFecha1;
            this.fecha2 = pFecha2;
            this.totalPagos = pTotalPagos;
            this.totalDeducciones = pTotalDeducciones;
            this.anulado = pAnulado;
            this.descripcion = pDescripcion;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
        }

        public int IdPago
        {
            get { return idPago; }
            set { idPago = value; }
        }

        public DateTime Fecha1
        {
            get { return fecha1; }
            set { fecha1 = value; }
        }

        public DateTime Fecha2
        {
            get { return fecha2; }
            set { fecha2 = value; }
        }

        public double TotalPagos
        {
            get { return totalPagos; }
            set { totalPagos = value; }
        }

        public double TotalDeducciones
        {
            get { return totalDeducciones; }
            set { totalDeducciones = value; }
        }

        public string Anulado
        {
            get { return anulado; }
            set { anulado = value; }
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
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
            return  "ID Pago:" + this.IdPago + "\n" +
                    "Fecha Inicial:" + this.fecha1 + "\n" +
                    "Fecha Final:" + this.fecha2 + "\n" +
                    "Total Neto de Pago:" + this.totalPagos + "\n" +
                    "Total Deducciones:" + this.totalDeducciones + "\n" +
                    "Estado del Pago:" + this.anulado + "\n" +
                    "Descripción:" + this.descripcion + "\n" +
                    "Creado Por:" + this.CreadoPor + "\n" +
                    "Fecha Creación:" + this.FechaCreacion + "\n" +
                    "Modificado Por:" + this.ModificadoPor + "\n" +
                    "Fecha Modificación:" + this.FechaModificacion;
        }
    }
}
