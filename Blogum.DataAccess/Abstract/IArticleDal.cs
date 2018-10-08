using Blogum.Core.DataAccess;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Abstract
{
    public interface IArticleDal : IEntityRepository<Article>
    {
        //Custom Operations
    }
}
