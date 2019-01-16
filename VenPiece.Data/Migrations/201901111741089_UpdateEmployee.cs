namespace VenPiece.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployee : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Employees", "PersonId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "PersonId", c => c.Guid(nullable: false));
        }
    }
}
