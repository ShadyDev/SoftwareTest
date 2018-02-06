using SoftwareTest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SoftwareTest.Contexts
{
    public class AppContext : DbContext
    {
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Courier> Couriers { get; set; }
    }
}