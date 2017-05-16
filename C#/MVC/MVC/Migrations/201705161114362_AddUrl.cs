namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUrl : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Student", "TestResults", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Student", "TestResults");
        }
    }
}
