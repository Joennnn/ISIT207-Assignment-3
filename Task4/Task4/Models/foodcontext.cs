using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Task4.Models
{
    public class foodcontext : DbContext
    {
        public foodcontext() : base("Task4")
        {
        }
        public DbSet<category> Categories { get; set; }
        public DbSet<food> Food { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}