using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawyerHelper.UI
{
    public partial class Ajustes : Form
    {
        Color iBackground;
        Color iForeground;
        Color iPresionado;
        public Color ColorBackground
        {
            get { return iBackground; }
            set { iBackground = value; }
        }
        public Color ColorForeground
        {
            get { return iForeground; }
            set { iForeground = value; }
        }
        public Color ColorPresionado
        {
            get { return iPresionado; }
            set { iPresionado = value; }
        }
        public Ajustes()
        {
            InitializeComponent();
        }

        private void BotonClaro_Click(object sender, EventArgs e)
        {
            ColorBackground = Color.FromArgb(209, 234, 255);
            ColorPresionado = Color.FromArgb(168, 215, 255);
            ColorForeground = Color.FromArgb(42, 92, 137);
        }

        private void BotonOscuro_Click(object sender, EventArgs e)
        {
            ColorBackground = Color.FromArgb(35, 37, 57);
            ColorPresionado = Color.FromArgb(54, 57, 89);
            ColorForeground = Color.FromArgb(179, 182, 208);
        }
    }
}
