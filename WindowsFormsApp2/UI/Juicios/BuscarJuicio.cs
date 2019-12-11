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

namespace LawyerHelper.UI.Juicios
{
    public partial class BuscarJuicio : Form
    {
        object iResultado;
        Juicio iJuicio;
        public object JuicioEncontrado
        {
            get { return iResultado; }
            set { iResultado = value; }
        }
        Fachada iFachada = new Fachada();
        List<Juicio> iResultados;
        ControladorJuicio iControladorJuicio;
        public BuscarJuicio()
        {
            InitializeComponent();
            iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
            iFachada.AsignarColores(this);
        }

        private void BotonMostrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                iResultados = iControladorJuicio.ObtenerTodosActivos(!CheckBoxEliminados.Checked).ToList();
                ComboBoxResultados.DataSource = iResultados;
                ComboBoxResultados.DisplayMember = "NroExpediente";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (iJuicio.Activo == false)
                {
                    DialogResult result = MessageBox.Show("Esta persona esta eliminada, quiere volver a darla de alta?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        iControladorJuicio.AltaLogicaJuicio(iJuicio);
                        iResultado = ComboBoxResultados.SelectedItem;
                    }
                    else if (result == DialogResult.No)
                    {
                        this.Close();
                    }
                }
                else
                {
                    iResultado = ComboBoxResultados.SelectedItem;
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Ya existe un juicio activo con este expediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
            
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iResultados = iControladorJuicio.BusquedaAvanzadaJuiciosActivos(comboBoxParametro.SelectedItem.ToString(), CuadroParametro.Text, !CheckBoxEliminados.Checked).ToList();
                ComboBoxResultados.DataSource = iResultados;
                ComboBoxResultados.DisplayMember = "NroExpediente";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            iJuicio = (Juicio)ComboBoxResultados.SelectedItem;
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
            List<Demandado> iDemandados = iJuicio.Demandados.ToList();
            List<Demandante> iDemandantes = iJuicio.Demandantes.ToList();
            ListBoxDemandados.DataSource = iDemandados;
            ListBoxDemandados.DisplayMember = "Descripcion";
            ListBoxDemandantes.DataSource = iDemandantes;
            ListBoxDemandantes.DisplayMember = "Descripcion";
        }
    }
}
