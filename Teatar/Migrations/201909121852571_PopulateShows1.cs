namespace Teatar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateShows1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Shows (Title,PriceForTicket,Description,Duration,Rating,GenreId,ImgUrl) VALUES ('Ne se kladi na englezi','100','orem ipsum dolor sit amet, consectetur adipiscing elit. Mauris id posuere nibh, nec sodales turpis. Suspendisse euismod massa a dui dignissim, congue congue lectus luctus. Nam gravida tristique bibendum. Quisque eu turpis auctor est posuere fringilla quis ac nunc.','60', '5', '1', 'https://images.pexels.com/photos/853168/pexels-photo-853168.jpeg?auto=compress&cs=tinysrgb&dpr=1&w=500') ");
            Sql("INSERT INTO Shows (Title,PriceForTicket,Description,Duration,Rating,GenreId,ImgUrl) VALUES ('Familija Markovski','150','orem ipsum dolor sit amet, consectetur adipiscing elit. Mauris id posuere nibh, nec sodales turpis. Suspendisse euismod massa a dui dignissim, congue congue lectus luctus. Nam gravida tristique bibendum. Quisque eu turpis auctor est posuere fringilla quis ac nunc.','90', '3','2', 'https://media.gettyimages.com/photos/skyline-dallas-texas-america-picture-id623559564?s=612x612') ");
            Sql("INSERT INTO Shows (Title,PriceForTicket,Description,Duration,Rating,GenreId,ImgUrl) VALUES ('Bubamara','200','orem ipsum dolor sit amet, consectetur adipiscing elit. Mauris id posuere nibh, nec sodales turpis. Suspendisse euismod massa a dui dignissim, congue congue lectus luctus. Nam gravida tristique bibendum. Quisque eu turpis auctor est posuere fringilla quis ac nunc.','100', '5','3','https://ichef.bbci.co.uk/news/976/cpsprodpb/3F63/production/_107472261_hi054700193.jpg') ");
        }

        public override void Down()
        {
        }
    }
}
