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
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BotonPersonas_Click(object sender, EventArgs e)
        {
            if (BotonPersonas.BackColor== Color.FromArgb(35, 37, 57))
            {
                FlechaPersonas.Visible = true;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = false;
                FlechaDocumentos.Visible = false;
                BotonPersonas.BackColor = Color.FromArgb(54, 57, 89);
                BotonJuicios.BackColor = Color.FromArgb(35, 37, 57);
                BotonAgenda.BackColor = Color.FromArgb(35, 37, 57);
                BotonPagos.BackColor = Color.FromArgb(35, 37, 57);
                BotonCobros.BackColor = Color.FromArgb(35, 37, 57);
                BotonDocumentos.BackColor = Color.FromArgb(35, 37, 57);
                MenuPersonasUC iMenuNuevo = new MenuPersonasUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonPersonas.BackColor = Color.FromArgb(35, 37, 57);
                FlechaPersonas.Visible = false;
            }            
        }

        private void BotonJuicios_Click(object sender, EventArgs e)
        {
            if (BotonJuicios.BackColor == Color.FromArgb(35, 37, 57))
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = true;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = false;
                FlechaDocumentos.Visible = false;
                BotonJuicios.BackColor = Color.FromArgb(54, 57, 89);
                BotonPersonas.BackColor = Color.FromArgb(35, 37, 57);
                BotonAgenda.BackColor = Color.FromArgb(35, 37, 57);
                BotonPagos.BackColor = Color.FromArgb(35, 37, 57);
                BotonCobros.BackColor = Color.FromArgb(35, 37, 57);
                BotonDocumentos.BackColor = Color.FromArgb(35, 37, 57);
                MenuJuiciosUC iMenuNuevo = new MenuJuiciosUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonJuicios.BackColor = Color.FromArgb(35, 37, 57);
                FlechaJuicios.Visible = false;
            }
        }

        private void BotonAgenda_Click(object sender, EventArgs e)
        {
            if (BotonAgenda.BackColor == Color.FromArgb(35, 37, 57))
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = true;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = false;
                FlechaDocumentos.Visible = false;
                BotonAgenda.BackColor = Color.FromArgb(54, 57, 89);
                BotonJuicios.BackColor = Color.FromArgb(35, 37, 57);
                BotonPersonas.BackColor = Color.FromArgb(35, 37, 57);
                BotonPagos.BackColor = Color.FromArgb(35, 37, 57);
                BotonCobros.BackColor = Color.FromArgb(35, 37, 57);
                BotonDocumentos.BackColor = Color.FromArgb(35, 37, 57);
                MenuAgendaUC iMenuNuevo = new MenuAgendaUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonAgenda.BackColor = Color.FromArgb(35, 37, 57);
                FlechaAgenda.Visible = false;
            }
        }

        private void BotonPagos_Click(object sender, EventArgs e)
        {
            if (BotonPagos.BackColor == Color.FromArgb(35, 37, 57))
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = true;
                FlechaCobros.Visible = false;
                FlechaDocumentos.Visible = false;
                BotonPagos.BackColor = Color.FromArgb(54, 57, 89);
                BotonJuicios.BackColor = Color.FromArgb(35, 37, 57);
                BotonAgenda.BackColor = Color.FromArgb(35, 37, 57);
                BotonPersonas.BackColor = Color.FromArgb(35, 37, 57);
                BotonCobros.BackColor = Color.FromArgb(35, 37, 57);
                BotonDocumentos.BackColor = Color.FromArgb(35, 37, 57);
                MenuPagosUC iMenuNuevo = new MenuPagosUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonPagos.BackColor = Color.FromArgb(35, 37, 57);
                FlechaPagos.Visible = false;
            }
        }

        private void BotonCobros_Click(object sender, EventArgs e)
        {
            if (BotonCobros.BackColor == Color.FromArgb(35, 37, 57))
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = true;
                FlechaDocumentos.Visible = false;
                BotonCobros.BackColor = Color.FromArgb(54, 57, 89);
                BotonJuicios.BackColor = Color.FromArgb(35, 37, 57);
                BotonAgenda.BackColor = Color.FromArgb(35, 37, 57);
                BotonPagos.BackColor = Color.FromArgb(35, 37, 57);
                BotonPersonas.BackColor = Color.FromArgb(35, 37, 57);
                BotonDocumentos.BackColor = Color.FromArgb(35, 37, 57);
                MenuCobrosUC iMenuNuevo = new MenuCobrosUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonCobros.BackColor = Color.FromArgb(35, 37, 57);
                FlechaCobros.Visible = false;
            }
        }

        private void BotonDocumentos_Click(object sender, EventArgs e)
        {
            if (BotonDocumentos.BackColor == Color.FromArgb(35, 37, 57))
            {
                FlechaPersonas.Visible = false;
                FlechaJuicios.Visible = false;
                FlechaAgenda.Visible = false;
                FlechaPagos.Visible = false;
                FlechaCobros.Visible = false;
                FlechaDocumentos.Visible = true;
                BotonDocumentos.BackColor = Color.FromArgb(54, 57, 89);
                BotonJuicios.BackColor = Color.FromArgb(35, 37, 57);
                BotonAgenda.BackColor = Color.FromArgb(35, 37, 57);
                BotonPagos.BackColor = Color.FromArgb(35, 37, 57);
                BotonCobros.BackColor = Color.FromArgb(35, 37, 57);
                BotonPersonas.BackColor = Color.FromArgb(35, 37, 57);
                MenuDocumentosUC iMenuNuevo = new MenuDocumentosUC();
                PanelOpciones.Controls.Clear();
                PanelOpciones.Controls.Add(iMenuNuevo);
            }
            else
            {
                PanelOpciones.Controls.Clear();
                BotonDocumentos.BackColor = Color.FromArgb(35, 37, 57);
                FlechaDocumentos.Visible = false;
            }
        }
    }
}
