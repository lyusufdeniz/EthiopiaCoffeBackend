using EthiopiaCoffe.Repository.DTOs.Category;

namespace EthiopiaCoffe.Repository.DTOs.Offer
{
    public record OfferWithCategoryDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public string Image { get; init; } = default!;
        public DateTime CreateDate { get; set; }
        public CategoryDTO Category { get; init; } = default!;
    }
}
