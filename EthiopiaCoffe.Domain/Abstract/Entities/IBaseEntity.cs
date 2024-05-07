namespace EthiopiaCoffe.Domain.Abstract.Entities
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
        public DateOnly CreateDate { get; set; }

    }
}
