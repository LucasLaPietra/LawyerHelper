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
using WindowsFormsApp2;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;

namespace LawyerHelper.UI.Pagos
{
    public partial class ConsultaPago : Form
    {
        Fachada iFachada = new Fachada();
        ControladorPago iControladorPago;

        public ConsultaPago()
        {
            InitializeComponent();
            iControladorPago =new ControladorPago(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
