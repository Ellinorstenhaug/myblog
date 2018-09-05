using MyBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.DtoModels
{
    public class PageDto : BaseViewModel
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Heading { get; set; }
        public string Description { get; set; }
        public string ImageOverlay { get; set; }
    }
}