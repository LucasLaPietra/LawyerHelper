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
            iUdT.RepositorioDocumento.Agregar(iDocumento);
            iUdT.Guardar();
        }

         public void BajaDocumento(Documento pDocumento)
        {
            iUdT.RepositorioDocumento.Eliminar(pDocumento);
            iUdT.Guardar();
        }

        public Documento BusquedaPorNroFoja(string pNroFoja)
        {
            Documento iDocumento = iUdT.RepositorioDocumento.BusquedaPorNroFoja(pNroFoja);
            return iDocumento;
        }


    }
}
