using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Data.DbModels
{
    public class DbLayout
    {
        public int Id { get; set; }
        public SocialMenu Menu { get; set; }
    }

    public class SocialMenu
    {
        public int Id { get; set; }
        public int Name { get; set; }
    }
}
