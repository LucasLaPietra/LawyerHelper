using LawyerHelper.Clases;
using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        //Definicion de la clase contexto
        private readonly Contexto iDbContext;
        //Declaracion de atributo para usar en el patron singleton
        private static volatile UnidadDeTrabajo cInstancia = null;
        private static readonly object cPadlock = new object();

        private UnidadDeTrabajo()
        {
            this.iDbContext = new Contexto();
            //Inicializar los repositorios
            this.RepositorioCobro = new RepositorioCobro(iDbContext);
            this.RepositorioDemandado = new RepositorioDemandado(iDbContext);
            this.RepositorioDemandante = new RepositorioDemandante(this.iDbContext);
            this.RepositorioDocumento = new RepositorioDocumento(this.iDbContext);
            this.RepositorioJuicio = new RepositorioJuicio(iDbContext);
            this.RepositorioPago = new RepositorioPago(iDbContext);
            this.RepositorioPersona = new RepositorioPersona(iDbContext);
            this.RepositorioRecordatorio = new RepositorioRecordatorio(iDbContext);
        }

        //Implementacion de las interfaces en la unidad de trabajo
        public IRepositorioCobro RepositorioCobro { get; private set; }
        public IRepositorioDemandado RepositorioDemandado { get; private set; }
        public IRepositorioDemandante RepositorioDemandante { get; private set; }
        public IRepositorioDocumento RepositorioDocumento { get; private set; }
        public IRepositorioJuicio RepositorioJuicio { get; private set; }
        public IRepositorioPago RepositorioPago { get; private set; }
        public IRepositorioPersona RepositorioPersona { get; private set; }
        public IRepositorioRecordatorio RepositorioRecordatorio { get; private set; }
        /// <summary>
        /// Patron singleton para usar el mismo contexto en todo el sistema
        /// </summary>
        public static UnidadDeTrabajo Instancia
        {
            get
            {
                if (cInstancia == null)
                {
                    lock (cPadlock)
                    {
                        if (cInstancia == null)
                        {
                            cInstancia = new UnidadDeTrabajo();
                        }
                    }
                }
                return cInstancia;
            }
        }

        /// <summary>
        /// Libera memoria
        /// </summary>
        public void Dispose()
        {
            this.iDbContext.Dispose();
        }
        /// <summary>
        /// Guarda en la base de datos 
        /// </summary>
        public void Guardar()
        {
            this.iDbContext.SaveChanges();
        }
    }
}