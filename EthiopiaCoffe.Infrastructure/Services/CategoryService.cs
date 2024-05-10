using AutoMapper;
using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.DTOs;
using EthiopiaCoffe.Repository.DTOs.Category;
using EthiopiaCoffe.Repository.Repositories;
using EthiopiaCoffe.Repository.Services;
using EthiopiaCoffe.Repository.UnitOfWorks;
using System.Net;

namespace EthiopiaCoffe.Infrastructure.Services
{
    public class CategoryService : GenericService<Category, CategoryDTO>, ICategoryService
    {
        ICategoryRepository _categoryRepository;
        public CategoryService(IMapper mapper, IGenericRepository<Category> genericRepository, IUnitOfWork unitOfWork, ICategoryRepository categoryRepository) : base(mapper, genericRepository, unitOfWork)
        {
            _categoryRepository = categoryRepository;
        }


        public ResponseDTO<List<CategoryWithProductsDTO>> CategoryWithProducts()
            => ResponseDTO<List<CategoryWithProductsDTO>>.Succes(_mapper.Map<List<CategoryWithProductsDTO>>(_categoryRepository.CategoryWithProducts()));


        public ResponseDTO<NoContent> Update(CategoryUpdateDTO entity)
        {
            _categoryRepository.Update(_mapper.Map<Category>(entity));
            _unitOfWork.Commit();
            return ResponseDTO<NoContent>.Succes(HttpStatusCode.NoContent);

        }
        public async Task<ResponseDTO<Guid>> AddAsync(CategoryAddDTO entity)
        {
            var id = await _categoryRepository.AddAsync(_mapper.Map<Category>(entity));
            await _unitOfWork.CommitAsync();
            return ResponseDTO<Guid>.Succes(id,HttpStatusCode.Created);
        }
    }
}
