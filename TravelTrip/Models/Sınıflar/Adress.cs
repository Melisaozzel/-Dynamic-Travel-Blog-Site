using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Sınıflar
{
    public class Adress
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public string Address { get; set; }
        public string Mail { get; set; }
        public string Tel { get; set; }
        public string Location { get; set; }

    }
}