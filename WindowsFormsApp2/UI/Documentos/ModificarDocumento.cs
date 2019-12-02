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
        List<Documento> iDocumentos;
        Juicio iJuicio;
        public ModificarDocumento(Juicio pJuicio)
        {
            InitializeComponent();
            iControladorDocumento = new ControladorDocumento(UnidadDeTrabajo.Instancia);
            //Asignacion de colores     
            iFachada.AsignarColores(this);
            iJuicio = pJuicio;
        }

        private void ModificarDocumento_Load(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iDocumento = iControladorDocumento.BusquedaPorNroFojaActivos(CuadroNumeroFoja.Text, iJuicio,!CheckBoxEliminados.Checked);
                CuadroDetalle.Text = iDocumento.Detalle;
                TimePickerFecha.Value = iDocumento.Fecha;
                CuadroNumeroFoja.Text = iDocumento.NroFoja;
                CuadroNombreDocumento.Text = iDocumento.Nombre;
                CuadroTipo.Text = iDocumento.TipoDocumento;
                CheckEnExpediente.Checked = iDocumento.EnExpediente;

            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar el documento, verifique que el numero de foja sea correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
           try
            {
                if (iDocumento.Activo == false)
                {
                    DialogResult result = MessageBox.Show("Este documento esta eliminado, quiere volver a darlo de alta?", "Confirmacion", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        iControladorDocumento.AltaLogicaDocumento(iDocumento,iJuicio);
                        iControladorDocumento.ModificarDocumento(iDocumento.DocumentoId, iDocumento.NroFoja, CuadroTipo.Text, CheckEnExpediente.Checked, CuadroNombreDocumento.Text, CuadroDetalle.Text, TimePickerFecha.Value, iDocumento.Juicio);
                        MessageBox.Show("Documento dado de alta y modificado con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    DialogResult iMensaje = MessageBox.Show("Seguro que desea modificar este documento?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                    if (iMensaje == DialogResult.Yes)
                    {
                        iControladorDocumento.ModificarDocumento(iDocumento.DocumentoId, iDocumento.NroFoja, CuadroTipo.Text, CheckEnExpediente.Checked, CuadroNombreDocumento.Text, CuadroDetalle.Text, TimePickerFecha.Value, iDocumento.Juicio);
                        MessageBox.Show("Documento modificado con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
           }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar el documento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BotonMostrarTodos_Click(object sender, EventArgs e)
        {
            iDocumentos = iControladorDocumento.MostrarDocumentosDeJuicioActivos(iJuicio,!CheckBoxEliminados.Checked);
            ComboBoxResultados.DataSource = iDocumentos;
            ComboBoxResultados.DisplayMember = "Descripcion";
        }

        private void ComboBoxResultados_SelectedIndexChanged(object sender, EventArgs e)
        {
            iDocumento = iDocumentos[ComboBoxResultados.SelectedIndex];
            CuadroDetalle.Text = iDocumento.Detalle;
            TimePickerFecha.Value = iDocumento.Fecha;
            CuadroNumeroFoja.Text = iDocumento.NroFoja;
            CuadroNombreDocumento.Text = iDocumento.Nombre;
            CuadroTipo.Text = iDocumento.TipoDocumento;
            CheckEnExpediente.Checked = iDocumento.EnExpediente;
        }
    }
}
