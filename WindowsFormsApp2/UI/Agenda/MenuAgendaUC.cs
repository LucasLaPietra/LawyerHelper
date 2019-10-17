using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawyerHelper.Clases;

namespace LawyerHelper.UI.Agenda
{
    public partial class MenuAgendaUC : UserControl
    {
        Color iColorForeground = Colores.ColorForeground;
        public MenuAgendaUC()
        {
            InitializeComponent();
            BotonAlta.ForeColor = iColorForeground;
            BotonBaja.ForeColor = iColorForeground;
            BotonModificacion.ForeColor = iColorForeground;
            BotonConsulta.ForeColor = iColorForeground;
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {

        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {

        }

        private void BotonModificacion_Click(object sender, EventArgs e)
        {

        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {

        }
    }
}
