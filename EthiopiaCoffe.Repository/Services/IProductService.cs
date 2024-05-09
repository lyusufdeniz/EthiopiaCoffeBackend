using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Product;

namespace EthiopiaCoffe.Repository.Services
{
    public interface IProductService : IGenericService<Product, ProductDTO> 
    {
        ResponseDTO<List<ProductWithCategoryDTO>> ProductsWithCategory();
        Task<ResponseDTO<Guid>> AddAsync(ProductAddDTO entity);
        ResponseDTO<NoContent> Update(ProductUpdateDTO entity);
    }
}
