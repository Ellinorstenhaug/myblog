using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyBlog.Data
{
    public class Initializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {

        protected override void Seed(ApplicationDbContext context)
        {
            var users = new List<User>
            {
            new User{Id = 0,Password = "123", FirstMidName="Carson",LastName="Alexander",Email="test@mail.com",CreatedDate=DateTime.Parse("2005-09-01")},
            new User{Id = 1,Password = "123", FirstMidName="Meredith",LastName="Alonso",Email="test2@mail.com",CreatedDate=DateTime.Parse("2002-09-01")},
            new User{Id = 2, Password = "123",FirstMidName="Arturo",LastName="Anand",Email="test3@mail.com",CreatedDate=DateTime.Parse("2003-09-01")},
            new User{Id = 3,Password = "123", FirstMidName="Gytis",LastName="Barzdukas",Email="test@4mail.com",CreatedDate=DateTime.Parse("2002-09-01")},
            new User{Id = 4,Password = "123", FirstMidName="Yan",LastName="Li",Email="test5@mail.com",CreatedDate=DateTime.Parse("2002-09-01")},
            new User{Id = 5,Password = "123", FirstMidName="Peggy",LastName="Justice",Email="test6@mail.com",CreatedDate=DateTime.Parse("2001-09-01")},
            new User{Id = 6,Password = "123", FirstMidName="Laura",LastName="Norman",Email="test7@mail.com",CreatedDate=DateTime.Parse("2003-09-01")},
            new User{Id = 7,Password = "123", FirstMidName="Nino",LastName="Olivetto",Email="test8@mail.com",CreatedDate=DateTime.Parse("2005-09-01")}
            };

            users.ForEach(s => context.User.Add(s));


            var categories = new List<Categories>
            {
               new Categories {Id = 1,Name = "Programmering" },
                new Categories {Id = 2,Name = "Allmänt" },
                 new Categories {Id = 3,Name = "Mode", }

            };

            categories.ForEach(x => context.Categories.Add(x));

            var blogPosts = new List<BlogPost>
            {
            new BlogPost{Name="Chemistry",Created=DateTime.Now, UserId = 0 ,CategoryId = 3},
            new BlogPost{Name="Microeconomics",Created=DateTime.Now, UserId = 0,CategoryId = 1},
            new BlogPost{Name="Macroeconomics",Created=DateTime.Now, UserId = 1,CategoryId = 3},
            new BlogPost{Name="Calculus",Created=DateTime.Now, UserId = 3,CategoryId = 2},
            new BlogPost{Name="Trött måndag",Created=DateTime.Now, UserId = 1,CategoryId = 2},
            new BlogPost{Name="Shopping for fun",Created=DateTime.Now, UserId = 3,CategoryId = 3},
            new BlogPost{Name="React JS",Created=DateTime.Now, UserId = 4,CategoryId = 1,}
            };
            blogPosts.ForEach(s => context.BlogPost.Add(s));

            var pages = new List<Page>
            {
                new Page
                {
                    Name = "Home",
                    Url = "/",
                    Heading = "Hem, 'där jag hör hemma'",
                    ImageOverlay = "https://i.ytimg.com/vi/t_t3h52Nx18/maxresdefault.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Integer imperdiet lectus quis justo. Aliquam erat volutpat. In dapibus augue non sapien. Nullam lectus justo, vulputate eget mollis sed, tempor sed magna. Nam quis nulla. Aenean id metus id velit ullamcorper pulvinar. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui",

                },
                new Page
                {
                    Name = "About",
                    Url = "/about",
                   Heading = "Om mig, elkynorky",
                    ImageOverlay = "https://i.ytimg.com/vi/t_t3h52Nx18/maxresdefault.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Integer imperdiet lectus quis justo. Aliquam erat volutpat. In dapibus augue non sapien. Nullam lectus justo, vulputate eget mollis sed, tempor sed magna. Nam quis nulla. Aenean id metus id velit ullamcorper pulvinar. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui",

                },
                  new Page
                {
                    Name = "Categories",
                    Url = "/categories",
                     Heading = "Kategorier, här finner du allt och inget",
                    ImageOverlay = "https://i.ytimg.com/vi/t_t3h52Nx18/maxresdefault.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Integer imperdiet lectus quis justo. Aliquam erat volutpat. In dapibus augue non sapien. Nullam lectus justo, vulputate eget mollis sed, tempor sed magna. Nam quis nulla. Aenean id metus id velit ullamcorper pulvinar. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui",

                },
                    new Page
                {
                    Name = "Archive",
                    Url = "/archive",
                     Heading = "Archive, Läs mer om mig och min blogg",
                    ImageOverlay = "https://i.ytimg.com/vi/t_t3h52Nx18/maxresdefault.jpg",
                    Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Integer imperdiet lectus quis justo. Aliquam erat volutpat. In dapibus augue non sapien. Nullam lectus justo, vulputate eget mollis sed, tempor sed magna. Nam quis nulla. Aenean id metus id velit ullamcorper pulvinar. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui",

                },
            };

            pages.ForEach(x => context.Pages.Add(x));
            var socialLinks = new List<SocialMedia>
            {
                new SocialMedia
                {
                    Logo = "http://www.free-icons-download.net/images/facebook-logo-icon-72283.png",
                    Url = "https://www.facebook.com/ellinorstenhaug"
                },
                 new SocialMedia
                {
                    Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS-BU8a9XXDVyPJmbbuErp-R3HdZcwFkLKH668Z3DnQvZ-gDFjH",
                    Url = "https://www.instagram.com/ellinorstenhaug/"
                },
                   new SocialMedia
                {
                    Logo = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS-BU8a9XXDVyPJmbbuErp-R3HdZcwFkLKH668Z3DnQvZ-gDFjH",
                    Url = "https://twitter.com/peterkellner1"
                },

            };
            socialLinks.ForEach(x => context.SocialMedia.Add(x));
            context.SaveChanges();
        }
    }
}