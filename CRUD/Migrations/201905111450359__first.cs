namespace CRUD.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class __first : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Client", "PlaceOfBirth", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Client", "PlaceOfBirth");
        }
    }
}
