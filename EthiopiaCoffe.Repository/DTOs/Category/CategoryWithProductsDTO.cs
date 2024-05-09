using EthiopiaCoffe.Repository.DTOs.Product;

namespace EthiopiaCoffe.Repository.DTOs.Category
{
    public record CategoryWithProductsDTO: BaseCategoryDTO
    {
        public Guid Id { get; set; }

        public DateOnly CreateDate { get; set; }
        public List<ProductDTO>? Products { get; init; }
    }
}
