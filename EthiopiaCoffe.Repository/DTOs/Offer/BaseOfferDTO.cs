namespace EthiopiaCoffe.Repository.DTOs.Offer
{
    public record BaseOfferDTO
    {
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public string Image { get; init; } = default!;

    }
}
