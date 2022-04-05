using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Sınıflar
{
    public class Abt
    {
        [Key]
        public int ID { get; set; }
        public int PhotoUrl { get; set; }
        public string Conts { get; set; }

    }
}