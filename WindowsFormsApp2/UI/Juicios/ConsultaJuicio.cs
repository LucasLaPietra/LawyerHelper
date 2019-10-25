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

namespace WindowsFormsApp2.Juicios
{
    public partial class ConsultaJuicios : Form
    {
        Fachada iFachada = new Fachada();
        ControladorJuicio iControladorJuicio;
        public ConsultaJuicios()
        {
            InitializeComponent();
            iControladorJuicio = new ControladorJuicio(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      

            iFachada.AsignarColores(this);
        }
        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }

        private void BotonVerDocumentacion_Click(object sender, EventArgs e)
        {

        }
    }
}
