using WebApiBase.Dominio.Models;
using WebApiBase.Dominio.Nucleo.Interfaces.Repositorios;
using WebApiBase.Infraestrutura.Data;

namespace WebApiBase.Infraestrutura.Repositorios.Repositorios
{
    public class RepositoryAtividade : RepositoryBase<Atividade>, IRepositoryAtividade
    {
        readonly InMemoryContext _inMemoryContext;

        public RepositoryAtividade(InMemoryContext inMemoryContext) : base(inMemoryContext)
        {
            _inMemoryContext = inMemoryContext;
        }
    }
}