using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Controladores
{
    class ControladorJuicio
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorJuicio(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public void RegistrarJuicio(string pNroExpediente, string pJuez, string pSecretario, string pEtapa,
            string pDescripcion, string pBienes, DateTime pFecha, string pGrupoFamiliar, string pTipoProceso,
            string pRecurso, string pCompetencia, string pFuero, string pCaratula, string pFolio, string pLibro,
            string pJurisdiccion, Double pPrecio)
            {
            Recordatorio iRecordatorio = new Recordatorio(pNroExpediente, pJuez, pSecretario, pEtapa,
             pDescripcion,  pBienes,  pFecha,  pGrupoFamiliar,pTipoProceso, pRecurso, pCompetencia, 
             pFuero,  pCaratula,  pFolio,  pLibro, pJurisdiccion, pPrecio);
            iUdT.RepositorioRecordatorio.Agregar(iRecordatorio);
            iUdT.Guardar();
        }

        public void BajaJuicio(Juicio pJuicio)
        {
            iUdT.RepositorioJuicio.Eliminar(pJuicio);
            iUdT.Guardar();
        }

        public juicio ObtenerJuicio(int pId)
        {
            return iUdT.RepositorioJuicio.Obtener(pId);
        }

        public IList<Juicio> BusquedaAvanzadaJuicio(string pParametro, string pValor)
        {
            return iUdT.RepositorioJuicio.BusquedaJuicios(pParametro,pValor);
        }

        public IList<Juicio> MostrarJuicios()
        {
            IList<Juicio> iQuery = iUdT.RepositorioJuicio.ObtenerTodos();
            return iQuery;
        }

        
        public Juicio BusquedaPorNroExpediente(string pNroExpediente)
        {
            Juicio juicio = iUdT.RepositorioJuicio.BusquedaAvanzadaJuicio("NroExpediente", pNroExpediente);
            return juicio;
        }









    }
}
