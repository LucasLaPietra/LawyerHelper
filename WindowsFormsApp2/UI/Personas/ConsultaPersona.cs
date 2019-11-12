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
    public partial class ConsultaPersona : Form
    {
        Fachada iFachada = new Fachada();
        List<Juicio> iJuicios;
        List<Cobro> iCobros;
        ControladorPersona iControladorPersona;
        Persona iPersona= new Persona();
        public ConsultaPersona()
        {
            InitializeComponent();
            iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
            //Asignacion de colores  
            iFachada.AsignarColores(this);

        }

     

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que desea cerrar la ventana?", "Aceptar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BotonBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                LabelDNI2.Text = iPersona.Dni;
                LabelDomicilio2.Text = iPersona.Domicilio;
                LabelDomicilioLegal2.Text = iPersona.DomicilioLegal;
                LabelEstadoCivil2.Text = iPersona.EstadoCivil;
                LabelFechaNacimiento2.Text = iPersona.FechaNacimiento.ToShortDateString();
                LabelLugarTrabajo2.Text = iPersona.LugarTrabajo;
                LabelProfesion2.Text = iPersona.Profesion;
                LabelRepresentante2.Text = iPersona.Representante;
                LabelTelefono2.Text = iPersona.Telefono;
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iPersona = iControladorPersona.BusquedaPorNombreyAp(CuadroApellido.Text, CuadroNombre.Text);
                LabelDNI2.Text = iPersona.Dni;
                LabelDomicilio2.Text = iPersona.Domicilio;
                LabelDomicilioLegal2.Text = iPersona.DomicilioLegal;
                LabelEstadoCivil2.Text = iPersona.EstadoCivil;
                LabelFechaNacimiento2.Text = iPersona.FechaNacimiento.ToShortDateString();
                LabelLugarTrabajo2.Text = iPersona.LugarTrabajo;
                LabelProfesion2.Text = iPersona.Profesion;
                LabelRepresentante2.Text = iPersona.Representante;
                LabelTelefono2.Text = iPersona.Telefono;

                iJuicios = iControladorPersona.ObtenerJuicios(iPersona.PersonaId).ToList();
                iCobros = iPersona.Cobros.ToList();
                ListBoxJuicios.DataSource = iJuicios;
                ListBoxJuicios.DisplayMember = "NumeroDeExpediente";
                ListBoxCobros.DataSource = iCobros;
                ListBoxCobros.DisplayMember = "Descripcion";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar la persona, verifique que los campos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
