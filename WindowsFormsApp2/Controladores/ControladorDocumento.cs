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
    class ControladorDocumento
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorDocumento(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public IList<Documento> MostrarDocumentos()
        {
            IList<Documento> iQuery = iUdT.RepositorioDocumento.ObtenerTodos();
            return iQuery;
        }

        public void RegistrarDocumento( String pTipoDocumento, String pNroFoja, Boolean pEnExpediente, String pNombre, String pDetalle, DateTime pFecha, Juicio pJuicio)
            {
            Documento iDocumento = new Documento(pTipoDocumento,  pNroFoja,  pEnExpediente,  pNombre,  pDetalle, pFecha, pJuicio);
            iUdT.RepositorioDocumento.DocumentoIgualFoja(pNroFoja, pJuicio);
            iUdT.RepositorioDocumento.Agregar(iDocumento);
            iUdT.Guardar();
        }

        public void ModificarDocumento(int pId, string pNroFoja,string pTipoDocumento, bool pEnExpediente, string pNombre, string pDetalle, DateTime pFecha,Juicio pJuicio)
        {
            Documento iQuery = iUdT.RepositorioDocumento.Obtener(pId);
            iQuery.Fecha = pFecha;
            iQuery.EnExpediente = pEnExpediente;
            iQuery.Detalle = pDetalle;
            iQuery.Juicio = pJuicio;
            iQuery.Nombre = pNombre;
            iQuery.TipoDocumento = pTipoDocumento;
            iUdT.Guardar();
        }

        public void BajaLogicaDocumento(Documento pDocumento, Juicio pJuicio)
        {
            Documento iQuery = iUdT.RepositorioDocumento.Obtener(pDocumento.DocumentoId);
            iQuery.Activo = false;
            iUdT.Guardar();
        }

        public void AltaLogicaDocumento(Documento pDocumento, Juicio pJuicio)
        {
            Documento iQuery = iUdT.RepositorioDocumento.Obtener(pDocumento.DocumentoId);
            iUdT.RepositorioDocumento.DocumentoIgualFoja(pDocumento.NroFoja, pJuicio);
            iQuery.Activo = true;
            iUdT.Guardar();
        }

        public void BajaDocumento(Documento pDocumento)
        {
            iUdT.RepositorioDocumento.Eliminar(pDocumento);
            iUdT.Guardar();
        }

        public void BajaLogicaDocumento(Documento pDocumento)
        {
            Documento iQuery = iUdT.RepositorioDocumento.Obtener(pDocumento.DocumentoId);
            iQuery.Activo = false;
            iUdT.Guardar();
        }

        public Documento BusquedaPorNroFoja(string pNroFoja,Juicio pJuicio)
        {
            Documento iDocumento = iUdT.RepositorioDocumento.BusquedaPorNroFoja(pNroFoja,pJuicio);
            return iDocumento;
        }

        public Documento BusquedaPorNroFojaActivos(string pNroFoja, Juicio pJuicio, bool pActivo)
        {
            Documento iDocumento = iUdT.RepositorioDocumento.BusquedaPorNroFoja(pNroFoja, pJuicio);
            if (iDocumento.Activo == pActivo)
                return iDocumento;
            else
                return null;
        }

        public List<Documento> MostrarDocumentosDeJuicio(Juicio pJuicio)
        {
            List<Documento> iDocumentos = iUdT.RepositorioDocumento.MostrarTodosDeUnJuicio(pJuicio);
            return iDocumentos;
        }

        public List<Documento> MostrarDocumentosDeJuicioActivos(Juicio pJuicio, bool pActivo)
        {
            List<Documento> iDocumentos = iUdT.RepositorioDocumento.MostrarTodosDeUnJuicio(pJuicio);
            List<Documento> iQuery = iDocumentos.Where(n => n.Activo == pActivo).ToList();
            return iQuery;
        }
    }
}
