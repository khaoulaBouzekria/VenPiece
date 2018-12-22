namespace DAL.VenPiece.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrder : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Guid(nullable: false),
                        ArrivingDate = c.DateTime(nullable: false),
                        state = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
