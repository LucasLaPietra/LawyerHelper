using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioJuicio : RepositorioGeneral<Juicio, Contexto>, IRepositorioJuicio
    {
        public RepositorioJuicio(Contexto pContext) : base(pContext)
        {

        }

        public IList<Juicio> BusquedaJuicios(string Parametro, string Valor)
        {
            List<Juicio> iQuery;
            //No se puede utilizar variables como atributos, ya que estos deben estar definidos en tiempo de compilacion
            //Por eso utilice el switch para cada atributo en particular
            switch (Parametro)
            {                
                case "Juez":
                    iQuery = iContext.Juicios.Where(n => n.Juez == Valor).ToList();
                    break;
                case "NroExpediente":
                    iQuery = iContext.Juicios.Where(n => n.NroExpediente == Valor).ToList();
                    break;
                case "Secretario":
                    iQuery = iContext.Juicios.Where(n => n.Secretario == Valor).ToList();
                    break;
                case "Etapa":
                    iQuery = iContext.Juicios.Where(n => n.Etapa == Valor).ToList();
                    break;
                case "Fecha":
                    iQuery = iContext.Juicios.Where(n => n.Fecha.ToShortDateString() == Valor).ToList();
                    break;
                case "TipoProceso":
                    iQuery = iContext.Juicios.Where(n => n.TipoProceso == Valor).ToList();
                    break;
                case "Recurso":
                    iQuery = iContext.Juicios.Where(n => n.Recurso == Valor).ToList();
                    break;
                case "Competencia":
                    iQuery = iContext.Juicios.Where(n => n.Competencia == Valor).ToList();
                    break;
                case "Fuero":
                    iQuery = iContext.Juicios.Where(n => n.Fuero == Valor).ToList();
                    break;
                case "Caratula":
                    iQuery = iContext.Juicios.Where(n => n.Caratula == Valor).ToList();
                    break;
                case "Folio":
                    iQuery = iContext.Juicios.Where(n => n.Folio == Valor).ToList();
                    break;
                case "Libro":
                    iQuery = iContext.Juicios.Where(n => n.Libro == Valor).ToList();
                    break;
                case "Jurisdiccion":
                    iQuery = iContext.Juicios.Where(n => n.Jurisdiccion == Valor).ToList();
                    break;
                default:
                    iQuery = null;
                    break;
            }
            return iQuery;
        }

        public void JuicioIgualExpediente(String pNroExpediente)
        {
            bool Resultado;
            Resultado = iContext.Juicios.Any(n => n.NroExpediente == pNroExpediente);
            if (Resultado == true)
            { throw new InvalidOperationException(); }
        }
    }
}