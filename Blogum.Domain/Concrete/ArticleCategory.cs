using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Abstract;

namespace Blogum.Domain.Concrete
{
    public class ArticleCategory : BaseEntity
    {
        public int? CategoryId { get; set; }
        public Category Category { get; set; }
        public int? ArticleId { get; set; }
        public Article Article { get; set; }
    }
}