using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.AppServices
{
    public interface IDrinkService
    {
        void Create(Drink drink);
        List<Drink> ReadAll();
        Drink ReadById(int id);
        void Delete(int id);


    }
}
