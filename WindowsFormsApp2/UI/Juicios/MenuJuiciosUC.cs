﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawyerHelper.UI.Juicios;
using LawyerHelper.Clases;
using WindowsFormsApp2.Juicios;

namespace LawyerHelper.UI.Juicios
{
    public partial class MenuJuiciosUC : UserControl
    {
        Color iColorForeground = Colores.ColorForeground;
        public MenuJuiciosUC()
        {
            InitializeComponent();
            BotonAlta.ForeColor = iColorForeground;
            BotonBaja.ForeColor = iColorForeground;
            BotonModificacion.ForeColor = iColorForeground;
            BotonConsulta.ForeColor = iColorForeground;
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            AltaJuicios iMenuNuevo = new AltaJuicios();
            iMenuNuevo.ShowDialog();
        }

        private void BotonConsulta_Click(object sender, EventArgs e)
        {
            ConsultaJuicios iMenuNuevo = new ConsultaJuicios();
            iMenuNuevo.ShowDialog();
        }

        private void BotonModificacion_Click(object sender, EventArgs e)
        {
            ModificarJuicio iMenuNuevo = new ModificarJuicio();
            iMenuNuevo.ShowDialog();
        }

        private void BotonBaja_Click(object sender, EventArgs e)
        {
            BajaJuicio iMenuNuevo = new BajaJuicio();
            iMenuNuevo.ShowDialog();
        }




    }
}
