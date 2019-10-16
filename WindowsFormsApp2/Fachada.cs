using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Fachada
    {
        public int Convertir24Hs(int pHora, string AMPM)
        {
            int iResultado;
            if (AMPM == "PM")
            {
                iResultado = pHora + 12;
                return iResultado;
            }
            else return pHora;
        }

    }
}
