namespace EthiopiaCoffe.Domain.Abstract.Entities
{
    public interface IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDeleted { get; set; }

    }
}
