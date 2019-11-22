using LawyerHelper.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Interfaces
{
    interface IRepositorioDocumento : IRepositorioGeneral<Documento>
    {
        Documento BusquedaPorNroFoja(string pNroFoja, Juicio pJuicio);
        void ModificarDocumento(Documento pDocumento);
        List<Documento> MostrarTodosDeUnJuicio(Juicio pJuicio);
    }
}
