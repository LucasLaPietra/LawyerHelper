using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioPersona:RepositorioGeneral<Persona,Contexto>,IRepositorioPersona
    {
        public RepositorioPersona(Contexto pContext):base(pContext)
        {
        }
    }
}
