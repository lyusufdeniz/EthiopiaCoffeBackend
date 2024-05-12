namespace EthiopiaCoffe.Repository.DTOs.Offer
{
    public record OfferDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public string Image { get; init; } = default!;
        public Guid CategoryId { get;init; }
        public DateOnly CreateDate { get; set; }

    }
}
