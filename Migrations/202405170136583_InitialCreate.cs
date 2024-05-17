namespace SchedulingApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        AddressId = c.Int(nullable: false, identity: true),
                        Address1 = c.String(unicode: false),
                        Address2 = c.String(unicode: false),
                        CityId = c.Int(nullable: false),
                        PostalCode = c.String(unicode: false),
                        Phone = c.String(unicode: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreatedBy = c.String(unicode: false),
                        LastUpdate = c.DateTime(nullable: false, precision: 0),
                        LastUpdateBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.AddressId);
            
            CreateTable(
                "dbo.Appointments",
                c => new
                    {
                        AppointmentId = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Title = c.String(unicode: false),
                        Description = c.String(unicode: false),
                        Location = c.String(unicode: false),
                        Contact = c.String(unicode: false),
                        Type = c.String(unicode: false),
                        Url = c.String(unicode: false),
                        Start = c.DateTime(nullable: false, precision: 0),
                        End = c.DateTime(nullable: false, precision: 0),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreatedBy = c.String(unicode: false),
                        LastUpdate = c.DateTime(nullable: false, precision: 0),
                        LastUpdateBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.AppointmentId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(unicode: false),
                        CountryId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreatedBy = c.String(unicode: false),
                        LastUpdate = c.DateTime(nullable: false, precision: 0),
                        LastUpdateBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        CountryId = c.Int(nullable: false, identity: true),
                        CountryName = c.String(unicode: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreatedBy = c.String(unicode: false),
                        LastUpdate = c.DateTime(nullable: false, precision: 0),
                        LastUpdateBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CountryId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(unicode: false),
                        AddressId = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreatedBy = c.String(unicode: false),
                        LastUpdate = c.DateTime(nullable: false, precision: 0),
                        LastUpdateBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        Active = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false, precision: 0),
                        CreatedBy = c.String(unicode: false),
                        LastUpdate = c.DateTime(nullable: false, precision: 0),
                        LastUpdateBy = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Customers");
            DropTable("dbo.Countries");
            DropTable("dbo.Cities");
            DropTable("dbo.Appointments");
            DropTable("dbo.Addresses");
        }
    }
}
