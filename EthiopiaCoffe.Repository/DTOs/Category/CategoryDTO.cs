using EthiopiaCoffe.Repository.DTOs.Product;

namespace EthiopiaCoffe.Repository.DTOs.Category
{
    public record  CategoryDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public DateOnly CreateDate { get; set; }
   

    }
}
