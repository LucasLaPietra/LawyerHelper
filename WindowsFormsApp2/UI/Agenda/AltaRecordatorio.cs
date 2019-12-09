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

namespace LawyerHelper.UI.Agenda
{
    public partial class AltaRecordatorio : Form
    {
        Fachada iFachada=new Fachada();
        ControladorRecordatorio iControladorRecordatorio;
        public AltaRecordatorio()
        {
            InitializeComponent();
            iFachada.AsignarColores(this);
            CuadroHora.Text = DateTime.Now.Hour.ToString();
            CuadroMinutos.Text = DateTime.Now.Minute.ToString();
            CuadroAM.Text = DateTime.Now.ToString("tt");
            iControladorRecordatorio = new ControladorRecordatorio(UnidadDeTrabajo.Instancia);
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int iHora = iFachada.Convertir24Hs((Convert.ToInt32(CuadroHora.Text)), CuadroAM.Text);
                DateTime iFechayHora = new DateTime(CuadroFecha.Value.Year, CuadroFecha.Value.Month, CuadroFecha.Value.Day, iHora, (Convert.ToInt32(CuadroMinutos.Text)), 0);
                iControladorRecordatorio.RegistrarRecordatorio(CuadroLugar.Text, CuadroTipo.Text, CuadroDescripcion.Text, iFechayHora);
                MessageBox.Show("Recordatorio añadido con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Recordatorio no fue añadido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AltaRecordatorio_Load(object sender, EventArgs e)
        {

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
