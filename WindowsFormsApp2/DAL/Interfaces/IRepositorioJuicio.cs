using LawyerHelper.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Interfaces
{
    interface IRepositorioJuicio : IRepositorioGeneral<Juicio>
    {
        IList<Juicio> BusquedaJuicios(string Parametro, string Valor);
        IList<Juicio> BusquedaJuciosActivos(string Parametro, string Valor, bool pActivo);
        void ModificarJuicio(Juicio pJuicio);
        void BajaLogicaJuicio(Juicio pJuicio);
        void JuicioIgualExpediente(String pNroExpediente);
    }
}
