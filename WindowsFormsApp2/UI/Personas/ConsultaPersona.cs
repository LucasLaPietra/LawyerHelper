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
using WindowsFormsApp2.Juicios;
using LawyerHelper.UI.Juicios;
using LawyerHelper.UI.Cobros;

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

        public ConsultaPersona(Persona pPersona)
        {
            InitializeComponent();
            iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
            //Asignacion de colores  
            iFachada.AsignarColores(this);

            BotonBuscar.Enabled = false;
            BotonBuscar.Visible = false;
            BotonBusquedaAvanzada.Enabled = false;
            BotonBusquedaAvanzada.Visible = false;
            CuadroApellido.ReadOnly = true;
            CuadroNombre.ReadOnly = true;

            CuadroNombre.Text = pPersona.Nombre;
            CuadroApellido.Text = pPersona.Apellido;
            LabelDNI2.Text = pPersona.Dni;
            LabelDomicilio2.Text = pPersona.Domicilio;
            LabelDomicilioLegal2.Text = pPersona.DomicilioLegal;
            LabelEstadoCivil2.Text = pPersona.EstadoCivil;
            LabelFechaNacimiento2.Text = pPersona.FechaNacimiento.ToShortDateString();
            LabelLugarTrabajo2.Text = pPersona.LugarTrabajo;
            LabelProfesion2.Text = pPersona.Profesion;
            LabelRepresentante2.Text = pPersona.Representante;
            LabelTelefono2.Text = pPersona.Telefono;

            BotonConsultarJuicio.Enabled = true;
            if (iPersona.Cobros.Count > 0)
                BotonConsultarCobro.Enabled = true;

            iJuicios = iControladorPersona.ObtenerJuicios(pPersona.PersonaId).ToList();
            iCobros = pPersona.Cobros.ToList();
            ListBoxJuicios.DataSource = iJuicios;
            ListBoxJuicios.DisplayMember = "NroExpediente";
            ListBoxCobros.DataSource = iCobros;
            ListBoxCobros.DisplayMember = "Descripcion";

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
            try
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

                    BotonConsultarJuicio.Enabled = true;
                    if (iPersona.Cobros.Count > 0)
                        BotonConsultarCobro.Enabled = true;

                    iJuicios = iControladorPersona.ObtenerJuicios(iPersona.PersonaId).ToList();
                    iCobros = iPersona.Cobros.ToList();
                    ListBoxJuicios.DataSource = iJuicios;
                    ListBoxJuicios.DisplayMember = "NroExpediente";
                    ListBoxCobros.DataSource = iCobros;
                    ListBoxCobros.DisplayMember = "Descripcion";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se devolvio ninguna persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                BotonConsultarJuicio.Enabled = true;
                if (iPersona.Cobros.Count > 0)
                    BotonConsultarCobro.Enabled = true;

                iJuicios = iControladorPersona.ObtenerJuicios(iPersona.PersonaId).ToList();
                iCobros = iPersona.Cobros.ToList();
                ListBoxJuicios.DataSource = iJuicios;
                ListBoxJuicios.DisplayMember = "NroExpediente";
                ListBoxCobros.DataSource = iCobros;
                ListBoxCobros.DisplayMember = "Descripcion";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar la persona, verifique que los campos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonConsultarJuicio_Click(object sender, EventArgs e)
        {
            ConsultaJuicios iMenuNuevo = new ConsultaJuicios(iJuicios[ListBoxJuicios.SelectedIndex]);
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsultarCobro_Click(object sender, EventArgs e)
        {
            ConsultaCobro iMenuNuevo = new ConsultaCobro(iCobros[ListBoxCobros.SelectedIndex]);
            iMenuNuevo.ShowDialog();
        }
    }
}
