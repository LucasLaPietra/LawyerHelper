using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Pagos;

namespace WindowsFormsApp2
{
    public partial class MenuPagos : Form
    {
        public MenuPagos()
        {
            InitializeComponent();
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            AltaPago iMenuNuevo = new AltaPago();
            iMenuNuevo.ShowDialog();
        }
    }
}
