namespace EthiopiaCoffe.Repository.DTOs.Product
{
    public  record  ProductAddDTO
    {
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public string Image { get; init; } = default!;
        public Guid CategoryId { get; set; }
    }
}
