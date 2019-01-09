using Microsoft.EntityFrameworkCore;
namespace Cedro.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
      public static void AddConfiguration<TEntity>(this ModelBuilder modelBuilder, 
      EntityTypeConfiguration<TEntity> configuration) where TEntity : class
      {
          configuration.map(modelBuilder.Entity<TEntity>());
      }   
    }
}