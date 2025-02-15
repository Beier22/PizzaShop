﻿using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace PizzaShop.Infrastructure.Repositories
{
    public class DrinkRepository : IDrinkRepository
    {
        PizzaShopContext ctx;

        public DrinkRepository(PizzaShopContext ctx)
        {
            this.ctx = ctx;
        }

        public void Create(Drink drink)
        {
            //ctx.Drinks.Add(drink);
            ctx.Drinks.Attach(drink).State = EntityState.Added;
            ctx.SaveChanges();
        }

        public void Delete(int id)
        {
            Drink drink = ReadById(id);
            ctx.Drinks.Remove(drink);
            ctx.SaveChanges();
        }

        public List<Drink> ReadAll()
        {
            return ctx.Drinks.ToList();
        }

        public Drink ReadById(int id)
        {
            return ctx.Drinks.FirstOrDefault(d => d.Id == id);
        }

        public Drink UpdateDrink(Drink updateDrink)
        {
            ctx.Attach(updateDrink).State = EntityState.Modified;
            ctx.SaveChanges();
            return updateDrink;
        }
    }
}
