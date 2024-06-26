﻿namespace BookCircle.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBooks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BookTitle = c.String(),
                        BookDescription = c.String(),
                        BookAuthor = c.String(),
                        BookPublisher = c.String(),
                        BookRating = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
