using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawyerHelper.Clases;

namespace LawyerHelper.UI.Pagos
{
    public partial class BajaPago : Form
    {

        public BajaPago()
        {
            InitializeComponent();
            //Asignacion de colores      
            //Background
            this.BackColor = Colores.ColorBackground;
            //Cajas
            foreach (TextBox t in Controls.OfType<TextBox>())
            {
                t.ForeColor = Colores.ColorForeground;
                t.BackColor = Colores.ColorBackgroundCajas;
            }
            // Labels
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = Colores.ColorForeground;
            //Botones
            foreach (Button b in Controls.OfType<Button>())
            {
                b.ForeColor = Colores.ColorForeground;
                b.BackColor = Colores.ColorBackground;
            }
            ListBoxPagos.ForeColor = Colores.ColorForeground;
            ListBoxPagos.BackColor = Colores.ColorBackground;
        }

        private void BajaPagos_Load(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
