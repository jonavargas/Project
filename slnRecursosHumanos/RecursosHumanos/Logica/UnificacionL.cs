using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
   public class UnificacionL
    {
        private int idUnificacion;        
        private string idEmpleado;       
        private int idPago;        
        private DateTime fechaUnificacion;        
        private double HorasRegulares;        
        private double HorasExtras;       
        private double HorasDobles;        
        private string aprobacionExtra;        
        private string detalleAprobacionExtra;       
        private double porcentajeDeduccion;
        private double pagoRegular;       
        private double pagoExtra;       
        private double pagoDoble;       
        private double montoDeduccion;        
        private string estadoUnificacion;       
        private double salarioBruto;       
        private double montoUnificacion;       
        private string creadoPor;
        private DateTime fechaCreacion;        
        private string modificadoPor;       
        private DateTime fechaModificacion;        
        private string activo;       
        private string nombreCompleto;

       

        public UnificacionL(int pIdUnificacion, string pIdEmpleado, int pIdPago, DateTime pFechaUnificacion, double pHorasRegulares,
                             double pHorasExtras, double pHorasDobles, string pAprobacionExtra, string pDetalleAprobacionExtra,
                             double pPorcentajeDeduccion, double pPagoRegular, double pPagoExtra, double pPagoDoble, double pMontoDeduccion,
                             string pEstadoUnificacion, double pSalarioBruto, double pMontoUnificacion, string pCreadoPor, DateTime pFechaCreacion,
                             string pModificadoPor, DateTime pFechaModificacion,string pactivo)
        {
            this.idUnificacion = pIdUnificacion;
            this.idEmpleado = pIdEmpleado;
            this.idPago = pIdPago;
            this.fechaUnificacion = pFechaUnificacion;
            this.HorasRegulares = pHorasRegulares;
            this.HorasExtras = pHorasExtras;
            this.HorasDobles = pHorasDobles;
            this.aprobacionExtra = pAprobacionExtra;
            this.detalleAprobacionExtra = pDetalleAprobacionExtra;
            this.porcentajeDeduccion = pPorcentajeDeduccion;
            this.pagoRegular = pPagoRegular;
            this.pagoExtra = pPagoExtra;
            this.pagoDoble = pPagoDoble;
            this.montoDeduccion = pMontoDeduccion;
            this.estadoUnificacion = pEstadoUnificacion;
            this.salarioBruto = pSalarioBruto;
            this.montoUnificacion = pMontoUnificacion;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
            this.activo = pactivo;


        
        }

        public UnificacionL(int pIdUnificacion, string pIdEmpleado, int pIdPago, DateTime pFechaUnificacion, double pHorasRegulares,
                             double pHorasExtras, double pHorasDobles, string pAprobacionExtra, string pDetalleAprobacionExtra,
                             double pPorcentajeDeduccion, double pPagoRegular, double pPagoExtra, double pPagoDoble, double pMontoDeduccion,
                             string pEstadoUnificacion, double pSalarioBruto, double pMontoUnificacion, string pCreadoPor, DateTime pFechaCreacion,
                             string pModificadoPor, DateTime pFechaModificacion,string pnombreCompleto, string pactivo)
        {

            this.idUnificacion = pIdUnificacion;
            this.idEmpleado = pIdEmpleado;
            this.idPago = pIdPago;
            this.fechaUnificacion = pFechaUnificacion;
            this.HorasRegulares = pHorasRegulares;
            this.HorasExtras = pHorasExtras;
            this.HorasDobles = pHorasDobles;
            this.aprobacionExtra = pAprobacionExtra;
            this.detalleAprobacionExtra = pDetalleAprobacionExtra;
            this.porcentajeDeduccion = pPorcentajeDeduccion;
            this.pagoRegular = pPagoRegular;
            this.pagoExtra = pPagoExtra;
            this.pagoDoble = pPagoDoble;
            this.montoDeduccion = pMontoDeduccion;
            this.estadoUnificacion = pEstadoUnificacion;
            this.salarioBruto = pSalarioBruto;
            this.montoUnificacion = pMontoUnificacion;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
            this.nombreCompleto = pnombreCompleto;
            this.activo = pactivo;
        
        
        
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
        public int IdPago
        {
            get { return idPago; }
            set { idPago = value; }
        }
        public DateTime FechaUnificacion
        {
            get { return fechaUnificacion; }
            set { fechaUnificacion = value; }
        }
        public double HorasRegulares1
        {
            get { return HorasRegulares; }
            set { HorasRegulares = value; }
        }
        public double HorasExtras1
        {
            get { return HorasExtras; }
            set { HorasExtras = value; }
        }
        public double HorasDobles1
        {
            get { return HorasDobles; }
            set { HorasDobles = value; }
        }
        public string AprobacionExtra
        {
            get { return aprobacionExtra; }
            set { aprobacionExtra = value; }
        }
        public string DetalleAprobacionExtra
        {
            get { return detalleAprobacionExtra; }
            set { detalleAprobacionExtra = value; }
        }
        public double PorcentajeDeduccion
        {
            get { return porcentajeDeduccion; }
            set { porcentajeDeduccion = value; }
        }
        public double PagoRegular
        {
            get { return pagoRegular; }
            set { pagoRegular = value; }
        }
        public double PagoExtra
        {
            get { return pagoExtra; }
            set { pagoExtra = value; }
        }
        public double PagoDoble
        {
            get { return pagoDoble; }
            set { pagoDoble = value; }
        }
        public double MontoDeduccion
        {
            get { return montoDeduccion; }
            set { montoDeduccion = value; }
        }
        public string EstadoUnificacion
        {
            get { return estadoUnificacion; }
            set { estadoUnificacion = value; }
        }
        public double SalarioBruto
        {
            get { return salarioBruto; }
            set { salarioBruto = value; }
        }
        public double MontoUnificacion
        {
            get { return montoUnificacion; }
            set { montoUnificacion = value; }
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
        public string NombreCompleto
        {
            get { return nombreCompleto; }
            set { nombreCompleto = value; }
        }
        public override string ToString()
        {
            return  "ID Unificacion:"+this.IdUnificacion+"\n"+
                    "ID Empleado:"+this.IdEmpleado+"\n"+
                    "ID Pago:"+this.IdPago+"\n"+
                    "Fecha Unificacion:"+this.FechaUnificacion+"\n"+
                    "Horas Regulares:"+this.HorasExtras1+"\n"+
                    "Horas Extra:"+this.HorasExtras1+"\n"+
                    "Horas Dobles:"+this.HorasDobles1+"\n"+
                    "Aprovación horas Extra:"+this.AprobacionExtra+"\n"+
                    "Detalle de aprovación horas extra:"+this.DetalleAprobacionExtra+"\n"+
                    "Porcentaje de Deducción:"+this.PorcentajeDeduccion+"\n"+
                    "Monto de horas Regulares:"+this.PagoRegular+"\n"+
                    "Monto de horas Extra:"+this.PagoExtra+"\n"+
                    "Monto de horas Dobles:"+this.PagoDoble+"\n"+
                    "Monto Deducciones:"+this.MontoDeduccion+"\n"+
                    "Estado Unificación:"+this.EstadoUnificacion+"\n"+
                    "Salario Bruto:"+this.SalarioBruto+"\n"+
                    "Estado Unificación:"+this.EstadoUnificacion+"\n"+
                    "Monto Unificación:"+this.MontoUnificacion+"\n"+
                    "Creado Por:"+this.CreadoPor+"\n"+
                    "Fecha Creación:"+this.FechaCreacion+"\n"+
                    "Modificado Por:"+this.ModificadoPor+"\n"+
                    "Fecha Modificación:"+this.FechaModificacion+"\n"+
                    "Nombre Completo:"+this.NombreCompleto+"\n"+
                    "Activo:"+this.Activo;   
   
        }


    }
}
