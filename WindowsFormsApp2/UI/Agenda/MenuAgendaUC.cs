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
            AltaRecordatorio iMenuNuevo = new AltaRecordatorio();
            iMenuNuevo.ShowDialog();
        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {
            BajaRecordatorio iMenuNuevo = new BajaRecordatorio();
            iMenuNuevo.ShowDialog();
        }

        private void BotonModificacion_Click(object sender, EventArgs e)
        {
            ModificarRecordatorio iMenuNuevo = new ModificarRecordatorio();
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            ConsultaRecordatorio iMenuNuevo = new ConsultaRecordatorio();
            iMenuNuevo.ShowDialog();
        }
    }
}
