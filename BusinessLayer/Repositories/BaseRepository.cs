using BusinessLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace BusinessLayer.Repositories
{
    public abstract class BaseRepository<TContext, TEntity> : ISelectableRepository<TEntity>, IUpdatableRepository<TEntity>, IInsertableRepository<TEntity> ,IDeletableRepository<TEntity> where TEntity : class where TContext : DbContext, new()
    {
        private readonly TContext _context;

        protected BaseRepository(TContext context)
        {
            _context = context;
        }

        public BaseRepository()
        {
            _context = new TContext();
        }

        public TEntity Add(TEntity item)
        {
            return _context.Set<TEntity>().Add(item);
        }

        public List<TEntity> AddRange(List<TEntity> items)
        {
            return _context.Set<TEntity>().AddRange(items).ToList();
        }

        public TEntity Delete(TEntity item)
        {
            return _context.Set<TEntity>().Remove(item);
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public TEntity GetByID(object ID)
        {
            return _context.Set<TEntity>().Find(ID);
        }

        public List<TEntity> GetAll(Func<TEntity, bool> whereCondition)
        {
            return _context.Set<TEntity>().Where(whereCondition).ToList();
        }

        public void MySaveChanges()
        {
         int a = _context.SaveChanges();
        }

        public void Update(TEntity item)
        {
            //_context.Entry(item).State = EntityState.Modified;
            //_context.Set<TEntity>().Attach(item);
            int a = _context.SaveChanges();
            
        }
    }
}
