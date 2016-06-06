using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EShopHA.Models
{
    public enum Category
    {
        Alchohol, Hookah
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
    }
    public class ProductDBContext : DbContext
    {
        public DbSet<Product> products { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }
    }
}