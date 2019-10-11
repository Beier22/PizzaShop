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
        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderPizza> OrderPizzas { get; set; }
        public DbSet<OrderFastfood> OrderFastfoods { get; set; }
        public DbSet<OrderDrink> OrderDrinks { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderPizza>().HasKey(op => new { op.OrderId, op.PizzaId });

            modelBuilder.Entity<OrderPizza>().HasOne(op => op.Order).WithMany(o => o.OrderPizzas).HasForeignKey(op => op.OrderId);

            modelBuilder.Entity<OrderPizza>().HasOne(op => op.Pizza).WithMany(p => p.OrderPizzas).HasForeignKey(op => op.PizzaId);


            modelBuilder.Entity<OrderFastfood>().HasKey(of => new { of.OrderId, of.FastfoodId });

            modelBuilder.Entity<OrderFastfood>().HasOne(of => of.Order).WithMany(o => o.OrderFastfoods).HasForeignKey(of => of.OrderId);

            modelBuilder.Entity<OrderFastfood>().HasOne(of => of.Fastfood).WithMany(f => f.OrderFastfoods).HasForeignKey(of => of.FastfoodId);


            modelBuilder.Entity<OrderDrink>().HasKey(od => new { od.OrderId, od.DrinkId });

            modelBuilder.Entity<OrderDrink>().HasOne(od => od.Order).WithMany(o => o.OrderDrinks).HasForeignKey(od => od.OrderId);

            modelBuilder.Entity<OrderDrink>().HasOne(od => od.Drink).WithMany(d => d.OrderDrinks).HasForeignKey(od => od.DrinkId);

        }
    }
}
