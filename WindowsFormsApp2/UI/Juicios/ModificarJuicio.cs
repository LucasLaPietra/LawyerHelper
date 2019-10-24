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
using LawyerHelper.UI.Personas;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;

namespace LawyerHelper.UI.Juicios
{
    public partial class ModificarJuicio : Form
    {
        public ModificarJuicio()
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
            foreach (RadioButton b in Controls.OfType<RadioButton>())
            {
                b.ForeColor = Colores.ColorForeground;
            }
            //ListBox
            foreach (ListBox t in Controls.OfType<ListBox>())
            {
                t.ForeColor = Colores.ColorForeground;
                t.BackColor = Colores.ColorBackgroundCajas;
            }
            //Layouts
            foreach (TableLayoutPanel l in this.Controls)
            {
                //Cajas
                foreach (TextBox t in l.Controls.OfType<TextBox>())
                {
                    t.ForeColor = Colores.ColorForeground;
                    t.BackColor = Colores.ColorBackgroundCajas;
                }
                // Labels
                foreach (Label l1 in l.Controls.OfType<Label>())
                    l1.ForeColor = Colores.ColorForeground;
                //Botones
                foreach (Button b in l.Controls.OfType<Button>())
                {
                    b.ForeColor = Colores.ColorForeground;
                    b.BackColor = Colores.ColorBackground;
                }
                foreach (RadioButton b in l.Controls.OfType<RadioButton>())
                {
                    b.ForeColor = Colores.ColorForeground;
                }
                //ListBox
                foreach (ListBox t in l.Controls.OfType<ListBox>())
                {
                    t.ForeColor = Colores.ColorForeground;
                    t.BackColor = Colores.ColorBackgroundCajas;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void ModificarJuicio_Load(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
