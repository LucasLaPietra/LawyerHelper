using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LawyerHelper.Clases;

namespace LawyerHelper.Controladores
{
    class ControladorDemandante
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorDemandante(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public IList<Demandante> MostrarDemandantes()
        {
            IList<Demandante> iQuery = iUdT.RepositorioDemandante.ObtenerTodos();
            return iQuery;
        }

        public IList<Demandante> MostrarDemandantesDeUnJuicio(Juicio pJuicio)
        {
            IList<Demandante> iQuery = iUdT.RepositorioDemandante.BuscarDemandantesDeUnJuicio(pJuicio.JuicioId);
            return iQuery;
        }

        public void BajaDemandantesDeUnJuicio(Juicio pJuicio)
        {
            IList<Demandante> iDemandantes = MostrarDemandantesDeUnJuicio(pJuicio);
            foreach (Demandante iDemandante in iDemandantes)
                BajaDemandante(iDemandante);
        }

        public void RegistrarDemandante(Boolean pCliente, Juicio pJuicio, int pIdPersona)
            {
            ControladorPersona iControladorPersona = new ControladorPersona(iUdT);
            Persona iPersona = iControladorPersona.ObtenerPersona(pIdPersona);
            Demandante iDemandante = new Demandante(pCliente, pJuicio, iPersona);
            iUdT.RepositorioDemandante.Agregar(iDemandante);
            iUdT.Guardar();
        }

         public void BajaDemandante(Demandante pDemandante)
        {
            iUdT.RepositorioDemandante.Eliminar(pDemandante);
            iUdT.Guardar();
        }

    }
}
