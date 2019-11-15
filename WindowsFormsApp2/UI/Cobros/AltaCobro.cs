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
using LawyerHelper.UI.Personas;
using LawyerHelper.UI.Juicios;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Cobros
{
    public partial class AltaCobro : Form
    {
        ControladorCobro iControladorCobro;
        Fachada iFachada=new Fachada();
        Persona iPersona;
        Juicio iJuicio;
        public AltaCobro()
        {
            InitializeComponent();
            CuadroHora.Text = DateTime.Now.Hour.ToString();
            CuadroMinutos.Text = DateTime.Now.Minute.ToString();
            CuadroAM.Text = DateTime.Now.ToString("tt");
            iControladorCobro = new ControladorCobro(UnidadDeTrabajo.Instancia);
            iFachada.AsignarColores(this);
        }

        private void CuadroHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int iHora = iFachada.Convertir24Hs((Convert.ToInt32(CuadroHora.Text)), CuadroAM.Text);
                DateTime iFechayHora = new DateTime(CuadroFecha.Value.Year, CuadroFecha.Value.Month, CuadroFecha.Value.Day, iHora, (Convert.ToInt32(CuadroMinutos.Text)),0);                
                iControladorCobro.RegistrarCobro((Convert.ToDouble(CuadroImporte.Text)),iFechayHora,CuadroDetalle.Text,iJuicio,iPersona);
                MessageBox.Show("Cobro añadido con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cobro no fue añadido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BotonAgregarPersona_Click(object sender, EventArgs e)
        {
            BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                CuadroPersona.Text = iPersona.Apellido+" "+iPersona.Nombre;
            }
        }

        private void BotonAgregarJuicio_Click(object sender, EventArgs e)
        {
            BuscarJuicio iMenuNuevo = new BuscarJuicio();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                iJuicio = (Juicio)iMenuNuevo.JuicioEncontrado;
                CuadroJuicio.Text = iJuicio.NroExpediente;
            }
        }
    }
}
