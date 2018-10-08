using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Abstract;

namespace Blogum.Domain.Concrete
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Cover { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public virtual ICollection<Article> Articles { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }

        public virtual ICollection<Follow> Follows { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
        
    }
}
