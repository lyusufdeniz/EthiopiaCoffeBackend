namespace EthiopiaCoffe.Domain.Abstract.Entities
{
    abstract public class BaseEntity : IBaseEntity
    {
        public Guid Id { get; set; }
        public DateOnly CreateDate { get; set; }
    }
}
