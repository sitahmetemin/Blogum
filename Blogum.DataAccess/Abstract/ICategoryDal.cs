using Blogum.Core.DataAccess;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
        //Custom Operations
    }
}
