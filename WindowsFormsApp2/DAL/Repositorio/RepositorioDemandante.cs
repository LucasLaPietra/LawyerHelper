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

        public IList<Demandante> BuscarDemandantesDeUnJuicio(int pId)
        {
            List<Demandante> iQuery = iContext.Demandantes.Where(n => n.Juicio.JuicioId == pId).ToList();
            return iQuery;
        }

        public IList<Demandante> BuscarDemandantesDeUnaPersona(int pId)
        {
            List<Demandante> iQuery = iContext.Demandantes.Where(n => n.Persona.PersonaId == pId).ToList();
            return iQuery;
        }
    }
}