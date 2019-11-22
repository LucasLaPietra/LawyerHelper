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
using LawyerHelper.UI.Juicios;

namespace LawyerHelper.UI.Documentos
{
    public partial class AltaDocumento : Form
    {
        ControladorDocumento iControladorDocumento;
        Fachada iFachada = new Fachada();
        Juicio iJuicio = null;
        public AltaDocumento(Juicio pJuicio)
        {
            InitializeComponent();
            iControladorDocumento = new ControladorDocumento(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);
            iJuicio = pJuicio;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (iJuicio == null)
                {
                    throw new InvalidOperationException();
                }
                iControladorDocumento.RegistrarDocumento(CuadroTipoDocumento.Text, CuadroFoja.Text, CheckEnExpediente.Checked, CuadroNombreDocumento.Text, CuadroDetalle.Text, TimePickerFecha.Value, iJuicio);
                MessageBox.Show("Documento añadido con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("No se asociaron juicios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Documento no fue añadido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
