namespace MigrDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKey : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.Teachers", "FamilyName", c => c.String());
            AddColumn("dbo.Teachers", "CathedrasId", c => c.Int());
            CreateIndex("dbo.Teachers", "CathedrasId");
            AddForeignKey("dbo.Teachers", "CathedrasId", "dbo.Cathedras", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "CathedrasId", "dbo.Cathedras");
            DropIndex("dbo.Teachers", new[] { "CathedrasId" });
            DropColumn("dbo.Teachers", "CathedrasId");
            //DropColumn("dbo.Teachers", "FamilyName");
        }
    }
}
