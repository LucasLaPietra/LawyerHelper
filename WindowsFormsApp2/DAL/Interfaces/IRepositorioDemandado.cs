using LawyerHelper.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Interfaces
{
    interface IRepositorioDemandado : IRepositorioGeneral<Demandado>
    {
        IList<Demandado> BuscarDemandadosDeUnJuicio(int pId);
        IList<Demandado> BuscarDemandadosDeUnaPersona(int pId);
    }
}
