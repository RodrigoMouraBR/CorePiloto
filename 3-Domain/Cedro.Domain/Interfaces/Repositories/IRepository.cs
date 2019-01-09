using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Cedro.Domain.Core.Entities;
namespace Cedro.Domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity<TEntity>
    {
         void Add(TEntity obj);
         void Update(TEntity obj);
         void Delete(Guid id);
         TEntity GetById(Guid id);
         IEnumerable<TEntity> GetAll();
         IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate);
         int SaveChanges();
    }
}