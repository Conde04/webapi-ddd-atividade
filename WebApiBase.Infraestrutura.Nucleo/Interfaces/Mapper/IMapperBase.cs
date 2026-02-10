using WebApiBase.Aplicacao.DTO.DTO;
using WebApiBase.Dominio.Models;

namespace WebApiBase.Infraestrutura.Nucleo.Interfaces.Mapper
{
    public interface IMapperBase<TypeDTO, TypeModel> where TypeDTO : BaseDTO
                                                         where TypeModel : BaseEntity
    {
        TypeModel Map(TypeDTO typeDTO);
        IEnumerable<TypeModel> MapList(IEnumerable<TypeDTO> typeDTOList);
        TypeDTO ReverseMap(TypeModel typeModel);
        IEnumerable<TypeDTO> ReverseMapList(IEnumerable<TypeModel> typeModelList);
    }
}