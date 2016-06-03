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
        public string ImageUrl { get; set; }
        public string CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
    public class ProductDBContext1 : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> products { get; set; }
    }
}