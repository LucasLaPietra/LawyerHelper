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
        List<Persona> iListaDemandados = new List<Persona>();
        List<Persona> iListaDemandantes = new List<Persona>();
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
                if (iDemandados[0].Cliente==true)
                    RadioButtonCliente2.Checked = true;
                else
                    RadioButtonCliente1.Checked = true;
                foreach (Demandado i in iDemandados)
                    iListaDemandados.Add(i.Persona);
                foreach (Demandante i in iDemandantes)
                    iListaDemandantes.Add(i.Persona);
                ListBoxDemandados.DataSource = iListaDemandados;
                ListBoxDemandados.DisplayMember = "NombreyAp";
                ListBoxDemandantes.DataSource = iListaDemandantes;
                ListBoxDemandantes.DisplayMember = "NombreyAp";
                BotonAgregarDemandado.Enabled = true;
                if (iListaDemandados.Count > 1)
                    BotonEliminarDemandado.Enabled = true;
                BotonAgregarDemandante.Enabled = true;
                if (iListaDemandantes.Count > 1)
                    BotonEliminarDemandante.Enabled = true;
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
            try
            {
                iControladorJuicio.ModificarJuicio(iJuicio.JuicioId, CuadroNroExpediente.Text, CuadroJuez.Text, CuadroSecretario.Text, CuadroEtapa.Text, CuadroDescripcion.Text, CuadroBienes.Text,
                    dateTimeFecha.Value, CuadroGrupoFamiliar.Text, CuadroTipoDeProceso.Text, CuadroRecurso.Text, CuadroCompetencia.Text, CuadroFuero.Text, CuadroCaratula.Text,
                    CuadroFolio.Text, CuadroLibro.Text, CuadroJurisdiccion.Text, Convert.ToDouble(CuadroPrecio.Value));
                iFachada.ModificarDemandadosyDemandantes(CuadroNroExpediente.Text, iListaDemandados, iListaDemandantes, RadioButtonCliente2.Checked, RadioButtonCliente1.Checked);
                MessageBox.Show("Juicio modificado con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Ya existe un juicio con ese mismo numero de expediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (MissingMemberException)
            {
                MessageBox.Show("El demandante y demandado no puede ser la misma persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("juicio no fue modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonAgregarDemandante_Click(object sender, EventArgs e)
        {
            BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                Persona iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                iListaDemandantes.Add(iPersona);
                ListBoxDemandantes.DataSource = null;
                ListBoxDemandantes.DataSource = iListaDemandantes;
                ListBoxDemandantes.DisplayMember = "NombreyAp";
            }
        }

        private void BotonEliminarDemandante_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxDemandantes.SelectedIndex;
            iListaDemandantes.RemoveAt(selectedIndex);
            ListBoxDemandantes.DataSource = null;
            ListBoxDemandantes.DataSource = iListaDemandantes;
            ListBoxDemandantes.DisplayMember = "NombreyAp";
            if (ListBoxDemandantes.Items.Count == 0)
            {
                BotonEliminarDemandante.Enabled = false;
            }
        }

        private void BotonAgregarDemandado_Click(object sender, EventArgs e)
        {
            BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                Persona iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                iListaDemandados.Add(iPersona);
                ListBoxDemandados.DataSource = null;
                ListBoxDemandados.DataSource = iListaDemandados;
                ListBoxDemandados.DisplayMember = "NombreyAp";
            }
        }

        private void BotonEliminarDemandado_Click(object sender, EventArgs e)
        {
            iListaDemandados.Remove((Persona)ListBoxDemandados.SelectedItem);
            ListBoxDemandados.DataSource = null;
            ListBoxDemandados.DataSource = iListaDemandados;
            ListBoxDemandados.DisplayMember = "NombreyAp";
            if (ListBoxDemandados.Items.Count == 0)
            {
                BotonEliminarDemandado.Enabled = false;
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
                    if (iDemandados[0].Cliente == true)
                        RadioButtonCliente2.Checked = true;
                    else
                        RadioButtonCliente1.Checked = true;
                    foreach (Demandado i in iDemandados)
                        iListaDemandados.Add(i.Persona);
                    foreach (Demandante i in iDemandantes)
                        iListaDemandantes.Add(i.Persona);
                    ListBoxDemandados.DataSource = iListaDemandados;
                    ListBoxDemandados.DisplayMember = "NombreyAp";
                    ListBoxDemandantes.DataSource = iListaDemandantes;
                    ListBoxDemandantes.DisplayMember = "NombreyAp";
                    BotonAgregarDemandado.Enabled = true;
                    if (iListaDemandados.Count > 1)
                        BotonEliminarDemandado.Enabled = true;
                    BotonAgregarDemandante.Enabled = true;
                    if (iListaDemandantes.Count > 1)
                        BotonEliminarDemandante.Enabled = true;
                    BotonEliminarDocumentos.Enabled = true;
                    BotonModificarDocumentos.Enabled = true;
                    BotonConsultarDocumentos.Enabled = true;
                    BotonAgregarDocumentos.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se devolvio ningun juicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CuadroNroExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            iFachada.SoloNumeros(e);
        }
    }
}
