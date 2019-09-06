using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    class Controlador
    {
        //Se recuperan los recordatorios que tengan fecha actual o superior (usando LINQ)
        public IList<Recordatorio> MostrarAgenda()
        {
            Contexto iContexto = new Contexto();
            IList<Recordatorio> iQuery = new List<Recordatorio>();
            foreach (Recordatorio recordatorio in iContexto.Recordatorios.Where(n => n.FechayHora >= DateTime.Today))
            {
                iQuery.Add(recordatorio);
            }
            return iQuery;
        }
    }
}
