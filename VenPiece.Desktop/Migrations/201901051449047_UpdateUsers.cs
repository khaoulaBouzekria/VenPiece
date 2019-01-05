namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateUsers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.InternalUserDatas", "Roles", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.InternalUserDatas", "Roles");
        }
    }
}
