namespace VenPiece.Desktop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDeliveries : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        DeliveryId = c.Guid(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Weight = c.Int(nullable: false),
                        NumberOfPackages = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DeliveryId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Deliveries");
        }
    }
}
