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

        public List<Pizza> GetAllPizzas()
        {
            return repo.ReadAllPizzas();
        }
    }
}
