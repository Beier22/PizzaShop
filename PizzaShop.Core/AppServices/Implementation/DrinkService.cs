using System;
using System.Collections.Generic;
using System.Text;
using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;

namespace PizzaShop.Core.AppServices.Implementation
{
    public class DrinkService : IDrinkService
    {
        private IDrinkRepository repo;

        public DrinkService(IDrinkRepository repo)
        {
            this.repo = repo;
        }

        public void Create(Drink drink)
        {
            repo.Create(drink);
        }

        public void Delete(int id)
        {
            repo.Delete(id);
        }

        public List<Drink> ReadAll()
        {
            return repo.ReadAll();
        }

        public Drink ReadById(int id)
        {
            return repo.ReadById(id);
        }

        public void UpdateDrink(Drink drink)
        {
            repo.UpdateDrink(drink);
        }
    }
}
