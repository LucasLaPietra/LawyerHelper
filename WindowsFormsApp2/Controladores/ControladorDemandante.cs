using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public RegistrarDemandante(Boolean pCliente, Juicio pJuicio, Persona pPersona)
            {
            Demandante iDemandante = new Demandante(pCliente, pJuicio, pPersona);
            iUdT.RepositorioDemandante.Agregar(iDemandante);
            iUdT.Guardar();
            //falta constructor de la clase
        }

         public BajaDemandante(Demandante pDemandante)
        {
            iUdT.RepositorioDemandante.Eliminar(pDemandante);
            iUdT.Guardar();
        }

    }
}
