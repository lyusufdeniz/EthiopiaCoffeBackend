using EthiopiaCoffe.Domain.Abstract.Entities;

namespace EthiopiaCoffe.Domain.Concrete.Entities
{
    public class Product : BaseEntity, IBaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Image { get; set; } = default!;
        public Guid CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        
    }
}
