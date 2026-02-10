using WebApiBase.Aplicacao.DTO.DTO;

namespace WebApiBase.Aplicacao.Nucleo.Interfaces
{
    public interface IApplicationServiceAtividade : IApplicationServiceBase<AtividadeDTO>
    {
        bool ValidarCadastroeDataInclusao(AtividadeDTO dto);
        AtividadeDTO ConcluirAtividade(AtividadeDTO dto);
        AtividadeDTO MarcarAtividadeExecucao(AtividadeDTO dto);
    }
}
