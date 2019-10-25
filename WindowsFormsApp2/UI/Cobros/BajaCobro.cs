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
using LawyerHelper.UI.Personas;
using LawyerHelper.UI.Juicios;
using WindowsFormsApp2;

namespace LawyerHelper.UI.Cobros
{
    public partial class BajaCobro : Form
    {
        ControladorCobro iControladorCobro;
        Fachada iFachada=new Fachada();
        List<Cobro> iListaCobros;
        Persona iPersona;
        Juicio iJuicio;
        public BajaCobro()
        {
            InitializeComponent();
            iControladorCobro = new ControladorCobro(UnidadDeTrabajo.Instancia);
            iFachada.AsignarColores(this);
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void ListBoxCobros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CuadroFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
