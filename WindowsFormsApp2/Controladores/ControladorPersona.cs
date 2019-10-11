using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Controladores
{
    class ControladorPersona
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorPersona(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }
        public void RegistrarPersona (string pNombre, string pApellido, string pDni, string pDomicilio,
            string pTelefono, DateTime pFecha, string pProfesion, string pLugarTrabajo, string pCuil, string pEstadoCivil, string pRepLegal, string pDomiLegal)
        {
            Persona iPersona = new Persona(pNombre, pApellido, pDni, pDomicilio,
            pTelefono, pFecha, pProfesion, pLugarTrabajo, pCuil, pEstadoCivil, pRepLegal, pDomiLegal);
            iUdT.RepositorioPersona.Agregar(iPersona);
            iUdT.Guardar();
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
    }
}
