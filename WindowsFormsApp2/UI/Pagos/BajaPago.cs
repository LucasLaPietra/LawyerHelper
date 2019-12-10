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
using WindowsFormsApp2;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using WindowsFormsApp2.Juicios;

namespace LawyerHelper.UI.Pagos
{
    public partial class BajaPago : Form
    {
        Fachada iFachada = new Fachada();
        ControladorPago iControladorPago;
        List<Pago> iPagos;
        Pago iPago;
        public BajaPago()
        {
            InitializeComponent();
            //Asignacion de colores      
            iFachada.AsignarColores(this);
            iControladorPago = new ControladorPago(UnidadDeTrabajo.Instancia);
        }

        private void BajaPagos_Load(object sender, EventArgs e)
        {
            iPagos = iControladorPago.ObtenerPagosPorFecha(dateTimePickerFecha.Value);
            ListBoxPagos.DataSource = iPagos;
            ListBoxPagos.DisplayMember = "Descripcion";
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iMensaje = MessageBox.Show("Seguro que desea eliminar este cobro?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (iMensaje == DialogResult.Yes)
                {
                    ListBoxPagos.DisplayMember = "Detalle";
                    iControladorPago.BajaPago(iPago);
                    MessageBox.Show("Pago dado de baja con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de baja el Pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dateTimePickerFecha_ValueChanged(object sender, EventArgs e)
        {
            iPagos = iControladorPago.ObtenerPagosPorFecha(dateTimePickerFecha.Value);
            ListBoxPagos.DataSource = iPagos;
            ListBoxPagos.DisplayMember = "Descripcion";
        }

        private void ListBoxPagos_SelectedIndexChanged(object sender, EventArgs e)
        {
            iPago = iPagos[ListBoxPagos.SelectedIndex];
            LabelHora2.Text = iPago.FechayHora.ToShortTimeString();
            LabelImporte2.Text = iPago.Importe.ToString();
            CuadroDetalle.Text = iPago.Detalle;
        }

        private void BotonJuiciosAsignados_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultaJuicios iMenuNuevo = new ConsultaJuicios(iPago.Juicio);
                iMenuNuevo.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Debe seleccionar un cobro primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
