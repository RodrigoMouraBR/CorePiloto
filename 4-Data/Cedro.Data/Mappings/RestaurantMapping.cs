using Cedro.Data.Extensions;
using Cedro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Cedro.Data.Mappings
{
    public class RestaurantMapping : EntityTypeConfiguration<Restaurant>
    {
        public override void map(EntityTypeBuilder<Restaurant> builder)
        {
            builder.Property(c=>c.Name)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.Category)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.DeliveryEstimate)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.Rating)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.imagePath)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.About)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.Hours)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Ignore(c=>c.ValidationResult);
            builder.Ignore(c=>c.CascadeMode);
            builder.ToTable("Restaurant");
            
        }
    }
}