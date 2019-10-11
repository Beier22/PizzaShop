using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.Entity
{
    public class OrderPizza
    {
        public int OrderId { get; set; }
        public int PizzaId { get; set; }

        public Order Order { get; set; }
        public Pizza Pizza { get; set; }
    }
}
