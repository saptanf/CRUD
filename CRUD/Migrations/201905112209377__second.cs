namespace CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class __second : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Client", "Gender", c => c.String(nullable: false, maxLength: 10));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Client", "Gender", c => c.String(maxLength: 10));
        }
    }
}
