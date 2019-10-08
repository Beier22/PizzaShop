using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShop.Infrastructure.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        PizzaShopContext ctx;

        public PizzaRepository(PizzaShopContext ctx)
        {
            this.ctx = ctx;
        }
        
        public Pizza CreatePizza(Pizza pizza)
        {
            var createdPizza = ctx.Pizzas.Add(pizza).Entity;
            ctx.SaveChanges();
            return createdPizza;
            
        }

        public Pizza DeletePizza(int id)
        {
            var pizzaToRemove = ReadById(id);
            ctx.Pizzas.Remove(pizzaToRemove);
            ctx.SaveChanges();
            return pizzaToRemove;
        }

        public List<Pizza> ReadAllPizzas()
        {
            return ctx.Pizzas.ToList();
        }

        public Pizza UpdatePizza(Pizza updatePizza)
        {
            throw new NotImplementedException();
        }
        public Pizza ReadById(int id)
        {
            return ctx.Pizzas.FirstOrDefault(c => c.Id == id);
        }
    }
}
