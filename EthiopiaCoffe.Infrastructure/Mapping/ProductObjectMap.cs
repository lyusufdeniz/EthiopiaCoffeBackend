using AutoMapper;
using EthiopiaCoffe.Domain.Concrete.Entities;
using EthiopiaCoffe.Repository.DTOs.Product;

namespace EthiopiaCoffe.Infrastructure.Mapping
{
    public class ProductObjectMap:Profile
    {
        public ProductObjectMap()
        {
       
            CreateMap<Product,ProductAddDTO>().ReverseMap();
            CreateMap<Product, ProductDTO>().ReverseMap();
            CreateMap<Product, ProductUpdateDTO>().ReverseMap();
            CreateMap<Product, ProductWithCategoryDTO>().ReverseMap();
         
      
     
           
        }
    }
}
