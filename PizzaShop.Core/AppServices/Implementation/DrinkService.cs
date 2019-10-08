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
        public void AddSize(int id, int size)
        {
            throw new NotImplementedException();
        }

        public void Create()
        {
            throw new NotImplementedException();
        }

        public List<Drink> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Drink ReadById(int id)
        {
            return repo.ReadById(id);
        }
    }
}
