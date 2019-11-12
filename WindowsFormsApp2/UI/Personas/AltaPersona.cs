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

namespace WindowsFormsApp2.Personas
{
    public partial class AltaPersona : Form
    {
        ControladorPersona iControladorPersona;
        Fachada iFachada = new Fachada();
        public AltaPersona()
        {
            InitializeComponent();
            iControladorPersona =new ControladorPersona(UnidadDeTrabajo.Instancia);
            iFachada.AsignarColores(this);
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            //try
            //{                
                iControladorPersona.RegistrarPersona(CuadroDNI.Text, CuadroApellido.Text, CuadroNombre.Text, CuadroDomReal.Text, CuadroTelefono.Text, CuadroFecha.Value, CuadroProfesion.Text, CuadroLugarTrabajo.Text, CuadroCUIL.Text, CuadroEstadoCivil.Text, CuadroRepresentante.Text, CuadroDomLegal.Text);
                MessageBox.Show("Persona añadida con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            /*}
            catch (InvalidOperationException)
            {
                MessageBox.Show("Ya existe una persona con ese mismo DNI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Persona no fue añadida", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }*/
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void AltaPersona_Load(object sender, EventArgs e)
        {

        }

        private void CuadroFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void CuadroNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
