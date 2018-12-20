namespace DAL.VenPiece.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateClient : DbMigration
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
                        State = c.String(),
                    })
                .PrimaryKey(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Clients");
        }
    }
}
