using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.DbModels
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<BlogPost> Posts { get; set; }
    }
    public class BlogPost
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<Categories> Categories { get; set; }
        public virtual ICollection<Comments> Comments { get; set; }
    }

    public class Comments
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public virtual BlogPost Post { get; set; }
    }
    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
