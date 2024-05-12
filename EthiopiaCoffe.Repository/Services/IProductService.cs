using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Product;

namespace EthiopiaCoffe.Repository.Services
{
    public interface IProductService 
    {
        Task<ResponseDTO<ProductDTO>> GetById(Guid id);
        Task<ResponseDTO<List<ProductDTO>>> AllAsync();
        Task<ResponseDTO<Guid>> AddAsync(ProductAddDTO entity);
        Task<ResponseDTO<NoContent>> UpdateAsync(ProductUpdateDTO entity);
        Task<ResponseDTO<NoContent>> DeleteAsync(ProductDTO entity);
        Task<ResponseDTO<NoContent>> DeleteAsync(Guid id);
        Task<ResponseDTO<List<ProductWithCategoryDTO>>> ProductsWithCategory();
      

    }
}
