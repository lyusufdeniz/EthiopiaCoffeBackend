﻿namespace EthiopiaCoffe.Repository.DTOs.Product
{
    public record ProductDTO
    {
        public Guid Id { get; init; }
        public string Name { get; init; } = default!;
        public string Description { get; init; } = default!;
        public string Image { get; init; } = default!;
        public Guid CategoryId { get; set; }
        public DateOnly CreateDate { get; init; }

    }
}
