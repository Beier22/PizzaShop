using System;
using System.Collections.Generic;
using System.Text;
using PizzaShop.Core.DomainServices;
using PizzaShop.Core.Entity;

namespace PizzaShop.Core.AppServices.Implementation
{
    public class PizzaService : IPizzaService
    {
        private IPizzaRepository repo;

        public PizzaService(IPizzaRepository repo)
        {
            this.repo = repo;
        }

        public void CreatePizza(Pizza pizza)
        {
            repo.CreatePizza(pizza);
        }

        public void DeletePizza(int id)
        {
            repo.DeletePizza(id);
        }

        public List<Pizza> GetAllPizzas()
        {
            return repo.ReadAllPizzas();
        }

        public Pizza ReadById(int id)
        {
            return repo.ReadById(id);
        }

        public void UpdatePizza(Pizza pizza)
        {
            repo.UpdatePizza(pizza);
        }
    }
}
