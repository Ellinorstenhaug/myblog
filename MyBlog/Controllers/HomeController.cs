using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        
        public ActionResult Index()
        {
            var user = new User()
            {
                Name = "elky"
            };
            return View(user);
        }

    }
}
