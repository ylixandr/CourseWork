namespace CoureWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Delete_Quantity : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Cart", "Quantity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cart", "Quantity", c => c.Int(nullable: false));
        }
    }
}
