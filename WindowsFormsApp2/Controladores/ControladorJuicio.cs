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
             iUdT.RepositorioJuicio.JuicioIgualExpediente(pNroExpediente);
             Juicio iJuicio = new Juicio(pNroExpediente, pJuez, pSecretario, pEtapa,
             pDescripcion, pBienes, pFecha, pGrupoFamiliar, pTipoProceso, pRecurso, pCompetencia,
             pFuero, pCaratula, pFolio, pLibro, pJurisdiccion, pPrecio);
             iUdT.RepositorioJuicio.Agregar(iJuicio);
             iUdT.Guardar();           
        }

        public void JuicioIgualExpediente(string pNroExpediente)
        {
            iUdT.RepositorioJuicio.JuicioIgualExpediente(pNroExpediente);
        }

        public void ModificarJuicio(int pId,string pNroExpediente, string pJuez, string pSecretario, string pEtapa,
            string pDescripcion, string pBienes, DateTime pFecha, string pGrupoFamiliar, string pTipoProceso,
            string pRecurso, string pCompetencia, string pFuero, string pCaratula, string pFolio, string pLibro,
            string pJurisdiccion, Double pPrecio,List<Demandado> pDemandados, List<Demandante> pDemandantes)
        {
            Juicio iQuery = iUdT.RepositorioJuicio.Obtener(pId);
            iQuery.Bienes = pBienes;
            iQuery.Descripcion = pDescripcion;
            iQuery.GrupoFamiliar = pGrupoFamiliar;
            iQuery.Caratula = pCaratula;
            iQuery.Competencia = pCompetencia;
            iQuery.Etapa = pEtapa;
            iQuery.NroExpediente = pNroExpediente;
            iQuery.Fecha = pFecha;
            iQuery.Folio = pFolio;
            iQuery.Juez = pJuez;
            iQuery.Jurisdiccion = pJurisdiccion;
            iQuery.Libro = pLibro;
            iQuery.Precio = pPrecio;
            iQuery.Recurso = pRecurso;
            iQuery.Secretario = pSecretario;
            iQuery.TipoProceso = pTipoProceso;
            iQuery.Fuero = pFuero;
            iQuery.Demandados = pDemandados;
            iQuery.Demandantes = pDemandantes;
            iUdT.Guardar();
        }

        public void BajaJuicio(Juicio pJuicio)
        {
            iUdT.RepositorioJuicio.Eliminar(pJuicio);
            iUdT.Guardar();
        }

        public void BajaLogicaJuicio(Juicio pJuicio)
        {
            Juicio iQuery = iUdT.RepositorioJuicio.Obtener(pJuicio.JuicioId);
            iQuery.Activo = false;
            iUdT.Guardar();
        }

        public Juicio ObtenerJuicio(int pId)
        {
            return iUdT.RepositorioJuicio.Obtener(pId);
        }

        public IList<Juicio> BusquedaAvanzadaJuicio(string pParametro, string pValor)
        {
            return iUdT.RepositorioJuicio.BusquedaJuicios(pParametro,pValor);
        }

        public IList<Juicio> ObtenerTodosActivos(bool pActivo)
        {
            List<Juicio> iQuery = iUdT.RepositorioJuicio.ObtenerTodos().ToList();
            iQuery = iQuery.Where(n => n.Activo == pActivo).ToList();
            return iQuery;
        }

        public IList<Juicio> BusquedaAvanzadaJuiciosActivos(string pParametro, string pValor, bool pActivo)
        {
            return iUdT.RepositorioJuicio.BusquedaJuciosActivos(pParametro, pValor, pActivo);
        }

        public IList<Demandante> ObtenerDemandantes(int pId)
        {

            return iUdT.RepositorioDemandante.BuscarDemandantesDeUnJuicio(pId).ToList();

        }

        public IList<Persona> ObtenerDemandados(int pId)
        {
            List<Persona> iQuery = new List<Persona>();
            List<Demandado> iLista = iUdT.RepositorioDemandado.BuscarDemandadosDeUnJuicio(pId).ToList();
            foreach (Demandado d in iLista)
            {
                iQuery.Add(d.Persona);
            }
            return iQuery;
        }

        public IList<Juicio> MostrarJuicios()
        {
            IList<Juicio> iQuery = iUdT.RepositorioJuicio.ObtenerTodos();
            return iQuery;
        }

        
        public Juicio BusquedaPorNroExpediente(string pNroExpediente)
        {
            IList<Juicio> iJuicios = iUdT.RepositorioJuicio.BusquedaJuicios("NroExpediente", pNroExpediente);
            Juicio iJuicio = iJuicios.FirstOrDefault();
            return iJuicio;
        }









    }
}
