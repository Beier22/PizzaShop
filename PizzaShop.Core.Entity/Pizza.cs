using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.Entity
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double NormalPrice { get; set; }
        public double FamilyPrice { get; set; }
        public string Toppings { get; set; }

        public List<OrderPizza> OrderPizzas { get; set; }

    }
}
