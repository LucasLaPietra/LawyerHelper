﻿using LawyerHelper.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Interfaces
{
    interface IRepositorioDemandante : IRepositorioGeneral<Demandante>
    {
        IList<Demandante> BuscarDemandantesDeUnJuicio(int pId);
        IList<Demandante> BuscarDemandantesDeUnaPersona(int pId);
    }
}
