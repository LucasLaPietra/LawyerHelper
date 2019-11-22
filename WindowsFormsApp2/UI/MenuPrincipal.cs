using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawyerHelper.UI.Juicios;
using LawyerHelper.UI.Personas;
using LawyerHelper.UI.Pagos;
using LawyerHelper.UI.Cobros;
using LawyerHelper.UI.Documentos;
using LawyerHelper.UI.Agenda;
using LawyerHelper.UI;
using LawyerHelper.Clases;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;

namespace WindowsFormsApp2
{
    public partial class MenuPrincipal : Form
    {
        Color iColorBackground = Colores.ColorBackground;
        Color iColorPresionado = Colores.ColorPresionado;
        Color iColorForeground = Colores.ColorForeground;
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = iColorBackground;
            LabelTitulo.ForeColor = iColorForeground;
            LabelCreditos.ForeColor = iColorForeground;
            BotonPersonas.ForeColor = iColorForeground;
            BotonJuicios.ForeColor = iColorForeground;
            BotonAgenda.ForeColor = iColorForeground;
            BotonPagos.ForeColor = iColorForeground;
            BotonCobros.ForeColor = iColorForeground;
            BotonJuicios.BackColor = iColorBackground;
            BotonPersonas.BackColor = iColorBackground;
            BotonAgenda.BackColor = iColorBackground;
            BotonPagos.BackColor = iColorBackground;
            BotonCobros.BackColor = iColorBackground;
        }

        private void BotonPersonas_Click(object sender, EventArgs e)
        {
            if (BotonPersonas.BackColor== iColorBackground)
            {
                FlechaPersonas.Visible = true;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = false;
                BotonPersonas.BackColor = iColorPresionado;
                BotonJuicios.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                MenuPersonasUC iMenuNuevo = new MenuPersonasUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonPersonas.BackColor = iColorBackground;
                FlechaPersonas.Visible = false;
            }            
        }

        private void BotonJuicios_Click(object sender, EventArgs e)
        {
            if (BotonJuicios.BackColor == iColorBackground)
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = true;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = false;
                BotonJuicios.BackColor = iColorPresionado;
                BotonPersonas.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                MenuJuiciosUC iMenuNuevo = new MenuJuiciosUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonJuicios.BackColor = iColorBackground;
                FlechaJuicios.Visible = false;
            }
        }

        private void BotonAgenda_Click(object sender, EventArgs e)
        {
            if (BotonAgenda.BackColor == iColorBackground)
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = true;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = false;
                BotonAgenda.BackColor = iColorPresionado;
                BotonJuicios.BackColor = iColorBackground;
                BotonPersonas.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                MenuAgendaUC iMenuNuevo = new MenuAgendaUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonAgenda.BackColor = iColorBackground;
                FlechaAgenda.Visible = false;
            }
        }

        private void BotonPagos_Click(object sender, EventArgs e)
        {
            if (BotonPagos.BackColor == iColorBackground)
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = true;
                FlechaCobros.Visible = false;
                BotonPagos.BackColor = iColorPresionado;
                BotonJuicios.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPersonas.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                MenuPagosUC iMenuNuevo = new MenuPagosUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonPagos.BackColor = iColorBackground;
                FlechaPagos.Visible = false;
            }
        }

        private void BotonCobros_Click(object sender, EventArgs e)
        {
            if (BotonCobros.BackColor == iColorBackground)
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = true;
                BotonCobros.BackColor = iColorPresionado;
                BotonJuicios.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonPersonas.BackColor = iColorBackground;
                MenuCobrosUC iMenuNuevo = new MenuCobrosUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonCobros.BackColor = iColorBackground;
                FlechaCobros.Visible = false;
            }
        }
        

       /* private void BotonAjustes_Click(object sender, EventArgs e)
        {
            
            Ajustes iMenuNuevo = new Ajustes();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                iColorBackground = iMenuNuevo.ColorBackground;
                iColorPresionado = iMenuNuevo.ColorPresionado;
                iColorForeground = iMenuNuevo.ColorForeground;
                PanelOpciones.Controls.Clear();
                this.BackColor = iColorBackground;
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = false;
                FlechaDocumentos.Visible = false;
                LabelTitulo.ForeColor = iColorForeground;
                BotonPersonas.ForeColor = iColorForeground;
                BotonJuicios.ForeColor = iColorForeground;
                BotonAjustes.ForeColor = iColorForeground;
                BotonAgenda.ForeColor = iColorForeground;
                BotonPagos.ForeColor = iColorForeground;
                BotonCobros.ForeColor = iColorForeground;
                BotonDocumentos.ForeColor = iColorForeground;
                LabelCreditos.ForeColor = iColorForeground;
                BotonDocumentos.BackColor = iColorBackground;
                BotonJuicios.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                BotonPersonas.BackColor = iColorBackground;
                BotonAjustes.BackColor = iColorBackground;
            }
        }*/
    }
}
