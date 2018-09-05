using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Data
{
    public class Page
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public string ImageOverlay { get; set; }
    }
}