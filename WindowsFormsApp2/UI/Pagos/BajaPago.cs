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

namespace LawyerHelper.UI.Pagos
{
    public partial class BajaPago : Form
    {
        Fachada iFachada = new Fachada();
        public BajaPago()
        {
            InitializeComponent();
            //Asignacion de colores      
            iFachada.AsignarColores(this);
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
