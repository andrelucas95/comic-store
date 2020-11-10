using ComicStore.Sales.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ComicStore.Sales.Data.Mappings
{
    public class OrderItemMapping : IEntityTypeConfiguration<OrderItem>
    {
        public void Configure(EntityTypeBuilder<OrderItem> builder)
        {
            builder.HasKey(oi => oi.Id);

            builder.Property(oi => oi.ItemName)
                .IsRequired()
                .HasColumnType("varchar(250)");

            builder.HasOne(oi => oi.Order)
                .WithMany(o => o.Items);

            builder.ToTable("OrderItems");
        }
    }
}