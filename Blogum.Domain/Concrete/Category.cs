using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Abstract;

namespace Blogum.Domain.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }
    }
}
