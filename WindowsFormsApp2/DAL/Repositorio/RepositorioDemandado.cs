using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioDemandado : RepositorioGeneral<Demandado, Contexto>, IRepositorioDemandado
    {
        public RepositorioDemandado(Contexto pContext) : base(pContext)
        {
            
        }

        public IList<Demandado> BuscarDemandadosDeUnJuicio(int pId)
        {
            List<Demandado> iQuery = iContext.Demandados.Where(n => n.Juicio.JuicioId == pId).ToList();
            return iQuery;
        }

        public IList<Demandado> BuscarDemandadosDeUnaPersona(int pId)
        {
            List<Demandado> iQuery = iContext.Demandados.Where(n => n.Persona.PersonaId == pId).ToList();
            return iQuery;
        }
    }
}