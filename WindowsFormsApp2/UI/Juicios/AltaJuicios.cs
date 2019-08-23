using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2.Juicios
{
    public partial class AltaJuicios : Form
    {
        public AltaJuicios()
        {
            InitializeComponent();
        }

        bool CompetenciaFederal=false;

        private void AltaJuicios_Load(object sender, EventArgs e)
        {
            CuadroCompetencia.Items.Add("Civil y comercial");
            CuadroCompetencia.Items.Add("Penal");
            CuadroCompetencia.Items.Add("Familiar y penal para niños y adolescentes");
            CuadroCompetencia.Items.Add("Laboral");
            CuadroCompetencia.Items.Add("Contencioso administrativo");
        }

        private void CuadroJurisdiccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CuadroJurisdiccion.SelectedIndex==1)
            {
                CompetenciaFederal=true;
                CuadroCompetencia.Items[2] = "-";
                CuadroCompetencia.Items[3] = "-";
                CuadroCompetencia.Items[4] = "-";
            }
            else
            {
                CompetenciaFederal = false;
                CuadroCompetencia.Items[2] = "Familiar y penal para niños y adolescentes";
                CuadroCompetencia.Items[3] = "Laboral";
                CuadroCompetencia.Items[4] = "Contencioso administrativo";
            }
        }

        private void CuadroCompetencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompetenciaFederal)
            {
                if (CuadroCompetencia.SelectedIndex == 2 || CuadroCompetencia.SelectedIndex == 3 || CuadroCompetencia.SelectedIndex == 4)
                    CuadroCompetencia.SelectedIndex = -1;
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
