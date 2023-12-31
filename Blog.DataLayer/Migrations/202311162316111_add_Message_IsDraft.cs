﻿namespace Blog.DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_Message_IsDraft : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Messages", "IsDraft", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Messages", "IsDraft");
        }
    }
}
