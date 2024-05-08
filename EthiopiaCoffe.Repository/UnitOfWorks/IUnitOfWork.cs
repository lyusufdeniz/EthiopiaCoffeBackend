namespace EthiopiaCoffe.Repository.UnitOfWorks
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();

    }
}
