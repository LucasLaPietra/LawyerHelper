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
    class RepositorioCobro : RepositorioGeneral<Cobro, Contexto>, IRepositorioCobro
    {
        public RepositorioCobro(Contexto pContext) : base(pContext)
        {
            
        }

        public IList<Cobro> BusquedaCobroPorFecha(DateTime pFecha)
        {
            DateTime iFecha = Convert.ToDateTime(pFecha.Date);
            List<Cobro> iQuery = iContext.Cobros.Where(n => DbFunctions.TruncateTime(n.FechayHora) == iFecha).ToList();
            return iQuery;
        }
    }
}
