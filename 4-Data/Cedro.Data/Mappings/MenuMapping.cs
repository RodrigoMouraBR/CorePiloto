using Cedro.Data.Extensions;
using Cedro.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Cedro.Data.Mappings
{
    public class MenuMapping : EntityTypeConfiguration<Menu>
    {
        public override void map(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(c=>c.Name)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.ImagePath)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.Description)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Property(c=>c.Price)
            .HasColumnType("varchar(150)")
            .IsRequired();
            builder.Ignore(c=>c.ValidationResult);
            builder.Ignore(c=>c.CascadeMode);
            builder.ToTable("Menu");
            builder.HasOne(r=>r.Restaurant)
            .WithMany(m=>m.Menus)
            .HasForeignKey(a=>a.RestaurantId);
        }
    }
}