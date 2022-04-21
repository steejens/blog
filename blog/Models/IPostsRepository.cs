using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace blog.Models
{
    public interface IPostsRepository
    {
        IEnumerable<Posts> GetAllPosts { get; }
        IEnumerable<Posts> GetActivePosts { get; }
        Posts GetPostById(int PostId);

    }
}
