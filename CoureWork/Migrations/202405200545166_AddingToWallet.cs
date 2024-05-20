namespace CoureWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingToWallet : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Wallet", "AccountId", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Wallet", "AccountId");
        }
    }
}
