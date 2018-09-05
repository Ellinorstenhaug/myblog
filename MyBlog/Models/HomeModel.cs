using MyBlog.Data;
using MyBlog.Models;
using MyBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Models
{
    //TODO Refactor? Move homemodel?
    public class HomeModel : BaseViewModel
    {
        public List<Categories> Categories { get; set; }
        public List<BlogPostViewModel> BlogPosts { get; set; }
        public List<Data.User> User { get; set; }
        public string PostedInCategory { get; set; }
    }

    //Move blogpostviewmodel?
    public class BlogPostViewModel
    {
        public int CategoryId { get; set; }
        public string PostedInCategory { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
    }



}