using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    class Recordatorio
    {
        public int IdRecordatorio { get; set; }
        public String Lugar { get; set; }
        public String Tipo { get; set; }
        public String Descripcion { get; set; }
        public DateTime FechayHora { get; set; }
    }
}
