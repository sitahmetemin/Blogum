using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Blogum.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        List<T> GetRandomList();
        void Create(T EntityDto);
        void Update(T EntityDto);
        void Delete(T EntityDto);
        void SoftDelete(T EntityDto);
    }
}