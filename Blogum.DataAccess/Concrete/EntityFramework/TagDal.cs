using Blogum.Core.DataAccess.EntityFramework;
using Blogum.DataAccess.Abstract;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Concrete.EntityFramework
{
    public class TagDal : EfEntityRepositoryBase<Tag, BlogumContext>, ITagDal
    {

    }
}
