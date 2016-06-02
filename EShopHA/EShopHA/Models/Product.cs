using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EShopHA.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Category Category { get; set; }
    }
    public class ProductDBContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}