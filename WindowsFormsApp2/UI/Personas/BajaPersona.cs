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
    public partial class BajaPersona : Form
    {
        ControladorPersona iControladorPersona;
        Persona iPersona;
        public BajaPersona()
        {
            InitializeComponent();
            iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
        }

        private void BajaPersona_Load(object sender, EventArgs e)
        {
            
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iPersona = iControladorPersona.BusquedaPorNombreyAp(CuadroApellido.Text, CuadroNombre.Text);
                LabelNombre3.Text = iPersona.Nombre;
                LabelApellido3.Text = iPersona.Apellido;
                LabelDNI3.Text = iPersona.Dni;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar la persona, verifique que los campos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iMensaje = MessageBox.Show("Seguro que desea dar de baja a esta persona?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (iMensaje == DialogResult.Yes)
                {
                    iControladorPersona.BajaPersona(iPersona);
                    MessageBox.Show("Persona dada de baja con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }                
            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de baja la persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonBusquedaAvanzada_Click(object sender, EventArgs e)
        {           
            BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog()==DialogResult.OK)
            {
                iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                LabelNombre3.Text = iPersona.Nombre;
                LabelApellido3.Text = iPersona.Apellido;
                LabelDNI3.Text = iPersona.Dni;
            }
        }
    }
}
