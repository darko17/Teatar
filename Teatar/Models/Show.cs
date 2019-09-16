using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teatar.Models
{
    public class Show
    {
        [Key]
        public int ShowId { get; set; }
        public string Title { get; set; }
        public int PriceForTicket { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public double Rating { get; set; }
        public int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual List<TimeTable> TimeTables { get; set; }
        public string ImgUrl { get; set; }
        public Show()
        {
            TimeTables = new List<TimeTable>();
        }
    }
}