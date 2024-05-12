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
    public class ProductService(IProductRepository _productRepository, IUnitOfWork _unitOfWork, IMapper _mapper) : IProductService

    {

        public async Task<ResponseDTO<Guid>> AddAsync(ProductAddDTO entity)
        {
            var id = await _productRepository.AddAsync(_mapper.Map<Product>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<Guid>.Succes(id, HttpStatusCode.Created);
        }

        public async Task<ResponseDTO<List<ProductDTO>>> AllAsync()
        {
            var mapped = _mapper.Map<List<ProductDTO>>(await _productRepository.All());
            return ResponseDTO<List<ProductDTO>>.Succes(mapped, HttpStatusCode.OK);
        }

        public async Task<ResponseDTO<NoContent>> DeleteAsync(ProductDTO entity)
        {
            if (_productRepository.GetByIdAsync(entity.Id) is null)
            {
              return  ResponseDTO<NoContent>.Fail($"Product Not Found", HttpStatusCode.NotFound);
            }

            await _productRepository.Delete(_mapper.Map<Product>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }

        public async Task<ResponseDTO<NoContent>> DeleteAsync(Guid id)
        {
            var entity = _productRepository.GetByIdAsync(id);
            if (entity is null)
            {
              return  ResponseDTO<NoContent>.Fail($"Product Not Found", HttpStatusCode.NotFound);
            }

            await _productRepository.Delete(_mapper.Map<Product>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }

        public async Task<ResponseDTO<ProductDTO>> GetById(Guid id)
        {
            var entity = await _productRepository.GetByIdAsync(id);
            if (entity is null)
            {
              return  ResponseDTO<ProductDTO>.Fail($"Product Not Found", HttpStatusCode.NotFound);
            }
            var mapped = _mapper.Map<ProductDTO>(entity);
            return ResponseDTO<ProductDTO>.Succes(mapped, HttpStatusCode.OK);
        }

        public async Task<ResponseDTO<List<ProductWithCategoryDTO>>> ProductsWithCategory()
        {
            var mapped = _mapper.Map<List<ProductWithCategoryDTO>>(await _productRepository.ProductsWithCategory());
            return ResponseDTO<List<ProductWithCategoryDTO>>.Succes(mapped, HttpStatusCode.OK);
        }

        public async Task<ResponseDTO<NoContent>> UpdateAsync(ProductUpdateDTO entity)
        {
            if (_productRepository.GetByIdAsync(entity.Id) is null)
            {
              return  ResponseDTO<NoContent>.Fail($"Category Not Found", HttpStatusCode.NotFound);
            }
            var mapped = _mapper.Map<Product>(entity);
            await _productRepository.Update(mapped);
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }
    }
}
