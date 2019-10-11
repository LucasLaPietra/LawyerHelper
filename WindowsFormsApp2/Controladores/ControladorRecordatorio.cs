using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Controladores
{
    class ControladorRecordatorio
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorRecordatorio(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

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
