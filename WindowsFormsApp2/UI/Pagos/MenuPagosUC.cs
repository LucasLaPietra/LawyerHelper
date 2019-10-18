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
using WindowsFormsApp2.Pagos;

namespace LawyerHelper.UI.Pagos
{
    public partial class MenuPagosUC : UserControl
    {
        Color iColorForeground = Colores.ColorForeground;
        public MenuPagosUC()
        {
            InitializeComponent();
            BotonAlta.ForeColor = iColorForeground;
            BotonBaja.ForeColor = iColorForeground;
            BotonConsulta.ForeColor = iColorForeground;
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            AltaPago iMenuNuevo = new AltaPago();
            iMenuNuevo.ShowDialog();
        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {
            BajaPago iMenuNuevo = new BajaPago();
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            ConsultaPago iMenuNuevo = new ConsultaPago();
            iMenuNuevo.ShowDialog();
        }
    }
}
