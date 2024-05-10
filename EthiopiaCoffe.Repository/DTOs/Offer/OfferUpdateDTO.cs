namespace EthiopiaCoffe.Repository.DTOs.Offer
{
    public record  OfferUpdateDTO:BaseOfferDTO
    {
        public Guid Id { get; init; }
        public Guid CategoryId { get; init; }

    }
}
