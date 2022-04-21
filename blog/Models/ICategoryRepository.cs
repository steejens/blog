using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace blog.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories { get; }
        
    }
}
