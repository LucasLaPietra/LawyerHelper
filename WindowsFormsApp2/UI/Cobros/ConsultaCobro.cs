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
using LawyerHelper.UI.Personas;
using WindowsFormsApp2.Juicios;
using LawyerHelper.UI.Juicios;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using WindowsFormsApp2;

namespace LawyerHelper.UI.Cobros
{
    public partial class ConsultaCobro : Form
    {
        ControladorCobro iControladorCobro;
        Fachada iFachada = new Fachada();
        List<Cobro> iCobros = new List<Cobro>();
        Cobro iCobro;
        public ConsultaCobro()
        {
            InitializeComponent();
            iControladorCobro = new ControladorCobro(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);
        }

        public ConsultaCobro(Cobro pCobro)
        {
            InitializeComponent();
            iControladorCobro = new ControladorCobro(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);

            iCobro = pCobro;
            LabelHora2.Text = iCobro.FechayHora.ToShortTimeString();
            LabelImporte2.Text = iCobro.Importe.ToString();
            CuadroDetalle.Text = iCobro.Detalle;
        }

        private void ConsultaCobro_Load(object sender, EventArgs e)
        {
            iCobros = iControladorCobro.ObtenerCobrosPorFecha(DateTimePickerFecha.Value);
            ListBoxCobros.DataSource = iCobros;
            ListBoxCobros.DisplayMember = "Descripcion";
        }

        private void DateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            iCobros = iControladorCobro.ObtenerCobrosPorFecha(DateTimePickerFecha.Value);
            ListBoxCobros.DataSource = iCobros;
            ListBoxCobros.DisplayMember = "Descripcion";
        }

        private void ListBoxCobros_SelectedIndexChanged(object sender, EventArgs e)
        {
            iCobro = iCobros[ListBoxCobros.SelectedIndex];
            LabelHora2.Text = iCobro.FechayHora.ToShortTimeString();
            LabelImporte2.Text = iCobro.Importe.ToString();
            CuadroDetalle.Text = iCobro.Detalle;
        }

        private void BotonJuiciosAsignados_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaJuicios iMenuNuevo = new ConsultaJuicios(iCobro.Juicio);
                iMenuNuevo.ShowDialog();
            }
            catch(Exception)
            {
                MessageBox.Show("Debe seleccionar un cobro primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonPersonasAsociadas_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaPersona iMenuNuevo = new ConsultaPersona(iCobro.Persona);
                iMenuNuevo.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un cobro primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
