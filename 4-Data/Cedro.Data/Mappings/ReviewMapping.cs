using Cedro.Data.Extensions;
using Cedro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Cedro.Data.Mappings
{
    public class ReviewMapping : EntityTypeConfiguration<Review>
    {
        public override void map(EntityTypeBuilder<Review> builder)
        {
            builder.Property(c=>c.Name)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.Date)
            .IsRequired();
            builder.Property(c=>c.Comments)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.Rating)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Ignore(c=>c.ValidationResult);
            builder.Ignore(c=>c.CascadeMode);
            builder.ToTable("Review");
            builder.HasOne(r=>r.Restaurant)
            .WithMany(m=>m.Reviews)
            .HasForeignKey(a=>a.RestaurantId);
        }
    }
}