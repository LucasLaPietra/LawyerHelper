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
using WindowsFormsApp2;

namespace LawyerHelper.UI.Juicios
{
    public partial class BajaJuicio : Form
    {            
     Fachada iFachada = new Fachada();
        public BajaJuicio()
        {
            InitializeComponent();
            //Asignacion de colores      

            iFachada.AsignarColores(this);
        }
        
    }
}
