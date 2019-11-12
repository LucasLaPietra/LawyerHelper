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
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using WindowsFormsApp2;

namespace LawyerHelper.UI.Personas
{

    public partial class BuscarPersona : Form
    {
        object iResultado;
        public object PersonaEncontrada
        { get {return iResultado;}
            set {iResultado = value;}
        }
        Fachada iFachada = new Fachada();
        List<Persona> iResultados;
        ControladorPersona iControladorPersona;
        public BuscarPersona()
        {
            InitializeComponent();
            iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
            iFachada.AsignarColores(this);
        }

        private void BuscarPersona_Load(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iResultados = iControladorPersona.BusquedaAvanzadaPersona(comboBoxParametro.SelectedItem.ToString(), CuadroParametro.Text).ToList();
                ComboBoxResultados.DataSource = iResultados;
                ComboBoxResultados.DisplayMember = "NombreyAp";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            iResultado = ComboBoxResultados.SelectedItem;            
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Persona iSeleccionado = (Persona)ComboBoxResultados.SelectedItem;
            LabelNombre2.Text = iSeleccionado.Nombre;
            LabelApellido2.Text = iSeleccionado.Apellido;
            LabelDNI2.Text = iSeleccionado.Dni;
            LabelDomicilio2.Text = iSeleccionado.Domicilio;
            LabelTelefono2.Text = iSeleccionado.Telefono;
            LabelFechaDeNacimiento2.Text = iSeleccionado.FechaNacimiento.ToShortDateString();
            LabelProfesion2.Text = iSeleccionado.Profesion;
            LabelCUIL2.Text = iSeleccionado.Cuil;
        }

        private void BotonMostrarTodos_Click(object sender, EventArgs e)
        {
            try
            {
                iResultados = iControladorPersona.ObtenerTodos().ToList();
                ComboBoxResultados.DataSource = iResultados;
                ComboBoxResultados.DisplayMember = "NombreyAp";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al mostrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }
    }
}
