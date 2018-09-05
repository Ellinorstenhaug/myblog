using Logger.Contracts;
using MyBlog.Data;
using MyBlog.DtoModels;
using MyBlog.Models;
using MyBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBlog.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ApplicationDbContext _context;
        // GET: /Home/
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public ActionResult Index()
        {
            var viewModel = SetUpViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Index(string url)
        {
            var findPage = _context.Pages.Find(url);
            if (findPage != null)
            {
                return View("standardpage", findPage);
            }

            return RedirectToAction("Index");
        }
        private HomeModel SetUpViewModel()
        {
            return new HomeModel
            {
                BlogPosts = GetBlogPosts(),
                User = _context.User.ToList(),
                Categories = _context.Categories.ToList(),
                MetaDescription = "Ellinors blogg handlar om mitt liv och min vardag som programmerare. Följ mitt äventyr idag!",
                Title = "Start",
            };
        }

        public ActionResult GetPage(int id)
        {

            var page = _context.Pages.Where(x => x.Id == id).FirstOrDefault();
            if (page != null && page.Url != "/")
            {
               var pageViewModel = MapPageToViewModel(page);
                return View("StandardPage", pageViewModel);
            }
            return RedirectToAction("Index");

        }

        private PageDto MapPageToViewModel(Page page)
        {
            var pageDto = new PageDto
            {
                Description = page.Description,
                Heading = page.Heading,
                ImageOverlay = page.ImageOverlay,
                MetaDescription = page.Description.Length > 30 ? page.Description.Substring(0, 30) : page.Description,
                Name = page.Name,
                Title = page.Name
            };

            return pageDto;
        }

        private List<BlogPostViewModel> GetBlogPosts()
        {
            var blogPostViewModel = new List<BlogPostViewModel>();

            var categories = _context.Categories.ToList();
            var databaseBlogPosts = _context.BlogPost.ToList();

            foreach (var post in databaseBlogPosts)
            {
                blogPostViewModel.Add(new BlogPostViewModel
                {
                    Created = post.Created,
                    Description = post.Name,
                    CategoryId = post.CategoryId,
                    PostedInCategory = categories.Where(x => x.Id == post.CategoryId).FirstOrDefault().Name,
                });
            }
            return blogPostViewModel;
        }
    }
}
