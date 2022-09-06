namespace BookCircle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedContactName : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "ContactName", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "ContactName");
        }
    }
}
