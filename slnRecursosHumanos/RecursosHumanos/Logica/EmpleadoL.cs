using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class EmpleadoL
    {
        private string idDepartamento;
        private string nombreEmpleado;
        private string apellido1;
        private string apellido2;
        private int numCedula;
        private int telefono;
        private string fechaNacimiento;
        private double salarioPorHora;
        private string creadoPor;
        private DateTime fechaCreacion;
        private string modificadoPor;
        private DateTime fechaModificacion;
        private string activo;

        public EmpleadoL(string pIdDepartamento, string pNombreEmpleado, string pApellido1, string pApellido2, int pNumCedula, int pTelefono, string pFechaNacimiento, double pSalarioPorHora, string pCreadoPor, DateTime pFechaCreacion, string pModificadoPor, DateTime pFechaModificacion, string pActivo)
        {
            this.idDepartamento = pIdDepartamento;
            this.nombreEmpleado = pNombreEmpleado;
            this.apellido1 = pApellido1;
            this.apellido2 = pApellido2;
            this.numCedula = pNumCedula;
            this.telefono = pTelefono;
            this.fechaNacimiento = pFechaNacimiento;
            this.salarioPorHora = pSalarioPorHora;
            this.creadoPor = pCreadoPor;
            this.fechaCreacion = pFechaCreacion;
            this.modificadoPor = pModificadoPor;
            this.fechaModificacion = pFechaModificacion;
            this.activo = pActivo;
        }

        public string IdDepartamento
        {
            get { return idDepartamento; }
            set { idDepartamento = value; }
        }

        public string NombreEmpleado
        {
            get { return nombreEmpleado; }
            set { nombreEmpleado = value; }
        }

        public string Apellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public string Apellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public int NumCedula
        {
            get { return numCedula; }
            set { numCedula = value; }
        }

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public double SalarioPorHora
        {
            get { return salarioPorHora; }
            set { salarioPorHora = value; }
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

        public override string ToString()
        {
            return "ID Departamento: " + this.idDepartamento +
                   "Nombre Empleado: " + this.nombreEmpleado +
                   "Apellido 1: " + this.apellido1 +
                   "Apellido 2: " + this.apellido2 +
                   "Número deCedula: " + this.numCedula +
                   "Teléfono: " + this.telefono +
                   "Fecha Nacimiento: " + this.fechaNacimiento +
                   "Salario por Hora: " + this.salarioPorHora +
                   "Creado por: " + this.creadoPor +
                   "Fecha de Creación: " + this.fechaCreacion +
                   "Modificado por: " + this.modificadoPor +
                   "Fecha de Modificación: " + this.fechaModificacion +
                   "Activo: " + this.activo;
        }
    }
}
