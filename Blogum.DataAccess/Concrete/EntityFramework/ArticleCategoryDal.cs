﻿using Blogum.Core.DataAccess.EntityFramework;
using Blogum.DataAccess.Abstract;
using Blogum.Domain.Concrete;

namespace Blogum.DataAccess.Concrete.EntityFramework
{
    public class ArticleCategoryDal : EfEntityRepositoryBase<ArticleCategory, BlogumContext>, IArticleCategoryDal
    {

    }
}
