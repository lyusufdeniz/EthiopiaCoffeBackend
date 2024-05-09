namespace EthiopiaCoffe.Repository.DTOs.Product
{
    public record ProductDTO: BaseProductDTO
    {
        public Guid Id { get; init; }
        public Guid CategoryId { get; set; }
        public DateOnly CreateDate { get; init; }

    }
}
