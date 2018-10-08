using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Core.DataAccess;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        //Custom Operations
    }
}
