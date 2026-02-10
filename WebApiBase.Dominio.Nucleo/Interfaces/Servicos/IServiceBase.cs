using WebApiBase.Dominio.Models;

namespace WebApiBase.Dominio.Nucleo.Interfaces.Servicos
{
    public interface IServiceBase<TEntity> : IDisposable where TEntity : BaseEntity
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void AddOrUpdate(TEntity entity);
        void Remove(TEntity entity);
        void Dispose();
    }
}
