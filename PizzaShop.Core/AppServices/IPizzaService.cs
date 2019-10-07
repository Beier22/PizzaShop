using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.AppServices
{
    public interface IPizzaService
    {
        List<Pizza> GetAllPizzas();
    }
}
