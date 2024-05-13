using EthiopiaCoffe.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EthiopiaCoffe.Persistence.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(product => product.Id);
            builder.Property(product => product.Id).ValueGeneratedNever();
            builder.Property(product => product.Name).IsRequired();
            builder.Property(product => product.Name).HasMaxLength(15);
            builder.Property(product => product.Description).IsRequired();
            builder.Property(product => product.Description).HasMaxLength(50);
        }
    }
}
