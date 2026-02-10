using WebApiBase.Dominio.Models;
using WebApiBase.Dominio.Nucleo.Interfaces.Repositorios;
using WebApiBase.Dominio.Nucleo.Interfaces.Servicos;

namespace WebApiBase.Dominio.Servicos.Servicos
{
    public abstract class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity>  where TEntity : BaseEntity
    {
        readonly IRepositoryBase<TEntity> _repository;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
        }

        public void AddOrUpdate(TEntity entity)
        {
            _repository.AddOrUpdate(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public void Remove(TEntity entity)
        {
            _repository.Remove(entity);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

    }
}