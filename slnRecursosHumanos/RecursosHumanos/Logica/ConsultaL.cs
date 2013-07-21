using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
     public class ConsultaL
    {
         /// <summary>
        ///  Atributos de la clase
         /// </summary>
        private int idMarca;
        private string idEmpleado;
        private string idDepartamento;
        private string idUnificacion;
        private string nombreEmpleado;
        private DateTime fecha;
        private string tipo;
        private string estado;
        private string creadoPor;
        private DateTime fechaCreacion;
        private string modificadoPor;
        private DateTime fechaModificacion;      
         
         
         /// <summary>
         /// Metodo constructor
         

         public ConsultaL(int pIdMarca, string pIdEmpleado,string pIdDepartamento, string pIdUnificacion, string pNombreEmpleado,
                          DateTime pFecha, string pTipo, string pEstado, string pCreadoPor, DateTime pFechaCreacion, 
                          string pModificadoPor, DateTime pFechaModificacion)
         {
            this.idMarca = pIdMarca;         
            this.idEmpleado = pIdEmpleado;
            this.idDepartamento = pIdDepartamento;
            this.idUnificacion = pIdUnificacion;
            this.nombreEmpleado = pNombreEmpleado;
            this.fecha = pFecha;
            this.tipo = pTipo;
            this.estado = pEstado;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;      
            this.fechaModificacion = pFechaModificacion;
         }

         /// <summary>
         /// Propiedades de los atributos
         /// </summary>
         public int IdMarca
         {
             get { return idMarca; }
             set { idMarca = value; }
         }
         public string IdEmpleado
         {
             get { return idEmpleado; }
             set { idEmpleado = value; }
         }

         public string IdDepartamento
         {
             get { return idDepartamento; }
             set { idDepartamento = value; }
         }
         public string IdUnificacion
         {
             get { return idUnificacion; }
             set { idUnificacion = value; }
         }
         public string NombreEmpleado
         {
             get { return nombreEmpleado; }
             set { nombreEmpleado = value; }
         }
         public DateTime Fecha
         {
             get { return fecha; }
             set { fecha = value; }
         }
         public string Tipo
         {
             get { return tipo; }
             set { tipo = value; }
         }
         public string Estado
         {
             get { return estado; }
             set { estado = value; }
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
         /// <summary>
         /// Metodo ToString 
         /// </summary>
         /// <returns></returns>

         public override string ToString()
         {
             return "Id Marca: " + this.IdMarca +
                    "Id Empleado: " + this.idEmpleado +
                    "Id Unificación: " + this.idUnificacion +
                    "Nombre de Empleado: " + this.nombreEmpleado +
                    "Fecha: " + this.fecha +                     
                    "Tipo: " + this.tipo +
                    "Estado: " + this.estado +                                       
                    "Fecha de Modificación: " + this.fechaModificacion +
                    "Fecha de Creación: " + this.fechaCreacion +
                    "Creado por: " + this.creadoPor +
                    "Modificado por: " + this.modificadoPor;
                    
         }

         
         

        



    }
}
