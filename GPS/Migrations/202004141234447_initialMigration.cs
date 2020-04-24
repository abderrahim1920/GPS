namespace GPS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Login = c.String(unicode: false),
                        PhoneNumber = c.String(unicode: false),
                        Name = c.String(unicode: false),
                        City = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.ClientId);

            CreateTable(
                "dbo.Payments",
                c => new
                {
                    PaiementId = c.Int(nullable: false, identity: true),
                    PaiementDate = c.DateTime(nullable: false, precision: 0),
                    Payee = c.Boolean(nullable: false),
                    TraceId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.PaiementId)
                .ForeignKey("dbo.Traces", t => t.TraceId, cascadeDelete: true);
            // .Index(t => t.TraceId);

            CreateTable(
                "dbo.Traces",
                c => new
                {
                    TraceId = c.Int(nullable: false, identity: true),
                    Number = c.String(unicode: false),
                    Name = c.String(unicode: false),
                    IMEI = c.String(unicode: false),
                    CreationDate = c.DateTime(nullable: false, precision: 0),
                    RenewDate = c.DateTime(nullable: false, precision: 0),
                    ClientId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TraceId)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true);
               // .Index(t => t.ClientId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Payments", "TraceId", "dbo.Traces");
            DropForeignKey("dbo.Traces", "ClientId", "dbo.Clients");
            DropIndex("dbo.Traces", new[] { "ClientId" });
            DropIndex("dbo.Payments", new[] { "TraceId" });
            DropTable("dbo.Traces");
            DropTable("dbo.Payments");
            DropTable("dbo.Clients");
        }
    }
}
