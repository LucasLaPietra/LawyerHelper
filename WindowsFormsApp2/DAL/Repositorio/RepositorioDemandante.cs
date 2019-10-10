using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioDemandante : RepositorioGeneral<Demandante, Contexto>, IRepositorioDemandante
    {
        public RepositorioDemandante(Contexto pContext) : base(pContext)
        {
        }
    }
}