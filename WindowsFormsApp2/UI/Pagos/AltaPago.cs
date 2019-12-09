using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
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
using LawyerHelper.DAL.Repositorio;
using LawyerHelper.UI.Juicios;

namespace WindowsFormsApp2.Pagos
{
    public partial class AltaPago : Form
    {
        ControladorPago iControladorPagos;
        Fachada iFachada = new Fachada();
        Juicio iJuicio = null;
        public AltaPago()
        {
            InitializeComponent();
            CuadroHora.Text = DateTime.Now.Hour.ToString();
            CuadroMinutos.Text = DateTime.Now.Minute.ToString();
            CuadroAM.Text = DateTime.Now.ToString("tt");
            iControladorPagos = new ControladorPago(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);
        }

        private void CuadroAM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AltaPago_Load(object sender, EventArgs e)
        {

        }

        private void CuadroFecha_ValueChanged(object sender, EventArgs e)
        {

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

        private void BotonAceptar1_Click(object sender, EventArgs e)
        {
            try
            {
                int iHora = iFachada.Convertir24Hs((Convert.ToInt32(CuadroHora.Text)), CuadroAM.Text);
                DateTime iFechayHora = new DateTime(CuadroFecha.Value.Year, CuadroFecha.Value.Month, CuadroFecha.Value.Day, iHora, (Convert.ToInt32(CuadroMinutos.Text)), 0);
                if (iJuicio == null)
                {
                    throw new InvalidOperationException();
                }
                iControladorPagos.RegistrarPago((Convert.ToDouble(CuadroImporte.Text)), iFechayHora, CuadroDetalle.Text, iJuicio);
                MessageBox.Show("Pago añadido con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No se asociaron juicios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Pago no fue añadido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonCancelar1_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
