﻿using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioDocumento : RepositorioGeneral<Documento, Contexto>, IRepositorioDocumento
    {
        public RepositorioDocumento(Contexto pContext) : base(pContext)
        {
        }

        public IList<Documento> BusquedaPorNroFoja(string pNroFoja)
        {
            iQuery = iContext.Documentos.Where(n => n.NroFoja == pNroFoja).ToList();
            return iQuery;
        }
    }


}