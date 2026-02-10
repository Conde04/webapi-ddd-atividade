using AutoMapper;
using WebApiBase.Aplicacao.DTO.DTO;
using WebApiBase.Dominio.Models;
using WebApiBase.Infraestrutura.Nucleo.Interfaces.Mapper;

namespace WebApiBase.Infraestrutura.CrossCutting.Adaptadores
{
    public class MapperAtividade : MapperBase<AtividadeDTO, Atividade>, IMapperAtividade
    {
        public MapperAtividade(IMapper mapper) : base(mapper)
        {
        }
    }
}