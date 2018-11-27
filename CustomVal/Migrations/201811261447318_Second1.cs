namespace CustomVal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Second1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EmployeeMsts", "Name", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EmployeeMsts", "Name", c => c.String(nullable: false));
        }
    }
}
