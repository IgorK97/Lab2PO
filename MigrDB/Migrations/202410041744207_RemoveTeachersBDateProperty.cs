﻿namespace MigrDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveTeachersBDateProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "BDates", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "BDates");
        }
    }
}
