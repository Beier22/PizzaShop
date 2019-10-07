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
            throw new NotImplementedException();
        }

        public Pizza DeletePizza(int id)
        {
            throw new NotImplementedException();
        }

        public List<Pizza> ReadAllPizzas()
        {
            return ctx.Pizzas.ToList();
        }

        public Pizza UpdatePizza(Pizza updatePizza)
        {
            throw new NotImplementedException();
        }
    }
}
