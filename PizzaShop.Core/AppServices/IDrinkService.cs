using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.AppServices
{
    public interface IDrinkService
    {
        void Create();
        List<Drink> ReadAll();
        Drink ReadById(int id);
        void AddSize(int id, int size);


    }
}
