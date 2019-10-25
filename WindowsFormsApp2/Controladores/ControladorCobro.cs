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

        public void RegistrarCobro(double pImporte, DateTime pFechayHora, string pDetalle, Juicio pJuicio, Persona pPersona)
        {
            Cobro iCobro = new Cobro(pImporte, pFechayHora, pDetalle, pJuicio,pPersona);
            iUdT.RepositorioCobro.Agregar(iCobro);
            iUdT.Guardar();
        }

        public void BajaCobro(Cobro pCobro)
        {
            iUdT.RepositorioCobro.Eliminar(pCobro);
            iUdT.Guardar();
        }

        public Cobro ObtenerCobro(int pId)
        {
            return iUdT.RepositorioCobro.Obtener(pId);
        }

    }
}
