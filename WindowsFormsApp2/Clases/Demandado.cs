using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    public class Demandado
    {
        public int DemandadoId { get; set; }
        public Boolean Cliente { get; set; }

        public virtual Juicio Juicio { get; set; }
        public virtual Persona Persona { get; set; }

        public bool Activo {get;  set;}

        public string Descripcion
        {
            get
            {
                if (Cliente==true)
                {
                    return Persona.Nombre + " " + Persona.Apellido + "-Cliente";
                }
                else
                {
                    return Persona.Nombre + " " + Persona.Apellido;
                }
                 
            }
        }

        public Demandado(Boolean pCliente, Juicio pJuicio, Persona pPersona)
        {
            this.Cliente = pCliente;
            this.Juicio = pJuicio;
            this.Persona = pPersona;
            this.Activo = true;          
        }

        public Demandado()
        {
        }
    }
}
