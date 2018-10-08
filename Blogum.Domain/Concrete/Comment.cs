using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Abstract;

namespace Blogum.Domain.Concrete
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }

        public int? ParentID { get; set; }
        public Comment Comments { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public int? ArticleId { get; set; }
        public Article Article { get; set; }

    }
}
