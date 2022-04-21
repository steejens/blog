using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace blog.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsOnHomePage { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public List<Posts> Posts { get; set; }
    }
}
