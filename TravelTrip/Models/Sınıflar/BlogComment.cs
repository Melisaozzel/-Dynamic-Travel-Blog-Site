using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Sınıflar
{
    public class BlogComment
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
        public IEnumerable<Comments> Deger2 { get; set; }
    }
}