using Microsoft.EntityFrameworkCore;
using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaShop.Infrastructure.Repositories
{
    public class FastFoodRepository : IFastFoodRepository
    {
        PizzaShopContext ctx;

        public FastFoodRepository(PizzaShopContext ctx)
        {
            this.ctx = ctx;
        }
        public FastFood CreateFastFood(FastFood fastFood)
        {
            ctx.FastFoods.Add(fastFood);
            ctx.SaveChanges();
            return fastFood;

        }

        public FastFood DeleteFastFood(int id)
        {
            FastFood ff = ReadById(id);
            ctx.FastFoods.Remove(ff);
            ctx.SaveChanges();
            return ff;
        }

        public List<FastFood> ReadAllFastFood()
        {
            return ctx.FastFoods.ToList();
        }

        public FastFood ReadById(int id)
        {
            return ctx.FastFoods.FirstOrDefault(ff => ff.Id == id);
        }

        public FastFood Update(FastFood fastfood)
        {
            ctx.Attach(fastfood).State = EntityState.Modified;
            ctx.SaveChanges();
            return fastfood;
        }

    }
}
