using WebApiBase.Dominio.Models;
using WebApiBase.Dominio.Nucleo.Interfaces.Repositorios;
using WebApiBase.Infraestrutura.Data;

namespace WebApiBase.Infraestrutura.Repositorios.Repositorios
{
    public abstract class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        readonly InMemoryContext _inMemoryContext;

        public RepositoryBase(InMemoryContext inMemoryContext)
        {
            _inMemoryContext = inMemoryContext;
        }

        public virtual void AddOrUpdate(TEntity entity)
        {
            _inMemoryContext.Set<TEntity>().Update(entity);
            _inMemoryContext.SaveChanges();
        }

        public virtual void Remove(TEntity entity)
        {
            _inMemoryContext.Set<TEntity>().Remove(entity);
            _inMemoryContext.SaveChanges();
        }
        public virtual void RemoveRange(IEnumerable<TEntity> entityList)
        {
            _inMemoryContext.Set<TEntity>().RemoveRange(entityList);
            _inMemoryContext.SaveChanges();
        }
        public virtual TEntity GetById(int id)
        {
            return _inMemoryContext.Set<TEntity>()
                                   .Where(x => x.Id.Equals(id))
                                   .FirstOrDefault();
        }
        public virtual IEnumerable<TEntity> GetAll()
        {
            return _inMemoryContext.Set<TEntity>()
                                   .ToList();
        }
        public void Dispose()
        {
            _inMemoryContext.Dispose();
        }
    }
}
