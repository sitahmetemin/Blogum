using Blogum.Core.DataAccess.EntityFramework;
using Blogum.DataAccess.Abstract;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Concrete.EntityFramework
{
    public class ArticleDal : EfEntityRepositoryBase<Article, BlogumContext>, IArticleDal
    {

    }
}
