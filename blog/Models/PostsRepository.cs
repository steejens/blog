using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace blog.Models
{
    public class PostsRepository : IPostsRepository
    {
        private readonly AppDbContext _appDbContext;

        public PostsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Posts> GetAllPosts
        {
            get
            {
                return _appDbContext.Posts.Include(c => c.Category);
            }
        }

        public IEnumerable<Posts> GetActivePosts
        {
            get { 
                return _appDbContext.Posts.Include(c => c.Category).Where(p => p.IsActive); 
            }
        }

        public Posts GetPostById(int PostId)
        {
            return _appDbContext.Posts.FirstOrDefault(i => i.Id == PostId);
        }
    }
}
