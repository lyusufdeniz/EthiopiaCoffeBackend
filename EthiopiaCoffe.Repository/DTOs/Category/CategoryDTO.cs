using EthiopiaCoffe.Repository.DTOs.Product;

namespace EthiopiaCoffe.Repository.DTOs.Category
{
    public record  CategoryDTO: BaseCategoryDTO
    {
        public Guid Id { get; set; }
        public DateOnly CreateDate { get; set; }
   

    }
}
