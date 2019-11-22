using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawyerHelper.Clases;

namespace LawyerHelper.UI.Documentos
{
    public partial class MenuDocumentosUC : UserControl
    {
        Color iColorForeground = Colores.ColorForeground;
        public MenuDocumentosUC()
        {
            InitializeComponent();
            BotonAlta.ForeColor = iColorForeground;
            BotonBaja.ForeColor = iColorForeground;
            BotonModificacion.ForeColor = iColorForeground;
            BotonConsulta.ForeColor = iColorForeground;
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            AltaDocumento iMenuNuevo = new AltaDocumento();
            iMenuNuevo.ShowDialog();
        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {
            BajaDocumento iMenuNuevo = new BajaDocumento();
            iMenuNuevo.ShowDialog();
        }

        private void BotonModificacion_Click(object sender, EventArgs e)
        {
            ModificarDocumento iMenuNuevo = new ModificarDocumento();
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            ConsultaDocumento iMenuNuevo = new ConsultaDocumento();
            iMenuNuevo.ShowDialog();
        }
    }
}
