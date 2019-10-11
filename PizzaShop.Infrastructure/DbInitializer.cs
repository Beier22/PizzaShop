using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Infrastructure
{
    public static class DbInitializer
    {
        public static void Seed(PizzaShopContext ctx)
        {
            List<Pizza> pizzas = new List<Pizza>();
            List<FastFood> fastfoods = new List<FastFood>();
            List<Drink> drinks = new List<Drink>();

            Pizza p1 = new Pizza
            {
                Name = "Pepperoni",
                NormalPrice = 69.99,
                FamilyPrice = 99.99,
                Toppings = "Cheese and pepperoni"
            };

            Pizza p2 = new Pizza
            {
                Name = "Margherita",
                NormalPrice = 49.99,
                FamilyPrice = 79.99,
                Toppings = "Cheese"
            };

            FastFood f1 = new FastFood
            {
                Name = "Fries",
                SmallPrice = 29.99,
                LargePrice = 39.99
            };

            FastFood f2 = new FastFood
            {
                Name = "Cheese Burger",
                SmallPrice = 39.99,
                LargePrice = 59.99
            };

            Drink d1 = new Drink
            {
                Name = "Coca Cola",
                Price = 19.99


            };

            Drink d2 = new Drink
            {
                Name = "Sprite",
                Price = 19.99
            };

            /*OrderPizza op1 = new OrderPizza
            {
                PizzaId = 1
            };

            Order o1 = new Order
            {
                Name = "Joe",
                Email = "Mail",
                PhoneNumber = 1234567,
                Address = "Earth",
                Message = "This is dog",
                OrderPizzas = 
                {
                    op1
                    
                }

            };*/

            pizzas.Add(p1);
            pizzas.Add(p2);

            fastfoods.Add(f1);
            fastfoods.Add(f2);

            drinks.Add(d1);
            drinks.Add(d2);

            ctx.Pizzas.AddRange(pizzas);
            ctx.FastFoods.AddRange(fastfoods);
            ctx.Drinks.AddRange(drinks);
            //ctx.Orders.Add(o1);
            ctx.SaveChanges();
        }
    }
}
