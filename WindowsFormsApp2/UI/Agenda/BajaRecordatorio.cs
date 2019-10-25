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
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using WindowsFormsApp2;

namespace LawyerHelper.UI.Agenda
{
    public partial class BajaRecordatorio : Form
    {
        Fachada iFachada = new Fachada();
        List<Recordatorio> iListaRecordatorios;
        ControladorRecordatorio iControladorRecordatorio;
        public BajaRecordatorio()
        {
            InitializeComponent();
            iFachada.AsignarColores(this);
            iControladorRecordatorio = new ControladorRecordatorio(UnidadDeTrabajo.Instancia);
            iListaRecordatorios = iControladorRecordatorio.MostrarAgenda().ToList();
            ListBoxRecordatorios.DataSource = iListaRecordatorios;
            ListBoxRecordatorios.DisplayMember = "FechayHora";
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iMensaje = MessageBox.Show("Seguro que desea dar de baja este recordatorio?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (iMensaje == DialogResult.Yes)
                {
                    iControladorRecordatorio.BajaRecordatorio((Recordatorio)ListBoxRecordatorios.SelectedItem);
                    MessageBox.Show("Recordatorio dado de baja con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al dar de baja el recordatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que dese cancelar?", "Cancelar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ListBoxRecordatorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex=ListBoxRecordatorios.SelectedIndex;
            Recordatorio iRecordatorio = iListaRecordatorios[iSelectedIndex];
            LabelHora2.Text = iRecordatorio.FechayHora.Hour.ToString();
            LabelMinutos.Text = iRecordatorio.FechayHora.Minute.ToString();
            LabelAM.Text = iRecordatorio.FechayHora.ToString("tt");
            CuadroDescripcion.Text = iRecordatorio.Descripcion;
            LabelLugar2.Text = iRecordatorio.Lugar;
            LabelTipo2.Text = iRecordatorio.Tipo;
        }
    }
}
