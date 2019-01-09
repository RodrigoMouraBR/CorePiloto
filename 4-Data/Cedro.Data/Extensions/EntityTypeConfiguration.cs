using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Cedro.Data.Extensions
{
    public abstract class EntityTypeConfiguration<TEntity> where TEntity : class
    {
        public abstract void map(EntityTypeBuilder<TEntity> builder);
    }
}