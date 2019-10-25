using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
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
using LawyerHelper.DAL.Repositorio;

namespace WindowsFormsApp2.Pagos
{
    public partial class AltaPago : Form
    {
        ControladorPago iControladorPagos;
        Fachada iFachada = new Fachada();
        public AltaPago()
        {
            InitializeComponent();
            CuadroHora.Text = DateTime.Now.Hour.ToString();
            CuadroMinutos.Text = DateTime.Now.Minute.ToString();
            CuadroAM.Text = DateTime.Now.ToString("tt");
            iControladorPagos = new ControladorPago(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);
            }
        }

        private void CuadroAM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaPago_Load(object sender, EventArgs e)
        {

        }
    }
}
