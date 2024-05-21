namespace CoureWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Account",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        IsLoged = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Wallet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity:true),
                        Balance = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Cart",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AccountId = c.Int(nullable: false),
                        ProductId = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                        PurchaseDate = c.DateTime(nullable: false),
                        ProductPrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantity = c.Int(nullable: false),
                        ProductType = c.String(),
                        ProductName = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Account", t => t.AccountId, cascadeDelete: true)
                .Index(t => t.AccountId);
            
            CreateTable(
                "dbo.Category",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Laptop",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Stock = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Smartphone",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Stock = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Smartwatch",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Stock = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.TV",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                        Stock = c.Int(nullable: false),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Category", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TV", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Smartwatch", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Smartphone", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Laptop", "CategoryId", "dbo.Category");
            DropForeignKey("dbo.Cart", "AccountId", "dbo.Account");
            DropForeignKey("dbo.Wallet", "Id", "dbo.Account");
            DropIndex("dbo.TV", new[] { "CategoryId" });
            DropIndex("dbo.Smartwatch", new[] { "CategoryId" });
            DropIndex("dbo.Smartphone", new[] { "CategoryId" });
            DropIndex("dbo.Laptop", new[] { "CategoryId" });
            DropIndex("dbo.Cart", new[] { "AccountId" });
            DropIndex("dbo.Wallet", new[] { "Id" });
            DropTable("dbo.TV");
            DropTable("dbo.Smartwatch");
            DropTable("dbo.Smartphone");
            DropTable("dbo.Laptop");
            DropTable("dbo.Category");
            DropTable("dbo.Cart");
            DropTable("dbo.Wallet");
            DropTable("dbo.Account");
        }
    }
}
