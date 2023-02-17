using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace api.Models
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("product")
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}