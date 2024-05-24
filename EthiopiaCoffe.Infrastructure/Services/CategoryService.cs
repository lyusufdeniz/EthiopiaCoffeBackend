using AutoMapper;
using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Persistence.Repositories;
using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Category;
using EthiopiaCoffe.Repository.Repositories;
using EthiopiaCoffe.Repository.Services;
using EthiopiaCoffe.Repository.UnitOfWorks;
using System.Net;

namespace EthiopiaCoffe.Infrastructure.Services
{
    public class CategoryService(ICategoryRepository _categoryRepository, IUnitOfWork _unitOfWork, IMapper _mapper) : ICategoryService
    {

        public async Task<ResponseDTO<CategoryDTO>> GetById(Guid id)
        {
            var entity = await _categoryRepository.GetByIdAsync(id);
            if (entity is null)
            {
               return ResponseDTO<CategoryDTO>.Fail($"Category Not Found", HttpStatusCode.NotFound);
            }
            var mapped = _mapper.Map<CategoryDTO>(entity);
            return ResponseDTO<CategoryDTO>.Succes(mapped, HttpStatusCode.OK);
        }
        public async Task<ResponseDTO<Guid>> AddAsync(CategoryAddDTO entity)
        {
            var id = await _categoryRepository.AddAsync(_mapper.Map<Category>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<Guid>.Succes(id, HttpStatusCode.Created);
        }

        public async Task<ResponseDTO<List<CategoryDTO>>> AllAsync()
        {
            var mapped = _mapper.Map<List<CategoryDTO>>(await _categoryRepository.All());
            return ResponseDTO<List<CategoryDTO>>.Succes(mapped, HttpStatusCode.OK);
        }

        public async Task<ResponseDTO<List<CategoryWithProductsDTO>>> CategoryWithProductsAsync()
        {
            var mapped = _mapper.Map<List<CategoryWithProductsDTO>>(await _categoryRepository.CategoryWithProducts());
            return ResponseDTO<List<CategoryWithProductsDTO>>.Succes(mapped, HttpStatusCode.OK);
        }

        public async Task<ResponseDTO<NoContent>> DeleteAsync(CategoryDTO entity)
        {
            if (await _categoryRepository.GetByIdAsync(entity.Id) is null)
            {
              return ResponseDTO<NoContent>.Fail($"Category Not Found", HttpStatusCode.NotFound);
            }

            await _categoryRepository.Delete(_mapper.Map<Category>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }

        public async Task<ResponseDTO<NoContent>> DeleteAsync(Guid id)
        {
            var entity = await _categoryRepository.GetByIdAsync(id);
            if (entity is null)
            {
             return   ResponseDTO<NoContent>.Fail($"Category Not Found", HttpStatusCode.NotFound);
            }

            await _categoryRepository.Delete(_mapper.Map<Category>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }


        public async Task<ResponseDTO<NoContent>> UpdateAsync(CategoryUpdateDTO entity)
        {
            if (await _categoryRepository.GetByIdAsync(entity.Id) is null)
            {
                return ResponseDTO<NoContent>.Fail($"Category Not Found", HttpStatusCode.NotFound);
            }
            var mapped = _mapper.Map<Category>(entity);
            await _categoryRepository.Update(mapped);
            await _unitOfWork.CommitAsync();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);
        }



    }
}
