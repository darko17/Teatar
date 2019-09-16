namespace Teatar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateHalls : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Halls (Name,NumOfSeats,NumOfAvailableSeats) VALUES ('Hall 1', '50', '50')");
            Sql("INSERT INTO Halls (Name,NumOfSeats,NumOfAvailableSeats) VALUES ('Hall 2', '50', '50')");
            Sql("INSERT INTO Halls (Name,NumOfSeats,NumOfAvailableSeats) VALUES ('Hall 3', '50', '50')");
        }
        
        public override void Down()
        {
        }
    }
}
