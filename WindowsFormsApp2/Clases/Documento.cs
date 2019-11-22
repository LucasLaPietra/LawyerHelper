using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    public class Documento
    {
        public int DocumentoId { get; set; }
        public String TipoDocumento { get; set; }
        public String NroFoja { get; set; }
        public Boolean EnExpediente { get; set; }
        public String Nombre { get; set; }
        public String Detalle { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Juicio Juicio { get; set; }

        public bool Activo {get;  set;}


        public Documento (String pTipoDocumento, String pNroFoja, Boolean pEnExpediente, String pNombre, String pDetalle, DateTime pFecha, Juicio pJuicio)
        {
            this.TipoDocumento = pTipoDocumento;
            this.NroFoja = pNroFoja;
            this.EnExpediente = pEnExpediente;
            this.Nombre = pNombre;
            this.Detalle = pDetalle;
            this.Fecha = pFecha;
            this.Juicio = pJuicio;
            this.Activo = true;
        }

        public Documento()
        {
           
        }
    }
}
