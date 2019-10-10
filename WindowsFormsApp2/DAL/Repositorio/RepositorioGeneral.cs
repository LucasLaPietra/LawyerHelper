using LawyerHelper.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawyerHelper.DAL.Repositorio
{
    abstract class RepositorioGeneral<TEntity, TDbContext> : IRepositorioGeneral<TEntity>
        where TEntity : class
        where TDbContext : DbContext
    {
        protected readonly TDbContext iContext;
        public RepositorioGeneral(TDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }
            this.iContext = pContext;
        }
        /// <summary>
        /// Agrego un objeto al repositorio
        /// </summary>
        /// <param name="pEntity">objeto a agregar</param>
        public void Agregar(TEntity pEntity)
        {
            this.iContext.Set<TEntity>().Add(pEntity);
        }
        /// <summary>
        /// Elimina un objeto del repositorio
        /// </summary>
        /// <param name="pEntity">objeto a eliminar</param>
        public void Eliminar(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new ArgumentNullException(nameof(pEntity));
            }
            this.iContext.Set<TEntity>().Remove(pEntity);
        }
        /// <summary>
        /// Modifica un objeto del repositorio
        /// </summary>
        /// <param name="pEntity">objeto a modificar</param>
        public void Modificar(TEntity pEntity)
        {
            if (pEntity == null)
            {
                throw new NullReferenceException(nameof(pEntity));
            }
            this.iContext.Entry(pEntity).State = EntityState.Modified;
        }
        /// <summary>
        /// Obtiene un objeto del repositorio a traves del id
        /// </summary>
        /// <param name="pId">identificador del objeto a buscar</param>
        /// <returns></returns>
        public TEntity Obtener(int pId)
        {
            return this.iContext.Set<TEntity>().Find(pId);
        }
        /// <summary>
        /// Genera una lista de todos objetos del repositorio
        /// </summary>
        /// <returns></returns>
        public IList<TEntity> ObtenerTodos()
        {
            return this.iContext.Set<TEntity>().ToList();
        }
    }
}
