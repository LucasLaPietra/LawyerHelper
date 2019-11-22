using LawyerHelper.Clases;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioDocumento : RepositorioGeneral<Documento, Contexto>, IRepositorioDocumento
    {
        public RepositorioDocumento(Contexto pContext) : base(pContext)
        {
        }

        public Documento BusquedaPorNroFoja(string pNroFoja,Juicio pJuicio)
        {
            List<Documento> ListaPorJuicio = iContext.Documentos.Where(n => n.Juicio == pJuicio).ToList();
            Documento iQuery = ListaPorJuicio.FirstOrDefault(n => n.NroFoja == pNroFoja);
            return iQuery;
        }

        public List<Documento> MostrarTodosDeUnJuicio(Juicio pJuicio)
        {
            List<Documento> iQuery = iContext.Documentos.Where(n => n.Juicio == pJuicio).ToList();
            return iQuery;
        }

        public void ModificarDocumento(Documento pDocumento)
        {
            Documento iQuery;
            iQuery = iContext.Documentos.First(n => n.NroFoja == (pDocumento.NroFoja));
            iQuery.Fecha = pDocumento.Fecha;
            iQuery.EnExpediente = pDocumento.EnExpediente;
            iQuery.Detalle = pDocumento.Detalle;
            iQuery.Juicio = pDocumento.Juicio;
            iQuery.Nombre = pDocumento.Nombre;
            iQuery.TipoDocumento = pDocumento.TipoDocumento;
            iContext.SaveChanges();
        }
    }


}