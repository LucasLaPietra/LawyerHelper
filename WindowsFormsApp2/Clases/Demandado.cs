using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    class Demandado
    {
        public Boolean Cliente { get; set; }

        public Juicio Juicio { get; set; }
        public Persona Persona { get; set; }

        public Juicio GetJuicio()
        {
            Contexto iContexto = new Contexto();
            foreach (Juicio juicio in iContexto.Juicios)
            {
                foreach (Demandado demandado in juicio.Demandados)
                {
                    if (demandado==this)
                    {
                        return juicio;
                    }
                }
            }
            return null;
        }
    }
}
