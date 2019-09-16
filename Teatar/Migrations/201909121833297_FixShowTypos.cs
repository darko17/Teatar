namespace Teatar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixShowTypos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Shows", "PriceForTicket", c => c.Int(nullable: false));
            AddColumn("dbo.Shows", "Description", c => c.String());
            DropColumn("dbo.Shows", "PriceForTicked");
            DropColumn("dbo.Shows", "Desciption");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Shows", "Desciption", c => c.String());
            AddColumn("dbo.Shows", "PriceForTicked", c => c.Int(nullable: false));
            DropColumn("dbo.Shows", "Description");
            DropColumn("dbo.Shows", "PriceForTicket");
        }
    }
}
