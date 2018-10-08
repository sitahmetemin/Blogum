using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Domain.Abstract;

namespace Blogum.Domain.Concrete
{
    public class Follow : BaseEntity
    {
        public int? UserId { get; set; }
        public User User { get; set; }

        public int? FollowId { get; set; }
        public User Follower { get; set; }
    }
}
