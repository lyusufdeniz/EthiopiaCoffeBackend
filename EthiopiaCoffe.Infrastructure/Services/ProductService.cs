using AutoMapper;
using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Product;
using EthiopiaCoffe.Repository.Repositories;
using EthiopiaCoffe.Repository.Services;
using EthiopiaCoffe.Repository.UnitOfWorks;
using System.Net;

namespace EthiopiaCoffe.Infrastructure.Services
{
    public class ProductService : GenericService<Product,ProductDTO>, IProductService
    {
        IProductRepository _productRepository;
        public ProductService(IMapper mapper, IGenericRepository<Product> genericRepository, IUnitOfWork unitOfWork, IProductRepository productRepository) : base(mapper, genericRepository, unitOfWork)
        {
            _productRepository = productRepository;
        }
        public async Task<ResponseDTO<Guid>> AddAsync(ProductAddDTO entity) => ResponseDTO<Guid>.Succes(await _productRepository.AddAsync(_mapper.Map<Product>(entity)), HttpStatusCode.Created);
  

        public ResponseDTO<NoContent> Update(ProductUpdateDTO entity)
        {
            _productRepository.Update(_mapper.Map<Product>(entity));
          return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);

        }
        public ResponseDTO<List<ProductWithCategoryDTO>> ProductsWithCategory()
        {
            var mapped = _mapper.Map<List<ProductWithCategoryDTO>>(_productRepository.ProductsWithCategory());
            return ResponseDTO<List<ProductWithCategoryDTO>>.Succes(mapped);
        }
    }
}
