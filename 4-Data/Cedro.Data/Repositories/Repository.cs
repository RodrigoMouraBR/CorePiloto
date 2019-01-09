using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Cedro.Data.Context;
using Cedro.Domain.Core.Entities;
using Cedro.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
namespace Cedro.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity<TEntity>
    {
        protected CedroContext _context;
        protected DbSet<TEntity> _dbSet;
        public Repository(CedroContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }
        public void Add(TEntity obj)
        {
            _dbSet.Add(obj);
        }
        public void Delete(Guid id)
        {
            _dbSet.Remove(_dbSet.Find(id));
        }
        public void Dispose()
        {
            _context.Dispose();
        }
        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }
        public TEntity GetById(Guid id)
        {
            return _dbSet.Find(id);
        }
        public int SaveChanges()
        {
           return _context.SaveChanges();
        }
        public IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }
        public void Update(TEntity obj)
        {
           _dbSet.Update(obj);
        }
    }
}