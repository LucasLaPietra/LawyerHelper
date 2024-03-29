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
using LawyerHelper.UI.Personas;
using LawyerHelper.UI.Juicios;
using WindowsFormsApp2;

namespace WindowsFormsApp2.Cobros
{
    public partial class AltaCobro : Form
    {
        ControladorCobro iControladorCobro;
        Fachada iFachada=new Fachada();
        Persona iPersona=null;
        Juicio iJuicio=null;
        public AltaCobro()
        {
            InitializeComponent();
            CuadroHora.Text = DateTime.Now.Hour.ToString();
            CuadroMinutos.Text = DateTime.Now.Minute.ToString();
            iControladorCobro = new ControladorCobro(UnidadDeTrabajo.Instancia);
            iFachada.AsignarColores(this);
        }

        private void CuadroHora_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime iFechayHora = new DateTime(CuadroFecha.Value.Year, CuadroFecha.Value.Month, CuadroFecha.Value.Day, (Convert.ToInt32(CuadroHora.Text)), (Convert.ToInt32(CuadroMinutos.Text)),0);            
                if(iJuicio==null||iPersona==null)
                {
                    throw new InvalidOperationException();
                }
                iControladorCobro.RegistrarCobro((Convert.ToDouble(CuadroImporte.Text)),iFechayHora,CuadroDetalle.Text,iJuicio,iPersona);
                MessageBox.Show("Cobro añadido con exito", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch(InvalidOperationException)
            {
                MessageBox.Show("No se asociaron cobros o juicios ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void BotonAgregarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarPersona iMenuNuevo = new BuscarPersona();
                if (iMenuNuevo.ShowDialog() == DialogResult.OK)
                {
                    iPersona = (Persona)iMenuNuevo.PersonaEncontrada;
                    CuadroPersona.Text = iPersona.Apellido + " " + iPersona.Nombre;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se devolvio ninguna persona", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BotonAgregarJuicio_Click(object sender, EventArgs e)
        {
            try
            {
                BuscarJuicio iMenuNuevo = new BuscarJuicio();
                if (iMenuNuevo.ShowDialog() == DialogResult.OK)
                {
                    iJuicio = (Juicio)iMenuNuevo.JuicioEncontrado;
                    CuadroJuicio.Text = iJuicio.NroExpediente;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se devolvio ningun juicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
