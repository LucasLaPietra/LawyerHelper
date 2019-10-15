using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class RepositorioPersona:RepositorioGeneral<Persona,Contexto>,IRepositorioPersona
    {
        public RepositorioPersona(Contexto pContext):base(pContext)
        {

        }

        public IList<Persona> BusquedaPersonas(string Parametro, string Valor)
        {
            List<Persona> iQuery;
            //No se puede utilizar variables como atributos, ya que estos deben estar definidos en tiempo de compilacion
            //Por eso utilice el switch para cada atributo en particular
            switch (Parametro)
            {
                case "Nombre":
                    iQuery = iContext.Personas.Where(n => n.Nombre == Valor).ToList();
                    break;
                case "Apellido":
                    iQuery = iContext.Personas.Where(n => n.Apellido == Valor).ToList();
                    break;
                case "Dni":
                    iQuery = iContext.Personas.Where(n => n.Dni == Valor).ToList();
                    break;
                case "Domicilio":
                    iQuery = iContext.Personas.Where(n => n.Domicilio == Valor).ToList();
                    break;
                case "Telefono":
                    iQuery = iContext.Personas.Where(n => n.Telefono == Valor).ToList();
                    break;
                case "Profesion":
                    iQuery = iContext.Personas.Where(n => n.Profesion == Valor).ToList();
                    break;
                case "LugarTrabajo":
                    iQuery = iContext.Personas.Where(n => n.LugarTrabajo == Valor).ToList();
                    break;
                case "Cuil":
                    iQuery = iContext.Personas.Where(n => n.Cuil == Valor).ToList();
                    break;
                case "EstadoCivil":
                    iQuery = iContext.Personas.Where(n => n.EstadoCivil == Valor).ToList();
                    break;
                case "Representante":
                    iQuery = iContext.Personas.Where(n => n.Representante == Valor).ToList();
                    break;
                case "DomicilioLegal":
                    iQuery = iContext.Personas.Where(n => n.DomicilioLegal == Valor).ToList();
                    break;
                default:
                    iQuery = null;
                    break;
            }
            return iQuery;
        }

        public void ModificarPersona(Persona pPersona)
        {
            Persona iQuery;
            iQuery = iContext.Personas.First(n => n.Nombre == (pPersona.Nombre) && n.Dni == (pPersona.Dni));
            iQuery.Dni = pPersona.Dni;
            iQuery.Domicilio = pPersona.Domicilio;
            iQuery.DomicilioLegal = pPersona.DomicilioLegal;
            iQuery.EstadoCivil = pPersona.EstadoCivil;
            iQuery.FechaNacimiento = pPersona.FechaNacimiento;
            iQuery.LugarTrabajo = pPersona.LugarTrabajo;
            iQuery.Profesion = pPersona.Profesion;
            iQuery.Representante = pPersona.Representante;
            iQuery.Telefono = pPersona.Telefono;
            iContext.SaveChanges();
        }
    }
}
