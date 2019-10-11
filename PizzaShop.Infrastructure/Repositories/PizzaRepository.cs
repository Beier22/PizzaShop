using Microsoft.EntityFrameworkCore;
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
        
        public void CreatePizza(Pizza pizza)
        {
            //var createdPizza = ctx.Pizzas.Add(pizza).Entity;
            ctx.Pizzas.Attach(pizza).State = EntityState.Added;
            ctx.SaveChanges();     
        }

        public void DeletePizza(int id)
        {
            var pizzaToRemove = ReadById(id);
            ctx.Pizzas.Remove(pizzaToRemove);
            ctx.SaveChanges();
        }

        public List<Pizza> ReadAllPizzas()
        {
            return ctx.Pizzas.ToList();
        }

        public Pizza UpdatePizza(Pizza updatePizza)
        {
            ctx.Attach(updatePizza).State = EntityState.Modified;
            ctx.SaveChanges();
            return updatePizza;
        }
        public Pizza ReadById(int id)
        {
            return ctx.Pizzas.FirstOrDefault(c => c.Id == id);
        }

        public IEnumerable<Pizza> ReadSortedPizzas(Filter filter)

        {
            List<Pizza> sortedList = ReadAllPizzas();

            sortedList = sortedList.Where(pizza => pizza.NormalPrice.Equals(filter.Pizza))
            .Skip((filter.CurrentPage - 1) * 10)
            .Take(10).ToList();

            return sortedList;
        }
    }
}
