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


namespace WindowsFormsApp2.Juicios
{
    public partial class AltaJuicios : Form
    {
        ControladorJuicio iControladorJuicio;
        Fachada iFachada=new Fachada();
        List<Persona> iListaDemandados = new List<Persona>();
        List<Persona> iListaDemandantes = new List<Persona>();
        public AltaJuicios()
        {
            InitializeComponent();
            iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
            iFachada.AsignarColores(this);               
            ListBoxDemandados.DataSource = iListaDemandados;
            ListBoxDemandados.DisplayMember = "Apellido";
            ListBoxDemandantes.DataSource = iListaDemandantes;
            ListBoxDemandantes.DisplayMember = "Apellido";
        }

        private void AltaJuicios_Load(object sender, EventArgs e)
        {
            
        }

        

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                iControladorJuicio.RegistrarJuicio(CuadroExpediente.Text, CuadroJuez.Text, CuadroSecretario.Text, CuadroEtapa.Text, CuadroDescripcion.Text, CuadroBienes.Text,
                    dateTimeFecha.Value, CuadroGrupoFamiliar.Text, CuadroTipoDeProceso.Text, CuadroRecurso.Text, CuadroCompetencia.Text, CuadroFuero.Text, CuadroCaratula.Text,
                    CuadroFolio.Text, CuadroLibro.Text, CuadroJurisdiccion.Text, Convert.ToDouble(CuadroPrecio.Text));
                iFachada.AltaDemandadosyDemandantes(CuadroExpediente.Text, iListaDemandados, iListaDemandantes, RadioButtonDemandados.Checked, RadioButtonDemandantes.Checked);
                MessageBox.Show("Juicio añadido con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Ya existe un juicio con ese mismo numero de expediente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //catch (Exception)
            //{
            //    MessageBox.Show("juicio no fue añadido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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
                ListBoxDemandantes.DisplayMember = "Apellido";
            }
        }

        private void BotonEliminarDemandante_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxDemandantes.SelectedIndex;
            iListaDemandantes.RemoveAt(selectedIndex);
            ListBoxDemandantes.DataSource = null;
            ListBoxDemandantes.DataSource = iListaDemandantes;
            ListBoxDemandantes.DisplayMember = "Apellido";
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
                ListBoxDemandados.DisplayMember = "Apellido";
            }
        }

        private void BotonEliminarDemandado_Click(object sender, EventArgs e)
        {
            iListaDemandados.Remove((Persona)ListBoxDemandados.SelectedItem);
            ListBoxDemandados.DataSource = null;
            ListBoxDemandados.DataSource = iListaDemandados;
            ListBoxDemandados.DisplayMember = "Apellido";
            if (ListBoxDemandados.Items.Count == 0)
            {
                BotonEliminarDemandado.Enabled = false;
            }
        }

        private void BotonAgregarDocumentos_Click(object sender, EventArgs e)
        {

        }

        private void BotonEliminarDocumentos_Click(object sender, EventArgs e)
        {

        }

        private void BotonModificarDocumentos_Click(object sender, EventArgs e)
        {

        }
    }
}
