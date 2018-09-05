using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MyBlog.Data
{
    public class User
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<BlogPost> Enrollments { get; set; }
    }

    public class BlogPost
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
      
        public User User { get; set; }
        public virtual int UserId { get; set; }
        public virtual int CategoryId { get; set; }
    }
}