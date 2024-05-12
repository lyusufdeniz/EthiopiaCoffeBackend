using EthiopiaCoffe.Repository.DTOs.Category;

namespace EthiopiaCoffe.Repository.DTOs.Product
{
    public record ProductWithCategoryDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public string Image { get; init; } = default!;
        public DateTime CreateDate { get; init; }
        public CategoryDTO Category { get; set; } = default!;
    }
}
