using System;
using System.Collections.Generic;
using System.Text;
using Blogum.Core;

namespace Blogum.Domain.Abstract
{
    public class BaseEntity : IBaseEntity, IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public DateTime DeletedAt { get; set; }
    }
}
