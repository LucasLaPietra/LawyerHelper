using LawyerHelper.DAL.Interfaces;
using LawyerHelper.DAL.Repositorio;
using LawyerHelper.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.Controladores
{
    class ControladorCobro
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorCobro(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public IList<Cobro> MostrarCobros()
        {
            IList<Cobro> iQuery = iUdT.RepositorioCobro.ObtenerTodos();
            return iQuery;
        }

        public void RegistrarCobro(double pImporte, DateTime pFechayHora, string pDetalle)
        {
            Cobro iCobro = new Cobro(pImporte, pFechayHora, pDetalle);
            iUdT.RepositorioCobro.Agregar(iCobro);
            iUdT.Guardar();
        }

        /*public void ModificarPersona(string pNombre, string pApellido, string pDni, string pDomicilio,
    string pTelefono, DateTime pFecha, string pProfesion, string pLugarTrabajo, string pCuil, string pEstadoCivil, string pRepLegal, string pDomiLegal)
        {
            Persona iPersona = new Persona(pNombre, pApellido, pDni, pDomicilio,
            pTelefono, pFecha, pProfesion, pLugarTrabajo, pCuil, pEstadoCivil, pRepLegal, pDomiLegal);
            iUdT.RepositorioPersona.ModificarPersona(iPersona);
            iUdT.RepositorioPersona.Modificar(iPersona);
            //no me deja utilizar el savechanges de la unit of work, pero si si la hago desde el repositorio
            //iUdT.Guardar();
        } */

        public void BajaCobro(Cobro pCobro)
        {
            iUdT.RepositorioCobro.Eliminar(pCobro);
            iUdT.Guardar();
        }

        public Cobro ObtenerCobro(int pId)
        {
            return iUdT.RepositorioCobro.Obtener(pId);
        }

        public IList<Cobro> MostrarCobros()
        {
            IList<Cobro> iQuery = iUdT.RepositorioCobro.ObtenerTodos();
            return iQuery;
        }
    }
}
