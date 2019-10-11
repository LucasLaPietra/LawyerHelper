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

namespace LawyerHelper.UI.Personas
{

    public partial class BuscarPersona : Form
    {
        object iResultado;
        List<Persona> iResultados;
        ControladorPersona iControladorPersona;
        public BuscarPersona()
        {
            InitializeComponent();
            iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
        }

        private void BuscarPersona_Load(object sender, EventArgs e)
        {

        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iResultados = iControladorPersona.BusquedaAvanzadaPersona(comboBoxParametro.SelectedItem.ToString(), CuadroParametro.Text).ToList();
                ComboBoxResultados.DataSource = iResultados;
                ComboBoxResultados.DisplayMember = "Apellido";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            iResultado = ComboBoxResultados.SelectedItem;            
            this.Hide();
            BajaPersona iMenuNuevo = new BajaPersona((Persona)iResultado);
            iMenuNuevo.Closed += (s, args) => this.Close();
            iMenuNuevo.Show();
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
