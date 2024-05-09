namespace EthiopiaCoffe.Repository.DTOs.Category
{
    public record BaseCategoryDTO
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
    }
}
