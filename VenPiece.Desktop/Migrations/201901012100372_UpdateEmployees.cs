namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateEmployees : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Gender", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Sexe");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "Sexe", c => c.Int(nullable: false));
            DropColumn("dbo.Employees", "Gender");
        }
    }
}
