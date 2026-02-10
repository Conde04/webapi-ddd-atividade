using Microsoft.AspNetCore.Mvc;
using WebApiBase.Aplicacao.DTO.DTO;
using WebApiBase.Aplicacao.Nucleo.Interfaces;

namespace WebApiBase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtividadeController : ControllerBase
    {
        readonly IApplicationServiceAtividade _applicationServiceAtividade;

        public AtividadeController(IApplicationServiceAtividade applicationServiceAtividade)
        {
            _applicationServiceAtividade = applicationServiceAtividade;
        }

        /// <summary>
        /// Endpoint para criar um novo registro.
        /// </summary>
        /// <param name="dto">Dados do novo registro</param>
        /// <returns>Retorna o registro criado</returns>
        [HttpPost]
        public virtual ActionResult Post(AtividadeDTO dto)
        {
            //todo: para inserir uma atividade, não é permitido status diferente de Cadastrado e nem preencher a propriedade DataConclusao, pois a atividade ainda não foi concluída.
            if (_applicationServiceAtividade.ValidarCadastroeDataInclusao(dto))
                return Ok(_applicationServiceAtividade.AddOrUpdate(dto));

            return BadRequest("O Status nao é Cadastrado ou a DataConclusao está preenchida");
        }

        /// <summary>
        /// Remove um registro pelo id
        /// </summary>
        /// <param name="dto">Dados do registro a ser removido</param>
        /// <returns>Não possui retorno</returns>
        [HttpDelete("{id}")]
        public virtual ActionResult Remove(AtividadeDTO dto)
        {
            _applicationServiceAtividade.Remove(dto);
            
            return Ok(dto);
        }

        /// <summary>
        /// Endpoint para buscar as informações básicas de todos os registros cadastrados.
        /// </summary>
        ///<returns>Retorna os registros cadastrados</returns>
        [HttpGet]
        public virtual ActionResult GetAll()
        {
            return Ok(_applicationServiceAtividade.GetAll());
        }

        /// <summary>
        /// Busca um registros com base no id, retornando as informações básicas da mesma.
        /// </summary>
        [HttpGet("{id}")]
        public virtual ActionResult Get(int id)
        {
            return Ok(_applicationServiceAtividade.GetById(id));
        }

        //todo: implementar os endpoints de concluir e de marcar como em execução
        //a data de conclusão deve ser preenchida somente quando a atividade for concluída, e não pode ser preenchida quando a atividade for marcada como em execução, pois a atividade ainda não foi concluída.
        [HttpPatch("{id}/executar")]
        public virtual ActionResult Executar(int id)
        {
            var atividadeDTO = _applicationServiceAtividade.GetById(id);
            if (atividadeDTO != null)
            {
                atividadeDTO = _applicationServiceAtividade.MarcarAtividadeExecucao(atividadeDTO);

                return Ok(_applicationServiceAtividade.AddOrUpdate(atividadeDTO));
            }
            return NotFound($"ID nao encontrado: {id}");
        }



        [HttpPatch("{id}/concluir")]
        public virtual ActionResult Concluir(int id) 
        {
            var atividadeDTO = _applicationServiceAtividade.GetById(id);
            if (atividadeDTO != null)
            {
                atividadeDTO = _applicationServiceAtividade.ConcluirAtividade(atividadeDTO);

                return Ok(_applicationServiceAtividade.AddOrUpdate(atividadeDTO));
            }
            return NotFound($"ID nao encontrado: {id}");
        }


    }
}
