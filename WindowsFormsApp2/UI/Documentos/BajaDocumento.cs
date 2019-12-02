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
using WindowsFormsApp2.Juicios;
using LawyerHelper.UI.Juicios;

namespace LawyerHelper.UI.Documentos
{
    public partial class BajaDocumento : Form
    {
        ControladorDocumento iControladorDocumento;
        Fachada iFachada = new Fachada();
        Documento iDocumento;
        List<Documento> iDocumentos;
        Juicio iJuicio;

        public BajaDocumento(Juicio pJuicio)
        {
            InitializeComponent();
            iControladorDocumento = new ControladorDocumento(UnidadDeTrabajo.Instancia);
            //Asignacion de colores  
            iFachada.AsignarColores(this);
            iJuicio = pJuicio;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iMensaje = MessageBox.Show("Seguro que desea dar de baja este documento?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (iMensaje == DialogResult.Yes)
                {
                    iControladorDocumento.BajaLogicaDocumento(iDocumento);
                    MessageBox.Show("Documento dado de baja con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de baja el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BotonConsultarJuicio_Click(object sender, EventArgs e)
        {
            ConsultaJuicios iMenuNuevo = new ConsultaJuicios(iDocumento.Juicio);
            iMenuNuevo.ShowDialog();
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iDocumento = iControladorDocumento.BusquedaPorNroFoja(CuadroNumeroFoja.Text,iJuicio);
                CuadroDetalle.Text=iDocumento.Detalle;
                LabelFecha2.Text = iDocumento.Fecha.ToShortDateString();
                LabelFoja2.Text = iDocumento.NroFoja;
                LabelNombre2.Text = iDocumento.Nombre;
                LabelTipo2.Text = iDocumento.TipoDocumento;
                CheckEnExpediente.Checked = iDocumento.EnExpediente;
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar el documento, verifique que el numero de foja sea correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonMostrarTodos_Click(object sender, EventArgs e)
        {
            iDocumentos = iControladorDocumento.MostrarDocumentosDeJuicio(iJuicio);
            ComboBoxResultados.DataSource = iDocumentos;
            ComboBoxResultados.DisplayMember = "Descripcion";
        }

        private void ComboBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            iDocumento = iDocumentos[ComboBoxResultados.SelectedIndex];
            CuadroDetalle.Text = iDocumento.Detalle;
            LabelFecha2.Text = iDocumento.Fecha.ToShortDateString();
            LabelFoja2.Text = iDocumento.NroFoja;
            LabelNombre2.Text = iDocumento.Nombre;
            LabelTipo2.Text = iDocumento.TipoDocumento;
            CheckEnExpediente.Checked = iDocumento.EnExpediente;
        }
    }
}
