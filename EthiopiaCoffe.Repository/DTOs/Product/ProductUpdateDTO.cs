namespace EthiopiaCoffe.Repository.DTOs.Product
{
    public record ProductUpdateDTO: BaseProductDTO
    {
        public Guid Id { get; init; }
        public Guid CategoryId { get; set; }
    }
}
