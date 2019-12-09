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
using LawyerHelper.UI.Cobros;


namespace LawyerHelper.UI.Personas
{
    public partial class ModificarPersona : Form
    {
        Fachada iFachada = new Fachada();
        List<Juicio> iJuicios;
        List<Cobro> iCobros;
        ControladorPersona iControladorPersona;
        Persona iPersona= new Persona();
        public ModificarPersona()
        {
            InitializeComponent();
            iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
            //Asignacion de colores  
            iFachada.AsignarColores(this);                         
        }

        private void LabelDomicilio2_Click(object sender, EventArgs e)
        {

        }

        private void ModificarPersona_Load(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iPersona = iControladorPersona.BusquedaPorNombreyAp(CuadroApellido.Text, CuadroNombre.Text);
                CuadroDNI.Text = iPersona.Dni;
                CuadroDomicilio.Text = iPersona.Domicilio;
                CuadroDomicilioLegal.Text = iPersona.DomicilioLegal;
                CuadroEstadoCivil.Text = iPersona.EstadoCivil;
                CuadroFechaNacimiento.Value = iPersona.FechaNacimiento;
                CuadroLugarTrabajo.Text = iPersona.LugarTrabajo;
                CuadroProfesion.Text = iPersona.Profesion;
                CuadroRepresentante.Text = iPersona.Representante;
                CuadroTelefono.Text = iPersona.Telefono;

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

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iMensaje = MessageBox.Show("Seguro que desea modificar esta persona?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (iMensaje == DialogResult.Yes)
                {
                    iControladorPersona.ModificarPersona(iPersona.PersonaId,CuadroNombre.Text, CuadroApellido.Text, CuadroDNI.Text, CuadroDomicilio.Text, CuadroTelefono.Text, CuadroFechaNacimiento.Value, CuadroProfesion.Text, CuadroLugarTrabajo.Text, CuadroCUIL.Text, CuadroEstadoCivil.Text, CuadroRepresentante.Text, CuadroDomicilioLegal.Text);
                    MessageBox.Show("Persona modificada con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar la persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que dese cancelar?", "Cancelar", MessageBoxButtons.YesNoCancel);

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
                    CuadroApellido.Text = iPersona.Apellido;
                    CuadroNombre.Text = iPersona.Nombre;
                    CuadroDNI.Text = iPersona.Dni;
                    CuadroDomicilio.Text = iPersona.Domicilio;
                    CuadroDomicilioLegal.Text = iPersona.DomicilioLegal;
                    CuadroEstadoCivil.Text = iPersona.EstadoCivil;
                    CuadroFechaNacimiento.Value = iPersona.FechaNacimiento;
                    CuadroLugarTrabajo.Text = iPersona.LugarTrabajo;
                    CuadroProfesion.Text = iPersona.Profesion;
                    CuadroRepresentante.Text = iPersona.Representante;
                    CuadroTelefono.Text = iPersona.Telefono;

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

        private void ListBoxJuicios_SelectedIndexChanged(object sender, EventArgs e)
        {

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
