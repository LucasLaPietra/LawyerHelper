using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioPago : RepositorioGeneral<Pago, Contexto>, IRepositorioPago
    {
        public RepositorioPago(Contexto pContext) : base(pContext)
        {
        }

        public IList<Pago> BusquedaPagoPorFecha(DateTime pFecha)
        {
            DateTime iFecha = Convert.ToDateTime(pFecha.Date);
            List<Pago> iQuery = iContext.Pagos.Where(n => DbFunctions.TruncateTime(n.FechayHora) == iFecha).ToList();
            return iQuery;
        }
    }
}
