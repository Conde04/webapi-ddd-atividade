using AutoMapper;
using WebApiBase.Aplicacao.DTO.DTO;
using WebApiBase.Dominio.Models;
using WebApiBase.Infraestrutura.Nucleo.Interfaces.Mapper;

namespace WebApiBase.Infraestrutura.CrossCutting.Adaptadores
{
    public abstract class MapperBase<TypeDTO, TypeModel> : IMapperBase<TypeDTO, TypeModel> where TypeDTO : BaseDTO
                                                                                           where TypeModel : BaseEntity

    {
        readonly IMapper _mapper;

        public MapperBase(IMapper mapper)
        {
            _mapper = mapper;
        }
        public virtual TypeModel Map(TypeDTO typeDTO)
        {
            return _mapper.Map<TypeModel>(typeDTO);
        }
        public virtual IEnumerable<TypeModel> MapList(IEnumerable<TypeDTO> typeDTOList)
        {
            return _mapper.Map<IEnumerable<TypeModel>>(typeDTOList);
        }
        public virtual TypeDTO ReverseMap(TypeModel typeModel)
        {
            return _mapper.Map<TypeDTO>(typeModel);
        }
        public virtual IEnumerable<TypeDTO> ReverseMapList(IEnumerable<TypeModel> typeModelList)
        {
            return _mapper.Map<IEnumerable<TypeDTO>>(typeModelList);
        }
    }
}