using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonPersonas_Click(object sender, EventArgs e)
        {
            MenuPersonas iMenuNuevo = new MenuPersonas();
            this.Hide();
            iMenuNuevo.ShowDialog();
        }

        private void BotonJuicios_Click(object sender, EventArgs e)
        {
            MenuJuicios iMenuNuevo = new MenuJuicios();
            this.Hide();
            iMenuNuevo.ShowDialog();            
        }

        private void BotonAgenda_Click(object sender, EventArgs e)
        {
            MenuAgenda iMenuNuevo = new MenuAgenda();
            this.Hide();
            iMenuNuevo.ShowDialog();
        }

        private void BotonPagos_Click(object sender, EventArgs e)
        {
            MenuPagos iMenuNuevo = new MenuPagos();
            this.Hide();
            iMenuNuevo.ShowDialog();
        }

        private void BotonCobros_Click(object sender, EventArgs e)
        {
            MenuCobros iMenuNuevo = new MenuCobros();
            this.Hide();
            iMenuNuevo.ShowDialog();
        }
    }
}
