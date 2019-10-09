using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaShop.Core.Entity
{
    public class OrderItem
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public int TypeId { get; set; }
        public int Size { get; set; }
       // public double orderPrice { get; set; }
        
    }
}
