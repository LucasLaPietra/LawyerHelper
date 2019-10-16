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
using LawyerHelper.Clases;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;

namespace WindowsFormsApp2
{
    public partial class MenuPrincipal : Form
    {
        Color iColorBackground = Color.FromArgb(35, 37, 57);
        Color iColorPresionado = Color.FromArgb(54, 57, 89);
        Color iColorForeground = Color.FromArgb(179, 182, 208);
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = iColorBackground;
            LabelTitulo.ForeColor = iColorForeground;
            BotonPersonas.ForeColor = iColorForeground;
            BotonJuicios.ForeColor = iColorForeground;
            BotonAgenda.ForeColor = iColorForeground;
            BotonPagos.ForeColor = iColorForeground;
            BotonCobros.ForeColor = iColorForeground;
            BotonDocumentos.ForeColor = iColorForeground;
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
                FlechaDocumentos.Visible = false;
                BotonPersonas.BackColor = iColorPresionado;
                BotonJuicios.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                BotonDocumentos.BackColor = iColorBackground;
                MenuPersonasUC iMenuNuevo = new MenuPersonasUC(iColorForeground);
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
                FlechaDocumentos.Visible = false;
                BotonJuicios.BackColor = iColorPresionado;
                BotonPersonas.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                BotonDocumentos.BackColor = iColorBackground;
                MenuJuiciosUC iMenuNuevo = new MenuJuiciosUC(iColorForeground);
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
                FlechaDocumentos.Visible = false;
                BotonAgenda.BackColor = iColorPresionado;
                BotonJuicios.BackColor = iColorBackground;
                BotonPersonas.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                BotonDocumentos.BackColor = iColorBackground;
                MenuAgendaUC iMenuNuevo = new MenuAgendaUC(iColorForeground);
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
                FlechaDocumentos.Visible = false;
                BotonPagos.BackColor = iColorPresionado;
                BotonJuicios.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPersonas.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                BotonDocumentos.BackColor = iColorBackground;
                MenuPagosUC iMenuNuevo = new MenuPagosUC(iColorForeground);
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
                FlechaDocumentos.Visible = false;
                BotonCobros.BackColor = iColorPresionado;
                BotonJuicios.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonPersonas.BackColor = iColorBackground;
                BotonDocumentos.BackColor = iColorBackground;
                MenuCobrosUC iMenuNuevo = new MenuCobrosUC(iColorForeground);
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

        private void BotonDocumentos_Click(object sender, EventArgs e)
        {
            if (BotonDocumentos.BackColor == iColorBackground)
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = false;
                FlechaDocumentos.Visible = true;
                BotonDocumentos.BackColor = iColorPresionado;
                BotonJuicios.BackColor = iColorBackground;
                BotonAgenda.BackColor = iColorBackground;
                BotonPagos.BackColor = iColorBackground;
                BotonCobros.BackColor = iColorBackground;
                BotonPersonas.BackColor = iColorBackground;
                MenuDocumentosUC iMenuNuevo = new MenuDocumentosUC(iColorForeground);
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonDocumentos.BackColor = iColorBackground;
                FlechaDocumentos.Visible = false;
            }
        }
    }
}
