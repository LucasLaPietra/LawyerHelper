using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioJuicio : RepositorioGeneral<Juicio, Contexto>, IRepositorioJuicio
    {
        public RepositorioJuicio(Contexto pContext) : base(pContext)
        {
        }
    }
}