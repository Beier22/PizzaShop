using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.Entity
{
    public class OrderDrink
    {
        public int OrderId { get; set; }
        public int DrinkId { get; set; }

        public Order Order { get; set; }
        public Drink Drink { get; set; }
    }
}
