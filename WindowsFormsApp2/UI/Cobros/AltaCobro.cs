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
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;

namespace WindowsFormsApp2.Cobros
{
    public partial class AltaCobro : Form
    {
        ControladorCobro iControladorCobro;
        Fachada iFachada;
        public AltaCobro()
        {
            InitializeComponent();
            CuadroHora.Text = DateTime.Now.Hour.ToString();
            CuadroMinutos.Text = DateTime.Now.Minute.ToString();
            CuadroAM.Text = DateTime.Now.ToString("tt");
            iControladorCobro = new ControladorCobro(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            //Background
            this.BackColor = Colores.ColorBackground;
            //Cajas
            foreach (TextBox t in Controls.OfType<TextBox>())
            {
                t.ForeColor = Colores.ColorForeground;
                t.BackColor = Colores.ColorBackgroundCajas;
            }
            // Labels
            foreach (Label l in Controls.OfType<Label>())
                l.ForeColor = Colores.ColorForeground;
            //Botones
            foreach (Button b in Controls.OfType<Button>())
            {
                b.ForeColor = Colores.ColorForeground;
                b.BackColor = Colores.ColorBackground;
            }
        }

        private void CuadroHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                int iHora = iFachada.Convertir24Hs((Convert.ToInt32(CuadroHora.Text)), CuadroAM.Text);
                DateTime iFechayHora = new DateTime(CuadroFecha.Value.Year, CuadroFecha.Value.Month, CuadroFecha.Value.Day, iHora, (Convert.ToInt32(CuadroMinutos.Text)),0);                
                iControladorCobro.RegistrarCobro((Convert.ToDouble(CuadroImporte.Text)),iFechayHora,CuadroDetalle.Text);
                MessageBox.Show("Cobro añadido con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Cobro no fue añadido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que desea cancelar?", "Cancelar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
