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
using LawyerHelper.UI.Personas;
using LawyerHelper.Controladores;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using WindowsFormsApp2;

namespace LawyerHelper.UI.Juicios
{
    public partial class ModificarJuicio : Form
    {
        Fachada iFachada = new Fachada();
        public ModificarJuicio()
        {
            InitializeComponent();
            //Asignacion de colores      
            iFachada.AsignarColores(this);
        }
    
 



        private void BotonBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
