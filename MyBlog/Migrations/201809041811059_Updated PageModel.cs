namespace MyBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdatedPageModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Page", "Heading", c => c.String());
            AddColumn("dbo.Page", "Description", c => c.String());
            AddColumn("dbo.Page", "ImageOverlay", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Page", "ImageOverlay");
            DropColumn("dbo.Page", "Description");
            DropColumn("dbo.Page", "Heading");
        }
    }
}
