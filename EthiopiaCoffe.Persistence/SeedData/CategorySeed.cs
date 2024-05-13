using EthiopiaCoffe.Domain.Concrete.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EthiopiaCoffe.Persistence.SeedData
{
    public class CategorySeed : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
                new Category() { Id = Guid.NewGuid(), Name = "Soğuk İçecekler", Description = "Serinletici içeceklerle yazın sıcağında keyifli anlar yaşayın!", CreateDate = DateTime.Now },
                new Category() { Id = Guid.NewGuid(), Name = "Sıcak İçecekler", Description = "Kahve tutkunları için enfes sıcak içecekler! ", CreateDate = DateTime.Now },
                new Category() { Id = Guid.NewGuid(), Name = "Tatlılar ve Atıştırmalıklar", Description = "Kekler, kurabiyeler, muffinler, sandviçler ve daha fazlası",CreateDate=DateTime.Now },
                new Category() { Id = Guid.NewGuid(), Name = "Kahve Çekirdekleri ve Çeşniler", Description = "Çeşitli kahve çekirdekleri özel karışımlar", CreateDate = DateTime.Now },
                new Category() { Id = Guid.NewGuid(), Name = "Özel İçecekler", Description = "Mevsimlik özel içecekler, meyve suları, smoothie'ler, spesiyal tarifler", CreateDate = DateTime.Now });
        }
    }
}
