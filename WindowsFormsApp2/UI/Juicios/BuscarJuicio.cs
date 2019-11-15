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
                iResultados = iControladorJuicio.MostrarJuicios().ToList();
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
                iResultado = ComboBoxResultados.SelectedItem;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe seleccionar un juicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iResultados = iControladorJuicio.BusquedaAvanzadaJuicio(comboBoxParametro.SelectedItem.ToString(), CuadroParametro.Text).ToList();
                ComboBoxResultados.DataSource = iResultados;
                ComboBoxResultados.DisplayMember = "NroExpediente";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
