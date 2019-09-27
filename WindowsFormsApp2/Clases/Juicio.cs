using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    class Juicio
    {
        public int NroExpediente { get; set; }
        public String Juez { get; set; }
        public String Secretario { get; set; }
        public String Etapa { get; set; }
        public String Descripcion { get; set; }
        public String Bienes { get; set; }
        public DateTime Fecha { get; set; }
        public String GrupoFamiliar { get; set; }
        public String TipoProceso { get; set; }
        public String Recurso { get; set; }
        public String Competencia { get; set; }
        public String Fuero { get; set; }
        public String Caratula { get; set; }
        public String Folio { get; set; }
        public String Libro { get; set; }
        public String Jurisdiccion { get; set; }
        public Double Precio { get; set; }

        public IList<Cobro> Cobros { get; set; }
        public IList<Pago> Pagos { get; set; }
        public IList<Demandado> Demandados { get; set; }
        public IList<Demandante> Demandantes { get; set; }
        public IList<Documento> Documentos { get; set; }

    }
}
