namespace EthiopiaCoffe.Repository.DTOs.Product
{
    public  record ProductAddDTO: BaseProductDTO
    {

        public Guid CategoryId { get; set; }
    }
}
