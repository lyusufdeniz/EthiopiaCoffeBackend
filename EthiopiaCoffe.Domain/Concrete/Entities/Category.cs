﻿using EthiopiaCoffe.Domain.Abstract.Entities;

namespace EthiopiaCoffe.Domain.Concrete.Entities
{
    public class Category : BaseEntity, IBaseEntity, IHasDelete
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public ICollection<Product>? Products { get; set; }
        public ICollection<Offer>? Offers { get; set; }
        public bool IsDeleted { get; set; }
    }
}
