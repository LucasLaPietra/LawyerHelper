﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LawyerHelper.Clases;

namespace WindowsFormsApp2.Juicios
{
    public partial class ConsultaJuicios : Form
    {
        public ConsultaJuicios()
        {
            InitializeComponent();
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
            //ListBox
            foreach (ListBox t in Controls.OfType<ListBox>())
            {
                t.ForeColor = Colores.ColorForeground;
                t.BackColor = Colores.ColorBackgroundCajas;
            }
            //Para los layouts

            //Cajas
            foreach (TextBox t in Layout.Controls.OfType<TextBox>())
            {
                t.ForeColor = Colores.ColorForeground;
                t.BackColor = Colores.ColorBackgroundCajas;
            }
            // Labels
            foreach (Label l in Layout.Controls.OfType<Label>())
                l.ForeColor = Colores.ColorForeground;
            //Botones
            foreach (Button b in Layout.Controls.OfType<Button>())
            {
                b.ForeColor = Colores.ColorForeground;
                b.BackColor = Colores.ColorBackground;
            }
            //ComboBox
            foreach (ComboBox c in Layout.Controls.OfType<ComboBox>())
            {
                c.ForeColor = Colores.ColorForeground;
                c.BackColor = Colores.ColorBackground;
            }
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
    }
}
