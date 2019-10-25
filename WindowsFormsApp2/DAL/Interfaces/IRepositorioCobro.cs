using LawyerHelper.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Interfaces
{
    interface IRepositorioCobro : IRepositorioGeneral<Cobro>
    {
        IList<Cobro> BusquedaCobroPorFecha(DateTime pFecha);
    }
}
