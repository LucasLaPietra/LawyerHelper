﻿using System;
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

        public virtual Juicio Juicio { get; set; }

        public string Descripcion
        {
            get { return FechayHora.ToShortDateString() + "- Juicio:" + Juicio.NroExpediente; }
        }

        public Pago(double pImporte, DateTime pFechayHora, String pDetalle, Juicio pJuicio)
        {
            this.Importe = pImporte;
            this.FechayHora = pFechayHora;
            this.Detalle = pDetalle;
            this.Juicio = pJuicio;
        }

        public Pago()
        {

        }

    }
}
