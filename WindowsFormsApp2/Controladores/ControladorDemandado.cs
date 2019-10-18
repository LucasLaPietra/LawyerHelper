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

        public IList<Demandando> MostrarDemandados()
        {
            IList<Demandando> iQuery = iUdT.RepositorioDemandado.ObtenerTodos();
            return iQuery;
        }

        public RegistrarDemandado(Boolean pCliente, Juicio pJuicio, Persona pPersona)
            {
            Demandado iDemandado = new Demandado(pCliente, pJuicio, pPersona);
            iUdT.RepositorioDemandado.Agregar(iDemandado);
            iUdT.Guardar();
            //falta constructor de la clase
        }

         public BajaDemandado(Demandado pDemandado)
        {
            iUdT.RepositorioDemandado.Eliminar(pDemandado);
            iUdT.Guardar();
        }


    }
}
