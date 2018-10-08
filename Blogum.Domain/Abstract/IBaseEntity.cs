using System;
using System.Collections.Generic;
using System.Text;

namespace Blogum.Domain.Abstract
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
        DateTime UpdatedAt { get; set; }
        DateTime DeletedAt { get; set; }
    }
}
