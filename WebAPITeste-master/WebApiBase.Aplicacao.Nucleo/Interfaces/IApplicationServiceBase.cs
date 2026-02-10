using WebApiBase.Aplicacao.DTO.DTO;

namespace WebApiBase.Aplicacao.Nucleo.Interfaces
{
    public interface IApplicationServiceBase<TDTO> where TDTO : BaseDTO
    {
        TDTO AddOrUpdate(TDTO dto);
        void Remove(TDTO dto);
        TDTO GetById(int id);
        IEnumerable<TDTO> GetAll();
    }
}