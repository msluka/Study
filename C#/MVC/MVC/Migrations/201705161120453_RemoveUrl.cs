namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveUrl : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Student", "TestResults");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Student", "TestResults", c => c.String());
        }
    }
}
