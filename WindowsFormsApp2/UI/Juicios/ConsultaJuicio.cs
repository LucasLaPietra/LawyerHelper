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
using LawyerHelper.UI.Juicios;

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
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BotonVerDocumentacion_Click(object sender, EventArgs e)
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
            //try
            //{
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
            //}
            //catch (Exception)
            //{
             //   MessageBox.Show("Error al buscar el juicio, verifique que los campos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
                ListBoxDemandados.DisplayMember = "NombreyAp";
                ListBoxDemandantes.DataSource = iDemandantes;
                ListBoxDemandantes.DisplayMember = "NombreyAp";
                ListBoxDocumentos.DataSource = iJuicio.Documentos;
                ListBoxDocumentos.DisplayMember = "Nombre";
            }
        }
    }
}
