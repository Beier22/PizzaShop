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
            List<Topping> toppings = new List<Topping>();

            Pizza p1 = new Pizza
            {
                Name = "Pepperoni",
                Size = "Large",
                Price = 69.99,
                Toppings = new List<Topping>()
            };

            Pizza p2 = new Pizza
            {
                Name = "Margherita",
                Size = "Medium",
                Price = 49.99,
                Toppings = new List<Topping>()
            };

            FastFood f1 = new FastFood
            {
                Name = "Fries",
                Size = "Medium",
                Price = 29.99
            };

            FastFood f2 = new FastFood
            {
                Name = "Cheese Burger",
                Size = "Medium",
                Price = 39.99
            };

            Topping t1 = new Topping
            {
                Name = "Mushroom",
                Price = 4.99
            };

            Topping t2 = new Topping
            {
                Name = "Tomatoes",
                Price = 4.99
            };

            pizzas.Add(p1);
            pizzas.Add(p2);

            fastfoods.Add(f1);
            fastfoods.Add(f2);

            toppings.Add(t1);
            toppings.Add(t2);

            ctx.Pizzas.AddRange(pizzas);
            ctx.FastFoods.AddRange(fastfoods);
            ctx.Toppings.AddRange(toppings);
            ctx.SaveChanges();
        }
    }
}
