using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Cobros;

namespace WindowsFormsApp2
{
    public partial class MenuCobros : Form
    {
        public MenuCobros()
        {
            InitializeComponent();
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            AltaCobro iMenuNuevo = new AltaCobro();
            iMenuNuevo.ShowDialog();
        }
    }
}
