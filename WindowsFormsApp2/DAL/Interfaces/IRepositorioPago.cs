using LawyerHelper.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Interfaces
{
    interface IRepositorioPago : IRepositorioGeneral<Pago>
    {
        IList<Pago> BusquedaPagoPorFecha(DateTime pFecha);
    }
}
