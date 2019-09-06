using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Pagos
{
    public partial class AltaPago : Form
    {
        public AltaPago()
        {
            InitializeComponent();
            CuadroHora.Text = DateTime.Now.Hour.ToString();
            CuadroMinutos.Text = DateTime.Now.Minute.ToString();
            CuadroAM.Text = DateTime.Now.ToString("tt");
        }

        private void CuadroAM_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
