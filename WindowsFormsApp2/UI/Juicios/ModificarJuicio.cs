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
using WindowsFormsApp2;
using LawyerHelper.UI.Documentos;

namespace LawyerHelper.UI.Juicios
{
    public partial class ModificarJuicio : Form
    {
        Juicio iJuicio;
        List<Demandado> iDemandados;
        List<Demandante> iDemandantes;
        Fachada iFachada = new Fachada();
        ControladorJuicio iControladorJuicio;
        public ModificarJuicio()
        {
            InitializeComponent();
            iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);
        }
    
        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iJuicio = iControladorJuicio.BusquedaPorNroExpediente(CuadroNroExpediente.Text);
                CuadroBienes.Text = iJuicio.Bienes;
                CuadroDescripcion.Text = iJuicio.Descripcion;
                CuadroGrupoFamiliar.Text = iJuicio.GrupoFamiliar;
                CuadroCaratula.Text = iJuicio.Caratula;
                CuadroCompetencia.Text = iJuicio.Competencia;
                CuadroEtapa.Text = iJuicio.Etapa;
                dateTimeFecha.Text = iJuicio.Fecha.ToShortDateString();
                CuadroFolio.Text = iJuicio.Folio;
                CuadroJuez.Text = iJuicio.Juez;
                CuadroJurisdiccion.Text = iJuicio.Jurisdiccion;
                CuadroLibro.Text = iJuicio.Libro;
                CuadroPrecio.Text = iJuicio.Precio.ToString();
                CuadroRecurso.Text = iJuicio.Recurso;
                CuadroSecretario.Text = iJuicio.Secretario;
                CuadroTipoDeProceso.Text = iJuicio.TipoProceso;
                CuadroFuero.Text = iJuicio.Fuero;

                iDemandados = iJuicio.Demandados.ToList();
                iDemandantes = iJuicio.Demandantes.ToList();
                ListBoxDemandados.DataSource = iDemandados;
                ListBoxDemandados.DisplayMember = "Descripcion";
                ListBoxDemandantes.DataSource = iDemandantes;
                ListBoxDemandantes.DisplayMember = "Descripcion";
                BotonAgregarDemandado.Enabled = true;
                if (iDemandados.Count > 1)
                    BotonEliminarDemandado.Enabled = true;
                BotonConsultarDemandado.Enabled = true;
                BotonAgregarDemandante.Enabled = true;
                if (iDemandados.Count > 1)
                    BotonEliminarDemandante.Enabled = true;
                BotonConsultarDemandante.Enabled = true;
                BotonEliminarDocumentos.Enabled = true;
                BotonModificarDocumentos.Enabled = true;
                BotonConsultarDocumentos.Enabled = true;
                BotonAgregarDocumentos.Enabled = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar el juicio, verifique que los campos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonAgregarDocumentos_Click(object sender, EventArgs e)
        {
            AltaDocumento iMenuNuevo = new AltaDocumento(iJuicio);
            iMenuNuevo.ShowDialog();
        }

        private void BotonEliminarDocumentos_Click(object sender, EventArgs e)
        {
            BajaDocumento iMenuNuevo = new BajaDocumento(iJuicio);
            iMenuNuevo.ShowDialog();
        }

        private void BotonModificarDocumentos_Click(object sender, EventArgs e)
        {
            ModificarDocumento iMenuNuevo = new ModificarDocumento(iJuicio);
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsultarDocumentos_Click(object sender, EventArgs e)
        {
            ConsultaDocumento iMenuNuevo = new ConsultaDocumento(iJuicio);
            iMenuNuevo.ShowDialog();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que desea cerrar la ventana?", "Aceptar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void BotonAgregarDemandante_Click(object sender, EventArgs e)
        {

        }

        private void BotonEliminarDemandante_Click(object sender, EventArgs e)
        {

        }

        private void BotonAgregarDemandado_Click(object sender, EventArgs e)
        {

        }

        private void BotonEliminarDemandado_Click(object sender, EventArgs e)
        {

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
                CuadroCaratula.Text = iJuicio.Caratula;
                CuadroCompetencia.Text = iJuicio.Competencia;
                CuadroEtapa.Text = iJuicio.Etapa;
                CuadroNroExpediente.Text = iJuicio.NroExpediente;
                dateTimeFecha.Text = iJuicio.Fecha.ToShortDateString();
                CuadroFolio.Text = iJuicio.Folio;
                CuadroJuez.Text = iJuicio.Juez;
                CuadroJurisdiccion.Text = iJuicio.Jurisdiccion;
                CuadroLibro.Text = iJuicio.Libro;
                CuadroPrecio.Text = iJuicio.Precio.ToString();
                CuadroRecurso.Text = iJuicio.Recurso;
                CuadroSecretario.Text = iJuicio.Secretario;
                CuadroTipoDeProceso.Text = iJuicio.TipoProceso;
                CuadroFuero.Text = iJuicio.Fuero;

                iDemandados = iJuicio.Demandados.ToList();
                iDemandantes = iJuicio.Demandantes.ToList();
                ListBoxDemandados.DataSource = iDemandados;
                ListBoxDemandados.DisplayMember = "Descripcion";
                ListBoxDemandantes.DataSource = iDemandantes;
                ListBoxDemandantes.DisplayMember = "Descripcion";
                BotonAgregarDemandado.Enabled = true;
                if (iDemandados.Count > 1)
                    BotonEliminarDemandado.Enabled = true;
                BotonConsultarDemandado.Enabled = true;
                BotonAgregarDemandante.Enabled = true;
                if (iDemandados.Count > 1)
                    BotonEliminarDemandante.Enabled = true;
                BotonConsultarDemandante.Enabled = true;
                BotonEliminarDocumentos.Enabled = true;
                BotonModificarDocumentos.Enabled = true;
                BotonConsultarDocumentos.Enabled = true;
                BotonAgregarDocumentos.Enabled = true;
            }
        }
    }
}
