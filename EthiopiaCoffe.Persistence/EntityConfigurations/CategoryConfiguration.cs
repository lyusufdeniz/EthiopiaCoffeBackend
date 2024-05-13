using EthiopiaCoffe.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EthiopiaCoffe.Persistence.EntityConfigurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(category => category.Id);
            builder.Property(category => category.Id).ValueGeneratedNever();
            builder.Property(category => category.Name).IsRequired();
            builder.Property(category => category.Name).HasMaxLength(15);
            builder.Property(category => category.Description).IsRequired();
            builder.Property(category => category.Description).HasMaxLength(50);
        }
    }
}
