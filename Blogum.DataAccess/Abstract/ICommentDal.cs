using Blogum.Core.DataAccess;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Abstract
{
    public interface ICommentDal : IEntityRepository<Comment>
    {
        //Custom Operations
    }
}
