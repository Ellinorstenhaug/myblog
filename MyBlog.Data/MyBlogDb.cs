using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data
{
    public class MyBlogDb : DbContext
    {
        public MyBlogDb() : base("defaultConnectionString")
        {
            
        }
    }
}
