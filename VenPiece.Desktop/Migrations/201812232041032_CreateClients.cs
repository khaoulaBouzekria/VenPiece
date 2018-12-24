namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateClients : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Guid(nullable: false),
                        Name = c.String(),
                        Address = c.String(),
                        Type = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
