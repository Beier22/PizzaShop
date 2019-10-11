using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.AppServices
{
    public interface IFastFoodService
    {
        void Create(FastFood fastfood);
        List<FastFood> ReadAll();
        FastFood ReadById(int id);
        void Delete(int id);
        FastFood Update(FastFood fastfood);
    }
}
