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

namespace LawyerHelper.UI.Documentos
{
    public partial class ModificarDocumento : Form
    {
        public ModificarDocumento()
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
            //ListBox
            foreach (ListBox t in Controls.OfType<ListBox>())
            {
                t.ForeColor = Colores.ColorForeground;
                t.BackColor = Colores.ColorBackgroundCajas;
            }
            //ComboBox
            foreach (ComboBox c in Controls.OfType<ComboBox>())
            {
                c.ForeColor = Colores.ColorForeground;
                c.BackColor = Colores.ColorBackground;
            }
        }

        private void ModificarDocumento_Load(object sender, EventArgs e)
        {

        }
    }
}
