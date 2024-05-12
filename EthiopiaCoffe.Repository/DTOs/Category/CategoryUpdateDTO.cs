
namespace EthiopiaCoffe.Repository.DTOs.Category
{
    public record CategoryUpdateDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;


    }
}
