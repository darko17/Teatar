namespace Teatar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedControllers : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "ApplicatinUserId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "ApplicatinUserId");
        }
    }
}
