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

namespace LawyerHelper.UI.Documentos
{
    public partial class ModificarDocumento : Form
    {
        ControladorDocumento iControladorDocumento;
        Fachada iFachada = new Fachada();
        Documento iDocumento;
        public ModificarDocumento()
        {
            InitializeComponent();
            iControladorDocumento = new ControladorDocumento(UnidadDeTrabajo.Instancia);
            //Asignacion de colores     
            iFachada.AsignarColores(this);

        }

        private void ModificarDocumento_Load(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iDocumento = iControladorDocumento.BusquedaPorNroFoja(CuadroNumeroFoja.Text);
                CuadroDetalle.Text = iDocumento.Detalle;
                TimePickerFecha.Value = iDocumento.Fecha;
                CuadroNumeroFoja.Text = iDocumento.NroFoja;
                CuadroNombreDocumento.Text = iDocumento.Nombre;
                CuadroTipo.Text = iDocumento.TipoDocumento;
                CheckEnExpediente.Checked = iDocumento.EnExpediente;

                CuadroJuicio.Text = iDocumento.Juicio.NroExpediente;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar el documento, verifique que el numero de foja sea correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonConsultarJuicio_Click(object sender, EventArgs e)
        {

        }

        private void BotonCambiarJuicio_Click(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
