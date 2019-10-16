using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Personas;
using LawyerHelper.UI.Personas;
using LawyerHelper.Clases;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;

namespace LawyerHelper.UI.Personas
{
    public partial class MenuPersonasUC : UserControl
    {
        public MenuPersonasUC(Color pColorForeground)
        {
            InitializeComponent();
            BotonAlta.ForeColor = pColorForeground;
            BotonBaja.ForeColor = pColorForeground;
            BotonModificacion.ForeColor = pColorForeground;
            BotonConsulta.ForeColor = pColorForeground;
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            AltaPersona iMenuNuevo = new AltaPersona();
            iMenuNuevo.ShowDialog();
        }

        private void MenuPersonas_Load(object sender, EventArgs e)
        {
            
        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {
            BajaPersona iMenuNuevo = new BajaPersona();
            iMenuNuevo.ShowDialog();
        }

        private void BotonModificacion_Click(object sender, EventArgs e)
        {
            ModificarPersona iMenuNuevo = new ModificarPersona();
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            ConsultaPersona iMenuNuevo = new ConsultaPersona();
            iMenuNuevo.ShowDialog();
        }
    }
}
