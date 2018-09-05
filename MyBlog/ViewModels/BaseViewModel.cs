using MyBlog.Data;
using MyBlog.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog.ViewModels
{
    public class BaseViewModel
    {
        public string MetaDescription { get; set; }
        public string Title { get; set; }

        private List<TopMenuDto> _menuItem = new List<TopMenuDto>();
        private List<TopMenuDto> _socialItems = new List<TopMenuDto>();

        public List<TopMenuDto> MenuItems
        {
            get
            {
                return _menuItem = GetMenu(false);
            }
            set
            {
                _menuItem = value;
            }
        }
        public List<TopMenuDto> SocialItems
        {
            get
            {
                return _socialItems = GetMenu(true);
            }
            set
            {
                _socialItems = value;
            }
        }


        public List<TopMenuDto> GetMenu(bool social)
        {
            var menuList = new List<TopMenuDto>();
            if (social)
            {
                menuList = Extensions.DatabaseHelper.GetSocialLinksFromDatabase();
            }
            else
            {
                menuList = Extensions.DatabaseHelper.GetTopMenuPagesFromDatabase();
            }
            return menuList;
        }
    }



}