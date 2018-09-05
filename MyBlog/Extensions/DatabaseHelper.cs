using MyBlog.Data;
using MyBlog.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.Extensions
{
    public static class DatabaseHelper
    {
        public static List<TopMenuDto> GetSocialLinksFromDatabase()
        {
            var socialLinks = new List<SocialMedia>();
            using (var context = new ApplicationDbContext())
            {
                socialLinks = context.SocialMedia.ToList();
            }
            var mappedLinks = new List<TopMenuDto>();
            foreach (var item in socialLinks)
            {
                mappedLinks.Add(new TopMenuDto
                {
                    Link = item.Url,
                    Name = item.Logo,
                });
            }
            return mappedLinks;
        }
        public static List<TopMenuDto> GetTopMenuPagesFromDatabase()
        {
            var pages = new List<Page>();
            using (var context = new ApplicationDbContext())
            {
                pages = context.Pages.ToList();
            }
            var mappedLinks = new List<TopMenuDto>();
            foreach (var item in pages)
            {
                mappedLinks.Add(new TopMenuDto
                {
                    Link = item.Url,
                    Name = item.Name,
                    Id = item.Id
                });
            }
            return mappedLinks;
        }


    }
}