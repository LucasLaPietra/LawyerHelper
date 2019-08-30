using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Juicios;
using LawyerHelper.UI.Juicios;

namespace WindowsFormsApp2
{
    public partial class MenuJuicios : Form
    {
        public MenuJuicios()
        {
            InitializeComponent();
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
    }
}
