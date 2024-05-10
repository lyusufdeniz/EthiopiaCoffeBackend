namespace EthiopiaCoffe.Repository.DTOs.Offer
{
    public record OfferDTO:BaseOfferDTO
    {
        public Guid Id { get; init; }
        public Guid CategoryId { get;init; }
        public DateOnly CreateDate { get; set; }

    }
}
