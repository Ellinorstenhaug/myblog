﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Logger.Contracts;

namespace MyBlog.Controllers
{

    [Authorize(Roles = "User")]
    public class UserController : BaseController
    {
       
        public UserController()
        {
        }

        //
        // GET: /User/


        public ActionResult Index()
        {
            
            return View();
        }

    }
}
