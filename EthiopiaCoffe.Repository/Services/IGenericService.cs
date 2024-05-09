using EthiopiaCoffe.Repository.DTOs;

namespace EthiopiaCoffe.Repository.Services
{
    public interface IGenericService<T, TDTO> where T : class where TDTO : class 
    {
        ResponseDTO<List<TDTO>> GetAll();
        Task<ResponseDTO<TDTO>> GetByIdAsync(Guid id);
        Task<ResponseDTO<Guid>> AddAsync(TDTO entity);
        ResponseDTO<NoContent> Update(TDTO entity);
       ResponseDTO<NoContent> Delete(TDTO entity);
        Task<ResponseDTO<NoContent>> Delete(Guid id);




    }
}
