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

        public void RegistrarPersona(string pNombre, string pApellido, string pDni, string pDomicilio,
            string pTelefono, DateTime pFecha, string pProfesion, string pLugarTrabajo, string pCuil, string pEstadoCivil, string pRepLegal, string pDomiLegal)
        {
            Persona iPersona = new Persona(pNombre, pApellido, pDni, pDomicilio,
            pTelefono, pFecha, pProfesion, pLugarTrabajo, pCuil, pEstadoCivil, pRepLegal, pDomiLegal);
            iUdT.RepositorioPersona.PersonaIgualDni(pDni);
            iUdT.RepositorioPersona.Agregar(iPersona);
            iUdT.Guardar();
        }

        public void ModificarPersona( int pId, string pNombre, string pApellido, string pDni, string pDomicilio,
    string pTelefono, DateTime pFecha, string pProfesion, string pLugarTrabajo, string pCuil, string pEstadoCivil, string pRepresentante, string pDomiLegal)
        {
            Persona iQuery = iUdT.RepositorioPersona.Obtener(pId);
            iQuery.Dni = pDni;
            iQuery.Domicilio = pDomicilio;
            iQuery.DomicilioLegal = pDomiLegal;
            iQuery.EstadoCivil = pEstadoCivil;
            iQuery.FechaNacimiento = pFecha;
            iQuery.LugarTrabajo = pLugarTrabajo;
            iQuery.Profesion = pProfesion;
            iQuery.Representante = pRepresentante;
            iQuery.Telefono = pTelefono;
            iUdT.Guardar();
        }

        public void BajaPersona(Persona pPersona)
        {
            iUdT.RepositorioPersona.Eliminar(pPersona);
            iUdT.Guardar();
        }

        public void BajaLogicaPersona(Persona pPersona)
        {
            Persona iQuery = iUdT.RepositorioPersona.Obtener(pPersona.PersonaId);
            iQuery.Activo = false;
            iUdT.Guardar();
        }

        public void AltaLogicaPersona(Persona pPersona)
        {
            Persona iQuery = iUdT.RepositorioPersona.Obtener(pPersona.PersonaId);
            iQuery.Activo = false;
            iUdT.Guardar();
        }

        public Persona ObtenerPersona(int pId)
        {
            return iUdT.RepositorioPersona.Obtener(pId);
        }

        public IList<Persona> ObtenerTodos()
        {
            return iUdT.RepositorioPersona.ObtenerTodos();
        }

        public IList<Persona> BusquedaAvanzadaPersona(string pParametro, string pValor)
        {
            return iUdT.RepositorioPersona.BusquedaPersonas(pParametro,pValor);
        }

        public IList<Persona> ObtenerTodosActivos(bool pActivo)
        {
            List<Persona> iQuery= iUdT.RepositorioPersona.ObtenerTodos().ToList();
            iQuery = iQuery.Where(n => n.Activo == pActivo).ToList();
            return iQuery;
        }

        public IList<Persona> BusquedaAvanzadaPersonaActivos(string pParametro, string pValor,bool pActivo)
        {
            return iUdT.RepositorioPersona.BusquedaPersonasActivas(pParametro, pValor,pActivo);
        }

        public void PersonaIgualDni(string pDni)
        {
            iUdT.RepositorioPersona.PersonaIgualDni(pDni);
        }

        public Persona BusquedaPorNombreyAp(string pApellido, string pNombre)
        {
            List<Persona> ListaApellido= iUdT.RepositorioPersona.BusquedaPersonas("Apellido", pApellido).ToList();
            ListaApellido = ListaApellido.Where(n => n.Activo == true).ToList();
            Persona iResultado = ListaApellido.FirstOrDefault(n => n.Nombre == pNombre);
            return iResultado;
        }

        public IList<Juicio> ObtenerJuicios(int pId)
        {
            List<Juicio> iQuery = new List<Juicio>();
            List<Demandado> iLista = iUdT.RepositorioDemandado.BuscarDemandadosDeUnaPersona(pId).ToList();
            List<Demandante> iLista2 = iUdT.RepositorioDemandante.BuscarDemandantesDeUnaPersona(pId).ToList();
            foreach (Demandado d in iLista)
            {
                iQuery.Add(d.Juicio);
            }
            foreach (Demandante d in iLista2)
            {
                iQuery.Add(d.Juicio);
            }
            return iQuery;
        }
    }
}
