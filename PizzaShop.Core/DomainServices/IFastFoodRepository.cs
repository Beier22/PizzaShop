using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.DomainServices
{
    public interface IFastFoodRepository
    {
        FastFood CreateFastFood(FastFood fastFood);
        List<FastFood> ReadAllFastFood();
        FastFood UpdateFastFood(FastFood updateFastFood);
        FastFood DeleteFastFood(int id);
    }
}
