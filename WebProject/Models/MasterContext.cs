using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class MasterContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ProductsDelivered> ProductsDelivered { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetails> OrdersDetails { get; set; }
        public MasterContext()
            : base("DefaultConnection")
        {
        }

        public static MasterContext Create()
        {
            return new MasterContext();
        }
    }
}