using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using LawyerHelper.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Controladores
{
    class ControladorCobro
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorCobro(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public IList<Cobro> MostrarCobros()
        {
            IList<Cobro> iQuery = iUdT.RepositorioCobro.ObtenerTodos();
            return iQuery;
        }
    }
}
