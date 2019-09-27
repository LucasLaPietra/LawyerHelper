using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    class Demandante
    {
        public Boolean Cliente { get; set; }

        public Juicio Juicio { get; set; }
        public Persona Persona { get; set; }

        public Juicio GetJuicio()
        {
            Contexto iContexto = new Contexto();
            foreach (Juicio juicio in iContexto.Juicios)
            {
                foreach (Demandante demandante in juicio.Demandantes)
                {
                    if (demandante == this)
                    {
                        return juicio;
                    }
                }
            }
            return null;
        }
    }
}
