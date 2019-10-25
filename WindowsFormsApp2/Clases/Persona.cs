using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
   public class Persona
    {
        public int PersonaId { get; set; }
        public String Nombre { get; set; }
        public String Apellido { get; set; }
        public String Dni { get; set; }
        public String Domicilio { get; set; }
        public String Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public String Profesion { get; set; }
        public String LugarTrabajo { get; set; }
        public String Cuil { get; set; }
        public String EstadoCivil { get; set; }
        public String Representante { get; set; }
        public String DomicilioLegal { get; set; }

        public IList<Cobro> Cobros { get; set; }
        public IList<Demandado> Demandado { get; set; }
        public IList<Demandante> Demandante { get; set; }

        public bool Activo {get;  set;}


        public Persona(String pNombre, String pApellido, String pDni, String pDomicilio, String pTelefono, DateTime pFechaNacimiento, String pProfesion, String pLugarTrabajo, String pCuil, String pEstadoCivil, String pRepresentante, String pDomicilioLegal)
        {
            this.Nombre = pNombre;
            this.Apellido = pApellido;
            this.Dni = pDni;
            this.Domicilio = pDomicilio;
            this.Telefono = pTelefono;
            this.FechaNacimiento = pFechaNacimiento;
            this.Profesion = pProfesion;
            this.LugarTrabajo = pLugarTrabajo;
            this.Cuil = pCuil;
            this.EstadoCivil = pEstadoCivil;
            this.Representante = pRepresentante;
            this.DomicilioLegal = pDomicilioLegal;
            this.Activo = true;
        }

        
        public Persona()
        {

        }

        
    }
}
