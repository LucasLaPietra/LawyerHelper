using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void EsconderContenidoPanel(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                c.Enabled = false;
                c.Visible = false;
            }
        }

        public static void MostrarContenidoPanel(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                c.Enabled = true;
                c.Visible = true;
            }
        }
    }
}
