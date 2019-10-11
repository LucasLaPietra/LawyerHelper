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
    public partial class ConsultaPersona : Form
    {
        ControladorPersona iControladorPersona;
        public ConsultaPersona()
        {
            InitializeComponent();
            iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
