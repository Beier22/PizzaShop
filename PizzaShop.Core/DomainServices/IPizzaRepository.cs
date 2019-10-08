using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.DomainServices
{
    public interface IPizzaRepository
    {
        void CreatePizza(Pizza pizza);
        List<Pizza> ReadAllPizzas();
        Pizza UpdatePizza(Pizza updatePizza);
        void DeletePizza(int id);
        Pizza ReadById(int id);
        

    }
}
