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

namespace LawyerHelper.UI.Juicios
{
    public partial class BuscarJuicio : Form
    {
        object iResultado;
        public object JuicioEncontrado
        {
            get { return iResultado; }
            set { iResultado = value; }
        }
        Fachada iFachada = new Fachada();
        ControladorJuicio iControladorJuicio;
        public BuscarJuicio()
        {
            InitializeComponent();
            iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
            iFachada.AsignarColores(this);
        }

        private void BotonMostrarTodos_Click(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
