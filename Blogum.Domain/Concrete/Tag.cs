using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Abstract;

namespace Blogum.Domain.Concrete
{
    public class Tag : BaseEntity
    {
        public string Name { get; set; }

        public virtual ICollection<TagArticle> TagArticles { get; set; }
    }
}
