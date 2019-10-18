using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    public class Demandante
    {
        public int DemandanteId { get; set; }
        public Boolean Cliente { get; set; }

        public Juicio Juicio { get; set; }
        public Persona Persona { get; set; }

        public Demandante(Boolean pCliente, Juicio pJuicio, Persona pPersona)
        {
            this.Cliente = pCliente;
            this.Juicio = pJuicio;
            this.Persona = pPersona;
        }
    }
}
