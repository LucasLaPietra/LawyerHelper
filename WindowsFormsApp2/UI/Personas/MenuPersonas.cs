﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Personas;

namespace WindowsFormsApp2
{
    public partial class MenuPersonas : Form
    {
        public MenuPersonas()
        {
            InitializeComponent();
        }

        private void BotonAlta_Click(object sender, EventArgs e)
        {
            AltaPersona iMenuNuevo = new AltaPersona();
            iMenuNuevo.ShowDialog();
        }

        private void MenuPersonas_Load(object sender, EventArgs e)
        {

        }
    }
}
