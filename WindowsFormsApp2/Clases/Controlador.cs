using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Controlador
    {

    

    //Se recuperan los recordatorios que tengan fecha actual o superior (usando LINQ)
    public MostrarAgenda(){
        using (var context = new Contexto())
        {
             var query = from recordatorio in context.Contexto
                where recordatorio.FechayHora >= DateTime.Today()
                select recordatorio;
   
            //el siguiente All es de dudosa procedencia
            var agenda = query.All<Contexto>();
        }
    }
    }
}
