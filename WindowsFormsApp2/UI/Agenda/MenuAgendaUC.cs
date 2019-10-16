using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawyerHelper.UI.Agenda
{
    public partial class MenuAgendaUC : UserControl
    {
        public MenuAgendaUC(Color pColorForeground)
        {
            InitializeComponent();
            BotonAlta.ForeColor = pColorForeground;
            BotonBaja.ForeColor = pColorForeground;
            BotonModificacion.ForeColor = pColorForeground;
            BotonConsulta.ForeColor = pColorForeground;
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
