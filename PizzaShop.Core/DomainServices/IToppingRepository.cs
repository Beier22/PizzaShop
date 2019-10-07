using PizzaShop.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.DomainServices
{
    public interface IToppingRepository
    {
        Topping CreateTopping(Topping createTopping);
        List<Topping> ReadAllToppings();
        Topping UpdateTopping(Topping updateTopping);
        Topping DeleteTopping(int id);
    }
}
