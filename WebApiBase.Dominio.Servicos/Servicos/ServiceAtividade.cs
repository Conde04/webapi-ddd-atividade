using WebApiBase.Aplicacao.DTO.DTO;
using WebApiBase.Dominio.Models;
using WebApiBase.Dominio.Nucleo.Interfaces.Repositorios;
using WebApiBase.Dominio.Nucleo.Interfaces.Servicos;

namespace WebApiBase.Dominio.Servicos.Servicos
{
    public class ServiceAtividade : ServiceBase<Atividade>, IServiceAtividade
    {
        readonly IRepositoryAtividade _repositoryAtividade;
        public ServiceAtividade(IRepositoryAtividade repositoryAtividade) : base(repositoryAtividade)
        {
            _repositoryAtividade = repositoryAtividade;
        }
        public bool ValidarCadastroeDataInclusao(AtividadeDTO dto)
        {
            return false;
        }
    }
}