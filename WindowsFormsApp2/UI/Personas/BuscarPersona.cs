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
        Persona iSeleccionado;
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
                iResultados = iControladorPersona.BusquedaAvanzadaPersonaActivos(comboBoxParametro.SelectedItem.ToString(), CuadroParametro.Text,!CheckBoxEliminados.Checked).ToList();
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
            try
            {
                if(iSeleccionado.Activo==false)
                {
                    DialogResult result = MessageBox.Show("Esta persona esta eliminada, quiere volver a darla de alta?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        iControladorPersona.AltaLogicaPersona(iSeleccionado);
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
                MessageBox.Show("Ya existe una persona activa con este DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ComboBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            iSeleccionado = (Persona)ComboBoxResultados.SelectedItem;
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
                iResultados = iControladorPersona.ObtenerTodosActivos(!CheckBoxEliminados.Checked).ToList();
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
