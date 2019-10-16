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

namespace WindowsFormsApp2.Personas
{
    public partial class AltaPersona : Form
    {
        ControladorPersona iControladorPersona;
        //UnidadDeTrabajo iUdt;
        public AltaPersona()
        {
            InitializeComponent();
            iControladorPersona =new ControladorPersona(UnidadDeTrabajo.Instancia);
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                iControladorPersona.RegistrarPersona(CuadroNombre.Text, CuadroApellido.Text, CuadroDNI.Text, CuadroDomReal.Text, CuadroTelefono.Text, CuadroFecha.Value, CuadroProfesion.Text, CuadroLugarTrabajo.Text, CuadroCUIL.Text, CuadroEstadoCivil.Text, CuadroAbogado.Text, CuadroDomLegal.Text);
                MessageBox.Show("Persona añadida con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Persona no fue añadida", "Error", MessageBoxButtons.OK,MessageBoxIcon.Error);
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

        private void AltaPersona_Load(object sender, EventArgs e)
        {

        }
    }
}
