﻿namespace MigrDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTeachersPhoneProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers","Phone",c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "Phone");
        }
    }
}
