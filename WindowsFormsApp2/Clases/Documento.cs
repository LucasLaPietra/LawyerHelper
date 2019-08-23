using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    class Documento
    {
        public int IdDocumento { get; set; }
        public String TipoDocumento { get; set; }
        public String NroFoja { get; set; }
        public Boolean EnExpediente { get; set; }
        public String Nombre { get; set; }
        public String Detalle { get; set; }
        public DateTime Fecha { get; set; }
    }
}
