using Blogum.Core.DataAccess.EntityFramework;
using Blogum.DataAccess.Abstract;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Concrete.EntityFramework
{
    public class CategoryDal : EfEntityRepositoryBase<Category, BlogumContext>, ICategoryDal
    {

    }
}
