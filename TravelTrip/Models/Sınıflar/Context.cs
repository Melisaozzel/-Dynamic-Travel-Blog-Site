using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace TravelTrip.Models.Sınıflar
{
    public class Context : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adress> Adresses { get; set; }
        public DbSet<Abt> Abts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comments> Commentss { get; set; }
        public DbSet<Contact> Contacts { get; set; }



    }
}