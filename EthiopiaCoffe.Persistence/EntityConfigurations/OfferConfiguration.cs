using EthiopiaCoffe.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EthiopiaCoffe.Persistence.EntityConfigurations
{
    public class OfferConfiguration : IEntityTypeConfiguration<Offer>
    {
        public void Configure(EntityTypeBuilder<Offer> builder)
        {
            builder.HasKey(offer => offer.Id);
            builder.Property(offer => offer.Id).ValueGeneratedNever();
            builder.Property(offer => offer.Name).IsRequired();
            builder.Property(offer => offer.Name).HasMaxLength(15);
            builder.Property(offer => offer.Description).IsRequired();
            builder.Property(offer => offer.Description).HasMaxLength(50);
        }
    }
}
