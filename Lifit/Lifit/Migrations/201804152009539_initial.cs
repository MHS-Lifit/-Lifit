namespace Lifit.DAL.Migration
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Article",
                c => new
                    {
                        ArticleId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ArticleId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PictureUrl = c.String(),
                        Role = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            CreateTable(
                "dbo.Recip",
                c => new
                    {
                        RecipId = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        Name = c.String(),
                        PictureUrl = c.String(),
                        Text = c.String(),
                        Visits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RecipId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Recip", "UserId", "dbo.User");
            DropForeignKey("dbo.Article", "UserId", "dbo.User");
            DropIndex("dbo.Recip", new[] { "UserId" });
            DropIndex("dbo.Article", new[] { "UserId" });
            DropTable("dbo.Recip");
            DropTable("dbo.User");
            DropTable("dbo.Article");
        }
    }
}
