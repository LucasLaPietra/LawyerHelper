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
using WindowsFormsApp2;
using WindowsFormsApp2.Personas;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using LawyerHelper.UI.Juicios;
using LawyerHelper.UI.Personas;
using LawyerHelper.UI.Documentos;

namespace WindowsFormsApp2.Juicios
{
    public partial class ConsultaJuicios : Form
    {
        Juicio iJuicio;
        List<Demandado> iDemandados;
        List<Demandante> iDemandantes;
        Fachada iFachada = new Fachada();
        ControladorJuicio iControladorJuicio;
        public ConsultaJuicios()
        {
            InitializeComponent();
            iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);
        }

        public ConsultaJuicios(Juicio pJuicio)
        {
            InitializeComponent();
            iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);

            BotonBuscar.Enabled = false;
            BotonBuscar.Visible = false;
            BotonBusquedaAvanzada.Enabled = false;
            BotonBusquedaAvanzada.Visible = false;
            CuadroNroExpediente.ReadOnly = true;
            CuadroNroExpediente.Text = pJuicio.NroExpediente;

            CuadroBienes.Text = pJuicio.Bienes;
            CuadroDescripcion.Text = pJuicio.Descripcion;
            CuadroGrupoFamiliar.Text = pJuicio.GrupoFamiliar;
            LabelCaratula2.Text = pJuicio.Caratula;
            LabelCompetencia2.Text = pJuicio.Competencia;
            LabelEtapa2.Text = pJuicio.Etapa;
            LabelExpediente2.Text = pJuicio.NroExpediente;
            LabelFecha2.Text = pJuicio.Fecha.ToShortDateString();
            LabelFolio2.Text = pJuicio.Folio;
            LabelJuez2.Text = pJuicio.Juez;
            LabelJurisdiccion2.Text = pJuicio.Jurisdiccion;
            labelLibro2.Text = pJuicio.Libro;
            LabelPrecio2.Text = pJuicio.Precio.ToString();
            LabelRecurso2.Text = pJuicio.Recurso;
            LabelSecretario2.Text = pJuicio.Secretario;
            LabelTipoProceso2.Text = pJuicio.TipoProceso;
            LabelFuero2.Text = pJuicio.Fuero;

            iDemandados = pJuicio.Demandados.ToList();
            iDemandantes = pJuicio.Demandantes.ToList();
            ListBoxDemandados.DataSource = iDemandados;
            ListBoxDemandados.DisplayMember = "Descripcion";
            ListBoxDemandantes.DataSource = iDemandantes;
            ListBoxDemandantes.DisplayMember = "Descripcion";
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que desea cerrar la ventana?", "Aceptar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iJuicio = iControladorJuicio.BusquedaPorNroExpediente(CuadroNroExpediente.Text);
                CuadroBienes.Text = iJuicio.Bienes;
                CuadroDescripcion.Text = iJuicio.Descripcion;
                CuadroGrupoFamiliar.Text = iJuicio.GrupoFamiliar;
                LabelCaratula2.Text = iJuicio.Caratula;
                LabelCompetencia2.Text = iJuicio.Competencia;
                LabelEtapa2.Text = iJuicio.Etapa;
                LabelExpediente2.Text = iJuicio.NroExpediente;
                LabelFecha2.Text = iJuicio.Fecha.ToShortDateString();
                LabelFolio2.Text = iJuicio.Folio;
                LabelJuez2.Text = iJuicio.Juez;
                LabelJurisdiccion2.Text = iJuicio.Jurisdiccion;
                labelLibro2.Text = iJuicio.Libro;
                LabelPrecio2.Text = iJuicio.Precio.ToString();
                LabelRecurso2.Text = iJuicio.Recurso;
                LabelSecretario2.Text = iJuicio.Secretario;
                LabelTipoProceso2.Text = iJuicio.TipoProceso;
                LabelFuero2.Text = iJuicio.Fuero;

                iDemandados = iJuicio.Demandados.ToList();
                iDemandantes = iJuicio.Demandantes.ToList();
                ListBoxDemandados.DataSource = iDemandados;
                ListBoxDemandados.DisplayMember = "Descripcion";
                ListBoxDemandantes.DataSource = iDemandantes;
                ListBoxDemandantes.DisplayMember = "Descripcion";
                BotonConsultarDemandados.Enabled = true;
                BotonConsultarDemandante.Enabled = true;
                BotonConsultarDocumentos.Enabled = true;
            }
            catch (Exception)
            {
               MessageBox.Show("Error al buscar el juicio, verifique que los campos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            BuscarJuicio iMenuNuevo = new BuscarJuicio();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                iJuicio = (Juicio)iMenuNuevo.JuicioEncontrado;
                CuadroBienes.Text = iJuicio.Bienes;
                CuadroDescripcion.Text = iJuicio.Descripcion;
                CuadroGrupoFamiliar.Text = iJuicio.GrupoFamiliar;
                LabelCaratula2.Text = iJuicio.Caratula;
                LabelCompetencia2.Text = iJuicio.Competencia;
                LabelEtapa2.Text = iJuicio.Etapa;
                LabelExpediente2.Text = iJuicio.NroExpediente;
                LabelFecha2.Text = iJuicio.Fecha.ToShortDateString();
                LabelFolio2.Text = iJuicio.Folio;
                LabelJuez2.Text = iJuicio.Juez;
                LabelJurisdiccion2.Text = iJuicio.Jurisdiccion;
                labelLibro2.Text = iJuicio.Libro;
                LabelPrecio2.Text = iJuicio.Precio.ToString();
                LabelRecurso2.Text = iJuicio.Recurso;
                LabelSecretario2.Text = iJuicio.Secretario;
                LabelTipoProceso2.Text = iJuicio.TipoProceso;
                LabelFuero2.Text = iJuicio.Fuero;

                iDemandados = iJuicio.Demandados.ToList();
                iDemandantes = iControladorJuicio.ObtenerDemandantes(iJuicio.JuicioId).ToList();
                ListBoxDemandados.DataSource =iDemandados;
                ListBoxDemandados.DisplayMember = "Descripcion";
                ListBoxDemandantes.DataSource = iDemandantes;
                ListBoxDemandantes.DisplayMember = "Descripcion";
                BotonConsultarDemandados.Enabled = true;
                BotonConsultarDemandante.Enabled = true;
                BotonConsultarDocumentos.Enabled = true;
            }
        }

        private void BotonConsultarDemandantes_Click(object sender, EventArgs e)
        {
            ConsultaPersona iMenuNuevo = new ConsultaPersona(iDemandantes[ListBoxDemandantes.SelectedIndex].Persona);
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsultarDemandados_Click(object sender, EventArgs e)
        {
            ConsultaPersona iMenuNuevo = new ConsultaPersona(iDemandados[ListBoxDemandados.SelectedIndex].Persona);
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsultarDocumentos_Click(object sender, EventArgs e)
        {
            ConsultaDocumento iMenuNuevo = new ConsultaDocumento(iJuicio);
            iMenuNuevo.ShowDialog();
        }
    }
}
