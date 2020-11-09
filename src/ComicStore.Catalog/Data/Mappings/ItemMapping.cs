using ComicStore.Catalog.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicStore.Catalog.Data.Mappings
{
    public class ItemMapping : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(i => i.Name)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.Property(i => i.Description)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.Property(i => i.ImageUrl)
                .HasColumnType("varchar(250)");

            builder.ToTable("Items");
        }
    }
}