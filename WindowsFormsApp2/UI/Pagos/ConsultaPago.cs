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
using WindowsFormsApp2.Juicios;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;

namespace LawyerHelper.UI.Pagos
{
    public partial class ConsultaPago : Form
    {
        Fachada iFachada = new Fachada();
        ControladorPago iControladorPago;
        List<Pago> iPagos;
        Pago iPago;

        public ConsultaPago()
        {
            InitializeComponent();
            iControladorPago =new ControladorPago(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);
        }

        public ConsultaPago(Pago pPago)
        {
            InitializeComponent();
            iControladorPago = new ControladorPago(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);

            iPago = pPago;
            LabelHora2.Text = iPago.FechayHora.ToShortTimeString();
            LabelImporte2.Text = iPago.Importe.ToString();
            CuadroDetalle.Text = iPago.Detalle;
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

        private void BotonCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ConsultaPago_Load(object sender, EventArgs e)
        {
            iPagos = iControladorPago.ObtenerPagosPorFecha(dateTimePickerFecha.Value);
            ListBoxPagos.DataSource = iPagos;
            ListBoxPagos.DisplayMember = "Descripcion";
        }
    }
}
