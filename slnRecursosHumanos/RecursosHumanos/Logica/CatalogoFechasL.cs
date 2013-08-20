using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;

namespace Logica
{
  public  class CatalogoFechasL
    {
      /// <summary>
      /// Atributos de la clase
      /// </summary>
        private string idCatalogoFechas;       
        private int dia;       
        private string mes;        
        private string descripcion;       
        private DateTime fechaCreacion;
        private DateTime fechaModificacion;
        private string modificadoPor;
        private string creadoPor;
        private string activo;
        bool retorno = false;
        AccesoDatosOracle conexion;

      /// <summary>
      /// Metodo constructor con parametros
      /// </summary>
      /// <param name="pIdCatalogoFechas"></param>
      /// <param name="pDia"></param>
      /// <param name="pMes"></param>
      /// <param name="pDescripcion"></param>
      /// <param name="pFechaModificacion"></param>
      /// <param name="pFechaCreacion"></param>
      /// <param name="pCreadoPor"></param>
      /// <param name="pModificadoPor"></param>
      /// <param name="pActivo"></param>
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
        public CatalogoFechasL()
        {
            
        }
      /// <summary>
      /// Propiedades de los atributos
      /// </summary>
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


        public bool validarFecha(DateTime pFechaEntrada)
        {
            this.retorno = false;
            DateTime fechaConvertidaCatalogo;
            DateTime fechaConvertidaParametro;

            CatalogoFechasD oFechas = new CatalogoFechasD(this.conexion);
            List<CatalogoFechasL> listaFechas = oFechas.obtenerCatalogoFechas();

            int indice = listaFechas.Count;

            if (listaFechas.Count != 0)
            {
                for (int contador = 0; contador < indice; contador++)
                {
                    fechaConvertidaCatalogo = Convert.ToDateTime((listaFechas[contador].Dia + "/" + listaFechas[contador].Mes));
                    fechaConvertidaParametro = Convert.ToDateTime(pFechaEntrada.Day + "/" + pFechaEntrada.Month);

                    if (fechaConvertidaParametro == fechaConvertidaCatalogo)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }

        public double horasDobles(TimeSpan pHoras)
        {
            string horasEnteras = pHoras.ToString();
            string[] listaHoras = horasEnteras.Split(':');

            double horas = Double.Parse(listaHoras[0].ToString());
            int minutos = ((int.Parse(listaHoras[1].ToString())) * 100 / 60);
            double horasConvertidas = (Double.Parse(horas + "." + minutos));

            return horasConvertidas;
        }






      /// <summary>
      /// Metodo Tostring
      /// </summary>
      /// <returns></returns>
        public override string ToString()
        {
            return "Cod. Catalogo de Fechas: " + this.idCatalogoFechas + "\n" +
                   "Dia: " + this.dia + "\n" +
                   "Mes: " + this.mes + "\n" +
                   "Descripción: " + this.descripcion + "\n" +
                   "Fecha de Modificación: " + this.fechaModificacion + "\n" +
                   "Fecha de Creación: " + this.fechaCreacion + "\n" +
                   "Creado por: " + this.creadoPor + "\n" +
                   "Modificado por: " + this.modificadoPor + "\n" +
                   "Activo: " + this.activo;
        }
    }

}
