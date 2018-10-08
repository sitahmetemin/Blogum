using Blogum.Core.DataAccess;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Abstract
{
    public interface ITagArticleDal : IEntityRepository<TagArticle>
    {
        //Custom Operations
    }
}
