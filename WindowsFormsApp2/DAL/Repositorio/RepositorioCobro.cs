﻿using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioCobro : RepositorioGeneral<Cobro, Contexto>, IRepositorioCobro
    {
        public RepositorioCobro(Contexto pContext) : base(pContext)
        {
        }
    
    }
}
