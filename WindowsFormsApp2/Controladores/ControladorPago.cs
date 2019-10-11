using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Controladores
{
    class ControladorPago
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorPago(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public IList<Pago> MostrarPagos()
        {
            Contexto iContexto = new Contexto();
            IList<Pago> iQuery = new List<Pago>();
            foreach (Pago pago in iContexto.Pagos)
            {
                iQuery.Add(pago);
            }
            return iQuery;
        }
    }
}
