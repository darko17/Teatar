using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Teatar.Models
{
    public class Hall
    {
        [Key]
        public int HallId { get; set; }
        public string Name { get; set; }
        public int NumOfSeats { get; set; }
        public int NumOfAvailableSeats { get; set; }
    }
}