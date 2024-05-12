namespace EthiopiaCoffe.Domain.Abstract.Entities
{
    abstract public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
