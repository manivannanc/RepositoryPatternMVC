namespace TestDotNetWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        OrderIndex = c.Int(nullable: false),
                        ParentID = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.ParentID)
                .Index(t => t.ParentID);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sku = c.String(),
                        Title = c.String(),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        ThumbnailUrl = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CategoryProduct",
                c => new
                    {
                        CategoryID = c.Int(nullable: false),
                        ProductID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CategoryID, t.ProductID })
                .ForeignKey("dbo.Category", t => t.CategoryID, cascadeDelete: true)
                .ForeignKey("dbo.Product", t => t.ProductID, cascadeDelete: true)
                .Index(t => t.CategoryID)
                .Index(t => t.ProductID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Category", "ParentID", "dbo.Category");
            DropForeignKey("dbo.CategoryProduct", "ProductID", "dbo.Product");
            DropForeignKey("dbo.CategoryProduct", "CategoryID", "dbo.Category");
            DropIndex("dbo.CategoryProduct", new[] { "ProductID" });
            DropIndex("dbo.CategoryProduct", new[] { "CategoryID" });
            DropIndex("dbo.Category", new[] { "ParentID" });
            DropTable("dbo.CategoryProduct");
            DropTable("dbo.Product");
            DropTable("dbo.Category");
        }
    }
}
