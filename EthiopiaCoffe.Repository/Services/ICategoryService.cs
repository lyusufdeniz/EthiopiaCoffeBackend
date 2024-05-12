using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Category;

namespace EthiopiaCoffe.Repository.Services
{
    public interface ICategoryService
    {
        Task<ResponseDTO<CategoryDTO>> GetById(Guid id);
        Task<ResponseDTO<List<CategoryDTO>>> AllAsync();
        Task<ResponseDTO<Guid>> AddAsync(CategoryAddDTO entity);
        Task<ResponseDTO<NoContent>> UpdateAsync(CategoryUpdateDTO entity);
        Task<ResponseDTO<NoContent>> DeleteAsync(CategoryDTO entity);
        Task<ResponseDTO<NoContent>> DeleteAsync(Guid id);
        Task<ResponseDTO<List<CategoryWithProductsDTO>>> CategoryWithProductsAsync();
    }
}
