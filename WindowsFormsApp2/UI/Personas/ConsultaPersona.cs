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
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;

namespace LawyerHelper.UI.Personas
{
    public partial class ConsultaPersona : Form
    {
        ControladorPersona iControladorPersona;
        Persona iPersona;
        public ConsultaPersona()
        {
            InitializeComponent();
            iControladorPersona = new ControladorPersona(UnidadDeTrabajo.Instancia);
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

        }

        private void BotonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult iMensaje = MessageBox.Show("Seguro que desea cerrar la ventana?", "Aceptar", MessageBoxButtons.YesNoCancel);

            if (iMensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void BotonBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            BuscarPersona iMenuNuevo = new BuscarPersona();
            if (iMenuNuevo.ShowDialog() == DialogResult.OK)
            {
                iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                LabelDNI2.Text = iPersona.Dni;
                LabelDomicilio2.Text = iPersona.Domicilio;
                LabelDomicilioLegal2.Text = iPersona.DomicilioLegal;
                LabelEstadoCivil2.Text = iPersona.EstadoCivil;
                LabelFechaNacimiento2.Text = iPersona.FechaNacimiento.ToShortDateString();
                LabelLugarTrabajo2.Text = iPersona.LugarTrabajo;
                LabelProfesion2.Text = iPersona.Profesion;
                LabelRepresentante2.Text = iPersona.Representante;
                LabelTelefono2.Text = iPersona.Telefono;
            }
        }

        private void BotonBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                iPersona = iControladorPersona.BusquedaPorNombreyAp(CuadroApellido.Text, CuadroNombre.Text);
                LabelDNI2.Text = iPersona.Dni;
                LabelDomicilio2.Text = iPersona.Domicilio;
                LabelDomicilioLegal2.Text = iPersona.DomicilioLegal;
                LabelEstadoCivil2.Text = iPersona.EstadoCivil;
                LabelFechaNacimiento2.Text = iPersona.FechaNacimiento.ToShortDateString();
                LabelLugarTrabajo2.Text = iPersona.LugarTrabajo;
                LabelProfesion2.Text = iPersona.Profesion;
                LabelRepresentante2.Text = iPersona.Representante;
                LabelTelefono2.Text = iPersona.Telefono;
            }
            catch (Exception)
            {
                MessageBox.Show("Error al buscar la persona, verifique que los campos sean correctos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
