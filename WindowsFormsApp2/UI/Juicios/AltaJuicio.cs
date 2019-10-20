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

namespace WindowsFormsApp2.Juicios
{
    public partial class AltaJuicios : Form
    {
        List<Persona> iListaDemandados = new List<Persona>();
        List<Persona> iListaDemandantes = new List<Persona>();
        public AltaJuicios()
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

            ListBoxDemandados.DataSource = iListaDemandados;
            ListBoxDemandados.DisplayMember = "Apellido"+" "+"Nombre";
            ListBoxDemandantes.DataSource = iListaDemandantes;
            ListBoxDemandantes.DisplayMember = "Apellido" + " " + "Nombre";
        }

        private void AltaJuicios_Load(object sender, EventArgs e)
        {
            
        }

        

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void BotonAgregarDemandante_Click(object sender, EventArgs e)
        {
            BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                Persona iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                iListaDemandantes.Add(iPersona);
            }
        }

        private void BotonEliminarDemandante_Click(object sender, EventArgs e)
        {
            iListaDemandantes.Remove((Persona)ListBoxDemandantes.SelectedItem);
        }

        private void BotonAgregarDemandado_Click(object sender, EventArgs e)
        {
            BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                Persona iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                iListaDemandados.Add(iPersona);
            }
        }

        private void BotonEliminarDemandado_Click(object sender, EventArgs e)
        {
            iListaDemandados.Remove((Persona)ListBoxDemandados.SelectedItem);
        }
    }
}
