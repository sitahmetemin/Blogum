using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Abstract;

namespace Blogum.Domain.Concrete
{
    public class Like : BaseEntity
    {
        public int? UserId { get; set; }
        public User User { get; set; }

        public int? ArticleId { get; set; }
        public Article Article { get; set; }
    }
}
