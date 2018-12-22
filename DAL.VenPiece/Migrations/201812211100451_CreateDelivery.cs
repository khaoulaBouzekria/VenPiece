namespace DAL.VenPiece.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDelivery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        DeliveryId = c.Guid(nullable: false),
                        DateDelivery = c.DateTime(nullable: false),
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
