namespace MVC.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Validation : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "StudentName", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "StudentName", c => c.String());
        }
    }
}
