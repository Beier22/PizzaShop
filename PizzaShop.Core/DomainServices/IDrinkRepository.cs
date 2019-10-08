using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.DomainServices
{
    public interface IDrinkRepository
    {
        Drink ReadById(int id);
        List<Drink> ReadAll();
        void Create(Drink drink);
        void Delete(int id);
    }
}
