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

namespace WindowsFormsApp2.Personas
{
    public partial class AltaPersona : Form
    {
        public AltaPersona()
        {
            InitializeComponent();
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            using (Contexto db = new Contexto())
            {
                Persona iPersona = new Persona(CuadroNombre.Text, CuadroApellido.Text, CuadroDNI.Text, CuadroDomReal.Text, CuadroTelefono.Text, CuadroFecha.Value, CuadroProfesion.Text, CuadroLugarTrabajo.Text, CuadroCUIL.Text, CuadroEstadoCivil.Text, CuadroAbogado.Text, CuadroDomLegal.Text);
                db.Personas.Add(iPersona);
                db.SaveChanges();
            }               
            MessageBox.Show("Persona añadida con exito!","Exito");
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
