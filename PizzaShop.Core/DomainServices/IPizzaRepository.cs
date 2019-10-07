using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.DomainServices
{
    public interface IPizzaRepository
    {
        Pizza CreatePizza(Pizza pizza);
        List<Pizza> ReadAllPizzas();
        Pizza UpdatePizza(Pizza updatePizza);
        Pizza DeletePizza(int id);
        

    }
}
