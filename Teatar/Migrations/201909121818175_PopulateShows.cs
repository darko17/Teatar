namespace Teatar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateShows : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Shows (Title,PriceForTicked,Desciption,Duration,Rating) VALUES ('Ne se kladi na englezi','100','orem ipsum dolor sit amet, consectetur adipiscing elit. Mauris id posuere nibh, nec sodales turpis. Suspendisse euismod massa a dui dignissim, congue congue lectus luctus. Nam gravida tristique bibendum. Quisque eu turpis auctor est posuere fringilla quis ac nunc.','60', '5') ");
            Sql("INSERT INTO Shows (Title,PriceForTicked,Desciption,Duration,Rating) VALUES ('Familija Markovski','150','orem ipsum dolor sit amet, consectetur adipiscing elit. Mauris id posuere nibh, nec sodales turpis. Suspendisse euismod massa a dui dignissim, congue congue lectus luctus. Nam gravida tristique bibendum. Quisque eu turpis auctor est posuere fringilla quis ac nunc.','90', '3') ");
            Sql("INSERT INTO Shows (Title,PriceForTicked,Desciption,Duration,Rating) VALUES ('Bubamara','200','orem ipsum dolor sit amet, consectetur adipiscing elit. Mauris id posuere nibh, nec sodales turpis. Suspendisse euismod massa a dui dignissim, congue congue lectus luctus. Nam gravida tristique bibendum. Quisque eu turpis auctor est posuere fringilla quis ac nunc.','100', '5') ");
        }
        
        public override void Down()
        {
        }
    }
}
