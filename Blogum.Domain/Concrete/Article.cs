using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Abstract;

namespace Blogum.Domain.Concrete
{
    public class Article: BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Cover { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<TagArticle> TagArticles { get; set; }
        public virtual ICollection<ArticleCategory> ArticleCategories { get; set; }
        public virtual ICollection<Like> Likes { get; set; }


    }
}
