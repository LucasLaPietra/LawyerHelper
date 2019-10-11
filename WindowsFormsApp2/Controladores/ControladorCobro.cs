﻿using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Controladores
{
    class ControladorCobro
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorCobro(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public IList<Cobro> MostrarCobros()
        {
            Contexto iContexto = new Contexto();
            IList<Cobro> iQuery = new List<Cobro>();
            foreach (Cobro cobro in iContexto.Cobros)
            {
                iQuery.Add(cobro);
            }
            return iQuery;
        }
    }
}
