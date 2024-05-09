namespace EthiopiaCoffe.Repository.DTOs.Product
{
    public record BaseProductDTO
    {
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public string Image { get; init; } = default!;
    }
}
