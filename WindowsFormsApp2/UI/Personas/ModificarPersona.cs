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


namespace LawyerHelper.UI.Personas
{
    public partial class ModificarPersona : Form
    {
        ControladorPersona iControladorPersona;
        Persona iPersona;
        public ModificarPersona()
        {
            InitializeComponent();
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
                DialogResult iMensaje = MessageBox.Show("Seguro que desea dar de baja a esta persona?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (iMensaje == DialogResult.Yes)
                {
                    iControladorPersona.ModificarPersona(CuadroNombre.Text, CuadroApellido.Text, CuadroDNI.Text, CuadroDomicilio.Text, CuadroTelefono.Text, CuadroFechaNacimiento.Value, CuadroProfesion.Text, CuadroLugarTrabajo.Text, CuadroCUIL.Text, CuadroEstadoCivil.Text, CuadroRepresentante.Text, CuadroDomicilioLegal.Text);
                    MessageBox.Show("Persona modificada con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de baja la persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
