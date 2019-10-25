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
using WindowsFormsApp2;

namespace LawyerHelper.UI.Cobros
{
    public partial class ConsultaCobro : Form
    {
        ControladorCobro iControladorCobro;
        Fachada iFachada = new Fachada();
        public ConsultaCobro()
        {
            InitializeComponent();
            iControladorCobro = new ControladorCobro(UnidadDeTrabajo.Instancia);
            //Asignacion de colores      
            iFachada.AsignarColores(this);
        }
    }
}
