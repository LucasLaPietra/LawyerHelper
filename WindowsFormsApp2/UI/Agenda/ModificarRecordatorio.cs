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
    public partial class ModificarRecordatorio : Form
    {
        Fachada iFachada = new Fachada();
        List<Recordatorio> iListaRecordatorios;
        ControladorRecordatorio iControladorRecordatorio;
        public ModificarRecordatorio()
        {
            InitializeComponent();
            iControladorRecordatorio = new ControladorRecordatorio(UnidadDeTrabajo.Instancia);
            iListaRecordatorios = iControladorRecordatorio.MostrarAgenda().ToList();
            ListBoxRecordatorios.DataSource = iListaRecordatorios;
            ListBoxRecordatorios.DisplayMember = "FechayHora";
        }

        private void ListBoxRecordatorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = ListBoxRecordatorios.SelectedIndex;
            Recordatorio iRecordatorio = iListaRecordatorios[iSelectedIndex];
            CuadroHora.Text = iRecordatorio.FechayHora.Hour.ToString();
            CuadroMinutos.Text = iRecordatorio.FechayHora.Minute.ToString();
            CuadroAM.Text = iRecordatorio.FechayHora.ToString("tt");
            CuadroDescripcion.Text = iRecordatorio.Descripcion;
            CuadroLugar.Text = iRecordatorio.Lugar;
            CuadroTipo.Text = iRecordatorio.Tipo;
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult iMensaje = MessageBox.Show("Seguro que desea dar de baja este recordatorio?", "Confirmacion", MessageBoxButtons.YesNoCancel);

                if (iMensaje == DialogResult.Yes)
                {
                    int iHora = iFachada.Convertir24Hs((Convert.ToInt32(CuadroHora.Text)), CuadroAM.Text);
                    DateTime iFechayHora = new DateTime(CuadroFecha.Value.Year, CuadroFecha.Value.Month, CuadroFecha.Value.Day, iHora, (Convert.ToInt32(CuadroMinutos.Text)), 0);
                    //iControladorRecordatorio.ModificarRecordatorio(CuadroLugar.Text, CuadroTipo.Text, CuadroDescripcion.Text, iFechayHora);
                    MessageBox.Show("Recordatorio modificado con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al modificar el recordatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
