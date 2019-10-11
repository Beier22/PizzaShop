using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.Entity
{
    public class OrderFastfood
    {
        public int OrderId { get; set; }
        public int FastfoodId { get; set; }

        public Order Order { get; set; }
        public FastFood Fastfood { get; set; }
    }
}
