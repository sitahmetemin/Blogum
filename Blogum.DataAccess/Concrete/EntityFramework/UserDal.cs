using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Core.DataAccess.EntityFramework;
using Blogum.DataAccess.Abstract;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Concrete.EntityFramework
{
    public class UserDal : EfEntityRepositoryBase<User, BlogumContext>, IUserDal
    {

    }
}
