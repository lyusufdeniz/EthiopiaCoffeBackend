namespace EthiopiaCoffe.Repository.DTOs.Category
{
    public record CategoryAddDTO
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
