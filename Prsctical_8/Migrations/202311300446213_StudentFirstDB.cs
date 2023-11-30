namespace Prsctical_8.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class StudentFirstDB : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Students", "Name", c => c.String());
            AlterColumn("dbo.Students", "Sex", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Sex", c => c.String(nullable: false));
            AlterColumn("dbo.Students", "Name", c => c.String(nullable: false));
        }
    }
}
