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
    public partial class ConsultaRecordatorio : Form
    {
        Fachada iFachada = new Fachada();
        List<Recordatorio> iListaRecordatorios;
        ControladorRecordatorio iControladorRecordatorio;
        public ConsultaRecordatorio()
        {
            InitializeComponent();
            iFachada.AsignarColores(this);
            iControladorRecordatorio = new ControladorRecordatorio(UnidadDeTrabajo.Instancia);
            iListaRecordatorios = iControladorRecordatorio.MostrarAgenda().ToList();
            ListBoxRecordatorios.DataSource = iListaRecordatorios;
            ListBoxRecordatorios.DisplayMember = "FechayHora";
        }

        private void BotonAceptar_Click1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListBoxRecordatorios_SelectedIndexChanged(object sender, EventArgs e)
        {
            int iSelectedIndex = ListBoxRecordatorios.SelectedIndex;
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
