using LawyerHelper.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Interfaces
{
    interface IUnidadDeTrabajo
    {
         IRepositorioCobro RepositorioCobro { get;  }
         IRepositorioDemandado RepositorioDemandado { get; }
        IRepositorioDemandante RepositorioDemandante { get; }
        IRepositorioDocumento RepositorioDocumento { get; }
        IRepositorioJuicio RepositorioJuicio { get; }
        IRepositorioPago RepositorioPago { get; }
        IRepositorioPersona RepositorioPersona { get; }
        IRepositorioRecordatorio RepositorioRecordatorio { get; }
    
        void Guardar();
    }
}
