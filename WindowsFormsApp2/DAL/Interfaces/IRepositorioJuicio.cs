﻿using LawyerHelper.Clases;
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
        void JuicioIgualExpediente(String pNroExpediente);
    }
}
