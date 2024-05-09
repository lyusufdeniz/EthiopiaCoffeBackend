using AutoMapper;
using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.DTOs.Category;

namespace EthiopiaCoffe.Infrastructure.Mapping
{
    public class CategoryObjectMap:Profile
    {
        public CategoryObjectMap()
        {
            CreateMap<Category,CategoryDTO>().ReverseMap();
            CreateMap<Category,CategoryAddDTO>().ReverseMap();
            CreateMap<Category,CategoryUpdateDTO>().ReverseMap();
            CreateMap<Category,CategoryWithProductsDTO>().ReverseMap();
        }
    }
}
