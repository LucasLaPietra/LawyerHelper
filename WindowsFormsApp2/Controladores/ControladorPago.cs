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
    class ControladorPago
    {
        private readonly UnidadDeTrabajo iUdT;
        public ControladorPago(UnidadDeTrabajo pUnidadTrabajo)
        {
            iUdT = pUnidadTrabajo;
        }

        public IList<Pago> MostrarPagos()
        {
            IList<Pago> iQuery = iUdT.RepositorioPago.ObtenerTodos();
            return iQuery;
        }

        public void RegistrarPago(double pImporte, DateTime pFechayHora, string pDetalle, Juicio pJuicio)
        {
            Pago iPago = new Pago(pImporte, pFechayHora, pDetalle, pJuicio);
            iUdT.RepositorioPago.Agregar(iPago);
            iUdT.Guardar();
        }

        public void BajaPago(Pago pPago)
        {
            iUdT.RepositorioPago.Eliminar(pPago);
            iUdT.Guardar();
        }

        public Pago ObtenerPago(int pId)
        {
            return iUdT.RepositorioPago.Obtener(pId);
        }

        public List<Pago> ObtenerPagosPorFecha(DateTime pFecha)
        {
            return iUdT.RepositorioPago.BusquedaPagoPorFecha(pFecha).ToList();
        }



    }
}
