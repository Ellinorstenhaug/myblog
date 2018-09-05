using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace MyBlog.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext() : base("DefaultConnection")
        {
            System.Data.Entity.Database.SetInitializer<ApplicationDbContext>(new Initializer());
        }


        public DbSet<Page> Pages { get; set; }
        public DbSet<SocialMedia> SocialMedia { get; set; }

        public DbSet<User> User { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }     
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}