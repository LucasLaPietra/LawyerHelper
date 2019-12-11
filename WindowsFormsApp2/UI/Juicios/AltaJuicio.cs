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
            ListBoxDemandados.DisplayMember = "NombreyAp";
            ListBoxDemandantes.DataSource = iListaDemandantes;
            ListBoxDemandantes.DisplayMember = "NombreyAp";
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
                    CuadroFolio.Text, CuadroLibro.Text, CuadroJurisdiccion.Text, Convert.ToDouble(CuadroPrecio.Value));
                iFachada.AltaDemandadosyDemandantes(CuadroExpediente.Text, iListaDemandados, iListaDemandantes, RadioButtonDemandados.Checked, RadioButtonDemandantes.Checked);
                MessageBox.Show("Juicio añadido con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe cargarse al menos un demandado y un demandante", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("juicio no fue añadido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }

        private void BotonAgregarDemandante_Click(object sender, EventArgs e)
        {
            try
            { 
            BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                Persona iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                iListaDemandantes.Add(iPersona);
                ListBoxDemandantes.DataSource = null;
                ListBoxDemandantes.DataSource = iListaDemandantes;
                ListBoxDemandantes.DisplayMember = "NombreyAp";
                if (ListBoxDemandantes.Items.Count > 1)
                {
                    BotonEliminarDemandante.Enabled = true;
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("No se devolvio ninguna persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonEliminarDemandante_Click(object sender, EventArgs e)
        {
            int selectedIndex = ListBoxDemandantes.SelectedIndex;
            iListaDemandantes.RemoveAt(selectedIndex);
            ListBoxDemandantes.DataSource = null;
            ListBoxDemandantes.DataSource = iListaDemandantes;
            ListBoxDemandantes.DisplayMember = "NombreyAp";
            if (ListBoxDemandantes.Items.Count <= 1)
            {
                BotonEliminarDemandante.Enabled = false;
            }
        }

        private void BotonAgregarDemandado_Click(object sender, EventArgs e)
        {
            try
            { 
                BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                Persona iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                iListaDemandados.Add(iPersona);
                ListBoxDemandados.DataSource = null;
                ListBoxDemandados.DataSource = iListaDemandados;
                ListBoxDemandados.DisplayMember = "NombreyAp";
                if (ListBoxDemandados.Items.Count > 1)
                {
                    BotonEliminarDemandado.Enabled = true;
                }
            }
            }
            catch (Exception)
            {
                MessageBox.Show("No se devolvio ninguna persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonEliminarDemandado_Click(object sender, EventArgs e)
        {
            iListaDemandados.Remove((Persona)ListBoxDemandados.SelectedItem);
            ListBoxDemandados.DataSource = null;
            ListBoxDemandados.DataSource = iListaDemandados;
            ListBoxDemandados.DisplayMember = "NombreyAp";
            if (ListBoxDemandados.Items.Count <=1)
            {
                BotonEliminarDemandado.Enabled = false;
            }
        }        

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }     

        private void CuadroExpediente_KeyPress(object sender, KeyPressEventArgs e)
        {
            iFachada.SoloNumeros(e);
        }
    }
}
