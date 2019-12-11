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
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using LawyerHelper.UI.Personas;
using LawyerHelper.UI.Documentos;
using LawyerHelper.UI.Cobros;
using LawyerHelper.UI.Pagos;

namespace LawyerHelper.UI.Juicios
{
    public partial class BajaJuicio : Form
    {
        Juicio iJuicio;
        List<Demandado> iDemandados;
        List<Demandante> iDemandantes;
        List<Cobro> iCobros;
        List<Pago> iPagos;
        ControladorJuicio iControladorJuicio;
        Fachada iFachada = new Fachada();
        public BajaJuicio()
        {
            InitializeComponent();
            iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      

            iFachada.AsignarColores(this);
        }

        private void BotonConsultarDemandante_Click(object sender, EventArgs e)
        {
            ConsultaPersona iMenuNuevo = new ConsultaPersona(iDemandantes[ListBoxDemandantes.SelectedIndex].Persona);
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsultarDemandados_Click(object sender, EventArgs e)
        {
            ConsultaPersona iMenuNuevo = new ConsultaPersona(iDemandados[ListBoxDemandados.SelectedIndex].Persona);
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
            try
            {
                DialogResult iMensaje = MessageBox.Show("Seguro que desea dar de baja a este juicio?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (iMensaje == DialogResult.Yes)
                {
                    iControladorJuicio.BajaLogicaJuicio(iJuicio);
                    MessageBox.Show("Juicio dada de baja con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de baja el juicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ListBoxCobros.DataSource = iCobros;
                ListBoxCobros.DisplayMember = "Descripcion";
                ListBoxPagos.DataSource = iPagos;
                ListBoxPagos.DisplayMember = "Descripcion";

                if (iJuicio.Cobros.Count > 0)
                    BotonConsultarCobro.Enabled = true;
                if (iJuicio.Pagos.Count > 0)
                    BotonConsultarPagos.Enabled = true;
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
            try
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
                    iDemandantes = iJuicio.Demandantes.ToList();
                    ListBoxDemandados.DataSource = iDemandados;
                    ListBoxDemandados.DisplayMember = "Descripcion";
                    ListBoxDemandantes.DataSource = iDemandantes;
                    ListBoxDemandantes.DisplayMember = "Descripcion";
                    ListBoxCobros.DataSource = iCobros;
                    ListBoxCobros.DisplayMember = "Descripcion";
                    ListBoxPagos.DataSource = iPagos;
                    ListBoxPagos.DisplayMember = "Descripcion";

                    if (iJuicio.Cobros.Count > 0)
                        BotonConsultarCobro.Enabled = true;
                    if (iJuicio.Pagos.Count > 0)
                        BotonConsultarPagos.Enabled = true;
                    BotonConsultarDemandados.Enabled = true;
                    BotonConsultarDemandante.Enabled = true;
                    BotonConsultarDocumentos.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se devolvio ningun juicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonConsultarDocumentos_Click_1(object sender, EventArgs e)
        {
            ConsultaDocumento iMenuNuevo = new ConsultaDocumento(iJuicio);
            iMenuNuevo.ShowDialog();
        }

        private void CuadroNroExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            iFachada.SoloNumeros(e);
        }

        private void BotonConsultarCobro_Click(object sender, EventArgs e)
        {
            ConsultaCobro iMenuNuevo = new ConsultaCobro(iCobros[ListBoxCobros.SelectedIndex]);
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsultarPagos_Click(object sender, EventArgs e)
        {
            ConsultaPago iMenuNuevo = new ConsultaPago(iPagos[ListBoxPagos.SelectedIndex]);
            iMenuNuevo.ShowDialog();
        }
    }
}
