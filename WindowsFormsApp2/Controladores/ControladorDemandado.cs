using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Controladores
{
    class ControladorDemandado
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorDemandado(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public IList<Demandado> MostrarDemandados()
        {
            IList<Demandado> iQuery = iUdT.RepositorioDemandado.ObtenerTodos();
            return iQuery;
        }

        public IList<Demandado> MostrarDemandadosDeUnJuicio(Juicio pJuicio)
        {
            IList<Demandado> iQuery = iUdT.RepositorioDemandado.BuscarDemandadosDeUnJuicio(pJuicio.JuicioId);
            return iQuery;
        }

        public void BajaDemandadosDeUnJuicio(Juicio pJuicio)
        {
            IList<Demandado> iDemandados = MostrarDemandadosDeUnJuicio(pJuicio);
            foreach (Demandado iDemandado in iDemandados)
                BajaDemandado(iDemandado);
        }

        public void RegistrarDemandado(Boolean pCliente, Juicio pJuicio, Persona pPersona)
        {
            Demandado iDemandado = new Demandado(pCliente, pJuicio, pPersona);
            iUdT.RepositorioDemandado.Agregar(iDemandado);
            iUdT.Guardar();
        }

         public void BajaDemandado(Demandado pDemandado)
        {
            iUdT.RepositorioDemandado.Eliminar(pDemandado);
            iUdT.Guardar();
        }


    }
}
