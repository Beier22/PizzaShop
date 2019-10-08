using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PizzaShop.Infrastructure.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        PizzaShopContext ctx;

        public DrinkRepository(PizzaShopContext ctx)
        {
            this.ctx = ctx;
        }
        public void AddSize(int id, string size)
        {
            Drink drink = ReadById(id);
        }

        public Drink ReadById(int id)
        {
            return ctx.Drinks.FirstOrDefault(d => d.Id == id);
        }
    }
}
