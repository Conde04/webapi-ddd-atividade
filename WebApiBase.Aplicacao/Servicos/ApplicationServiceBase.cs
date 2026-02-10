using WebApiBase.Aplicacao.DTO.DTO;
using WebApiBase.Aplicacao.Nucleo.Interfaces;
using WebApiBase.Dominio.Models;
using WebApiBase.Dominio.Nucleo.Interfaces.Servicos;
using WebApiBase.Infraestrutura.Nucleo.Interfaces.Mapper;

namespace WebApiBase.Aplicacao.Servicos
{
    public abstract class ApplicationServiceBase<TDTO, TEntity> : IApplicationServiceBase<TDTO> where TDTO : BaseDTO
                                                                                                where TEntity : BaseEntity

    {
        readonly IServiceBase<TEntity> _serviceBase;
        readonly IMapperBase<TDTO, TEntity> _mapperBase;

        public ApplicationServiceBase(IServiceBase<TEntity> serviceBase, IMapperBase<TDTO, TEntity> mapperBase)
        {
            _serviceBase = serviceBase;
            _mapperBase = mapperBase;
        }

        public TDTO AddOrUpdate(TDTO dto)
        {
            var entity = _mapperBase.Map(dto);

            _serviceBase.AddOrUpdate(entity);

            return _mapperBase.ReverseMap(entity);
        }

        public IEnumerable<TDTO> GetAll()
        {
            var entities = _serviceBase.GetAll();
            return _mapperBase.ReverseMapList(entities);
        }

        public TDTO GetById(int id)
        {
            var entity = _serviceBase.GetById(id);
            return _mapperBase.ReverseMap(entity);
        }

        public void Remove(TDTO dto)
        {
            var entity = _mapperBase.Map(dto);
            _serviceBase.Remove(entity);
        }
    }
}