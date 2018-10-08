using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Abstract;

namespace Blogum.Domain.Concrete
{
    public class TagArticle : BaseEntity
    {
        public int? ArticleId { get; set; }
        public Article Article { get; set; }
        public int? TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
