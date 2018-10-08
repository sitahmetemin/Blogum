using Blogum.Core.DataAccess;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Abstract
{
    public interface IArticleCategoryDal : IEntityRepository<ArticleCategory>
    {
        //Custom Operations
    }
}
