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
using WindowsFormsApp2.Juicios;
using WindowsFormsApp2;

namespace LawyerHelper.UI.Cobros
{
    public partial class BajaCobro : Form
    {
        ControladorCobro iControladorCobro;
        Fachada iFachada=new Fachada();
        List<Cobro> iCobros;
        Cobro iCobro;
        public BajaCobro()
        {
            InitializeComponent();
            iControladorCobro = new ControladorCobro(UnidadDeTrabajo.Instancia);
            iFachada.AsignarColores(this);
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iMensaje = MessageBox.Show("Seguro que desea eliminar este cobro?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (iMensaje == DialogResult.Yes)
                {
                    ListBoxCobros.DisplayMember = "Detalle";
                    iControladorCobro.BajaCobro(iCobro);
                    MessageBox.Show("Cobro dado de baja con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de baja el cobro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListBoxCobros_SelectedIndexChanged(object sender, EventArgs e)
        {
                iCobro = iCobros[ListBoxCobros.SelectedIndex];
                LabelHora2.Text = iCobro.FechayHora.ToShortTimeString();
                LabelImporte2.Text = iCobro.Importe.ToString();
                CuadroDetalle.Text = iCobro.Detalle;   
        }

        private void CuadroFecha_ValueChanged(object sender, EventArgs e)
        {
            iCobros = iControladorCobro.ObtenerCobrosPorFecha(CuadroFecha.Value);
            ListBoxCobros.DataSource = iCobros;
            ListBoxCobros.DisplayMember = "Descripcion";
        }

        private void BotonJuiciosAsignados_Click(object sender, EventArgs e)
        {
            ConsultaJuicios iMenuNuevo = new ConsultaJuicios(iCobro.Juicio);
            iMenuNuevo.ShowDialog();
        }

        private void BotonPersonasAsociadas_Click(object sender, EventArgs e)
        {
            ConsultaPersona iMenuNuevo = new ConsultaPersona(iCobro.Persona);
            iMenuNuevo.ShowDialog();
        }

        private void BajaCobro_Load(object sender, EventArgs e)
        {
            iCobros = iControladorCobro.ObtenerCobrosPorFecha(CuadroFecha.Value);
            ListBoxCobros.DataSource = iCobros;
            ListBoxCobros.DisplayMember = "Descripcion";
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
