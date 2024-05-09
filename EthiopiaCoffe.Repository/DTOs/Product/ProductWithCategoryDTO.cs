using EthiopiaCoffe.Repository.DTOs.Category;

namespace EthiopiaCoffe.Repository.DTOs.Product
{
    public record ProductWithCategoryDTO: ProductDTO
    {
     
        public CategoryDTO Category { get; set; } = default!;
    }
}
