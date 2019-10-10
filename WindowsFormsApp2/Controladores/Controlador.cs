using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Clases
{
    class Controlador
    {
        //Se recuperan los recordatorios que tengan fecha actual o superior (usando LINQ)
        public IList<Recordatorio> MostrarAgenda()
        {
            Contexto iContexto = new Contexto();
            IList<Recordatorio> iQuery = new List<Recordatorio>();
            foreach (Recordatorio recordatorio in iContexto.Recordatorios.Where(n => n.FechayHora >= DateTime.Today))
            {
                iQuery.Add(recordatorio);
            }
            return iQuery;
        }

        public IList<Cobro> MostrarCobros()
        {
            Contexto iContexto = new Contexto();
            IList<Cobro> iQuery = new List<Cobro>();
            foreach (Cobro cobro in iContexto.Cobros)
            {
                iQuery.Add(cobro);
            }
            return iQuery;
        }

        public IList<Pago> MostrarPagos()
        {
            Contexto iContexto = new Contexto();
            IList<Pago> iQuery = new List<Pago>();
            foreach (Pago pago in iContexto.Pagos)
            {
                iQuery.Add(pago);
            }
            return iQuery;
        }

        public IList<Persona> BusquedaPersonas(string Parametro, string Valor)
        {
            Contexto iContexto = new Contexto();
            List<Persona> iQuery;
            //No se puede utilizar variables como atributos, ya que estos deben estar definidos en tiempo de compilacion
            //Por eso utilice el switch para cada atributo en particular
            switch (Parametro)
            {
                case "Nombre":
                    iQuery = iContexto.Personas.Where(n => n.Nombre == Valor).ToList();
                    break;
                case "Apellido":
                    iQuery = iContexto.Personas.Where(n => n.Apellido == Valor).ToList();
                    break;
                case "Dni":
                    iQuery = iContexto.Personas.Where(n => n.Dni == Valor).ToList();
                    break;
                case "Domicilio":
                    iQuery = iContexto.Personas.Where(n => n.Domicilio == Valor).ToList();
                    break;
                case "Telefono":
                    iQuery = iContexto.Personas.Where(n => n.Telefono == Valor).ToList();
                    break;
                case "Profesion":
                    iQuery = iContexto.Personas.Where(n => n.Profesion == Valor).ToList();
                    break;
                case "LugarTrabajo":
                    iQuery = iContexto.Personas.Where(n => n.LugarTrabajo == Valor).ToList();
                    break;
                case "Cuil":
                    iQuery = iContexto.Personas.Where(n => n.Cuil == Valor).ToList();
                    break;
                case "EstadoCivil":
                    iQuery = iContexto.Personas.Where(n => n.EstadoCivil == Valor).ToList();
                    break;
                case "Representante":
                    iQuery = iContexto.Personas.Where(n => n.Representante == Valor).ToList();
                    break;
                case "DomicilioLegal":
                    iQuery = iContexto.Personas.Where(n => n.DomicilioLegal == Valor).ToList();
                    break;
                default:
                    iQuery = null;
                    break;
            }
            return iQuery;
        }

        public IList<Persona> BusquedaJuicios(string Parametro, string Valor)
        {
            Contexto iContexto = new Contexto();
            List<Persona> iQuery;
            //No se puede utilizar variables como atributos, ya que estos deben estar definidos en tiempo de compilacion
            //Por eso utilice el switch para cada atributo en particular
            switch (Parametro)
            {
                case "Nombre":
                    iQuery = iContexto.Personas.Where(n => n.Nombre == Valor).ToList();
                    break;
                case "Apellido":
                    iQuery = iContexto.Personas.Where(n => n.Apellido == Valor).ToList();
                    break;
                case "Dni":
                    iQuery = iContexto.Personas.Where(n => n.Dni == Valor).ToList();
                    break;
                case "Domicilio":
                    iQuery = iContexto.Personas.Where(n => n.Domicilio == Valor).ToList();
                    break;
                case "Telefono":
                    iQuery = iContexto.Personas.Where(n => n.Telefono == Valor).ToList();
                    break;
                case "Profesion":
                    iQuery = iContexto.Personas.Where(n => n.Profesion == Valor).ToList();
                    break;
                case "LugarTrabajo":
                    iQuery = iContexto.Personas.Where(n => n.LugarTrabajo == Valor).ToList();
                    break;
                case "Cuil":
                    iQuery = iContexto.Personas.Where(n => n.Cuil == Valor).ToList();
                    break;
                case "EstadoCivil":
                    iQuery = iContexto.Personas.Where(n => n.EstadoCivil == Valor).ToList();
                    break;
                case "Representante":
                    iQuery = iContexto.Personas.Where(n => n.Representante == Valor).ToList();
                    break;
                case "DomicilioLegal":
                    iQuery = iContexto.Personas.Where(n => n.DomicilioLegal == Valor).ToList();
                    break;
                default:
                    iQuery = null;
                    break;
            }
            return iQuery;
        }
    }
}
