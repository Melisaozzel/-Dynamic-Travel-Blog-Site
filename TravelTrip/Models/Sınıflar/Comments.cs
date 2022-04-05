using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TravelTrip.Models.Sınıflar
{
    public class Comments
    {
        [Key]
        public int ID { get; set; }

        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Comment { get; set; }
        public int BLOGID { get; set; }
        
        public virtual Blog Blog { get; set; }

    }
}