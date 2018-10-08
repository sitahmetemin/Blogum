using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Blogum.Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
        where TEntity : class, IEntity, new()
        where TContext : DbContext, new()
    {
        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            var context = new TContext();
            return context.Set<TEntity>().FirstOrDefault(filter);
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            var context = new TContext();
            return filter == null
                ? context.Set<TEntity>().ToList()
                : context.Set<TEntity>().Where(filter).ToList();
        }

        public List<TEntity> GetRandomList()
        {
            throw new NotImplementedException();
        }

        public void Create(TEntity EntityDto)
        {
            using (var context = new TContext())
            {
                var added = context.Entry(EntityDto);
                added.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Update(TEntity EntityDto)
        {
            using (var context = new TContext())
            {
                var updated = context.Entry(EntityDto);
                updated.State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(TEntity EntityDto)
        {
            using (var context = new TContext())
            {
                var deleted = context.Entry(EntityDto);
                deleted.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public void SoftDelete(TEntity EntityDto)
        {
            throw new NotImplementedException();
        }
    }
}