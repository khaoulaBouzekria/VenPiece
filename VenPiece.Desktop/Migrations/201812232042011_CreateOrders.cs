namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateOrders : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        OrderId = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.OrderId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Orders");
        }
    }
}
