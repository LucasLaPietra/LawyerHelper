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
    public partial class BajaPago : Form
    {
        Fachada iFachada = new Fachada();
        ControladorPago iControladorPago;

        public BajaPago()
        {
            InitializeComponent();
            //Asignacion de colores      
            iFachada.AsignarColores(this);
            iControladorPago = new ControladorPago(UnidadDeTrabajo.Instancia);
        }

        private void BajaPagos_Load(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
