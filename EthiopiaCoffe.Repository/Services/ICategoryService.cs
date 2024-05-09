using EthiopiaCoffe.Repository.DTOs.Category;
using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.DTOs.Product;

namespace EthiopiaCoffe.Repository.Services
{
    public interface ICategoryService:IGenericService<Category,CategoryDTO>
    {
        ResponseDTO<List<CategoryWithProductsDTO>> CategoryWithProducts();
        Task<ResponseDTO<Guid>> AddAsync(CategoryAddDTO entity);
        ResponseDTO<NoContent> Update(CategoryUpdateDTO entity);
    }
}
