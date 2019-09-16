namespace Teatar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeToModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.TimeTables",
                c => new
                    {
                        TimeId = c.Int(nullable: false, identity: true),
                        HallId = c.Int(nullable: false),
                        ShowId = c.Int(nullable: false),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TimeId)
                .ForeignKey("dbo.Halls", t => t.HallId, cascadeDelete: true)
                .ForeignKey("dbo.Shows", t => t.ShowId, cascadeDelete: true)
                .Index(t => t.HallId)
                .Index(t => t.ShowId);
            
            AddColumn("dbo.Reservations", "NumOfTickets", c => c.Int(nullable: false));
            AddColumn("dbo.Reservations", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddColumn("dbo.Reservations", "TimeTable_TimeId", c => c.Int());
            AddColumn("dbo.Shows", "GenreId", c => c.Int(nullable: false));
            AddColumn("dbo.Shows", "ImgUrl", c => c.String());
            CreateIndex("dbo.Shows", "GenreId");
            CreateIndex("dbo.Reservations", "ApplicationUser_Id");
            CreateIndex("dbo.Reservations", "TimeTable_TimeId");
            AddForeignKey("dbo.Shows", "GenreId", "dbo.Genres", "GenreId", cascadeDelete: true);
            AddForeignKey("dbo.Reservations", "ApplicationUser_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.Reservations", "TimeTable_TimeId", "dbo.TimeTables", "TimeId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "TimeTable_TimeId", "dbo.TimeTables");
            DropForeignKey("dbo.Reservations", "ApplicationUser_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.TimeTables", "ShowId", "dbo.Shows");
            DropForeignKey("dbo.TimeTables", "HallId", "dbo.Halls");
            DropForeignKey("dbo.Shows", "GenreId", "dbo.Genres");
            DropIndex("dbo.Reservations", new[] { "TimeTable_TimeId" });
            DropIndex("dbo.Reservations", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.TimeTables", new[] { "ShowId" });
            DropIndex("dbo.TimeTables", new[] { "HallId" });
            DropIndex("dbo.Shows", new[] { "GenreId" });
            DropColumn("dbo.Shows", "ImgUrl");
            DropColumn("dbo.Shows", "GenreId");
            DropColumn("dbo.Reservations", "TimeTable_TimeId");
            DropColumn("dbo.Reservations", "ApplicationUser_Id");
            DropColumn("dbo.Reservations", "NumOfTickets");
            DropTable("dbo.TimeTables");
        }
    }
}
