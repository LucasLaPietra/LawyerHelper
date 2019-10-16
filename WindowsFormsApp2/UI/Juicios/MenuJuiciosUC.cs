using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawyerHelper.UI.Juicios;
using WindowsFormsApp2.Juicios;

namespace LawyerHelper.UI.Juicios
{
    public partial class MenuJuiciosUC : UserControl
    {
        public MenuJuiciosUC(Color pColorForeground)
        {
            InitializeComponent();
            BotonAlta.ForeColor = pColorForeground;
            BotonBaja.ForeColor = pColorForeground;
            BotonModificacion.ForeColor = pColorForeground;
            BotonConsulta.ForeColor = pColorForeground;
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            AltaJuicios iMenuNuevo = new AltaJuicios();
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            ConsultaJuicios iMenuNuevo = new ConsultaJuicios();
            iMenuNuevo.ShowDialog();
        }

        private void BotonModificacion_Click(object sender, EventArgs e)
        {
            ModificarJuicio iMenuNuevo = new ModificarJuicio();
            iMenuNuevo.ShowDialog();
        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {

        }




    }
}
