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
using WindowsFormsApp2.Cobros;

namespace LawyerHelper.UI.Cobros
{
    public partial class MenuCobrosUC : UserControl
    {
        Color iColorForeground = Colores.ColorForeground;
        public MenuCobrosUC()
        {
            InitializeComponent();
            BotonAlta.ForeColor = iColorForeground;
            BotonBaja.ForeColor = iColorForeground;
            BotonConsulta.ForeColor = iColorForeground;
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            AltaCobro iMenuNuevo = new AltaCobro();
            iMenuNuevo.ShowDialog();
        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {
            BajaCobro iMenuNuevo = new BajaCobro();
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            ConsultaCobro iMenuNuevo = new ConsultaCobro();
            iMenuNuevo.ShowDialog();
        }
    }
}
