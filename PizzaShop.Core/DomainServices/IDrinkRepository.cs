using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.DomainServices
{
    public interface IDrinkRepository
    {
        void AddSize(int id, string size);
        Drink ReadById(int id);
    }
}
