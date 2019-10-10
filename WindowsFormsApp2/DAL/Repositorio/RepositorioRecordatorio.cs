using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioRecordatorio : RepositorioGeneral<Recordatorio, Contexto>, IRepositorioRecordatorio
    {
        public RepositorioRecordatorio(Contexto pContext) : base(pContext)
        {
        }
    }
}
