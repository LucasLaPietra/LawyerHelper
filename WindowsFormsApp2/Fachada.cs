using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawyerHelper.Clases;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;


namespace WindowsFormsApp2
{
    public class Fachada
    {
        public void AltaDemandadosyDemandantes(string pNroExpediente,List<Persona> pListaDemandados, List<Persona> pListaDemandantes, 
            bool pDemandadosClientes, bool pDemandantesClientes)
        {
           ControladorDemandado iControladorDemandado = new ControladorDemandado(UnidadDeTrabajo.Instancia);
           ControladorDemandante iControladorDemandante = new ControladorDemandante(UnidadDeTrabajo.Instancia);
           ControladorJuicio iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
           ControladorPersona iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
            Juicio iJuicio = iControladorJuicio.BusquedaPorNroExpediente(pNroExpediente);
            bool iRepetidos = pListaDemandados.Intersect(pListaDemandantes).Any();
            if (iRepetidos==true)
            {
                throw new MissingMemberException();
            }
            if (pListaDemandados.Count == 0 || pListaDemandantes.Count == 0)
            {
                throw new NullReferenceException();
            }
            foreach (Persona iPersona in pListaDemandados)
            {               
                iControladorDemandado.RegistrarDemandado(pDemandadosClientes, iJuicio, iPersona);
            }
            foreach (Persona iPersona in pListaDemandantes)
            {
                iControladorDemandante.RegistrarDemandante(pDemandantesClientes, iJuicio, iPersona.PersonaId);
            }
        }

        public void ModificarDemandadosyDemandantes(string pNroExpediente, List<Persona> pListaDemandados, List<Persona> pListaDemandantes,
            bool pDemandadosClientes, bool pDemandantesClientes)
        {
            ControladorDemandado iControladorDemandado = new ControladorDemandado(UnidadDeTrabajo.Instancia);
            ControladorDemandante iControladorDemandante = new ControladorDemandante(UnidadDeTrabajo.Instancia);
            ControladorJuicio iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
            ControladorPersona iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
            Juicio iJuicio = iControladorJuicio.BusquedaPorNroExpediente(pNroExpediente);
            iControladorDemandado.BajaDemandadosDeUnJuicio(iJuicio);
            iControladorDemandante.BajaDemandantesDeUnJuicio(iJuicio);
            bool iRepetidos = pListaDemandados.Intersect(pListaDemandantes).Any();
            if (iRepetidos == true)
            {
                throw new MissingMemberException();
            }

            foreach (Persona iPersona in pListaDemandados)
            {
                    iControladorDemandado.RegistrarDemandado(pDemandadosClientes, iJuicio, iPersona);
            }
            foreach (Persona iPersona in pListaDemandantes)
            {
                    iControladorDemandante.RegistrarDemandante(pDemandantesClientes, iJuicio, iPersona.PersonaId);
            }
        }

        public int Convertir24Hs(int pHora, string AMPM)
        {
            int iResultado;
            if (AMPM == "PM")
            {
                iResultado = pHora + 12;
                return iResultado;
            }
            else return pHora;
        }
        public static void EsconderContenidoPanel(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                c.Enabled = false;
                c.Visible = false;
            }
        }

        public void SoloNumeros(KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public static void MostrarContenidoPanel(Panel p)
        {
            foreach (Control c in p.Controls)
            {
                c.Enabled = true;
                c.Visible = true;
            }
        }

        public void AsignarColores(Form iForm)
        {
            //Background
            iForm.BackColor = Colores.ColorBackground;
            //Cajas
            foreach (TextBox t in iForm.Controls.OfType<TextBox>())
            {
                t.ForeColor = Colores.ColorForeground;
                t.BackColor = Colores.ColorBackgroundCajas;
                t.BorderStyle = BorderStyle.FixedSingle;
            }
            // Labels
            foreach (Label l in iForm.Controls.OfType<Label>())
                l.ForeColor = Colores.ColorForeground;
            //Botones
            foreach (Button b in iForm.Controls.OfType<Button>())
            {
                b.ForeColor = Colores.ColorForeground;
                b.BackColor = Colores.ColorBackground;
                b.FlatStyle = FlatStyle.Flat;
            }
            foreach (RadioButton b in iForm.Controls.OfType<RadioButton>())
            {
                b.ForeColor = Colores.ColorForeground;
            }
            //ListBox
            foreach (ListBox t in iForm.Controls.OfType<ListBox>())
            {
                t.ForeColor = Colores.ColorForeground;
                t.BackColor = Colores.ColorBackgroundCajas;
                t.BorderStyle = BorderStyle.FixedSingle;
            }
            //ComboBox
            foreach (ComboBox c in iForm.Controls.OfType<ComboBox>())
            {
                c.ForeColor = Colores.ColorForeground;
                c.BackColor = Colores.ColorBackgroundCajas;
                c.FlatStyle = FlatStyle.Flat;
            }
            //NumericUpDown
            foreach (NumericUpDown n in iForm.Controls.OfType<NumericUpDown>())
            {
                n.ForeColor = Colores.ColorForeground;
                n.BackColor = Colores.ColorBackgroundCajas;
                n.BorderStyle = BorderStyle.FixedSingle;
            }
            //Layouts
            foreach (TableLayoutPanel l in iForm.Controls.OfType<TableLayoutPanel>())
            {
                //Cajas
                foreach (TextBox t in l.Controls.OfType<TextBox>())
                {
                    t.ForeColor = Colores.ColorForeground;
                    t.BackColor = Colores.ColorBackgroundCajas;
                    t.BorderStyle = BorderStyle.FixedSingle;
                }
                // Labels
                foreach (Label l1 in l.Controls.OfType<Label>())
                    l1.ForeColor = Colores.ColorForeground;
                //Botones
                foreach (Button b in l.Controls.OfType<Button>())
                {
                    b.ForeColor = Colores.ColorForeground;
                    b.BackColor = Colores.ColorBackground;
                    b.FlatStyle = FlatStyle.Flat;
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
                    t.BorderStyle = BorderStyle.FixedSingle;
                }
                //ComboBox
                foreach (ComboBox c in iForm.Controls.OfType<ComboBox>())
                {
                    c.ForeColor = Colores.ColorForeground;
                    c.BackColor = Colores.ColorBackgroundCajas;
                    c.FlatStyle = FlatStyle.Flat;
                }
                //NumericUpDown
                foreach (NumericUpDown n in iForm.Controls.OfType<NumericUpDown>())
                {
                    n.ForeColor = Colores.ColorForeground;
                    n.BackColor = Colores.ColorBackgroundCajas;
                    n.BorderStyle = BorderStyle.FixedSingle;
                }
            }
        }
    }
}
