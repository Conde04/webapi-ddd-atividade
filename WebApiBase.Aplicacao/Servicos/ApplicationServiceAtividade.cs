using WebApiBase.Aplicacao.DTO.DTO;
using WebApiBase.Aplicacao.Nucleo.Interfaces;
using WebApiBase.Dominio.Models;
using WebApiBase.Dominio.Nucleo.Interfaces.Servicos;
using WebApiBase.Infraestrutura.CrossCutting.Enumeradores;
using WebApiBase.Infraestrutura.Nucleo.Interfaces.Mapper;

namespace WebApiBase.Aplicacao.Servicos
{
    public class ApplicationServiceAtividade : ApplicationServiceBase<AtividadeDTO, Atividade>, IApplicationServiceAtividade
    {
        readonly IServiceAtividade _serviceAtividade;
        readonly IMapperAtividade _mapperAtividade;
        public ApplicationServiceAtividade(IServiceAtividade serviceAtividade, IMapperAtividade mapperAtividade) : base(serviceAtividade, mapperAtividade)
        {
            _serviceAtividade = serviceAtividade;
            _mapperAtividade = mapperAtividade;
        }

        public bool ValidarCadastroeDataInclusao(AtividadeDTO dto)
        {
            if (dto.Status == Status.Cadastrada && dto.DataConclusao == null)
                return true;
            
            return false;
        }
        public AtividadeDTO ConcluirAtividade(AtividadeDTO dto) 
        {
                dto.Status = Status.Concluida;
                dto.DataConclusao = DateTime.Now;
                return dto;
        }
        public AtividadeDTO MarcarAtividadeExecucao(AtividadeDTO dto)
        {
            dto.Status = Status.EmExecucao;
            dto.DataConclusao = null;
            return dto;
        }
    }
}
