using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace TravelTrip.Models.Sınıflar
{
    public class HomePage
    {
        [Key]
        public int ID { get; set; }
        public string  Title  { get; set; }
        public string Comment { get; set; }
    }
}