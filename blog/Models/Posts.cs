using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Channels;

namespace blog.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Text { get; set; }
        public string ImageUrl { get; set; }
        public bool IsActive { get; set; }
        public string Author { get; set; }
        public DateTime Created { get; set; }

        [ForeignKey(nameof(Category))]
        public int CatId { get; set; }
        public Category Category { get; set; }
    }
}
