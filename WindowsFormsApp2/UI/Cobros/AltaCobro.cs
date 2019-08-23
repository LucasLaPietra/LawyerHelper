using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Cobros
{
    public partial class AltaCobro : Form
    {
        public AltaCobro()
        {
            InitializeComponent();
            CuadroHora.Text = DateTime.Now.Hour.ToString();
            CuadroMinutos.Text = DateTime.Now.Minute.ToString();
            CuadroAM.Text = DateTime.Now.ToString("tt");
        }

        private void CuadroHora_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
