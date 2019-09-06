using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    class Persona
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
        public Demandado Demandado { get; set; }
        public Demandante Demandante { get; set; }

    }
}
