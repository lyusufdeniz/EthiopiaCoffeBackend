using EthiopiaCoffe.Repository.DTOs.Category;

namespace EthiopiaCoffe.Repository.DTOs.Offer
{
    public record OfferWithCategoryDTO:BaseOfferDTO
    {
        public Guid Id { get; init; }
        public DateOnly CreateDate { get; set; }
        public CategoryDTO Category { get; init; } = default!;
    }
}
