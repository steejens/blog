using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

using System.Collections.Generic;

namespace blog.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> GetAllCategories
        {
            get
            {
                return _appDbContext.Category;
            }
        }
    }
}
