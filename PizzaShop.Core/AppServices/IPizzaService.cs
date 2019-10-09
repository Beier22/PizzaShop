using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.AppServices
{
    public interface IPizzaService
    {
        List<Pizza> GetAllPizzas();
        void DeletePizza(int id);
        void CreatePizza(Pizza pizza);
        Pizza ReadById(int id);
        void UpdatePizza(Pizza pizza);
    }
}
