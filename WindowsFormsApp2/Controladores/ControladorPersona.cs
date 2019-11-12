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

        public void ModificarPersona( string pNombre, string pApellido, string pDni, string pDomicilio,
    string pTelefono, DateTime pFecha, string pProfesion, string pLugarTrabajo, string pCuil, string pEstadoCivil, string pRepLegal, string pDomiLegal)
        {
            Persona iPersona = new Persona( pNombre, pApellido, pDni, pDomicilio,
            pTelefono, pFecha, pProfesion, pLugarTrabajo, pCuil, pEstadoCivil, pRepLegal, pDomiLegal);
            iUdT.RepositorioPersona.ModificarPersona(iPersona);
            iUdT.RepositorioPersona.Modificar(iPersona);
            //no me deja utilizar el savechanges de la unit of work, pero si si la hago desde el repositorio
            //iUdT.Guardar();
        }

        public void BajaPersona(Persona pPersona)
        {
            iUdT.RepositorioPersona.Eliminar(pPersona);
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

        public Persona BusquedaPorNombreyAp(string pApellido, string pNombre)
        {
            List<Persona> ListaApellido= iUdT.RepositorioPersona.BusquedaPersonas("Apellido", pApellido).ToList();
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
