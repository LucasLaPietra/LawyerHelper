using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    public class Cobro
    {
        public int CobroId { get; set; }
        public double Importe { get; set; }
        public DateTime FechayHora { get; set; }
        public String Detalle { get; set; }

        public Juicio Juicio { get; set; }
        public Persona Persona { get; set; }

        public bool Activo {get;  set;}

        
        public Cobro(double pImporte, DateTime pFechayHora, String pDetalle, Juicio pJuicio, Persona pPersona)
        {
            this.Importe = pImporte;
            this.FechayHora = pFechayHora;
            this.Detalle = pDetalle;
            this.Juicio = pJuicio;
            this.Persona = pPersona;
            this.Activo = true;
        }

        public Cobro()
        {
        }
    }
}
