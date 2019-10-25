using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    public class Pago
    {
        public int PagoId { get; set; }
        public double Importe { get; set; }
        public DateTime FechayHora { get; set; }
        public String Detalle { get; set; }

        public Juicio Juicio { get; set; }

        public bool Activo {get;  set;}


        public Pago(double pImporte, DateTime pFechayHora, String pDetalle)
        {
            this.Importe = pImporte;
            this.FechayHora = pFechayHora;
            this.Detalle = pDetalle;
        }

        public Pago()
        {

        }

    }
}
