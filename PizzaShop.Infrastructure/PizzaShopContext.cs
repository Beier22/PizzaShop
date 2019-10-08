using Microsoft.EntityFrameworkCore;
using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Infrastructure
{
    public class PizzaShopContext : DbContext
    {
        public PizzaShopContext(DbContextOptions<PizzaShopContext> opt) : base(opt) { }

        public DbSet<FastFood> FastFoods { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Drink> Drinks { get; set; }
    }
}
