using AutoMapper;
using WebApiBase.Aplicacao.DTO.DTO;
using WebApiBase.Dominio.Models;

namespace WebApiBase.Infraestrutura.CrossCutting.Adaptadores.Profiles
{
    public class AtividadeProfile : Profile
    {
        //todo: implementar perfil de mapeamento do AutoMapper para Atividade
        public AtividadeProfile()
        {
            CreateMap<AtividadeDTO, Atividade>();
        }
    }
}
